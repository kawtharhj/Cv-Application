using CvApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CvApplication.Pages
{
    public class SummaryModel : PageModel
    {

        [BindProperty(SupportsGet = true)]
        public CvBindingModel Input { get; set; }


        /* public IEnumerable<SelectListItem> Nationality { get; set; }
        = new List<SelectListItem>
        {
             new SelectListItem{Value="Lebanese" ,Text="Lebanese"},
             new SelectListItem{Value="Syrian" , Text="Syrian"},
             new SelectListItem { Value = "American", Text = "American" },
             new SelectListItem { Value = "British", Text = "British" },
             new SelectListItem { Value = "French", Text = "French" },
             new SelectListItem { Value = "German", Text = "German" },
             new SelectListItem { Value = "Japanese", Text = "Japanese" },
             new SelectListItem { Value = "Chinese", Text = "Chinese" },
             new SelectListItem { Value = "Russian", Text = "Russian" },
             new SelectListItem { Value = "Mexican", Text = "Mexican" },
             new SelectListItem { Value = "Australian", Text = "Australian" }
        };

         public IEnumerable<SelectListItem> Gender { get; set; } =
             new List<SelectListItem>
             {
                 new SelectListItem{Value="Male",Text="Male"},
                  new SelectListItem{Value="Female",Text="Female"}
             };

         public IEnumerable<SelectListItem> SelectSkills =
             new List<SelectListItem>
         {
                 new SelectListItem { Value = "Java", Text = "Java" },
                 new SelectListItem { Value = "C", Text = "C" },
                 new SelectListItem { Value = "Csharp", Text = "C#" },
                 new SelectListItem { Value = "Python", Text = "Python" },
                 new SelectListItem { Value = "Rubby", Text = "R" },
                 new SelectListItem { Value = "JavaScript", Text = "JavaScript" },
                 new SelectListItem { Value = "C++", Text = "C++" }

         };
        public int Grade { get; set; }
         public IActionResult OnPost()
         {

         }
        */

        public void OnGet(CvBindingModel input)
        {
            if ((Input.X + Input.Y) != Input.Sum)
            {
                ModelState.AddModelError(string.Empty, "The sum is incorrect. Please try again.");
            }
            this.Input = input;

        }

    }
}
