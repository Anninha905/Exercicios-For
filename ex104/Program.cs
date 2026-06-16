int num1, num2;
int resultado = 0;

Console.Write("Digite o multiplicando: ");
num1 = int.Parse(Console.ReadLine());
Console.Write("Digite o multiplicador: ");
num2 = int.Parse(Console.ReadLine());

for (int i = 1; i <= num2; i++)
{
    resultado += num1;
}

Console.WriteLine($"{num1} x {num2} = {resultado}");

//finalizado