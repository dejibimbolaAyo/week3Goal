using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashSet_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dictionary =new Dictionary<string, int>();

            dictionary.Add("rice", 2);
            dictionary.Add("beans", 1);
            dictionary.Add("plantain", 3);
            dictionary.Add("yam", 4 );

            if (dictionary.ContainsKey("rice"))
            {
                int value = dictionary["rice"];
                Console.WriteLine(value);
            }
            Console.ReadLine();
        }
    }
}
