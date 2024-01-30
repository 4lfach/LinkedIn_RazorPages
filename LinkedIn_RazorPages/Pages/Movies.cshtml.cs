using LinkedIn_RazorPages.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LinkedIn_RazorPages.Pages
{
    public class MoviesModel : PageModel
    {
        public List<Movie> Movies { get; set; }

        public void OnGet()
        {
            Movies = new List<Movie>()
            {
                new Movie()
                {
                    Id = 1, Title = "Pirates of the Caribbean Sea", Rate = 10, Description = "Pirates of the Caribbean is a sweeping action-adventure story set in an era when villainous pirates scavenged the Caribbean seas. This roller coaster tale teams a young man, Will Turner, with an unlikely ally in rogue and unusually heroic pirate Jack Sparrow."
                },
                new Movie()
                {
                    Id = 2, Title = "Interstellar", Rate = 10, Description = "Set in a dystopian future where humanity is embroiled in a catastrophic blight and famine, the film follows a group of astronauts who travel through a wormhole near Saturn in search of a new home for humankind."
                },
                new Movie()
                {
                    Id = 3, Title = "Green Mile", Rate = 9, Description = "The Green Mile is a 1996 serial novel by American writer Stephen King. It tells the story of death row supervisor Paul Edgecombe's encounter with John Coffey, an unusual inmate who displays inexplicable healing and empathetic abilities."
                },
                new Movie()
                {
                    Id = 4, Title = "Your name", Rate = 9, Description = "Your Name is a touching, emotional, dramatic movie about two character, Taki and Mitsuha, who begin waking up in each other's bodies every few days. They learn to work together to make both their lives as normal as possible and eventually, both attempt to visit one another."
                },
            };
        }
    }
}
