using CQRS_Project.Domain.Interfaces;
using CQRS_Project.Intrastructure.Databases;
using Microsoft.EntityFrameworkCore;

namespace CQRS_Project.Intrastructure.Domains
{
    internal class UnitOfWork : IUnitOfWork
    {
        private readonly DataDbContext _dataDbContext;
        private bool _disposed = false;
        public UnitOfWork(DataDbContext dataDbContext)
        {
            _dataDbContext = dataDbContext;
        }
        public async Task<int> CommitAsync(CancellationToken cancellationToken = default)
        {
            return await this._dataDbContext.SaveChangesAsync(cancellationToken);
        }
        //public void Dispose()
        //{
        //    if (!_disposed)
        //    {
        //        _dataDbContext.Dispose();
        //        _disposed = true;
        //    }
        //}
    }
}
