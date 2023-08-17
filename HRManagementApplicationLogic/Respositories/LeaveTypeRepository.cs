using HRManagementApplicationLogic.Contracts;
using HRManagementData;

namespace HRManagementApplicationLogic.Respositories
{
    public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository
    {
        public LeaveTypeRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
