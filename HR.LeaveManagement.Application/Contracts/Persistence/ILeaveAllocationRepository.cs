﻿using HR.LeaveManagement.Domain;

namespace HR.LeaveManagement.Application.Contracts.Persistence;

internal interface ILeaveAllocationRepository<T>
    : IGenericRepository<LeaveType>
{

}
