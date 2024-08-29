using HR.LeaveManagement.Domain;

namespace HR.LeaveManagement.Application.Contracts.Persistence;

internal interface ILeaveTypeRepository<T>
    : IGenericRepository<LeaveType>
{

}
