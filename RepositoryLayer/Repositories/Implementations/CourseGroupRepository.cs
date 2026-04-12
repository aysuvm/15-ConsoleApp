using DomainLayer.Entities;
using RepositoryLayer.Data;
using RepositoryLayer.Repositories.Interfaces;
using System;
using System.Collections.Generic;

namespace RepositoryLayer.Repositories.Implementations
{
    public class CourseGroupRepository : IRepository<CourseGroup>
    {
        public void Create(CourseGroup data)
        {
            if (data == null) return;

            AppDbContext<CourseGroup>.datas.Add(data);
        }

        public void Delete(CourseGroup data)
        {
            if (data == null) return;

            AppDbContext<CourseGroup>.datas.Remove(data);
        }

        public CourseGroup Get(Predicate<CourseGroup> predicate)
        {
            return predicate == null
                ? null
                : AppDbContext<CourseGroup>.datas.Find(predicate);
        }

        public List<CourseGroup> GetAll(Predicate<CourseGroup> predicate)
        {
            return predicate == null
                ? AppDbContext<CourseGroup>.datas
                : AppDbContext<CourseGroup>.datas.FindAll(predicate);
        }

        public void Update(CourseGroup data)
        {
            if (data == null) return;

            var exist = AppDbContext<CourseGroup>.datas.Find(x => x.Id == data.Id);

            if (exist == null) return;

            exist.Name = data.Name;
            exist.SeatCount = data.SeatCount;
            exist.Teacher = data.Teacher;
            exist.Room = data.Room;
        }
    }
}
