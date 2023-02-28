﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EFCoreEx1
{
	public class ApplicationContext : DbContext
	{
		public DbSet<User> Users => Set<User>();
		public ApplicationContext() => Database.EnsureCreated();

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlite("Data Source=helloapp.db");
		}

	}
}
