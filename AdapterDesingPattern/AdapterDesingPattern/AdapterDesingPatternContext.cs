using Microsoft.EntityFrameworkCore;
using AdapterDesingPattern.Models;

namespace AdapterDesingPattern
{
    public class AdapterDesingPatternContext : DbContext
    {
        public AdapterDesingPatternContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            //DB BAĞLANTISI VB DATABASE INSTANCE'INI İLGİLENDİREN İNCE AYARLAR
            dbContextOptionsBuilder.UseSqlServer(
                "Server=127.0.0.1;" +
                "Database=ADP;" +
                "User Id=sa;" +
                "Password = 123;"
                );
        }
        public DbSet<Main> Mains { get; set; }
    }
}
