double totalHotel = 0;

for (int i = 1; i <= 30; i++)
{
    Console.Write("Nome: ");
    string nome = Console.ReadLine();

    Console.Write("Diárias: ");
    int diarias = int.Parse(Console.ReadLine());

    double taxa;

    if (diarias < 15)
        taxa = 4;
    else if (diarias == 15)
        taxa = 3.60;
    else
        taxa = 3;

    double total = diarias * (50 + taxa);

    Console.WriteLine("Conta: R$ " + total);

    totalHotel += total;
}

Console.WriteLine("Total do hotel: R$ " + totalHotel);