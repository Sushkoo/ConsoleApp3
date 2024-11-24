using ConsoleApp3;

static void Main(string[] args)
{
	Matrix matrix = new Matrix(3, 3);
	Matrix matrix2 = new Matrix(3, 3);


	int[,] result = Matrix.Osszead(matrix, matrix2);

	Matrix.FillArray(matrix.array, 5);

	Console.WriteLine("Mátrix tartalma:");
	Console.WriteLine(matrix);



	Matrix matrix3 = new Matrix(3, 4);

	Console.WriteLine($"Mátrix mérete: {matrix.Meret}");
	Console.WriteLine($"Mátrix hossza: {matrix.Hossz}");

	Matrix.FillArray(matrix3, 7);
	Console.WriteLine("Mátrix tartalma:");
	Console.WriteLine(matrix);
}