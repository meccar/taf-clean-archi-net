using AutoMapper;
using HR.LeaveManagement.Application.Contracts.Persistence;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveType.Commands.UpdateLeaveType;
public class UpdateLeaveTypeCommandHandler(IMapper mapper, ILeaveTypeRepository leaveTypeRepository) 
    : IRequestHandler<UpdateLeaveTypeCommand, Unit>
{
    private readonly IMapper _mapper = mapper;
    private readonly ILeaveTypeRepository _leaveTypeRepository = leaveTypeRepository;

    public async Task<Unit> Handle(UpdateLeaveTypeCommand request, 
        CancellationToken cancellationToken)
    {
        var leaveTypeToUpdate = _mapper.Map<Domain.LeaveType>(request);
        await _leaveTypeRepository.UpdateAsync(leaveTypeToUpdate);
        return Unit.Value;
    }
}
