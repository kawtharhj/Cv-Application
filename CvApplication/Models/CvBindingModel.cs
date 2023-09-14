using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace CvApplication.Models
{
    public class CvBindingModel
    {


        [Required(ErrorMessage = "First Name is Required")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is Required")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Nationality Field is required")]
        [Display(Name = "Nationality")]
        public string Nationality { get; set; }

        [Required(ErrorMessage = "Gender is Required")]
        [Display(Name = "Gender")]
        public string Gender { get; set; }



        public bool Java { get; set; }
        public bool dotnet { get; set; }
        public bool SQL { get; set; }
        public bool PHP { get; set; }
        public bool C { get; set; }
        public bool Mips { get; set; }


        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [Compare("Email", ErrorMessage = "The confirm email does not match.")]
        [Display(Name = "Confirm Your Email")]
        public string CnEmail { get; set; }

        [Required]
        [Display(Name = "Enter X ")]
        [Range(1, 20, ErrorMessage = "X must be between 1 and 20")]
        public int X { get; set; }

        [Required]
        [Display(Name = "Enter Y ")]
        [Range(20, 50, ErrorMessage = "Y must be between 20 and 50")]
        public int Y { get; set; }

        [Required]
        [Display(Name = "Sum ")]
        public int Sum { get; set; }

       [Required(ErrorMessage = "Upload A Photo")]
        [DataType(DataType.Upload)]
        [Display(Name = "Upload Photo")]
        public IFormFile Photo { get; set; }

        public int grade { get; set; } = 0;


    }
}
