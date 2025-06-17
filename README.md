# BigO

Este repositório contém exemplos de algoritmos que demonstram diferentes complexidades do Big O Notation.

## Pré-requisitos

Escolha uma das seguintes opções para executar o projeto:

- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- [Docker](https://www.docker.com/)

## Como Executar

Você pode executar o projeto de duas formas:

1. **Com Docker** (recomendado para evitar configurações locais)
2. **Localmente com .NET SDK** (caso já tenha o ambiente .NET configurado)

### Clone o Projeto

Clone este repositório em sua máquina local:

```bash
git clone https://github.com/kauatwn/BigO.git
```

### Executar com Docker

1. Navegue até a pasta raiz do projeto:

    ```bash
    cd BigO/
    ```

2. Construa a imagem Docker:

    ```bash
    docker compose build
    ```

3. Execute o container desejado (veja a tabela abaixo):

    ```bash
    docker compose run --rm <complexity>
    ```

### Complexidades disponíveis:

| Docker `<complexity>` | Projeto `<project>` |
| --------------------- | ------------------- |
| `constant`            | `Constant`          |
| `exponential`         | `Exponential`       |
| `factorial`           | `Factorial`         |
| `linear`              | `Linear`            |
| `loglinear`           | `LogLinear`         |
| `logarithmic`         | `Logarithmic`       |
| `quadratic`           | `Quadratic`         |

### Executar Localmente com .NET SDK

1. Navegue até o diretório do projeto correspondente (veja a tabela abaixo):

    ```bash
    cd src/<project>/
    ```

2. Restaure as dependências do projeto:

    ```bash
    dotnet restore
    ```

3. Inicie a aplicação:

    ```bash
    dotnet run
    ```

## Estrutura do Projeto

O repositório está organizado da seguinte forma:

```plaintext
BigO/
└── src/
    ├── Constant
    ├── Exponential
    ├── Factorial
    ├── Linear
    ├── LogLinear
    ├── Logarithmic
    └── Quadratic
```

## Descrições das Complexidades

| Complexidade | Notação Big O | Descrição                                                         |
| ------------ | ------------- | ----------------------------------------------------------------- |
| Constante    | O(1)          | O tempo de execução não depende do tamanho da entrada.            |
| Logarítmica  | O(log n)      | O tempo cresce logaritmicamente em relação ao tamanho da entrada. |
| Linear       | O(n)          | O tempo cresce proporcionalmente ao tamanho da entrada.           |
| Log-Linear   | O(n log n)    | Combina crescimento linear e logarítmico.                         |
| Quadrática   | O(n²)         | O tempo cresce ao quadrado do tamanho da entrada.                 |
| Exponencial  | O(2ⁿ)         | O tempo dobra a cada novo elemento de entrada.                    |
| Fatorial     | O(n!)         | O tempo cresce fatorialmente com o tamanho da entrada.            |
