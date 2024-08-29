using HR.LeaveManagement.Domain;

namespace HR.LeaveManagement.Application.Contracts.Persistence;

internal interface ILeaveRequestRepository<T>
    : IGenericRepository<LeaveType>
{

}
