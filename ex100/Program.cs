int soma = 0;
int maior = int.Parse(Console.ReadLine());
int menor = int.Parse(Console.ReadLine());

for (int i = 1; i <= 10; i++)
{
    Console.Write("Digite um número: ");
    int numero = int.Parse(Console.ReadLine());

    soma += numero;

    if (numero > maior)
        maior = numero;

    if (numero < menor)
        menor = numero;
}

Console.WriteLine("Média: " + soma / 10.0);
Console.WriteLine("Maior: " + maior);
Console.WriteLine("Menor: " + menor);