using MS.Data.Entities;
using MS.Infrastructure.Contexts;
using MS.Infrastructure.Repositories.Generics;
using MS.Infrastructure.Repositories.Repository.RepoClasses;
using MS.Infrastructure.Repositories.Repository.RepoInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Infrastructure.Repositories.UnitOfWork
{
    internal class UnitOfWork : IUnitOfWork
    {
        #region Vars/Props
        private readonly Context _context;
        // TO DO : Implement Generic of all Entities
        // done or not ??
        public IBaseRepository<Clinic> Clinics { get; private set; }

        public IBaseRepository<PlacePrice> PlacePrice { get; private set; }

        public IBaseRepository<Department> Departments { get; private set; }

        public IBaseRepository<Equipment> Equipments {  get; private set; }

        public IBaseRepository<Hospital> Hospitals { get; private set; }

        public IBaseRepository<Lab> Labs { get; private set; }

        public IBaseRepository<Medicine> Medicines { get; private set; }

        public IBaseRepository<MedicineType> MedicineTypes { get; private set; }

        public IBaseRepository<Pharmacy> Pharmacies { get; private set; }

        public IBaseRepository<PharmacyMedicine> PharmacyMedicines { get; private set; }

        public IBaseRepository<PlaceEquipment> PlaceEquipments { get; private set; }

        public IBaseRepository<PlaceShift> PlaceShifts { get; private set; }

        public IBaseRepository<Report> Reports { get; private set; }

        public IBaseRepository<ReportMedicine> ReportMedicines { get; private set; }

        public IResrvationRepo Reservations { get; private set; }

        public IBaseRepository<Shift> Shifts { get; private set; }

        public IBaseRepository<Test> Tests { get; private set; }

        public IBaseRepository<TestLab> TestLabs { get; private set; }

        public IBaseRepository<Types> Types { get; private set; }

        public IBaseRepository<ApplicationUser> Users { get; private set; }

        public IBaseRepository<Attachment> Attachment { get; private set; }
        public IBaseRepository<OTP> OTPs {  get; private set; }
        public IBaseRepository<ApplicationUserDisease> ApplicationUserDiseases { get; private set; }
        public IBaseRepository<Disease> Diseases { get; private set; }
        
        #endregion
        public UnitOfWork(Context context)
        {
            _context = context;
            Clinics = new BaseRepository<Clinic>(context);
            PlacePrice = new BaseRepository<PlacePrice>(context);
            Departments = new BaseRepository<Department>(context);
            Equipments = new BaseRepository<Equipment>(context);
            Hospitals = new BaseRepository<Hospital>(context);
            Labs = new BaseRepository<Lab>(context);
            Medicines = new BaseRepository<Medicine>(context);
            MedicineTypes = new BaseRepository<MedicineType>(context);
            Pharmacies = new BaseRepository<Pharmacy>(context);
            PharmacyMedicines = new BaseRepository<PharmacyMedicine>(context);
            PlaceEquipments = new BaseRepository<PlaceEquipment>(context);
            PlaceShifts = new BaseRepository<PlaceShift>(context);
            Reports = new BaseRepository<Report>(context);
            ReportMedicines = new BaseRepository<ReportMedicine>(context);
            Reservations = new ReservationRepo(context);
            Shifts = new BaseRepository<Shift>(context);
            Tests = new BaseRepository<Test>(context);
            TestLabs = new BaseRepository<TestLab>(context);
            Types = new BaseRepository<Types>(context);
            Users = new BaseRepository<ApplicationUser>(context);
            Attachment = new BaseRepository<Attachment>(context);
            OTPs=new BaseRepository<OTP>(context);
            ApplicationUserDiseases = new BaseRepository<ApplicationUserDisease>(context);
            Diseases = new BaseRepository<Disease>(context);
        }


        public void Dispose()
        {
            _context.Dispose();
        }

        int IUnitOfWork.complete()
        {
          return  _context.SaveChanges();
        }
    }
}
