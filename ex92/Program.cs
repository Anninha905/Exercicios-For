int N;
double A = 1;

Console.Write("Digite o valor de N: ");
N = int.Parse(Console.ReadLine());

for (int i = 2; i <= N; i++)
{
    if (i % 2 == 0)
    {
        A += 1.0 / i;
    }
    else
    {
        A -= 1.0 / i;
    }
}

Console.WriteLine("Valor de A = " + A);

//finalizado