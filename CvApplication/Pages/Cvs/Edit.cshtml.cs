using CvApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CvApplication.Pages.Cvs
{
    public class EditModel : PageModel
    {

        [BindProperty(SupportsGet = true)]
        public CvBindingModel Input { get; set; }




        public Application App { get; set; }

        private readonly AppCvContext database;

        public IEnumerable<SelectListItem> Nationality { get; set; }
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



        public List<string> SelectSkills { get; set; } =
            new List<string>()
        {
                "PHP",
                "C",
                "C++",
                "Java",
                "C#",
                "Python",
                "SQL"

        };

        
        public EditModel(AppCvContext database)
        {
            this.database = database;
        }
        public IActionResult OnGet(int id)
        {

            App = database.Applications.FirstOrDefault(a => a.Id == id);
            if (App == null)
            {
                return NotFound();
            }
           

            Input.FirstName = App.FirstName;
            Input.LastName = App.LastName;
            Input.Date = App.Date;
            Input.Nationality = App.Nationality;
            Input.Gender = App.Gender;
            Input.Email = App.Email;
            Input.C = App.C;
            Input.Java = App.Java;
            Input.dotnet = App.dotnet;
            Input.SQL = App.SQL;
            Input.PHP = App.PHP;
            Input.Mips = App.Mips;

            return Page();
        }

        public async Task<IActionResult> OnPost()

        {
            if (App != null)
            {
                
                if (!ModelState.IsValid)
                {

                    return Page();
                }

                if (Input.X + Input.Y != Input.Sum)
                {
                    ModelState.AddModelError("Sum Validation", "The Summation is incorrect");
                    return Page();
                }
                 App.FirstName = Input.FirstName;
                 App.LastName = Input.LastName;
                 App.Date = Input.Date ;
                 App.Nationality= Input.Nationality;
                 App.Gender= Input.Gender ;
                 App.Email= Input.Email ;
                 App.C= Input.C ;
                 App.Java= Input.Java ;
                 App.dotnet= Input.dotnet ;
                 App.SQL = Input.SQL ;
                 App.PHP= Input.PHP ;
                 App.Mips= Input.Mips ;

                database.Applications.Update(App);
                await database.SaveChangesAsync();
                return RedirectToPage("Browse");
            }

            return Page();
        }
    }
}
