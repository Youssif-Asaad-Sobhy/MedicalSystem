using MS.Data.Entities;
using MS.Infrastructure.Repositories.Dtos;
using MS.Infrastructure.Repositories.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MS.Infrastructure.Repositories.Repository.RepoInterfaces
{
    public interface IResrvationRepo : IBaseRepository<Reservation>
    {

        Task<ReservationINFODto> GetReservationINFO(int id);
        //Task<GetAllcurrentReservationDto> GetAllCurrentReservation(int placeid, string placetype);

//        Task<IEnumerable<Reservation>> GetByExpressionAsync(Expression<Func<Reservation, bool>> expression);
    }
}
