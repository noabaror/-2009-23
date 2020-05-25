using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace בגרות_2009_שאלה_23
{
   public class page2: page, IPrintHtml
    {
        protected int num2;
        public page2(int n, int n2):base (n)
        {
            this.num2 = n2;
        }
    }
    public override void Print()
    {
        base.Print();
        Console.WriteLine(this.num2);

    }
    public override void CreateHtml()
    {
        Console.WriteLine("Html Data: num=" + this.num + ",num2=" + this.num2);
    }
}
}
