// Complexidade O(n): o tempo de execução cresce linearmente com o tamanho da entrada, ocorrendo quando cada elemento
// precisa ser processado exatamente uma vez.
// Exemplo clássico: iteração em arrays, listas ou coleções de tamanho variável.

int[] array = [1, 2, 3, 4, 5];

foreach (int element in array) // O(n) - Linear
{
    Console.Write($"{element} ");
}

int[] numbers = [10, 20, 30, 40, 50];
var sum = 0;

foreach (int number in numbers) // O(n) - Linear
{
    sum += number;
}

Console.WriteLine($"{Environment.NewLine}Soma: {sum}");