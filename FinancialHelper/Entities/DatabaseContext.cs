using Microsoft.EntityFrameworkCore;

namespace FinancialHelper.Entities
{
    public class DatabaseContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<BankData> BankDatas { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=C:\Users\oleksii.hudzishevsky\Projects\ajp\PAB\AJP-PAB-PROJECT\FinancialHelper\app.db");
        }
    }
}
