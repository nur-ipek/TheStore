using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TheStore.Core.UnitOfWorks;
using TheStore.Data;

namespace TheStore.Data.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _context;
        public UnitOfWork(DataContext dataContext)
        {
            _context = dataContext;
        }
        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
           await _context.SaveChangesAsync();
        }
    }
}
