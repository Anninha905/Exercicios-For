int numero;

Console.Write("Digite um número qualquer: ");
numero = int.Parse(Console.ReadLine());

for (int i = 1; i <= 13; i++)
{
    Console.WriteLine($"{numero} x {i} = {numero * i}");
}

//finalizado