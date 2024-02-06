using LinkedIn_RazorPages.Data;
using LinkedIn_RazorPages.Data.Models;
using LinkedIn_RazorPages.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LinkedIn_RazorPages.Pages
{
    public class MoviesModel : PageModel
    {
        private IMoviesService _service;
        public List<Movie> Movies { get; set; }

        public MoviesModel(IMoviesService service)
        {
            _service = service; 
        }

        public void OnGet(int id)
        {
            Movies = _service.GetMovies();
        }
    }
}
