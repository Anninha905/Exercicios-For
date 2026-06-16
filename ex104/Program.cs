Console.Write("Primeiro número: ");
int n1 = int.Parse(Console.ReadLine());

Console.Write("Segundo número: ");
int n2 = int.Parse(Console.ReadLine());

int resultado = 0;

for (int i = 1; i <= n2; i++)
{
    resultado += n1;
}

Console.WriteLine("Resultado = " + resultado);