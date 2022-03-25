using System.Collections.Generic;
using TE19DWEBAPIKURS.Models;

namespace TE19DWEBAPIKURS.Services.studentServices
{
    public interface IStudentService
    {
         List<Student> GetStudentList();

         List<Student> AddStudent(Student newStudent);

         List<Student> RemoveStudent(int id);
    }

}