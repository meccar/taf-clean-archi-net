using AutoMapper;
using HR.LeaveManagement.Application.Contracts.Persistence;
using HR.LeaveManagement.Application.Exceptions;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveType.Queries.GetDetailLeaveType;
public class GetDetailLeaveTypeQueryHandler(IMapper mapper, ILeaveTypeRepository leaveTypeRepository)
    : IRequestHandler<GetDetailLeaveTypeQuery, DetailLeaveTypeDto>
{
    private readonly IMapper _mapper = mapper;
    private readonly ILeaveTypeRepository _leaveTypeRepository = leaveTypeRepository;

    public async Task<DetailLeaveTypeDto> Handle(GetDetailLeaveTypeQuery request, CancellationToken cancellationToken)
    {
        var leaveType = await _leaveTypeRepository.GetLeaveByIdAsync(request.Id)
            ?? throw new NotFoundException(nameof(LeaveType), request.Id);

        var data = _mapper.Map<DetailLeaveTypeDto>(leaveType);

        return data;
    }
}

