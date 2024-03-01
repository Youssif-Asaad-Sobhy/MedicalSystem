using MS.Data.Entities;
using MS.Infrastructure.Repositories.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Infrastructure.Repositories.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IBaseRepository<Clinic> Clinincs { get; }
        IBaseRepository<PlacePrice> PlacePrice { get; }
        IBaseRepository<Department> Departments { get; }
        IBaseRepository<Equipment> Equipments { get; }
        IBaseRepository<Hospital> Hospitals { get; }
        IBaseRepository<Lab> Labs { get; }
        IBaseRepository<Medicine> Medicines { get; }
        IBaseRepository<MedicineType> MedicineTypes { get; }
        IBaseRepository<Pharmacy> Pharmacies { get; }
        IBaseRepository<PharmacyMedicine> PharmacyMedicines { get; }
        IBaseRepository<PlaceEquipment> PlaceEquipments { get; }
        IBaseRepository<PlaceShift> PlaceShifts { get; }
        IBaseRepository<Report> Reports { get; }
        IBaseRepository<ReportMedicine> ReportMedicines { get; }
        IBaseRepository<Reservation> Reservations { get; }
        IBaseRepository<Shift> Shifts { get; }
        IBaseRepository<Test> Tests { get; }
        IBaseRepository<TestLab> TestLabs { get; }
        IBaseRepository<Types> Types { get; }
        IBaseRepository<ApplicationUser> Users { get; }
        IBaseRepository<Document> Documents { get; }


        // TO DO : Add Generic of all Entities
        int complete();
    }
}
