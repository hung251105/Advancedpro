using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advancedpro
{
    internal class Menu
    {

        public static void showMenu(string schoolName)
        {
            Console.WriteLine("\t\t|__________________________________________|");
            Console.WriteLine($"\t\t	[ {schoolName} Wizarding School ]	");
            Console.WriteLine("\t\t											");
            Console.WriteLine("\t\t	[1] Add Student							");
            Console.WriteLine("\t\t	[2] Add Teacher							");
            Console.WriteLine("\t\t	[3] Find Teacher						");
            Console.WriteLine("\t\t	[4] Find Student						");
            Console.WriteLine("\t\t	[5] Show Students						");
            Console.WriteLine("\t\t	[6] Show Teachers						");
            Console.WriteLine("\t\t	[7] Delete Teachers								");
            Console.WriteLine("\t\t	[8] Delete Students								");
            Console.WriteLine("\t\t__________________________________________");

        }
    }
}
