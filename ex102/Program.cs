string nome;
int diarias;
double totalHotel = 0;
double taxa;

for (int i = 1; i <= 30; i++)
{
    Console.Write("Digite o Nome do cliente: ");
    nome = Console.ReadLine();
    Console.Write("Digite a quantidade de Diárias: ");
    diarias = int.Parse(Console.ReadLine());

    if (diarias < 15)
        taxa = 4;
    else if (diarias == 15)
        taxa = 3.60;
    else
        taxa = 3;

    double total = diarias * (50 + taxa);

    Console.WriteLine($"O valor total da diária será de: R$ {total}");

    totalHotel += total;
}

Console.WriteLine($"O valor total do hotel será de: R$ {totalHotel}");

//finalizado