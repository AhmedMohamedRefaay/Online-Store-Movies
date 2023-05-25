using Online__Store_Movies.Models.Domain;
using Online__Store_Movies.Repository.Abstract;

namespace Online__Store_Movies.Repository.Implementation
{
    public class GenereService : IGenereService
    {
        private readonly MoviesDb _moviesDb;
        

        public GenereService(MoviesDb moviesDb)
        {
            _moviesDb = moviesDb;
        }

        public bool Add(Genere model)
        {
           try
            {

                _moviesDb.Genere.Add(model);
                _moviesDb.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

       public bool Delete(int Id)
        {
           try
            {
               var gener= _moviesDb.Genere.Find(Id);

                if(gener != null)
                {
                    _moviesDb.Genere.Remove(gener);
                    _moviesDb.SaveChanges();
                }
                return true;
            }catch(Exception ex)
            {
                return false;
            }
        }

       public IQueryable<Genere> GetAll()
        {
            return _moviesDb.Genere.AsQueryable();
        }

        public Genere GetById(int Id)
        {
             try
            {
                var genere = _moviesDb.Genere.Find(Id);
                    if(genere!= null)
                {
                    return genere;
                }
                return null;
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public bool Update(Genere model)
        {
            try
            {
                var gener = _moviesDb.Genere.Find(model.Id);

                if (gener != null)
                {



                    _moviesDb.Genere.Update(gener);
                    _moviesDb.SaveChanges();
                   
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
