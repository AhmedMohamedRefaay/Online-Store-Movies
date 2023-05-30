using MovieStoreMvc.Models.Domain;
using MovieStoreMvc.Models.DTO;

namespace MovieStoreMvc.Repositories.Abstract
{
    public interface IGenreService:IService<Genre>
    {
      
       IQueryable<Genre> List();

    }
}
