﻿using HR.LeaveManagement.Persistence.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HR.LeaveManagement.Persistence;
public static class PersistenceServiceRegistration
{
    public static IServiceCollection AddPersistenceService(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDbContext<HRDatabaseContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString("HRDatabaseConnectionString"));
        });

        return services;
    }
}
