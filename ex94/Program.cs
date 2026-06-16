//PARA EXECUTAR O FOR É O ONDE ESTA O "10"

for (int i = 0; i < 10; i++)
{
    int A, B;

    Console.Write("Digie um valor para A: ");
    A = int.Parse(Console.ReadLine());
    Console.Write("Digie um valor para B: ");
    B = int.Parse(Console.ReadLine());

//ESSE "%" É USADO PARA SABER O RESTO DA DIVISÃO

    Console.WriteLine($"Resto da divisão de {A} por {B} é {A % B}");
}

Console.WriteLine("Não executar nenhuma vez");
for (int i = 0; i < 0; i++)
{
    int A, B;

    Console.Write("Digie um valor para A: ");
    A = int.Parse(Console.ReadLine());
    Console.Write("Digie um valor para B: ");
    B = int.Parse(Console.ReadLine());
    Console.WriteLine($"Resto da divisão de {A} por {B} é {A % B}");
}


for (int x = 0; x < 50; x++)
{
    int A, B;
    Console.Write("Digie um valor para A: ");
    A = int.Parse(Console.ReadLine());
    Console.Write("Digie um valor para B: ");
    B = int.Parse(Console.ReadLine());
    Console.WriteLine($"Resto da divisão de {A} por {B} é {A % B}");
    for (int X = 0; X < 50; X++)
    {
        Console.Write("Digie um valor para A: ");
        A = int.Parse(Console.ReadLine());
        Console.Write("Digie um valor para B: ");
        B = int.Parse(Console.ReadLine());
        Console.WriteLine($"Resto da divisão de {A} por {B} é {A % B}");
    }

}

Console.WriteLine("Digite o número de vezes a ser executado: ");
int num = int.Parse(Console.ReadLine());
for (int i = 0; i <= num; i++)
{
    int A, B;
    Console.Write("Digie um valor para A: ");
    A = int.Parse(Console.ReadLine());
    Console.Write("Digie um valor para B: ");
    B = int.Parse(Console.ReadLine());
    Console.WriteLine($"Resto da divisão de {A} por {B} é {A % B}");
}


//finalizado