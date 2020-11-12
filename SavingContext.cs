using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Quete_EntityFrameWorkCodeFirst
{
    class SavingContext : DbContext
    {
        // Person entites can be accessed by this context
        public virtual DbSet<Person> Persons { get; set; }

        // SavingAccount entities can be accessed by this context
        public virtual DbSet<SavingAccount> SavingAccounts { get; set; }

        // OnConfiguring is a hook that executes while the context configures itself
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // I add a connection to a database instance while the context configures
            optionsBuilder.UseSqlServer(
                @"Server=LOCALHOST\SQLEXPRESS;Database=Saving;Integrated Security=True");
        }
    }
}
