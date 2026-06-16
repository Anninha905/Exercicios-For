Console.Write("Quantidade de funcionários: ");
int qtd = int.Parse(Console.ReadLine());

double soma = 0;
double maior = 0;
double menor = 0;

for (int i = 1; i <= qtd; i++)
{
    Console.Write("Nome: ");
    string nome = Console.ReadLine();

    Console.Write("Salário: ");
    double salario = double.Parse(Console.ReadLine());

    soma += salario;

    if (salario > maior)
        maior = salario;

    if (salario < menor)
        menor = salario;
}

Console.WriteLine("Média: " + soma / qtd);
Console.WriteLine("Maior salário: " + maior);
Console.WriteLine("Menor salário: " + menor);