using System.Collections.Generic;
using System.Linq;
using TE19DWEBAPIKURS.Models;

namespace TE19DWEBAPIKURS.Services.studentServices
{
    public class StudentService : IStudentService
    {

        private List<Student> studentLista = new List<Student>() {
            new Student(),
            new Student() {Id = 2, Name = "Pelle", EnergyStudent = StudentEnergy.Celsius, ClassStudent = StudentClass.TE19C},
            new Student() {Id = 3, Name = "Boris", EnergyStudent = StudentEnergy.Nocco, ClassStudent = StudentClass.TE19D }
        };

        private readonly DataContext _context;

        public StudentService(DataContext context)
        {
            _context = context;
        }

        public List<Student> GetStudentList()
        {
            return _context.students.ToList();
        }

        public List<Student> AddStudent(Student newStudent) {
            _context.students.Add(newStudent);
            _context.SaveChanges();
            return _context.students.ToList();
        }

        public List<Student> RemoveStudent(int id) {
            
            var hittadStudent = _context.students.FirstOrDefault(student => student.Id == id);
            _context.students.Remove(hittadStudent);
            _context.SaveChanges();
            return _context.students.ToList();

        }
    }
}