using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermFirstBuild
{
    class BagFullException : ApplicationException
    {
        public BagFullException() : base("Your bag is full, you can't hold anymore items")
        {

        }
    }
}
