using Microsoft.EntityFrameworkCore;
using PrzezMiasto.Api.Models;

namespace PrzezMiasto.Api.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Place> Places { get; set; }
    }
}