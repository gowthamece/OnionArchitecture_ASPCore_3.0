using OA_DataAccess;

namespace OA_Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
        T Get(int id);
        System.Collections.Generic.IEnumerable<T> GetAll();
        void SaveChanges();
    }
}