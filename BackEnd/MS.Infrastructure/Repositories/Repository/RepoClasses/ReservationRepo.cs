using Microsoft.EntityFrameworkCore;
using MS.Data.Entities;
using MS.Data.Enums;
using MS.Infrastructure.Configuration;
using MS.Infrastructure.Contexts;
using MS.Infrastructure.Repositories.Dtos;
using MS.Infrastructure.Repositories.Generics;
using MS.Infrastructure.Repositories.Repository.RepoInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Infrastructure.Repositories.Repository.RepoClasses
{
    public class ReservationRepo : BaseRepository<Reservation>, IResrvationRepo
    {
        private readonly Context _context;

        #region constructor
        public ReservationRepo(Context dbContext) : base(dbContext)
        {
           _context = dbContext;
        }
        #endregion

        #region ReservationINFO
        public async Task<ReservationINFODto> GetReservationINFO(int id)
        {
            var r = await _context.reservations
                .Include(r => r.User)
                .Include(r => r.PlacePrice)
                .Where(r => r.ID == id)

                .FirstOrDefaultAsync();
            var ret = new ReservationINFODto
            {
                firstname = r.User.FirstName,
                lastname = r.User.LastName,
                Nid = r.UserID,

                Price = r.PlacePrice.Price,
                Time = r.Time
            };
            if (r.PlacePrice.PlaceType == PlaceType.Clinic)
            {
                ret.PlaceName = await _context.clinics.Where(c => c.ID == r.PlacePrice.PlaceID).Select(c => c.Name).FirstOrDefaultAsync();
            }
            else if (r.PlacePrice.PlaceType == PlaceType.Lab)
            {
                ret.PlaceName = await _context.labs.Where(c => c.ID == r.PlacePrice.PlaceID).Select(c => c.Name).FirstOrDefaultAsync();
            }
            return ret;
        }
        #endregion

        /*
        #region PlaceTypeINFO
        public async Task<ActionResult<IEnumerable<GetAllcurrentReservationDto>>> GetAllCurrentReservation(int placeid,string placetype)
        {
            var r = await _context.reservations
                .Include(r => r.User)
                .FirstOrDefaultAsync();
            var ret = new GetAllcurrentReservationDto
            {
                firstname = r.User.FirstName,
                lastname = r.User.LastName,
                Nid = r.UserID,
                BirthDate = r.User.BirthDate,
                SerialNumber = r.SerialNumber,
            };
            //if (r.PlacePrice.PlaceType == PlaceType.Clinic)
            //{
            //    ret.PlaceName = await _context.clinics.Where(c => c.ID == r.PlacePrice.PlaceID).Select(c => c.Name).FirstOrDefaultAsync();
            //}
            //else if (r.PlacePrice.PlaceType == PlaceType.Lab)
            //{
            //    ret.PlaceName = await _context.labs.Where(c => c.ID == r.PlacePrice.PlaceID).Select(c => c.Name).FirstOrDefaultAsync();
            //}
            return ret;
        }
        #endregion*/
    }
}
