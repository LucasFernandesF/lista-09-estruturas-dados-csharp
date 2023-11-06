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