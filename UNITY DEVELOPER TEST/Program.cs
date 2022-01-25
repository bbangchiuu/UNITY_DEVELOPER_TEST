using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNITY_DEVELOPER_TEST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Quest1 quest1 = new Quest1(9);
            //quest1.Run();

            //Quest2 quest2 = new Quest2();
            //quest2.Run();

            //Quest3 quest3 = new Quest3("9/16", "1/4");
            //quest3.Run();

            Quest4 quest4 = new Quest4(0, 0, 15, 45);
            quest4.Run(1.5f);
            Console.ReadKey();
        }
    }
}
