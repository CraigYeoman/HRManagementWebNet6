using AutoMapper;
using AutoMapper.QueryableExtensions;
using HRManagementCommon.Constants;
using HRManagementApplicationLogic.Contracts;
using HRManagementData;
using HRManagementCommon.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;

namespace HRManagementApplicationLogic.Respositories
{
    public class LeaveAllocationRepository : GenericRepository<LeaveAllocation>, ILeaveAllocationRepository
    {
        private readonly ApplicationDbContext context;
        private readonly UserManager<Employee> userManager;
        private readonly ILeaveTypeRepository leaveTypeRepository;
        private readonly IEmailSender emailSender;
        private readonly AutoMapper.IConfigurationProvider configurationProvider;
        private readonly IMapper mapper;

        public LeaveAllocationRepository(ApplicationDbContext context, 
            UserManager<Employee> userManager, 
            ILeaveTypeRepository leaveTypeRepository,
            IEmailSender emailSender,
            AutoMapper.IConfigurationProvider configurationProvider,
            IMapper mapper
            ) : base(context)
        {
            this.context = context;
            this.userManager = userManager;
            this.leaveTypeRepository = leaveTypeRepository;
            this.emailSender = emailSender;
            this.configurationProvider = configurationProvider;
            this.mapper = mapper;
        }

        public async Task<bool> AllocationExists(string employeeId, int leaveTypeId, int period)
        {
            return await context.LeaveAllocations.AnyAsync(q => q.EmployeeId == employeeId
                                                                && q.LeaveTypeId == leaveTypeId
                                                                && q.Period == period);
        }

        public async Task<EmployeeAllocationVM> GetEmployeeAllocations(string employeeId)
        {
            var allocations = await context.LeaveAllocations
                .Include(q => q.LeaveType)
                .Where(q => q.EmployeeId == employeeId)
                .ProjectTo<LeaveAllocationVM>(configurationProvider)
                .ToListAsync();

            var employee = await userManager.FindByIdAsync(employeeId);

            var employeeAllocationModel = mapper.Map<EmployeeAllocationVM>(employee);
            employeeAllocationModel.LeaveAllocations = allocations;

            return employeeAllocationModel;
        }

        public async Task<LeaveAllocationEditVM> GetEmployeeAllocation(int id)
        {
            var allocation = await context.LeaveAllocations
                .Include(q => q.LeaveType)
                .FirstOrDefaultAsync(q => q.Id == id);

            if(allocation == null)
            {
                return null;
            }

            var employee = await userManager.FindByIdAsync(allocation.EmployeeId);
            
            var model = mapper.Map<LeaveAllocationEditVM>(allocation);
            model.Employee = mapper.Map<EmployeeListVM>(await userManager.FindByIdAsync(allocation.EmployeeId));

            return model;
        }

        public async Task LeaveAllocation(int leaveTypeId)
        {
            var employees = await userManager.GetUsersInRoleAsync(Roles.User);
            var period = DateTime.Now.Year;
            var leaveType = await leaveTypeRepository.GetAsync(leaveTypeId);
            var allocations = new List<LeaveAllocation>(); 
            var employeesWithNewAllocations = new List<Employee>();

            foreach (var employee in employees)
            {
                if (await AllocationExists(employee.Id, leaveTypeId, period))
                    continue;
                allocations.Add( new LeaveAllocation
                {
                    EmployeeId = employee.Id,
                    LeaveTypeId = leaveTypeId,
                    Period = period,
                    NumberofDays = leaveType.DefaultDays
                });
                employeesWithNewAllocations.Add(employee);
            }
            await AddRangeAsync(allocations);

            foreach (var employee in employeesWithNewAllocations)
            {
                try
                {
                    await emailSender.SendEmailAsync(employee.Email, $"Leave Allocation Posted for {period}", $"Your {leaveType.Name} leave " +
                   $"has been posted for the period of {period}. You have been given {leaveType.DefaultDays}.");
                }
                 catch (Exception)
                {
                    return;
                }
            }

        }

        public async Task<bool> UpdateEmployeeAllocation(LeaveAllocationEditVM model)
        {
            var leaveAllocation = await GetAsync(model.Id);
            if (leaveAllocation == null)
            {
                return false;
            }
            leaveAllocation.Period = model.Period;
            leaveAllocation.NumberofDays = model.NumberofDays;
            await UpdateAsync(leaveAllocation);

            return true;
        }

        public async Task<LeaveAllocation> GetEmployeeAllocation(string employeeId, int leaveTypeId)
        {
            return await context.LeaveAllocations.FirstOrDefaultAsync(q => q.EmployeeId == employeeId && q.LeaveTypeId == leaveTypeId);
        }
    }
}
