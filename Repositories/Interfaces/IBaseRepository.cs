namespace AirlineMS.Repositories.Interfaces
{
    public interface IBaseRepository<T>
    {
        public T Create(T entity);
        public T Get(int id);
        public List<T> GetAll();
        public T Update(T entity);
        public bool Delete(int id);

    }
}