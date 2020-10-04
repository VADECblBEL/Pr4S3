using System;
using System.Collections;

namespace Pr4S3
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();

            ht["0"] = "Zero";
            ht["1"] = "One";
            ht["2"] = "Two";
            ht["3"] = "Three";
            ht["4"] = "Four";
            ht["5"] = "Five";
            ht["6"] = "Six";
            ht["7"] = "Seven";
            ht["8"] = "So many";
            ht["9"] = "Finally nine";

            string number = "915-066-1129";
            foreach (char c in number)
            {
                string digit = c.ToString();
                if (ht.ContainsKey(digit))
                {
                    Console.WriteLine(ht[digit]);
                }
            }
        }
    }
}
