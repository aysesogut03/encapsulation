using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ogrenci ogrenci1= new ogrenci();
            ogrenci1.setisim("enes");
            string gelenisim= ogrenci1.getisim();
            if (gelenisim == "enes")
            {
                Console.WriteLine("Başarılı");
            }
            else
            {
                Console.WriteLine("başarısız");
            }
            Console.ReadLine();
        }
    }
}
