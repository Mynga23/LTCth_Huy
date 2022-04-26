using System;

namespace BT_Diemdanh
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap a = ");
            Double a_241 = Double.Parse(Console.ReadLine());
            Console.Write("Nhap b = ");
            Double b_241 = Double.Parse(Console.ReadLine());
            Console.Write("Nhap c = ");
            Double c_241 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Phuong trinh co dang {0}x^2 + {1}x + {2}", a_241, b_241, c_241);
            if (a_241 == 0)
            {
                Console.WriteLine("Phuong trinh tro thanh bac nhat");
                Console.WriteLine("Co nghiem bang, x = {0}", -c_241 / b_241);
            }
            else
            {
                Double delta_241 = b_241 * b_241 - 4 * a_241 * c_241;
                if (delta_241 < 0)
                    Console.WriteLine("Phuong trinh vo nghiem");
                else if (delta_241 == 0)
                    Console.WriteLine("Phuong trinh co nghiem kep, x1 = x2 = {0}", -b_241 / (2 * a_241));
                else
                {
                    Console.WriteLine("Phuong trinh co 2 nghiem phan biet");
                    Console.WriteLine("x1 = {0}", (-b_241 + Math.Sqrt(delta_241) / (2 * a_241)));
                    Console.WriteLine("x2 = {0}", (-b_241 - Math.Sqrt(delta_241) / (2 * a_241)));
                }
            }
        }
    }
}
