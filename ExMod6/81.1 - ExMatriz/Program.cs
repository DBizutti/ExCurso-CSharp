using System;

namespace _81._1___ExMatriz {
    class Program {
        static void Main(string[] args) {

            int a, b, x;
            string[] matrixOrder;
            int[,] mat;

            Console.Write("Insert the matrix order: ");
            matrixOrder = Console.ReadLine().Split(' ');
            a = int.Parse(matrixOrder[0]);
            b = int.Parse(matrixOrder[1]);
            mat = new int[a, b];

            Console.WriteLine("Input the matrix:");
            for (int i = 0; i < a; i++) {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < b; j++) {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("-----------------------------------");

            Console.Write("Enter a number: ");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = 0; i < a; i++) {
                for (int j = 0; j < b; j++) {
                    if (mat[i, j] == x) {
                        Console.WriteLine($"Position: {i}, {j}");
                        if (j > 0) {
                            Console.WriteLine($"Left: {mat[i, j - 1]}");
                        }
                        if (i > 0) {
                            Console.WriteLine($"Up: {mat[i - 1, j]}");
                        }
                        if (j + 1 < b - 1) {
                            Console.WriteLine($"Right: {mat[i, j + 1]}");
                        }
                        if (i < a - 1) {
                            Console.WriteLine($"Down: {mat[i + 1, j]}");
                        }

                        Console.WriteLine();
                    }
                }
            }

        }
    }
}
