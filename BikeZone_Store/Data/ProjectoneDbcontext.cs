using BikeZone_Store.Models;
using Microsoft.EntityFrameworkCore;

namespace BikeZone_Store.Data
{

    public class ProjectoneDbcontext : DbContext
    {
        public ProjectoneDbcontext(DbContextOptions<ProjectoneDbcontext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
    }



}
