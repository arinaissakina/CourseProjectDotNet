using System.Collections.Generic;
using System.Threading.Tasks;
using CourseProject.Models;

namespace CourseProject.Services
{
    public interface ISpecialtyRepository
    {
        Task<List<Specialty>> GetAll();
        Task<Specialty> GetOne(long? id);
        void AddSpecialty(Specialty specialty);
        void EditSpecialty(Specialty specialty);
        Task Save();
        void RemoveSpecialty(Specialty specialty);
        bool Exists(long? id);
    }
}