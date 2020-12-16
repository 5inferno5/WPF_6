using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpflab6
{
    class Params
    {
        int xMin;
        int xMax;
        int n;

        public int XMin
        {
            get { return xMin; }
            set { xMin = value; }
        }
        public int XMax
        {
            get { return xMax; }
            set
            { if (value == 0 || value > 1) throw new ArgumentOutOfRangeException("Xmax can't be zerro or more than 1");
                xMax = value;
            }
        }
        public int N
        {
            get { return n; }
            set 
            { 
            if (value == 0) throw new ArgumentException("Steps can't = 0");
                n = value;
            }
        }
        public Params(int xMin, int xMax, int n)
        {
            XMin = xMin;
            XMax = xMax;
            N = n;
        }
        public Params()
        {
            XMin = 0;
            XMax = 1;
            N = 100;
        }
    }
}
