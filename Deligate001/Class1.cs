using System;
using System.Collections.Generic;
using System.Text;

namespace Deligate001
{
    class Class1
    {
        static public void Print(string str)
        {
            
            Console.WriteLine(str);
        }
        static public void Space(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                Console.Write(str[i]);
                if (i % 2 != 0)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
        static public void countSym(string str)
        {
            Console.WriteLine("Колличество элементов в строке - {0} = {1}", str, str.Length);
        }

    }
}
