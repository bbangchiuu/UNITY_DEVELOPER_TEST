using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNITY_DEVELOPER_TEST
{
    public class Quest2
    {
        public void Run()
        {
            decimal f1 = 0;
            decimal f2 = 1;
            Console.WriteLine("1: " + f1);
            Console.WriteLine("2: " + f2);

            for (int i = 3; i <= 100; i++)
            {
                decimal fn = f1 + f2;
                Console.WriteLine(i + ": " + fn);
                f1 = f2;
                f2 = fn;
            }
        }
    }
}
