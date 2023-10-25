using Microsoft.EntityFrameworkCore;
using System;
namespace TeknoLabs.Crm.Domain
{
    public interface IUnitOfWork
    {
        void SetDbContextInstance(DbContext context);
        Task<int> SaveChangesAsync();
    }
}

