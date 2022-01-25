using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNITY_DEVELOPER_TEST
{
    public class Quest1
    {
        public int _input;

        public Quest1(int input)
        {
            _input = input;
        }
        public void Run()
        {
            if (_input < 4)
            {
                Console.WriteLine(_input + " la so nguyen to");
                return;
            }

            bool primeNumber = true;
            for (int i = 2; i <= Math.Sqrt(_input); i++)
            {
                if (_input % i == 0)
                {
                    primeNumber = false;
                    break;
                }
            }

            if (primeNumber)
            {
                Console.WriteLine(_input + " la so nguyen to");
            }
            else
            {
                Console.WriteLine(_input + " khong la so nguyen to");
            }
        }
    }
}
