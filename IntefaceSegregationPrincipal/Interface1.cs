using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntefaceSegregationPrincipal
{
    internal interface IPrinterTasks
    {
        void Print(string PrintContent);
        void Scan(string ScanContent);
        void Fax(string FaxContent);
        void PrintDuplex(string PrintDuplexContent);

    }

    public class HPLaserJetPrinter : IPrinterTasks
    {
        public void Fax(string FaxContent)
        {
            Console.WriteLine("Fax");
        }

        public void Print(string PrintContent)
        {
            Console.WriteLine("Print");
        }

        public void PrintDuplex(string PrintDuplexContent)
        {
            Console.WriteLine("PrintDuplex");
        }

        public void Scan(string ScanContent)
        {
            Console.WriteLine("Scan");
        }

        public class LiquidInkjetPrinter : IPrinterTasks
        {
           

            public void Print(string PrintContent)
            {
                Console.WriteLine("print");
            }
            public void Scan(string ScanContent)
            {
                Console.WriteLine("Scan");
            }

            //Interface segragation principal was violeted 
            //method that we don't need it to use
            public void PrintDuplex(string PrintDuplexContent)
            {
                throw new NotImplementedException();
            }

            public void Fax(string FaxContent)
            {
                throw new NotImplementedException();
            }
        }
    }
}
