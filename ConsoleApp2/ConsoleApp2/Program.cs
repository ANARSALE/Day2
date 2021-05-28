using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
			int[,] arr = new int[2, 2];
			int[,] trans = new int[2, 2];
			int row, col;
			Console.WriteLine("Enter Values into Array: ");
			for (row = 0; row < 2; row++)
			{
				for (col = 0; col < 2; col++)
				{
					arr[row, col] = Convert.ToInt32(Console.ReadLine());
				}
			}

			for (row = 0; row < 2; row++)
			{
				for (col = 0; col < 2; col++)
				{
					trans[col, row] = arr[row, col];
				}
			}

			Console.WriteLine("Actual array");
			for (row = 0; row < 2; row++)
			{
				for (col = 0; col < 2; col++)
				{
					Console.Write(arr[row, col] + "\t");
				}
				Console.WriteLine();
			}
			Console.WriteLine("Transpose array");
			for (row = 0; row < 2; row++)
			{
				for (col = 0; col < 2; col++)
				{
					Console.Write(trans[row, col] + "\t");
				}
				Console.WriteLine();
			}
			}
		}
}
