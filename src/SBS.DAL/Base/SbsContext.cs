using Microsoft.EntityFrameworkCore;
using SBS.Data.Entities;

namespace SBS.DAL.Base
{
    public class SbsContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Data Source=(localdb)\ProjectsV13;Initial Catalog=SBS.DB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        public DbSet<PedalType> PedalType { get; set; }
    }
}
