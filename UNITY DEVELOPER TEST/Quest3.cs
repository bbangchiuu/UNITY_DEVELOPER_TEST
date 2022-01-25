using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNITY_DEVELOPER_TEST
{
    public class Quest3
    {
        public string _inputA, _inputB;
        public Quest3(string inputA, string inputB)
        {
            _inputA = inputA;
            _inputB = inputB;
        }

        public void Run()
        {
            var numberA = _inputA.Split('/');
            var numberB = _inputB.Split('/');

            var numerator = int.Parse(numberA[0]) * int.Parse(numberB[1]) + int.Parse(numberB[0]) * int.Parse(numberA[1]);
            var denominator = int.Parse(numberA[1]) * int.Parse(numberB[1]);

            var ucln = gcd(numerator, denominator);
            string sum = (numerator / ucln) + "/" + (denominator / ucln);
            Console.WriteLine(sum);
        }

        int gcd(int a, int b)
        {
            int r = a % b;
            while (r != 0)
            {
                a = b;
                b = r;
                r = a % b;
            }

            return b;
        }
    }
}
