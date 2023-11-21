using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    internal class Information
    {
        public string name;
        public int currentDate;
        public int bornDate;

        public int CalcAge()
        {
            return currentDate - bornDate;
        }

        public void setDates(int current, int born)
        {
            currentDate = current;
            bornDate = born;
        }

    }
}
