int[] array = [1, 2, 3, 4, 5];

Console.WriteLine($"O(1): {array[0]}"); // O(1)

// É O(1) quando:

// Não tem laços de repetição.
// Acessos direto a elementos.
// Operações mateḿaticas simples.
// Uso de estruturas de dados eficientes (métodos de busca, inserção, remoção são geralmente O(1)).

var ages = new Dictionary<string, int>
{
    { "Alice", 25 },
    { "Bob", 30 },
    { "Josh", 35 }
};

// Adicionando um novo elemento com atribuição direta
ages["Diana"] = 28; // O(1)
Console.WriteLine($"Idade da Diana: {ages["Diana"]}");

// Adicionando um novo elemento com método Add()
ages.Add("Charlie", 40); // O(1)
Console.WriteLine($"Idade do Charlie: {ages["Charlie"]}");

// Removendo um elemento
ages.Remove("Bob"); // O(1)
Console.WriteLine("Bob foi removido do dicionário.");

// Verificando se um elemento existe
if (ages.ContainsKey("Alice")) // O(1)
{
    Console.WriteLine("Alice está no dicionário.");
}

// O(1) é a complexidade de tempo mais eficiente que existe. Significa que o algoritmo é constante, independentemente
// do tamanho da entrada.