using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
	internal class Matrix
	{
		private int[,] array;

		public Matrix(int oszlop, int sor)
		{
			array = new int[oszlop, sor];
		}

		public Matrix(int helo)
		{
			array = new int[helo, helo];
		}

		public Matrix()
		{
			array = new int[3, 3];
		}

		public static void FillArray(int[,] array, int szam)
		{
			for (int oszlop = 0; oszlop < array.GetLength(0); oszlop++)
			{
				for (int sor = 0; sor < array.GetLength(1); sor++)
				{
					array[oszlop, sor] = szam;
				}
			}
		}

		public static int[,] Osszead(int[,] A, int[,] B)
		{
			if (A.GetLength(0) != B.GetLength(0) || A.GetLength(1) != B.GetLength(1))
			{
				throw new ArgumentException("A mátrixok mérete nem egyezik meg.");
			}

			int rows = A.GetLength(0);
			int cols = A.GetLength(1);

			int[,] result = new int[rows, cols];

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					result[i, j] = A[i, j] + B[i, j];
				}
			}

			return result;
		}

		public override string ToString()
		{
			if (array == null || array.Length == 0)
				return "Üres mátrix";

			string result = "";
			for (int i = 0; i < array.GetLength(0); i++)
			{
				for (int j = 0; j < array.GetLength(1); j++)
				{
					result += array[i, j].ToString().PadLeft(4);
				}
				result += "\n";
			}
			return result;
		}
		public string Meret => $"{array.GetLength(0)} x {array.GetLength(1)}";


		public int Hossz => array.Length;
	}
}

