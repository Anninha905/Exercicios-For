Console.Write("Massa inicial: ");
double massa = double.Parse(Console.ReadLine());

int tempo = 0;

for (; massa >= 0.05; tempo += 50)
{
    massa /= 2;
}

Console.WriteLine("Tempo: " + tempo + " segundos");
Console.WriteLine("Massa final: " + massa);