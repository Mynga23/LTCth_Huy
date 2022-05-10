using System;

namespace BAITAPDIEMDANH
{
    class Program
    {
        static void Main(string[] args)
        {
          
            int[] arr1 = new int[100];
            int i_241,j_241, mx_241, mn_241, n_241, tmp_241;
            n_241 = 11;
            for (i_241 = 0; i_241 < n_241; i_241++)
            {
                Console.Write("Phan tu - {0}: ", i_241);
                arr1[i_241] = Convert.ToInt32(Console.ReadLine());
            }
            mx_241 = arr1[0];
            mn_241 = arr1[0];
            for (i_241 = 1; i_241 < n; i_241++)
            {
                if (arr1[i_241] > mx_241)
                {
                    mx_241 = arr1[i_241];
                }


                if (arr1[i_241] < mn_241)
                {
                    mn_241 = arr1[i_241];
                }
            }
            Console.Write("Phan tu lon nhat trong mang la: {0}\n", mx_241);
            Console.Write("Phan tu nho nhat trong mang la: {0}\n\n", mn_241);
            for (i_241 = 0; i_241 < n_241; i_241++)
            {
                for (j_241 = i_241 + 1; j_241 < n_241; j_241++)
                {
                    if (arr1[j_241] < arr1[i_241])
                    {
                        //cach trao doi gia tri
                        tmp_241 = arr1[i_241];
                        arr1[i_241] = arr1[j_241];
                        arr1[j_241] = tmp_241;
                    }
                }
            }
            Console.Write("\nIn cac phan tu mang theo thu tu tang dan:\n");
            for (i_241 = 0; i_241 < n_241; i_241++)
            {
                Console.Write("{0}  ", arr1[i_241]);
            }
             for (i_241 = 0; i_241 < n_241; i_241++)
            {
                for (j_241 = i_241 + 1; j_241 < n_241; j_241++)
                {
                    if (arr1[i_241] < arr1[j_241])
                    {
                        //cach trao doi gia tri
                        tmp_241 = arr1[i_241];
                        arr1[i_241] = arr1[j_241];
                        arr1[j_241] = tmp_241;
                    }
                }
            }

            Console.Write("\nIn cac phan tu mang theo thu tu giam dan:\n");
            for (i_241 = 0; i_241 < n_241; i_241++)
            {
                Console.Write("{0}  ", arr1[i_241]);
            }

        }
    }
}
