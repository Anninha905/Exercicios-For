for (int i = 1; i <= 10; i++)
{
    int A, B, modulo;

    Console.Write("Digie um valor para A: ");
    A = int.Parse(Console.ReadLine());

    Console.Write("Digie um valor para B: ");
    B = int.Parse(Console.ReadLine());

    modulo = A % B;

    Console.WriteLine("Resto = " + modulo);
}

//finalizado