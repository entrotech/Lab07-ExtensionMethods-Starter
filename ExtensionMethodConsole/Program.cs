using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Talent.Domain;
using Talent.Domain.TestData;

namespace ExtensionMethodConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Extension Method Lab:");
            Console.WriteLine("\r\nPrint using foreach loop:");

            DomainObjectStore store = new DomainObjectStore();
            foreach(Show s in store.Shows)
            {
                Console.WriteLine(s.Display());
            }


            Console.WriteLine("Press <Enter> to quit the application");
            Console.ReadLine();
        }
    }
}
