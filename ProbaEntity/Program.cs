using System;
using System.Collections.Generic;
using System.Linq;

namespace ProbaEntity
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			var db = new DataCenter();

			var userlist = new List<User>();
			for (var i = 0; i < 10; i++)
			{
				userlist.Add(new User() {
					Name = $"usuari{i}",
					Age = i
				});
			}

			db.Users.AddRange(userlist);
			db.SaveChanges();
			Console.WriteLine(userlist[1].Name);

			var data = from usr in db.Users where usr.Name.StartsWith("u", StringComparison.Ordinal) select usr;
			foreach (var item in data)
			{
				Console.WriteLine(item.Name);
			}
		}
	}
}
