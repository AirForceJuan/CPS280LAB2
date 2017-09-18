using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPS280LAB2_rojas1nd
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr1 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            int[,] arr2 = { { 9, 8, 7 }, { 6, 5, 4 }, { 3, 2, 1 } };


            int[,] ans = new int[3, 3];
            Console.WriteLine("FIRST ARRAY");
            Print(arr1);
            Console.WriteLine("SECOND ARRAY");
            Print(arr2);
            Console.WriteLine("FIRST ARRAY + SECOND ARRAY ");
            Add(arr1,arr2,ref ans);
            Console.WriteLine("FIRST ARRaY - SECOND ARRAY");
            Subtract(arr1, arr2, ref ans);
            Console.Read();
        }

        private static void Print(int[,] mat)
        {
            int row = mat.GetLength(0);
            int col = mat.GetLength(1);

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(string.Format("{00,5} ", mat[i, j]));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
            Console.ReadLine();

        }

        private static void Add(int[,] arrA, int[,] arrB, ref int[,] ans)
        {

            int arrayRow = ans.GetLength(0);
            int arrayCol = ans.GetLength(1);

            int[,] result = new int[ans.GetLength(0), ans.GetLength(1)];


            for (int i = 0; i < arrayRow; i++)
            {
                for (int j = 0; j < arrayCol; j++)
                {
                    result[i, j] = arrA[i, j] + arrB[i, j];

                    Console.Write(string.Format("{00,5}", result[i, j]));
                }

                Console.WriteLine();
            }

        }
        private static void Subtract(int[,] arrA, int[,] arrB, ref int[,] ans)
        {

            int arrayRow = ans.GetLength(0);
            int arrayCol = ans.GetLength(1);

            int[,] result = new int[ans.GetLength(0), ans.GetLength(1)];


            for (int i = 0; i < arrayRow; i++)
            {
                for (int j = 0; j < arrayCol; j++)
                {
                    result[i, j] = arrA[i, j] - arrB[i, j];

                    Console.Write(string.Format("{00,5}", result[i, j]));
                }

                Console.WriteLine();
            }

        }

    }
}
