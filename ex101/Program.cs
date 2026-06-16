int numero;
int fatorial = 1;

Console.Write("Digite um número: ");
numero = int.Parse(Console.ReadLine());

for (int i = 1; i <= numero; i++)
{
    fatorial *= i;
}

Console.WriteLine($"A fatoração do número {numero} é de: {fatorial}");

//finalizado