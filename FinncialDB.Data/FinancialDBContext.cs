using FinancialDB.Domain;
using Microsoft.EntityFrameworkCore;

namespace FinncialDB.Data
{
    public class FinancialDBContext : DbContext
    {
        public DbSet<ApplicationUserLogin> ApplicationUserLogin { get; set; }

    }
}