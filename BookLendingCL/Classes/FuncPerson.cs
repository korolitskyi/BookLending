using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookLending.Classes
{
    public class FuncPerson
    {
        public int BookId { get; set; } 
        public int PersonId { get; set; }        
        public int FunctionId { get; set; }

        internal Book Book { get; set; }
        internal Person Person { get; set; }
        internal Function Function { get; set; }
    }
}
