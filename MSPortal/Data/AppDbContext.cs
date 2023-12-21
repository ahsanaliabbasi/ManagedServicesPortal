using Microsoft.EntityFrameworkCore;

namespace MSPortal.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }


    }
}
