using Microsoft.EntityFrameworkCore;
using TracNghiemOnline.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
namespace TracNghiemOnline.Data
{
    public class ApplicationDbContext : IdentityDbContext<CustomUser>
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) :base(options) { }

        public DbSet<Lophoc> Lophocs { get; set; }


        public DbSet<Monhoc> Monhocs { get; set; }

        public DbSet<Loaitk> Loaitks { get; set; }

        public DbSet<Dethi> Dethis { get; set; }


        public DbSet<Cauhoi> Cauhois { get; set; }

        public DbSet<DapAn> DapAns   { get; set; }
    }
}
