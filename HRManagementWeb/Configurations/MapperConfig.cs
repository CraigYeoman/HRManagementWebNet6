using AutoMapper;
using HRManagementWeb.Data;
using HRManagementWeb.Models;

namespace HRManagementWeb.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();
        }
    }
}
