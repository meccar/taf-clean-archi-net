using HR.LeaveManagement.Domain;

namespace HR.LeaveManagement.Application.Contracts.Persistence;
internal interface IGenericRepository<T> 
    where T : class
{
    Task<T> GetAsync();
    Task<T> GetDetailAsync(int id);
    Task<T> CreateAsync(T entity);
    Task<T> UpdateAsync(T entity);
    Task<T> DeleteAsync(T entity);
}