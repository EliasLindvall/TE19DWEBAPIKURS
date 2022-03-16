using System.Collections.Generic;
using TE19DWEBAPIKURS.Models;

namespace TE19DWEBAPIKURS.Services.studentServices
{
    public interface IStudentService
    {
         List<Student> GetStudentList();
    }
}