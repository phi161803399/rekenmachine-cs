using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekenmachine
{
    public class Operand
    {
        private decimal _waarde;

        public decimal Waarde
        {
            get
            {
                return _waarde;
            }
            set { _waarde = value; }
        }

        public Operand()
        {
                
        }
        public Operand(decimal number)
        {
            _waarde = number;
        }
    }
}
