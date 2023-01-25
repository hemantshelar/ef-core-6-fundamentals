using eReceiptsDomain;
using Microsoft.EntityFrameworkCore;

namespace eReceiptData
{
	public class eReceiptsDbContext : DbContext
	{

		public DbSet<Customer>	 Customers { get; set; }
		public DbSet<Receipt>	 Receipts { get; set; }


		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);
			var connString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EReceiptDb;Integrated Security=True";
			optionsBuilder.UseSqlServer(connString);
		}

	}
}