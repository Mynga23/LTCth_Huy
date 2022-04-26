using System;
using System.Collections.Generic;
using System.Text;

namespace BaiDiemDanh_26_4
{
    class giai_pt_bac2
    {
        private double a_241, b_241, c_241;
        public giai_pt_bac2()
        {

        }
        public double A_241
        {
            get { return a_241; }
            set { a_241 = value; }

        }
        public double B_241
        {
            get { return b_241; }
            set { b_241 = value; }

        }
        public double C_241;
        {
            get { return c_241; }
            set { c_241 = value; }

        }
        public giai_pt_bac2(double a_241, double b_241, double c_241)
        {
            this.A_241 = a_241;
            this.B_241 = b_241;
            this.C_241 = c_241;
        }

        public double Delta(double a_241, double b_241, double c_241)
        {
            return (b_241 * b_241 - 4 * a_241 * c_241);
        }

        public void nghiem_PT(double a_241, double b_241, double c_241)
        {
            double delta_241 = Delta(a_241, b_241, c_241);
            if (a_241 == 0)
            {
                Console.WriteLine("Phuong trinh tro thanh bac nhat");
                Console.WriteLine("Co nghiem bang, x = {0}", -c_258 / b_258);
            }
            else
            {
                if (delta_241 < 0)
                    Console.WriteLine("Phuong trinh vo nghiem");
                else if (delta_241 == 0)
                    Console.WriteLine("Phuong trinh co nghiem kep, x1 = x2 = {0}", -b_258 / (2 * a_241));
                else
                {
                    Console.WriteLine("Phuong trinh co 2 nghiem phan biet");
                    Console.WriteLine("x1 = {0}", (-b_258 + Math.Sqrt(delta_241) / (2 * a_241)));
                    Console.WriteLine("x2 = {0}", (-b_258 - Math.Sqrt(delta_241) / (2 * a_241)));
                }

            }
        }
    }
}