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
            // CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator = "@"; wyskakuje problem, bo nie można tak zrobić! Trzeba pracować na kopii.
            // Poniższe też nie zadziała, bo trzeba wykonać rzutowanie  rzutujący(rzutowanie)
            //var newCulture = CultureInfo.CurrentCulture.Clone();
            //newCulture.

            var newCulture = (CultureInfo)CultureInfo.CurrentCulture.Clone();
            newCulture.NumberFormat.NumberDecimalSeparator = " @ ";
            newCulture.NumberFormat.NegativeSign = "~MiNuS~";
            CultureInfo.CurrentCulture = newCulture; // nadpisanie kultury naszą nową

            int a = -5;
            float b = 3.14f; // wartość standardowo wyświetlana z kropką ! Zmienimy to na  małpę @

            Console.WriteLine(a);
            Console.WriteLine(b);

            Console.ReadKey();
        }
    }
}
