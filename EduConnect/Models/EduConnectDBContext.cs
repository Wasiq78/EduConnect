
using Microsoft.EntityFrameworkCore;
namespace EduConnect.Models
{
    public class EduConnectDBContext : DbContext
    {
        public EduConnectDBContext(DbContextOptions options) : base(options)
        {




        }
        public DbSet<HiringForm> HiringForm { get; set; }
        public DbSet<RequestTable> RequestTable { get; set; }
        public DbSet<Teacher> Teacher { get; set; }

    }
}
