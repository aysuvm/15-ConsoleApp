using DomainLayer.Entities;
using RepositoryLayer.Data;
using RepositoryLayer.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Repositories.Implementations
{
    public class StudentRepository : IRepository<Student>
    {
        public void Create(Student data)
        {
            if (data == null) return;

            AppDbContext<Student>.datas.Add(data);
        }

        public void Delete(Student data)
        {
            if (data == null) return;

            AppDbContext<Student>.datas.Remove(data);
        }

        public Student Get(Predicate<Student> predicate)
        {
            return predicate == null
                ? null
                : AppDbContext<Student>.datas.Find(predicate);
        }

        public List<Student> GetAll(Predicate<Student> predicate)
        {
            return predicate == null
                ? AppDbContext<Student>.datas
                : AppDbContext<Student>.datas.FindAll(predicate);
        }

        public IEnumerable<Student> GetAll()
        {
            throw new NotImplementedException();
        }

        public Student GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Student data)
        {
            if (data == null) return;

            var exist = AppDbContext<Student>.datas.Find(x => x.Id == data.Id);

            if (exist == null) return;

            exist.Name = data.Name;
            exist.Surname = data.Surname;
            exist.Age = data.Age;
            exist.Group= data.Group;
        }
    }
}

