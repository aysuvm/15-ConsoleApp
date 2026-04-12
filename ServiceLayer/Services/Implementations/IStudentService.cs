using DomainLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Implementations
{
    internal interface  IStudentService
    {
       
        Student CreateStudent(Student student);

       
        bool UpdateStudent(int id, Student student);

        
        Student GetStudentById(int id);

        
        bool DeleteStudent(int id);

        
        Student GetStudentsByAge(int age);

        
        List<Student> GetStudentsByGroupId(int groupId);
    }
}
