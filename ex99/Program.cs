Console.Write("Digite a Quantidade de funcionários: ");
int qtd = int.Parse(Console.ReadLine());

double soma = 0;
double maior = 0;
double menor = 0;

for (int i = 1; i <= qtd; i++)
{
    Console.Write("Digite o Nome do funcionário: ");
    string nome = Console.ReadLine();

    Console.Write("Digite o Salário do funcionário: ");
    double salario = double.Parse(Console.ReadLine());

    soma += salario;

    if (i == 0)
    {
        maior = salario;
        menor = salario;
    } else
    {
        if (salario > maior)
            maior = salario;

        if (salario < menor)
            menor = salario;
    }
}

Console.WriteLine("Média: " + soma / qtd);
Console.WriteLine("Maior salário: " + maior);
Console.WriteLine("Menor salário: " + menor);

//finalizado