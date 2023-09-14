using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data.Common;

namespace CvApplication.Models
{
    public class AppCvContext:DbContext
    {
        public AppCvContext(DbContextOptions<AppCvContext> options) : base(options) { }

        public DbSet<Application> Applications { get; set; }
    }
}
