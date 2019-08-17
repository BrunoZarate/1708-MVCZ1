using System.Data.Entity;

namespace MVCProject.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<MVCProject.Models.Product> Products { get; set; }
    }
}