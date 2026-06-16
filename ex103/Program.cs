double massa;
int tempo = 0;

Console.Write("Digite o valor da Massa inicial: ");
massa = double.Parse(Console.ReadLine());

for (; massa >= 0.05; tempo += 50)
{
    massa /= 2;
}
Console.WriteLine($"O Tempo necessário foi de: {tempo} segundos");
Console.WriteLine($"A Massa final será de: {massa}");

//finalizado