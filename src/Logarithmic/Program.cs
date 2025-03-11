using System.Diagnostics;

// É O(log n) quando:

// Divide o problema em partes menores.
// A complexidade de tempo é logarítmica, ou seja, cresce de forma logarítmica em relação ao tamanho da entrada.
// Exemplo: busca binária.

var array = new int[100_000];
FillArray(array);

var random = new Random();
int target = random.Next(0, array.Length);

var stopwatch = Stopwatch.StartNew();
int result = BinarySearch(array, target);
stopwatch.Stop();

Console.WriteLine($"Resultado da busca: {result}");
Console.WriteLine($"Tempo de execução: {stopwatch.ElapsedMilliseconds}ms");

return;

static void FillArray(int[] array) // O(n) - Linear
{
    for (var i = 0; i < array.Length; i++)
    {
        array[i] = i;
    }
}

static int BinarySearch(int[] array, int target) // O(log n) - Logarítmica
{
    var left = 0;
    int right = array.Length - 1;
    var count = 0;

    while (left <= right)
    {
        count++;
        // // Chance de overflow
        // int middle = (left + right) / 2;

        // Evita overflow
        int middle = left + (right - left) / 2;

        if (array[middle] == target)
        {
            Console.WriteLine($"Iterações: {count}");
            return middle;
        }

        if (array[middle] < target)
        {
            left = middle + 1;
            continue;
        }
        
        right = middle - 1;
    }
    
    Console.WriteLine($"Iterações: {count}");
    return -1;
}