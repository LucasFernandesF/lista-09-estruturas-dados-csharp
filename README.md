# lista-09-estruturas-dados-csharp


## 1 - Faça um programa em C# que utilize a Estrutura de Dados HashTables. Ele deverá ler o CPF da pessoa e seu telefone. O programa deverá conseguir ler até 05 CPF e seus respectivos telefones. Imprima esses dados na tela.
```
using System.Collections;

Hashtable cpfPessoa = new Hashtable();
int[] telefones =  new int[5];

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Informe o seu CPF (só com números): ");
    cpfPessoa[i] = Console.ReadLine();

    Console.WriteLine("Informe o seu telefone (com DD e só numeros:)");
    telefones[i] = Convert.ToInt32(Console.ReadLine());
}


for (int i = 0; i < 5; i++)
{
    Console.WriteLine("O cpf é " + cpfPessoa[i]);
    Console.WriteLine("O telefone é "+ telefones[i]);
}


Console.ReadLine();
```
## 2 - Modifique o programa anterior para que ele consiga também pesquisar por cpf's e encontrar seus telefones.

```
using System.Collections;

Hashtable cpfPessoa = new Hashtable();

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Informe o seu CPF (só com números): ");
    string cpf = Console.ReadLine();

    Console.WriteLine("Informe o seu telefone (com DD e só numeros:)");
    string telefones = Console.ReadLine();
    cpfPessoa.Add(cpf, telefones);
}

Console.WriteLine("Você quer fazer uma busca por CPF? (SIM OU NÃO)");
string resposta = Console.ReadLine().ToUpper();
do
{

    if (resposta == "SIM")
    {
        Console.Write("Digite o CPF: ");
        string cpf = Console.ReadLine();

        if (cpfPessoa.ContainsKey(cpf))
        {
            Console.WriteLine("Telefone: {0}", cpfPessoa[cpf]);
        }
        else
        {
            Console.WriteLine("CPF não encontrado.");
        }
        Console.WriteLine("Quer fazer mais alguma busca?");
        resposta = Console.ReadLine().ToUpper();
    }
    else
    {
        return;
    }
} while (resposta == "SIM");

Console.ReadLine();
```
## 3 - Você foi contratado para desenvolver um programa em C# para criar um sistema de carrinho de compras usando HashTables. O programa permite adicionar produtos ao carrinho, visualizar o carrinho, finalizar a compra mostrando o valor total a ser pago e sair. Cada produto é representado pelo seu nome (chave) e preço (valor associado) na HashTable.

``` 
using System.Collections;

Hashtable carrinho = new Hashtable();

bool compra = true;
double totalPreco = 0.0;
string nome;
double preco;

while (compra)
{
    Console.WriteLine("Escolha uma opção abaixo");
    Console.WriteLine("1- Adicionar Produtos. ");
    Console.WriteLine("2- Visualizar Produtos. ");
    Console.WriteLine("3- Finalizar Compra");
    Console.WriteLine("4 Sair");
    int escolha = Convert.ToInt32(Console.ReadLine());

    switch (escolha)
    {
        case 1:
            AdicionarProduto();
            break;
        case 2:
            VisualizarProduto();
            break;
        case 3:
            Console.WriteLine($"Total a ser pago: R${totalPreco}");
            compra = false;
            break;
        case 4:
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Codigo inválido!!");
            break;
    }



}

void AdicionarProduto()
{
    Console.WriteLine("Digite o nome do produto: ");
    nome = Console.ReadLine();

    Console.WriteLine("Digite o preço do produto: ");
    preco = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"'{nome}' adicionado ao carrinho por R${preco}");
    carrinho[nome] = preco;
    
    totalPreco += preco;
}

void VisualizarProduto()
{

    Console.WriteLine("Carrinho de compras:");
    foreach (DictionaryEntry item in carrinho)
    {
        Console.WriteLine($"{item.Key}: R${item.Value}");
    }
    Console.WriteLine($"Total: R${totalPreco}");

}
Console.ReadLine();
```
