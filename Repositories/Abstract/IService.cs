using MovieStoreMvc.Models.Domain;

namespace MovieStoreMvc.Repositories.Abstract
{
    public interface IService<T> where T:class
    {
        bool Add(T model);
        bool Update(T model);
        T GetById(int id);
        bool Delete(int id);
    }
}
