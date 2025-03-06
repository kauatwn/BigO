int[] array = [1, 2, 3, 4, 5];

foreach (int element in array) // O(n)
{
    Console.Write($"{element} ");
}

// É O(n) quando:

// Possui laços de repetição.
// A complexidade de tempo é linear, ou seja, cresce proporcionalmente ao tamanho da entrada.
// Exemplo: percorrer um array, lista, dicionário, etc.

int[] numbers = [10, 20, 30, 40, 50];
int sum = 0;

foreach (int number in numbers) // O(n)
{
    sum += number; // O(1)
}

Console.WriteLine($"{Environment.NewLine}Soma: {sum}");

// O(n) é a complexidade de tempo mais comum. Significa que o algoritmo é linear, ou seja, o tempo de execução.