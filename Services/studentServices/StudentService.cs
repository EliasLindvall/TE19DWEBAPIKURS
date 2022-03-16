using System.Collections.Generic;
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

        public List<Student> GetStudentList()
        {
            return studentLista;
        }
    }
}