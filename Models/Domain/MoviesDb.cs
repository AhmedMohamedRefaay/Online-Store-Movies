using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Online__Store_Movies.Models.Domain
{
    public class MoviesDb:IdentityDbContext<ApplicationUser>
    {
        public MoviesDb(DbContextOptions<MoviesDb> options):base(options)
        {
            
        }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genere> Genere { get; set; }

        public DbSet<MovieGenere> movieGeneres { set; get; }
    }
}
