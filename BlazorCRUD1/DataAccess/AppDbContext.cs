using BlazorCRUD1.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorCRUD1.DataAccess
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Article> ArticleList { get; set; }
    }
}
