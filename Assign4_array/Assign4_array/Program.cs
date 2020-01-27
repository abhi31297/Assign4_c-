using System;
using System.Collections;
using System.Linq;

namespace Assign4_array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] things = new string[5]{"Boat", "house", "cat", "river", "cupboard" };
            foreach (string item in things)
            {
                Console.WriteLine(item+"s");
            }

            Console.WriteLine();

            things[1] = "Home";
            Console.WriteLine(things[1]);
            Console.WriteLine();

            ArrayList ArrayList = new ArrayList();
            ArrayList.AddRange(things);
            ArrayList.Add("coconut");

            Console.WriteLine(ArrayList.Count);
            Console.WriteLine();

            foreach (string item in ArrayList)
            {
                char[] store = item.ToCharArray();
                if (store.Length == 7)
                {
                    Console.WriteLine("Word with 7 letters in array list is : " + item);
                }
            }

            Console.WriteLine();
            Console.WriteLine("The word on 3rd position is: "+ ArrayList[2] );
            Console.WriteLine();

            var sorted = ArrayList.Cast<string>()
                 .OrderBy(str => str.Length)
                 .ThenBy(str => str);
            foreach (var item in sorted)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            ArrayList.Reverse();
            foreach (var item in ArrayList)
            {
                Console.WriteLine(item);
            }


        }
    }
}
