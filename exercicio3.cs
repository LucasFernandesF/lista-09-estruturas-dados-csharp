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