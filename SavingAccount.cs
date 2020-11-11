using System;
using System.Collections.Generic;
using System.Text;

namespace Quete_EntityFrameWorkCodeFirst
{
    class SavingAccount
    {
        public Guid SavingAccountId { get; set; }
        public Double Rate { get; set; }
        public Double Capital { get; set; }
        public Int32 Periodicity { get; set; }
    }
}
