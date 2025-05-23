﻿using System.Diagnostics;

// Complexidade O(n log n): combina divisões logarítmicas (log n) com processamento linear (n) em cada nível,
// resultando em tempo de execução proporcional a n multiplicado pelo logaritmo de n.
// Exemplo clássico: algoritmos de ordenação eficientes como Merge Sort, Quick Sort e Heap Sort.

var array = new int[1_000_000];
var tempArray = new int[array.Length];
FillArray(array);

Console.WriteLine($"Iniciando ordenação de um array com {array.Length:N0} elementos");

var stopwatch = Stopwatch.StartNew();
MergeSort(array, 0, array.Length - 1, tempArray);
stopwatch.Stop();

Console.WriteLine($"{Environment.NewLine}Ordenação concluída com sucesso!");
Console.WriteLine($"Tempo total de execução: {stopwatch.ElapsedMilliseconds:N0}ms");

return;

static void FillArray(int[] array)
{
    var random = new Random();
    for (var i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(0, 10_000_000);
    }
}

// Método MergeSort principal (chamada inicial)
static void MergeSort(int[] array, int left, int right, int[] tempArray) // O(n log n) - Log-linear
{
    if (left < right)
    {
        // // Chance de overflow
        // int middle = (left + right) / 2;

        // Evita overflow
        int middle = left + (right - left) / 2;

        // Ordena a primeira metade do array (esquerda)
        MergeSort(array, left, middle, tempArray);

        // Ordena a segunda metade do array (direita)
        MergeSort(array, middle + 1, right, tempArray);

        // Combina as duas metades
        Merge(array, left, middle, right, tempArray);
    }

    return;

    // Método Merge otimizado (usa tempArray compartilhado)
    static void Merge(int[] array, int left, int middle, int right, int[] tempArray)
    {
        // Índice do subarray esquerdo
        int leftIndex = left;

        // Índice do subarray direito
        int rightIndex = middle + 1;

        // Índice do array temporário
        int mergePosition = left;

        // Copia a região a ser mesclada para tempArray
        Array.Copy(array, left, tempArray, left, middle - left + 1);

        // Combina os subarrays em ordem
        while (leftIndex <= middle && rightIndex <= right)
        {
            if (tempArray[leftIndex] <= array[rightIndex])
            {
                array[mergePosition++] = tempArray[leftIndex++];
            }
            else
            {
                array[mergePosition++] = array[rightIndex++];
            }
        }

        // Copia os elementos restantes (se houver)
        while (leftIndex <= middle)
        {
            array[mergePosition++] = tempArray[leftIndex++];
        }
    }
}