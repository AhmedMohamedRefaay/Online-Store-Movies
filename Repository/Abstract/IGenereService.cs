using Online__Store_Movies.Models.Domain;

namespace Online__Store_Movies.Repository.Abstract
{
    public interface IGenereService
    {
        public bool Add(Genere model);
        public bool Update(Genere model);
        public bool Delete(int  Id);    
        public IQueryable<Genere> GetAll();

        public Genere GetById(int Id);
        

    }
}
