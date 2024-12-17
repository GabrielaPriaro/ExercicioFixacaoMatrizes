namespace ExercicioFixacaoMatrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contNegativos = 0;

            Console.Write("Qual a ordem da matriz? ");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Digite os valores da {i + 1}ª linha da matriz:");
                string[] valor = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(valor[j]);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Diagonal Principal:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i, i] + " ");
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        contNegativos++;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Quantidade valores negativos: {contNegativos}");
        }
    }
}
