int idade;
double altura;

int somaIdades = 0;
int qtdBaixos = 0;
double somaAlturas = 0;
int qtdMais20 = 0;

for (int i = 1; i <= 45; i++)
{
    Console.Write("Digite a Idade: ");
    idade = int.Parse(Console.ReadLine());
    Console.Write("Digite a Altura: ");
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
if (qtdBaixos > 0)
{
    Console.WriteLine("Idade média (<1,70): " + (double)somaIdades / qtdBaixos);
}

if (qtdMais20 > 0)
{
    Console.WriteLine("Altura média (>20 anos): " + somaAlturas / qtdMais20);
}
