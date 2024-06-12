using Dranga_Marius_M531.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer
{
	public class MyDbContext : DbContext
	{
		private readonly string _windowsConnectionString = @"Data Source=DESKTOP-9JJKNRC;Database=TapDatabase2;Integrated Security = True; Connect Timeout = 30; Encrypt=False;Trust Server Certificate=False;Application Intent = ReadWrite; Multi Subnet Failover=False";

		public DbSet<Adresa> Addresses { get; set; }
		public DbSet<Banca> Banks { get; set; }
		public DbSet<Client> Clients { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(_windowsConnectionString);
		}

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);
		}
	}
}
