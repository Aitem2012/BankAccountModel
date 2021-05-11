using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Data
{
    public class BankWorldDbContext : DbContext
    {
       
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            SQLitePCL.Batteries.Init();
            optionsBuilder.UseSqlite(@"Data Source=C:\Users\hp\source\repos\TheNewBank\Data\Data\bankworld.db;");

            //optionsBuilder.UseInMemoryDatabase("BankWorld");
        }

        
    }
}
