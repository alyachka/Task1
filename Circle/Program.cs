using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading;

namespace Circle
{
   

    class Program
    {
        static void Main(string[] args)
        {
            InOutFile FL = new InOutFile();
            Round[] ar = FL.Input("input.txt");
            FL.Output(ar);
            foreach (Round item in ar)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
