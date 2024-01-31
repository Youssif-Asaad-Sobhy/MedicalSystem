using MS.Infrastructure.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Infrastructure.Repositories.UnitOfWork
{
    internal class UnitOfWork : IUnitOfWork
    {

        private readonly Context _context;
        // TO DO : Implement Generic of all Entities
        public UnitOfWork(Context context)
        {
            _context = context;
        }
        public async Task complete()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
