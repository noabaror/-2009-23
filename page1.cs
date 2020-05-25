using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace בגרות_2009_שאלה_23
{
    class page1 : page  
    {
        protected int numl;
        public page1 (int n, int n1):base (n)
        {
            this.numl = n1;
        }
        public override void print()
        {
            base.print();
            Console.WriteLine(this.numl);

        }
        public override void CreateBinary()
        {
            Console.WriteLine("Binary Data: num="+this.num+",numl="+this.numl);
        }
    }
}
