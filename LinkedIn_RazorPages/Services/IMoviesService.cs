using LinkedIn_RazorPages.Data.Models;

namespace LinkedIn_RazorPages.Services
{
    public interface IMoviesService
    {
        List<Movie> GetMovies();
        void AddMovie(Movie movie);
        Movie GetMovie(int id);
    }
}
