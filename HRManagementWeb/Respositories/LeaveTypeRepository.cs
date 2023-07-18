using HRManagementWeb.Contracts;
using HRManagementWeb.Data;

namespace HRManagementWeb.Respositories
{
    public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository
    {
        public LeaveTypeRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
