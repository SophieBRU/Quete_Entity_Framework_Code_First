using System;
using System.Collections.Generic;
using System.Text;

namespace Quete_EntityFrameWorkCodeFirst
{
    class Person
    {
        public Guid PersonId { get; set; }
        public String Name { get; set; }
        public ICollection<SavingAccount> SavingAccounts { get; set; }
    }
}
