using DomainLayer.Common;


namespace RepositoryLayer.Repositories.Interfaces

{
    public interface IRepository<T> where T : BaseEntity
    {
        void Create(T Data);
        void Update(T Data);
        void Delete(T Data);
        T Get(Predicate<T> Predicate);
        List<T> GetAll(Predicate<T> predicate);
    }
}


