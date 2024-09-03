using AutoMapper;
using HR.LeaveManagement.Application.Contracts.Persistence;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveType.Queries.GetDetailLeaveType;
public class GetDetailLeaveTypeQueryHandler
    : IRequestHandler<GetDetailLeaveTypeQuery, DetailLeaveTypeDto>
{
    private readonly IMapper _mapper;
    private readonly ILeaveTypeRepository _leaveTypeRepository;

    public  GetDetailLeaveTypeQueryHandler(IMapper mapper, 
        ILeaveTypeRepository leaveTypeRepository)
    {
        this._mapper=mapper;
        this._leaveTypeRepository=leaveTypeRepository;
    }

    public async Task<DetailLeaveTypeDto> 
        Handle(GetDetailLeaveTypeQuery request,
            CancellationToken cancellationToken)
    {
        var leaveType = await _leaveTypeRepository.GetLeaveByIdAsync(request.);

        //if (leaveType == null)
        //{
        //    throw new NotImplementedException();
        //}

        var data = _mapper.Map<DetailLeaveTypeDto>(leaveType);

        return data;
    }
}
