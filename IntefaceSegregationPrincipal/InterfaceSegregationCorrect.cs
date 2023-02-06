using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntefaceSegregationPrincipal
{
    internal interface InterfaceSegregationCorrect
    {
    }

    //the idea is 
    /*rather the one fat interface numerous little interfaces*/

    internal interface IPrintTask {
        void Print(string PrintContent);
        void Scan(string ScanContent);
    }

    internal interface IFaxTask
    {
        void Fax(string PrintContent);
       
    }

    internal interface IDuplicateTask
    {
        void PrintDuplex(string PrintContent);

    }


    public class HPLaserJetPrinterOne : IPrintTask, IFaxTask,IDuplicateTask
    {
        public void Fax(string PrintContent)
        {
            Console.WriteLine("fax");
        }

        public void Print(string PrintContent)
        {
            Console.WriteLine("print");
        }

        public void PrintDuplex(string PrintContent)
        {
            Console.WriteLine("printDuplex");
        }

        public void Scan(string ScanContent)
        {
            Console.WriteLine("scan");
        }
    }


    public class LiquidInkjetPrinter : IPrintTask
    {
        public void Print(string PrintContent)
        {
            Console.WriteLine("print");
        }

        public void Scan(string ScanContent)
        {
            Console.WriteLine("scan");
        }
    }
}
