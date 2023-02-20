using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0216hw
{
    class Program
    {
        struct Vector3D
        {
            public double x { get; set; }
            public double y { get; set; }
            public double z { get; set; }

            public Vector3D(double _x, double _y, double _z)
            {
                x = _x;
                y = _y;
                z = _z;
            }
            public void Input()
            {
                Console.WriteLine("x?");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("y?");
                y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("z?");
                z = Convert.ToInt32(Console.ReadLine());
            }
            public void Print()
            {
                Console.WriteLine("x: " + x + " y: " + y + " z: " + z);
            }
            public double VectorPlus(Vector3D vector)
            {
                return ((this.x + vector.x) * (this.y + vector.y) * (this.z + vector.z));
            }
            public double VectorMinus(Vector3D vector)
            {
                return ((this.x - vector.x) * (this.y - vector.y) * (this.z - vector.z));
            }
            public Vector3D VectorMult(int mult)
            {
                Vector3D result = new Vector3D(this.x * mult, this.y * mult, this.z * mult);
                return result;
            }
        }

        struct DecimalNum
        {
            public int decnum { get; set; }
            public DecimalNum(int _decnum)
            {
                decnum = _decnum;
            }
            public void Input()
            {
                Console.WriteLine("number?");
                decnum = Convert.ToInt32(Console.ReadLine());
            }
            public void Print()
            {
                Console.WriteLine("number: "+decnum);
            }
            public string To2()
            {
                return Convert.ToString(decnum, 2);
            }
            public string To8()
            {
                return Convert.ToString(decnum, 8);
            }
            public string To16()
            {
                return Convert.ToString(decnum, 16);
            }
        }
        struct RGB
        {
            int R;
            int G;
            int B;
            public RGB(int _R,int _G,int _B)
            {
                if(_R >= 0 && _R <= 255 && _G >= 0 && _G <= 255 && _B >= 0 && _B <= 255)
                {
                    R = _R;
                    G = _G;
                    B = _B;
                }
                else
                {
                    throw new Exception("Out of range");
                }
            }
            public void Input()
            {
                Console.WriteLine("R?");
                R = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("G?");
                G = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("B?");
                B = Convert.ToInt32(Console.ReadLine());
            }
            public void Print()
            {
                Console.WriteLine(R + " " + G + " " + B);
            }
            public string ToHEX()
            {
                return R.ToString("X2") + R.ToString("X2") + B.ToString("X2");
            }
            public string ToCMYK()
            {
                int K = Math.Min(1 - R, 1 - G);
                K = Math.Min(K, 1 - B);
                int C = (1 - R - B) / (1 - B);
                int M = (1 - G - B) / (1 - B);
                int Y = (1 - B - B) / (1 - B);
                return C + " " + M + " " + Y + " " + K;
            }
        }

        static void Main(string[] args)
        {
        }
    }
}
