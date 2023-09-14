using CvApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CvApplication.Pages.Cvs
{
    public class DetailsModel : PageModel
    {

        [BindProperty(SupportsGet = true)]
        public CvBindingModel Input { get; set; }

        private readonly AppCvContext database;
        [BindProperty(SupportsGet = true)]
        public Application App { get; set; }

        public DetailsModel(AppCvContext db)
        {
            database = db;
        }

        public void OnGet(int id)
        {
            App = database.Applications.Find(id);
        }

    }
}
