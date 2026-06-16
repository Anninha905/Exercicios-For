int idade, TotalIdade;
double altura, TotalAltura;
int somaIdades = 0;
int qtdBaixos = 0;
double somaAlturas = 0;
int qtdMais20 = 0;

for (int i = 1; i <= 45; i++)
{
    Console.Write("Digite a Idade do aluno(a): ");
    idade = int.Parse(Console.ReadLine());
    Console.Write("Digite a Altura do aluno(a): ");
    altura = double.Parse(Console.ReadLine());

    if (altura < 1.70)
    {
        somaIdades += idade;
        qtdBaixos++;
    }
    if (idade > 20)
    {
        somaAlturas += altura;
        qtdMais20++;
    }
}

TotalAltura = (double)somaIdades / qtdBaixos;
TotalIdade = (int)somaAlturas / qtdMais20;
if (qtdBaixos > 0)
{
    Console.WriteLine($"A Idade média menor que 1,70 é igual a {TotalAltura} ");
}
if (qtdMais20 > 0)
{
    Console.WriteLine($"A Altura média maior que 20 anos é igual a {TotalIdade} ");
}

//finalizado