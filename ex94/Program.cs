for (int i = 1; i <= 10; i++)
{
    int A, B, modulo;

    Console.Write("A: ");
    A = int.Parse(Console.ReadLine());

    Console.Write("B: ");
    B = int.Parse(Console.ReadLine());

    modulo = A % B;

    Console.WriteLine("Resto = " + modulo);
}