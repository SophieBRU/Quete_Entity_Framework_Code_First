using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quete_EntityFrameWorkCodeFirst
{
    class SavingCalculator
    {
        public void calculatetotalsaved(DateTime begin, DateTime end, ICollection<SavingAccount> SavingAccounts)
        {
            var monthNumber = DateAndTime.DateDiff(DateInterval.Month, begin, end);

            Double allTotalSaving = 0;

            foreach (SavingAccount sv in SavingAccounts)
            {
                if(sv.Periodicity == 12) 
                {                     ;
                    var totalSaving = (sv.Capital * Math.Pow((1 + sv.Rate), monthNumber)) - sv.Capital;
                    allTotalSaving = allTotalSaving + totalSaving;
                    Console.WriteLine("Saving par compte par période mensuelle : " + Math.Round(totalSaving, 2));
                }
                else if(sv.Periodicity == 1)
                {
                    var totalSaving = (sv.Capital * Math.Pow((1 + sv.Rate), (monthNumber/12))) - sv.Capital;
                    allTotalSaving = allTotalSaving + totalSaving;
                    Console.WriteLine("Saving par compte par période annuelle : " + Math.Round(totalSaving, 2));
                }
                
            }
            Console.WriteLine("Saving de tous les comptes par période : " + Math.Round(allTotalSaving, 2));
        }
    }
}


