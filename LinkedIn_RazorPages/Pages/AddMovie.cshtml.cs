using LinkedIn_RazorPages.Data;
using LinkedIn_RazorPages.Data.Models;
using LinkedIn_RazorPages.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LinkedIn_RazorPages.Pages
{
    public class AddMovieModel : PageModel
    {
        private IMoviesService _service;

        [BindProperty]
        public Movie Movie { get; set; }

        public AddMovieModel(IMoviesService service)
        {
            _service = service;
        }

        public void OnGet()
        {
            Movie = new Movie();
            Movie.Title = "Wellcome";
        }

        public IActionResult OnPost()
        {
            string title = Movie.Title;
            int rate = Movie.Rate;
            string desc = Movie.Description;

            Console.WriteLine($"{title} - {rate} - {desc}");

            if (!ModelState.IsValid)
            {
                return Page();
            }

            Movie movie = new Movie()
            {
                Title= title,
                Rate = rate,
                Description = desc
            };

            _service.AddMovie(movie);

            return Redirect("Movies");
        }
    }
}
