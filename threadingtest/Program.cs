//https://msdn.microsoft.com/en-us/library/aa645740(v=vs.71).aspx

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace threadingtest
{

    class arr_poker
    {
        int ele;
        int[] arr;
        public arr_poker(ref int[] a, int e)
        {
            ele = e;
            arr = a;
            test();
        }
        void test()
        {
            arr[ele] = 99;
        }
    }
    class Program
    {
        static int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        static List<int> lst; //duplicate to test both

        static void Main(string[] args)
        {
            lst = new List<int>(arr); //dupelicate

            //arr first
            arr_poker aclass = new arr_poker(ref arr,5);




            for(int i = 0; i < arr.Length; ++i)
            {
                Console.WriteLine(arr[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
