using CvApplication.Models;

namespace CvApplication.Services
{
    public class AppServices
    {
        public int CalculateGrade(CvBindingModel Input)
        {

            int g = 0;
            if (Input.C) g += 10;
            if (Input.SQL) g += 10;
            if (Input.Mips) g += 10;
            if (Input.Java) g += 10;
            if (Input.PHP) g += 10;
            if (Input.dotnet) g += 10;
            if (Input.Gender == "Male") g += 5;
            if (Input.Gender == "Female") g += 10;

            return g;
        }
    }
}
