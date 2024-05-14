using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s;

            //Py: print("Hello World")
            //Py: # comment
            Console.WriteLine("Hello World\n");

            int low_num = 0;
            while (low_num <= 0)
            {
                Console.Write("Type the LOW number: ");
                s = Console.ReadLine();
                low_num = int.Parse(s);
            }

            int high_num = low_num;
            while (high_num <= low_num)
            {
                Console.Write("Type the HIGH number: ");
                s = Console.ReadLine();
                high_num = int.Parse(s);
            }



            int diff_num;
            diff_num = high_num - low_num;
            //Py: "The difference is: diff_num"
            //Py: print("The difference is: ", diff_num)
            //Py: print(f"the difference is {diff_num})
            Console.WriteLine($"The difference is: {diff_num}");

            // int[] arr = new int[5] { 1, 2, 3, 4, 5 };
            int[] arr = new int[diff_num];

            // for i in range(diff_num)
            // i++ --> i += 1 --> i = i + 1
            // i-- --> i -= 1 --> i = i - 1
            for (int i = 0; i < diff_num; i++)
            {
                arr[i] = low_num + i;
            }

            string file_path = @"C:\TEMP\numbers.txt";
            using (StreamWriter writer = new StreamWriter(file_path))
            { 
                for (int i = 0; i < diff_num; i--)
                {
                    Console.WriteLine($"Reverse: {arr[i]}");
                }

                foreach (int i in arr)
                {
                    Console.WriteLine($"Value: {i}");
                    writer.WriteLine(arr[i]);
                }
            }

            Console.ReadLine();
        }
    }
}