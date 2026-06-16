int soma = 0;
int maior = 0;
int menor = 0;

for (int i = 1; i <= 10; i++)
{
    Console.Write("Digite um número qualquer: ");
    int numero = int.Parse(Console.ReadLine());

    soma += numero;

    if (numero > maior)
        maior = numero;

    if (numero < menor)
        menor = numero;
}

Console.WriteLine("A Média do número é: " + soma / 10.0);
Console.WriteLine("O Maior número é: " + maior);
Console.WriteLine("O Menor número é: " + menor);

//finalizado