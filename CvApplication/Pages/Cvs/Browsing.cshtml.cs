using CvApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CvApplication.Pages.Cvs
{
    public class BrowsingModel : PageModel
    {

        public IEnumerable<Application> App;
        public AppCvContext database;


        [BindProperty(SupportsGet = true)]
        public CvBindingModel Input { get; set; }

        public Application Application { get; set; }
        public BrowsingModel(AppCvContext db)
        {
            database = db;
        }


        public void OnGet()
        {
            App = database.Applications;
        }
    }
}
