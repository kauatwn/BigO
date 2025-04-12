// Complexidade O(n^2): o tempo de execução é proporcional ao quadrado do tamanho da entrada, ocorrendo quando cada
// elemento é processado em um loop dentro de outro loop.
// Exemplo clássico: processamento de matrizes ou algoritmos como Insertion Sort e Bubble Sort.

var matrix = new int[5, 5];
FillMatrix(matrix);

Console.WriteLine("Matriz original:");
PrintMatrix(matrix);

SortMainDiagonal(matrix);

Console.WriteLine("Matriz com diagonal principal ordenada:");
PrintMatrix(matrix, highlightDiagonal: true);

return;

static void FillMatrix(int[,] matrix) // O(n^2) - Quadrática
{
    var random = new Random();
    for (var i = 0; i < matrix.GetLength(0); i++)
    {
        for (var j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = random.Next(0, 100);
        }
    }
}

static void PrintMatrix(int[,] matrix, bool highlightDiagonal = false) // O(n^2) - Quadrática
{
    Console.WriteLine("[");
    for (var i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("  [");
        for (var j = 0; j < matrix.GetLength(1); j++)
        {
            if (highlightDiagonal && i == j)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"{matrix[i, j]:D2}");
                Console.ResetColor();
            }
            else
            {
                Console.Write($"{matrix[i, j]:D2}");
            }

            if (j < matrix.GetLength(1) - 1)
            {
                Console.Write(", ");
            }
        }
        Console.Write("]");
        if (i < matrix.GetLength(0) - 1)
        {
            Console.Write(",");
        }
        Console.WriteLine();
    }
    Console.WriteLine($"]{Environment.NewLine}");
}

static void SortMainDiagonal(int[,] matrix) // O(n^2) - Quadrática
{
    var diagonal = new int[matrix.GetLength(0)];

    for (var i = 0; i < matrix.GetLength(0); i++)
    {
        diagonal[i] = matrix[i, i];
    }

    InsertionSort(diagonal);

    for (var i = 0; i < matrix.GetLength(0); i++)
    {
        matrix[i, i] = diagonal[i];
    }

    return;

    static void InsertionSort(int[] array) // O(n^2) - Quadrática
    {
        for (var i = 1; i < array.Length; i++)
        {
            int currentValue = array[i];
            int previousIndex = i - 1;

            while (previousIndex >= 0 && array[previousIndex] > currentValue)
            {
                ShiftRight(array, previousIndex);
                previousIndex--;
            }

            array[previousIndex + 1] = currentValue;
        }

        return;

        static void ShiftRight(int[] array, int previousIndex)
        {
            array[previousIndex + 1] = array[previousIndex];
        }
    }
}