using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;


namespace Quete_EntityFrameWorkCodeFirst
{
    static class Program
    {
        static void Main()
        {
            using (var context = new SavingContext())
            {
                // I wipe out my database at each execution
                context.Database.EnsureDeleted();
                // Then I recreate it
                context.Database.EnsureCreated();

                var person = new Person
                {
                    Name = "Richard"
                };

                person.SavingAccounts = new List<SavingAccount>
                {
                    new SavingAccount { Rate = 0.05, Capital = 2000000 , Periodicity = 12},
                    new SavingAccount { Rate = 0.15, Capital = 250000, Periodicity = 1 },
                    new SavingAccount { Rate = 0.02, Capital = 10000000, Periodicity = 1 },
                };

                context.Add(person);
                // After the shop is added, his relatonships will too
                // if they are defined          
                context.SaveChanges();
                // Once changes are added, they must be saved to the database
                // unless you will have an unexisting one 

                SavingCalculator savingCalculator = new SavingCalculator();
                DateTime end = DateTime.Now;
                DateTime begin = new DateTime(2017, 11, 11);
                savingCalculator.calculatetotalsaved(begin, end, person.SavingAccounts);                           
            }
        }
    }
}
