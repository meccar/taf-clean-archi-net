﻿using HR.LeaveManagement.Domain;
using HR.LeaveManagement.Domain.common;
using Microsoft.EntityFrameworkCore;

namespace HR.LeaveManagement.Persistence.DatabaseContext;
public class HRDatabaseContext
    : DbContext
{
    public HRDatabaseContext(DbContextOptions<HRDatabaseContext> options)
        : base(options)
    {

    }
    public DbSet<LeaveType> LeaveTypes { get; set; }
    public DbSet<LeaveAllocation> LeaveAllocations { get; set; }
    public DbSet<LeaveRequest> LeaveRequests { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(HRDatabaseContext).Assembly);

        //modelBuilder.Entity<LeaveType>().HasData(
        //    new LeaveType
        //    {
        //        Id = 1,
        //        Name = "Vacation",
        //        DefaultDays = 10,
        //        DateCreated = DateTime.Now,
        //        DateModified = DateTime.Now,
        //    }
        //);
        base.OnModelCreating(modelBuilder);
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        foreach (var entry in base.ChangeTracker.Entries<BaseEntity>()
            .Where(q => q.State == EntityState.Added || q.State == EntityState.Modified))
        {
            entry.Entity.DateModified = DateTime.Now;

            if (entry.State == EntityState.Added)
            {
                entry.Entity.DateCreated = DateTime.Now;
            }
        }
        return base.SaveChangesAsync(cancellationToken);
    }
}
