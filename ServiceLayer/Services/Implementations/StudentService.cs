using DomainLayer.Entities;
using RepositoryLayer.Repositories.Implementations;

namespace ServiceLayer.Services.Implementations
{
    public class StudentService
    {
        private StudentRepository _repo = new();

        public void Create(Student student)
        {
            student.Id = new Random().Next(1, 10000);
            _repo.Create(student);
        }

        public void Update(int id, string name)
        {
            var student = _repo.GetById(id);

            if (student != null)
            {
                student.Name = name;
                _repo.Update(student);
            }
        }

        public void Delete(int id)
        {
            var student = _repo.GetById(id);

            if (student != null)
            {
                _repo.Delete(student);
            }
        }

        public Student GetById(int id)
        {
            return _repo.GetById(id);
        }

        public List<Student> GetAll()
        {
            return (List<Student>)_repo.GetAll();
        }

        public List<Student> GetByAge(int age)
        {
            return _repo.GetAll().Where(x => x.Age == age).ToList();
        }

        public List<Student> GetByGroupId(int groupId)
        {
            return _repo.GetAll().Where(x => x.Group.Id == groupId).ToList();
        }

        public List<Student> Search(string text)
        {
            return _repo.GetAll()
                .Where(x => x.Name.Contains(text) || x.Surname.Contains(text))
                .ToList();
        }
    }
}