using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNITY_DEVELOPER_TEST
{
    public class Quest4
    {
        float _positionStartX, _positionStartY;
        float _v0;
        float g = 9.98f;
        double _aplfa0;

        /// <param name="positionX">tọa độ x ban đầu</param>
		/// <param name="positionY">tọa độ y ban đầu</param>
        /// <param name="v0">vận tốc ban đầu</param>
        /// <param name="aplfa0">góc ném (độ)</param>
        public Quest4(float positionX, float positionY, float v0, float aplfa0)
        {
            _positionStartX = positionX;
            _positionStartY = positionY;
            _v0 = v0;
            _aplfa0 = aplfa0 * Math.PI / 180;
        }

        public void Run(float t)
        {
            var x = _v0 * Math.Cos(_aplfa0) * t;
            var y = _v0 * Math.Sin(_aplfa0) * t - g * Math.Pow(t, 2) / 2;
            
            var posX = _positionStartX + x;
            var posY = _positionStartY + y;

            Console.WriteLine("({0},{1})", posX, posY);
        }
    }
}
