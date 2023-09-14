using System.ComponentModel.DataAnnotations;

namespace CvApplication.Models
{
    public class Application
    {

        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public DateTime Date { get; set; }
        /*  {
              get => DateTime.Parse(_dateOfBirth);
              set => _dateOfBirth = value.ToString("o");
          }*/
        public bool Java { get; set; }
        public bool dotnet { get; set; }
        public bool SQL { get; set; }
        public bool PHP { get; set; }
        public bool C { get; set; }
        public bool Mips { get; set; }

        public string Nationality { get; set; }
        public string Gender { get; set; }

        public string Email { get; set; }
        public int Grade { get; set; }
    }
}
