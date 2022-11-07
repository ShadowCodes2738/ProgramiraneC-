using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aliqouts
{
    class AliqoutN
    {
        private int n;
        private int p;

        public int P
        {
            get { return p; }
            set
            {
                if (value % n == 0)
                {

                    p = value;

                }
                else
                {
                    throw new ArgumentException("p must be a positive number"); ;
                }

            }
        }
        public int N
        {
            get { return n; }
            set
            {
                if (value > 0)
                {
                    n = value;
                }
                else
                {
                    throw new ArgumentException("n is not dividable by p");
                }

            }
        }
        public AliqoutN(int n)
        {
            this.P = n;
            this.N = n;
        }
        public AliqoutN() : this(1)
        { }
        public void SumN(int k)
        {
            if (k % n == 0)
            {
                p += k;
            }
            else
            {
                throw new ArgumentException("Argument is not divable by k");
            }
        }
    }
}   
//NNN 7.11.2022
            

