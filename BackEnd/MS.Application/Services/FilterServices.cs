using Microsoft.AspNetCore.Http;
using MS.Application.Helpers.Filters;
using MS.Application.Helpers.Response;
using MS.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;
using MS.Data.Interfaces;
using MS.Infrastructure.Repositories.UnitOfWork;
using MS.Infrastructure.Repositories.Generics;
namespace MS.Application.Services
{
    public class FilterServices<Entity> : IFilter<Entity> where Entity : class
    {
        private readonly IBaseRepository<Entity> _baseRepository;
        public FilterServices(IBaseRepository<Entity> baseRepository)
        {
            _baseRepository= baseRepository;
        }
        public async Task<List<Entity>> GetFilterAsync(RootFilter filter)
        {
            IQueryable<Entity> entityQuery = _baseRepository.GetTableAsTracking();
                //_context.Set<Entity>().AsQueryable();
            if (filter != null && filter.Filters != null)
            {
                entityQuery = CompositeFilter<Entity>.ApplyFilter(entityQuery, filter);
            }
            return await entityQuery.ToListAsync();
        }
    }
}
