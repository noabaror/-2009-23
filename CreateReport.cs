using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace בגרות_2009_שאלה_23
{
    class CreateReport
    {
        public static void CreateBinaryDoc(IPrintBinary doc)
        {
            Console.WriteLine("***Binary Doc***");
            doc.CreateBinary();
        }
        public static void CreateHtmlDoc(IPrintHtml doc)
        {
            Console.WriteLine("***Html Doc***");
            doc.CreateHtml();
        }
        
    }   
}
