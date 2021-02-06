using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] names = new string[] { "Ahmet","Mehmet","Batın"};
            //Console.WriteLine(names[0]);
            //Console.WriteLine(names[1]);
            //Console.WriteLine(names[2]);

            List<string> isimler2 = new List<string> {"Ahmet","Mehmet","Batın" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            isimler2.Add("Faruk");
            Console.WriteLine(isimler2[3]);

        }   
    }
}
