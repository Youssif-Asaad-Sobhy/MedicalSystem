using MS.Application.Helpers.Filters;
using MS.Application.Helpers.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Application.Interfaces
{
    public interface IFilter<Entity> where Entity : class
    {
        Task<List<Entity>> GetFilterAsync(RootFilter filter);
    }
}
