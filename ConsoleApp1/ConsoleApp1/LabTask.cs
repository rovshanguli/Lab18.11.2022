using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class LabTask
    {
        public void ElementOfArray(string[] array)
        {

            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);
            //}

            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine(array[i]);
            //}





        }

        public void DioganalDifference(int[,] arr)
        {
            int lefttoright = 0;
            int rigthtoleft = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                lefttoright = lefttoright + arr[i, i];
            }



            int j = arr.GetLength(0) - 1;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                rigthtoleft += arr[i, j];
                j--;
            }

            Console.WriteLine(lefttoright - rigthtoleft);

        }



        public string Trim(string str)
        {
            string result = "";
            int start = 0;
            int end = str.Length - 1;

            while (str[start] == ' ')
            {
                start++;
            }

            while (str[end] == ' ')
            {
                end--;
            }

            result = str.Substring(start, end - start + 1);

            return result;
        }

    }
}
