using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CultureInfoTool
{
    class Program
    {
        static void Main(string[] args)
        {
            //var allCultureTypes = CultureInfo.GetCultures(CultureTypes.AllCultures);
            //foreach (var VARIABLE in allCultureTypes)
            //{
            //    Console.Write(VARIABLE.Name + " - ");
            //    Console.WriteLine(VARIABLE.NumberFormat.NumberDecimalSeparator);
            //}

            Console.WriteLine(CultureInfo.CurrentCulture.Name);

            int a = -5;
            float b = 3.14f; // wartość standardowo wyświetlana z kropką ! Zmienimy to na  małpę @

            Console.WriteLine(a);
            Console.WriteLine(b);

            Console.ReadKey();
        }
    }
}
