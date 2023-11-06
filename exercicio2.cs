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