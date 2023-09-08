using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HRManagementData.Configurations.Entities
{
    public class LeaveRequestSeedConfiguration : IEntityTypeConfiguration<LeaveRequest>
    {
        public void Configure(EntityTypeBuilder<LeaveRequest> builder)
        {
            builder.HasData(
                new LeaveRequest
                {
                    StartDate = new DateTime(2023, 10 , 1),
                    EndDate = new DateTime(2023, 10, 7),
                    LeaveTypeId = 2,
                    DateRequested = new DateTime(2023, 9, 1),
                    RequestComments = "Vacation",
                    Approved = null,
                    Cancelled = false,
                    RequestingEmployeeId = "3f4631bd-f907-4410-b416-ba356312e659",
                    Id = 4
                },
                new LeaveRequest
                {
                    StartDate = new DateTime(2023, 10, 10),
                    EndDate = new DateTime(2023, 10, 13),
                    LeaveTypeId = 2,
                    DateRequested = new DateTime(2023, 9, 1),
                    RequestComments = "Vacation",
                    Approved = null,
                    Cancelled = false,
                    RequestingEmployeeId = "3f4631bd-f907-4411-b416-ba356312e659",
                    Id = 5
                }
                ,
                new LeaveRequest
                {
                    StartDate = new DateTime(2023, 11, 1),
                    EndDate = new DateTime(2023, 11, 3),
                    LeaveTypeId = 2,
                    DateRequested = new DateTime(2023, 9, 1),
                    RequestComments = "Vacation",
                    Approved = null,
                    Cancelled = false,
                    RequestingEmployeeId = "3f4631bd-f907-4412-b416-ba356312e659",
                    Id = 6
                },
                new LeaveRequest
                {
                    StartDate = new DateTime(2023, 11, 13),
                    EndDate = new DateTime(2023, 11, 17),
                    LeaveTypeId = 2,
                    DateRequested = new DateTime(2023, 9, 1),
                    RequestComments = "Vacation",
                    Approved = null,
                    Cancelled = false,
                    RequestingEmployeeId = "3f4631bd-f907-4413-b416-ba356312e659",
                    Id = 7
                },
                new LeaveRequest
                {
                    StartDate = new DateTime(2023, 11, 20),
                    EndDate = new DateTime(2023, 11, 23),
                    LeaveTypeId = 2,
                    DateRequested = new DateTime(2023, 9, 1),
                    RequestComments = "Vacation",
                    Approved = null,
                    Cancelled = false,
                    RequestingEmployeeId = "3f4631bd-f907-4414-b416-ba356312e659",
                    Id = 8
                },
                new LeaveRequest
                {
                    StartDate = new DateTime(2023, 12, 4),
                    EndDate = new DateTime(2023, 12, 8),
                    LeaveTypeId = 2,
                    DateRequested = new DateTime(2023, 9, 1),
                    RequestComments = "Vacation",
                    Approved = null,
                    Cancelled = false,
                    RequestingEmployeeId = "3f4631bd-f907-4415-b416-ba356312e659",
                    Id = 9
                },
                new LeaveRequest
                {
                    StartDate = new DateTime(2023, 9, 5),
                    EndDate = new DateTime(2023, 9, 8),
                    LeaveTypeId = 1,
                    DateRequested = new DateTime(2023, 9, 1),
                    RequestComments = "Sick",
                    Approved = null,
                    Cancelled = false,
                    RequestingEmployeeId = "3f4631bd-f907-4416-b416-ba356312e659",
                    Id = 10
                },
                new LeaveRequest
                {
                    StartDate = new DateTime(2023, 8, 24),
                    EndDate = new DateTime(2023, 8, 25),
                    LeaveTypeId = 1,
                    DateRequested = new DateTime(2023, 9, 1),
                    RequestComments = "Sick",
                    Approved = null,
                    Cancelled = false,
                    RequestingEmployeeId = "3f4631bd-f907-4410-b416-ba356312e659",
                    Id = 11
                },
                new LeaveRequest
                {
                    StartDate = new DateTime(2023, 9, 5),
                    EndDate = new DateTime(2023, 9, 8),
                    LeaveTypeId = 2,
                    DateRequested = new DateTime(2023, 9, 1),
                    RequestComments = "Vacation",
                    Approved = null,
                    Cancelled = false,
                    RequestingEmployeeId = "3f4631bd-f907-4416-b416-ba356312e659",
                    Id = 12
                },
                new LeaveRequest
                {
                    StartDate = new DateTime(2023, 9, 18),
                    EndDate = new DateTime(2023, 9, 22),
                    LeaveTypeId = 2,
                    DateRequested = new DateTime(2023, 9, 1),
                    RequestComments = "Vacation",
                    Approved = null,
                    Cancelled = false,
                    RequestingEmployeeId = "3f4631bd-f907-4417-b416-ba356312e659",
                    Id = 13
                },
                new LeaveRequest
                {
                    StartDate = new DateTime(2023, 8, 30),
                    EndDate = new DateTime(2023, 8, 30),
                    LeaveTypeId = 1,
                    DateRequested = new DateTime(2023, 9, 1),
                    RequestComments = "Sick",
                    Approved = null,
                    Cancelled = false,
                    RequestingEmployeeId = "3f4631bd-f907-4412-b416-ba356312e659",
                    Id = 14
                },
                new LeaveRequest
                {
                    StartDate = new DateTime(2023, 8, 16),
                    EndDate = new DateTime(2023, 8, 18),
                    LeaveTypeId = 1,
                    DateRequested = new DateTime(2023, 9, 1),
                    RequestComments = "Sick",
                    Approved = null,
                    Cancelled = false,
                    RequestingEmployeeId = "3f4631bd-f907-4413-b416-ba356312e659",
                    Id = 15
                },
                new LeaveRequest
                {
                    StartDate = new DateTime(2023, 9, 1),
                    EndDate = new DateTime(2023, 9, 1),
                    LeaveTypeId = 1,
                    DateRequested = new DateTime(2023, 9, 1),
                    RequestComments = "Sick",
                    Approved = null,
                    Cancelled = false,
                    RequestingEmployeeId = "3f4631bd-f907-4414-b416-ba356312e659",
                    Id = 16
                }
                );
        }
    }
}
