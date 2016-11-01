using System.Data.Entity;

namespace ProbaEntity
{
	public class DataCenter : DbContext
	{
		public DataCenter() : base("dbconex")
		{
		}

		public DbSet<User> Users { get; set; }

	}
}
