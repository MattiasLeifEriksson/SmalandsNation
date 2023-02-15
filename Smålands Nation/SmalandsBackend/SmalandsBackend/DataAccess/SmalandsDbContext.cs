using Microsoft.EntityFrameworkCore;
using SmalandsBackend.Models;

using System.Data.Common;

namespace SmalandsBackend.DataAccess
{
    public class SmalandsDbContext: DbContext
    {
        public DbSet<Board>? Boards { get; set; }
        public DbSet<image>? images { get; set; }
        public SmalandsDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        DbSeed.Seed(modelBuilder);

    }}
}
