using AutoMapper;
using HR.LeaveManagement.Application.Features.LeaveType.Queries.GetAllLeaveTypes;
using HR.LeaveManagement.Application.Features.LeaveType.Queries.GetDetailLeaveType;
using HR.LeaveManagement.Domain;

namespace HR.LeaveManagement.Application.MappingProfiles;
public class LeaveTypeProfile : Profile
{
    public LeaveTypeProfile()
    {
        CreateMap<LeaveTypeDto, LeaveType>().ReverseMap();
        CreateMap<LeaveType, DetailLeaveTypeDto>();
    }
}
