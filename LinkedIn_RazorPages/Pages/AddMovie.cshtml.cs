using LinkedIn_RazorPages.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LinkedIn_RazorPages.Pages
{
    public class AddMovieModel : PageModel
    {
        [BindProperty]
        public Movie Movie { get; set; }

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

            return Redirect("Movies");
        }
    }
}
