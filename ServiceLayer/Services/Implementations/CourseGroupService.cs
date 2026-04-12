using DomainLayer.Entities;
using RepositoryLayer.Repositories.Implementations;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class AppService
{
    private CourseGroupRepository _groupRepository;
    private  StudentRepository _studentRepository;

    private int _groupCount = 1;
    private int _studentCount = 1;

    public AppService()
    {
        _groupRepository = new CourseGroupRepository();
        _studentRepository = new StudentRepository();
    }




    public CourseGroup CreateGroup(CourseGroup group)
    {
        group.Id = _groupCount++;
        _groupRepository.Create(group);
        return group;
    }

   
    public bool UpdateGroup(int id, CourseGroup newGroup)
    {
        var exist = GetGroupById(id);

        if (exist == null)
            return false;

        exist.Name = newGroup.Name;
        exist.SeatCount = newGroup.SeatCount;
        exist.Teacher = newGroup.Teacher;
        exist.Room = newGroup.Room;

        _groupRepository.Update(exist);
        return true;
    }
    public bool DeleteGroup(int id)
    {
        var group = GetGroupById(id);

        if (group == null)
            return false;

        _groupRepository.Delete(group);
        return true;
    }

 
    public CourseGroup GetGroupById(int id)
    {
        return _groupRepository.Get(x => x.Id == id);
    }

  
    public List<CourseGroup> GetGroupsByTeacher(string teacher)
    {
        return _groupRepository.GetAll(x => x.Teacher == teacher);
    }

    public List<CourseGroup> GetGroupsByRoom(string room)
    {
        return _groupRepository.GetAll(x => x.Room == room);
    }


    public List<CourseGroup> GetAllGroups()
    {
        return _groupRepository.GetAll(x => true);
    }

 
    public List<CourseGroup> SearchGroupsByName(string text)
    {
        text = text.ToLower();
        return _groupRepository.GetAll(x => x.Name.ToLower().Trim().Contains(text));
    }


    public Student CreateStudent(Student student)
    {
        student.Id = _studentCount++;
        _studentRepository.Create(student);
        return student;
    }

 
    public bool UpdateStudent(int id, Student newStudent)
    {
        var exist = GetStudentById(id);

        if (exist == null)
            return false;

        exist.Name = newStudent.Name;
        exist.Surname = newStudent.Surname;
        exist.Age = newStudent.Age;
        exist.GroupId = newStudent.GroupId;

        _studentRepository.Update(exist);
        return true;
    }

  
    public Student GetStudentById(int id)
    {
        return _studentRepository.Get(x => x.Id == id);
    }

   
    public bool DeleteStudent(int id)
    {
        var student = GetStudentById(id);

        if (student == null)
            return false;

        _studentRepository.Delete(student);
        return true;
    }


    public List<Student> GetStudentsByAge(int age)
    {
        return _studentRepository.GetAll(x => x.Age == age);
    }

    
    public List<Student> GetStudentsByGroupId(int group)
    {
        return _studentRepository.GetAll(x => x.Group.Id == group);
    }
   
    public List<CourseGroup> Searchmethodforgroupsbyname(string text)
    {
        text = text.ToLower();
        return _groupRepository.GetAll(x => x.Name.ToLower().Contains(text));
    }
    public List<Student> SearchStudents(string text)
    {
        text = text.ToLower();

        return _studentRepository.GetAll(x =>
            x.Name.ToLower().Contains(text) ||
            x.Surname.ToLower().Contains(text));
    }
}



