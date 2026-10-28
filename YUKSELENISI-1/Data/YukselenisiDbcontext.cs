using Microsoft.EntityFrameworkCore;
using YUKSELENISI_1.Models;

namespace YUKSELENISI_1.Data
{
    public class YukselenisiDbContext : DbContext
    {
        public YukselenisiDbContext(DbContextOptions<YukselenisiDbContext> options)
            : base(options)
        {
        }

        public DbSet<Hizmet> Hizmetler { get; set; }
        public DbSet<IletisimMesaji> IletisimMesajlari { get; set; }   

        
        
    }
}