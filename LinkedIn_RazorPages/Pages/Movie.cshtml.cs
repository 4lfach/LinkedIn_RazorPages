using LinkedIn_RazorPages.Data;
using LinkedIn_RazorPages.Data.Models;
using LinkedIn_RazorPages.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LinkedIn_RazorPages.Pages
{
    public class MovieModel : PageModel
    {
        private IMoviesService _service { get; set; }

        public Movie? movie { get; set; }
        public MovieModel(IMoviesService service)
        {
            _service = service;
        }
        public void OnGet(int id)
        {
            movie = _service.GetMovie(id);
        }
    }
}
