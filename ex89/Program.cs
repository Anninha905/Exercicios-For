int somaPositivos = 0;
int qtdNegativos = 0;
int numero;

for (int i = 1; i <= 6; i++)
{
    Console.Write($"Digite o {i}º número: ");
    numero = int.Parse(Console.ReadLine());

    if (numero > 0)
    {
        somaPositivos += numero;
    }
    else if (numero < 0)
    {
        qtdNegativos++;
    }
}

Console.WriteLine();
Console.WriteLine("Soma dos números positivos: " + somaPositivos);
Console.WriteLine("Quantidade de números negativos: " + qtdNegativos);

//finalizado