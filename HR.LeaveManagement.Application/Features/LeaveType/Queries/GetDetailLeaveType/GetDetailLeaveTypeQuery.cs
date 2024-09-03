using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveType.Queries.GetDetailLeaveType;
public record GetDetailLeaveTypeQuery(int Id) : IRequest<DetailLeaveTypeDto>;
