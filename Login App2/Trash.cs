using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class Trash
    {
        private bool takenOut;
        public Trash(bool value)
        {
            takenOut = value;
        }
        public bool TakenOut
        {
            get
            {
                return takenOut;
            }
            set
            {
                takenOut = value;
            }
        }
    }
}
