using LinkedIn_RazorPages.Data;
using LinkedIn_RazorPages.Data.Models;

namespace LinkedIn_RazorPages.Services
{
    public class MoviesService : IMoviesService
    {
        private ApplicationDbContext _context;
        public MoviesService(ApplicationDbContext context)
        {
            _context = context;
        }
        public void AddMovie(Movie movie)
        {
            _context.Movies.Add(movie);
            _context.SaveChanges();
        }

        public Movie GetMovie(int id)
        {
            return _context.Movies.FirstOrDefault(x => x.Id == id);
        }

        public List<Movie> GetMovies()
        {
            return _context.Movies.ToList();
        }
    }
}
