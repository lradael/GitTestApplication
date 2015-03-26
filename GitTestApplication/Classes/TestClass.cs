using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTestApplication.Classes
{
    public class TestClass
    {
        private int _count = 0;

        public void Increase()
        {
            this._count++;
        }

        public void IncreaseByValue(int pValue)
        {
            this._count = this._count + pValue;
        }
    }
}
