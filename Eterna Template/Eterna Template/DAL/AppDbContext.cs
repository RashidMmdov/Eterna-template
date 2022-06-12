using Eterna_Template.Models;
using Microsoft.EntityFrameworkCore;

namespace Eterna_Template.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<MiniCard> miniCards { get; set; }
        public DbSet<BigCard> bigCards { get; set; }
        public DbSet<ProgressBar> progressBars { get; set; }


    }
}
