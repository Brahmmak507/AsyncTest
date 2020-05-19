using customclassLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTSTestAsynch
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomClass custom = new CustomClass();
            Task<int> x = custom.Method1();
            int y=custom.Method2();
            Console.WriteLine("x:{0},y:{1}",x.Result,y);
            Console.ReadLine();
        }
    }
}
