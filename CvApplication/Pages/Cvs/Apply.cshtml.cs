using CvApplication.Models;
using CvApplication.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CvApplication.Pages.Cvs
{
    public class ApplyModel : PageModel
    {


        [BindProperty(SupportsGet = true)]
        public CvBindingModel Input { get; set; }

        public Application App { get; set; }
        public AppServices Services { get; set; }
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



        /* public List<string> SelectSkills { get; set; } =
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
        */
        //To call the services we have 2 ways either i make public AppServices app = new AppServices();
        //which is god, but its better to make dependency injection;


        



        public ApplyModel(AppServices appServices,AppCvContext database)

        {
            this.database = database;
            Services = appServices;
        }
        public void OnGet()
        {
        }



        public async Task<IActionResult> OnPost()
        {

            if ((Input.X + Input.Y) != Input.Sum)
            {
                ModelState.AddModelError(string.Empty, "The sum is incorrect. Please try again.");
                return Page();
            }
            if (!ModelState.IsValid)
            {
                return Page();
            }

            //     Input.Skills = services.MergeSkills(SelectSkills);


            Input.grade = Services.CalculateGrade(Input);
            var application = new Application
            {
                FirstName = Input.FirstName,
                LastName = Input.LastName,
                Date = Input.Date,
                Gender = Input.Gender,
                Email = Input.Email,
                Nationality= Input.Nationality,
                SQL= Input.SQL,
                Java= Input.Java,
                Mips= Input. Mips,
                C= Input. C,
                PHP= Input. PHP,
                dotnet= Input. dotnet,
                Grade = Input.grade
                
            };
            database.Applications.Add(application);
           await database.SaveChangesAsync();
            return RedirectToPage("/Summary", Input);
        }
    }
}
