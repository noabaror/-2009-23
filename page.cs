using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace בגרות_2009_שאלה_23
{
  public  class page: IPrintBinary
    {
        protected int num;
        public page ()
        { }
        public page (int n)
        {
            this.num = n;
        }
        public virtual void print()
        {
            Console.WriteLine(this.num);
        }
        public virtual void CreateBinary()
         

    }
}
