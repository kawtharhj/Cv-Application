using CvApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CvApplication.Pages.Cvs
{
    public class DeleteModel : PageModel
    {
        
            [BindProperty(SupportsGet = true)]
            public CvBindingModel Input { get; set; }
            [BindProperty(SupportsGet = true)]
            public Application App { get; set; }
            private readonly AppCvContext database;

            public DeleteModel(AppCvContext database)
            {
                this.database = database;
            }

            public void OnGet(int id)
            {
                App = database.Applications.Find(id);
            }

            public async Task<IActionResult> OnPost()
            {

                if (App != null)
                {

                    database.Applications.Remove(App);
                    await database.SaveChangesAsync();
                    return RedirectToPage("Browsing");
                }

                return Page();
            }
        }
}
