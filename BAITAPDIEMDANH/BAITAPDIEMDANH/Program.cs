using System;

namespace BAITAPDIEMDANH
{
    class Program
    {
        static void Main(string[] args)
        {
          
            int[] arr1 = new int[100];
            int i,j, mx, mn, n, tmp;
            n = 11;
            for (i = 0; i < n; i++)
            {
                Console.Write("Phan tu - {0}: ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            mx = arr1[0];
            mn = arr1[0];
            for (i = 1; i < n; i++)
            {
                if (arr1[i] > mx)
                {
                    mx = arr1[i];
                }


                if (arr1[i] < mn)
                {
                    mn = arr1[i];
                }
            }
            Console.Write("Phan tu lon nhat trong mang la: {0}\n", mx);
            Console.Write("Phan tu nho nhat trong mang la: {0}\n\n", mn);
            for (i = 0; i < n; i++)
            {
                for (j = i + 1; j < n; j++)
                {
                    if (arr1[j] < arr1[i])
                    {
                        //cach trao doi gia tri
                        tmp = arr1[i];
                        arr1[i] = arr1[j];
                        arr1[j] = tmp;
                    }
                }
            }
            Console.Write("\nIn cac phan tu mang theo thu tu tang dan:\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}  ", arr1[i]);
            }
            for (i = 0; i < n; i++)
            {
                for (j = i + 1; j < n; j++)
                {
                    if (arr1[i] < arr1[j])
                    {
                        //cach trao doi gia tri
                        tmp = arr1[i];
                        arr1[i] = arr1[j];
                        arr1[j] = tmp;
                    }
                }
            }

            Console.Write("\nIn cac phan tu mang theo thu tu giam dan:\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}  ", arr1[i]);
            }

        }
    }
}
