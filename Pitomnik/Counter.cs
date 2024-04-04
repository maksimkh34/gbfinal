using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pitomnik
{
    internal class Counter
    {
        private int counter ;
        public void Increment() { counter++; }
        public int GetCounter() => counter;
        public bool InRange(int i) => 0 < i && i <= counter;
    }
}
