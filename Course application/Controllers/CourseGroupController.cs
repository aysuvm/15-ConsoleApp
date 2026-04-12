using System;
using System.Collections.Generic;
using DomainLayer.Entities;
using ServiceLayer.Helpers;
using ServiceLayer.Services.Implementations;
using ServiceLayer.Services.Interfaces;

namespace CourseApplication.Controllers
{
    public class CourseGroupController
    {
        private CourseGroupService _courseGroupService = new ();
        private StudentService _studentService = new();

    

        public void CreateGroup()
        {
            Helper.PrintConsole(ConsoleColor.Blue, "Add Group Name");
            string name = Console.ReadLine();

        SeatInput:
            Helper.PrintConsole(ConsoleColor.Blue, "Add Seat Count");
            string seatStr = Console.ReadLine();

            if (int.TryParse(seatStr, out int seatCount))
            {
                CourseGroup group = new()
                {
                    Name = name,
                    SeatCount = seatCount
                };

                _courseGroupService.Create(group);

                Helper.PrintConsole(ConsoleColor.Green, "Group created");
            }
            else
            {
                Helper.PrintConsole(ConsoleColor.Red, "Wrong seat count");
                goto SeatInput;
            }
        }

        public void DeleteGroup()
        {
            Helper.PrintConsole(ConsoleColor.Blue, "Enter Id");
            int id = int.Parse(Console.ReadLine());

            _courseGroupService.Delete(id);

            Helper.PrintConsole(ConsoleColor.Green, "Deleted");
        }

        public void GetAllGroups()
        {
            var groups = _courseGroupService.GetAll();

            foreach (var g in groups)
            {
                Helper.PrintConsole(ConsoleColor.Green,
                    $"Id:{g.Id}, Name:{g.Name}");
            }
        }

        

        public void CreateStudent()
        {
            Helper.PrintConsole(ConsoleColor.Blue, "Name");
            string name = Console.ReadLine();

            Helper.PrintConsole(ConsoleColor.Blue, "Surname");
            string surname = Console.ReadLine();

            Helper.PrintConsole(ConsoleColor.Blue, "Age");
            int age = int.Parse(Console.ReadLine());

            Student student = new()
            {
                Name = name,
                Surname = surname,
                Age = age
            };

            _studentService.Create(student);

            Helper.PrintConsole(ConsoleColor.Green, "Student created");
        }

        public void GetStudentById()
        {
            Helper.PrintConsole(ConsoleColor.Blue, "Enter Id");
            int id = int.Parse(Console.ReadLine());

            var student = _studentService.GetById(id);

            if (student != null)
            {
                Helper.PrintConsole(ConsoleColor.Yellow,
                    $"{student.Name} {student.Surname}");
            }
            else
            {
                Helper.PrintConsole(ConsoleColor.Red, "Not found");
            }
        }

        public void DeleteStudent()
        {
            Helper.PrintConsole(ConsoleColor.Blue, "Enter Id");
            int id = int.Parse(Console.ReadLine());

            _studentService.Delete(id);

            Helper.PrintConsole(ConsoleColor.Green, "Deleted");
        }

        public void UpdateStudent()
        {
            Helper.PrintConsole(ConsoleColor.Blue, "Enter Id");
            int id = int.Parse(Console.ReadLine());

            Helper.PrintConsole(ConsoleColor.Blue, "New Name");
            string name = Console.ReadLine();

            _studentService.Update(id, name);

            Helper.PrintConsole(ConsoleColor.Green, "Updated");
        }

        public void GetStudentsByAge()
        {
            Helper.PrintConsole(ConsoleColor.Blue, "Enter Age");
            int age = int.Parse(Console.ReadLine());

            var students = _studentService.GetByAge(age);

            foreach (var s in students)
            {
                Helper.PrintConsole(ConsoleColor.Yellow, s.Name);
            }
        }

        public void GetStudentsByGroupId()
        {
            Helper.PrintConsole(ConsoleColor.Blue, "Enter Group Id");
            int groupId = int.Parse(Console.ReadLine());

            var students = _studentService.GetByGroupId(groupId);

            foreach (var s in students)
            {
                Helper.PrintConsole(ConsoleColor.Yellow, s.Name);
            }
        }

        public void SearchStudentByNameOrSurname()
        {
            Helper.PrintConsole(ConsoleColor.Blue, "Search text");
            string text = Console.ReadLine();

            var students = _studentService.Search(text);

            foreach (var s in students)
            {
                Helper.PrintConsole(ConsoleColor.Yellow,
                    $"{s.Name} {s.Surname}");
            }
        }

        internal void UpdateGroup()
        {
            throw new NotImplementedException();
        }

        internal void GetGroupById()
        {
            throw new NotImplementedException();
        }

        internal void GetGroupsByTeacher()
        {
            throw new NotImplementedException();
        }

        internal void GetAllGroupsByRoom()
        {
            throw new NotImplementedException();
        }

        internal void SearchGroupByName()
        {
            throw new NotImplementedException();
        }

        internal void GetAllGroupsByTeacher()
        {
            throw new NotImplementedException();
        }
    }
}