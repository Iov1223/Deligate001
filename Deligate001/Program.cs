using System;
using System.Collections.Generic;
using System.Linq;


namespace Deligate001
{
    delegate void myDelegate(string myStr);
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            string str1 = Console.ReadLine();
            myDelegate print = Class1.Print;
            print += Class1.Space;
            print += Class1.countSym;
            print(str1);
            
        }
    }
}


