using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTestApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;

            x = x * 5; // branch a

            x = x * 3;

            x = x * 5; // branch a

            x = x * 1;

            x = x * 5; // branch a
        }
    }
}
