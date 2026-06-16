int a = 0;
int b = 1;

Console.Write(a + " " + b + " ");

for (int i = 3; i <= 20; i++)
{
    int c = a + b;

    Console.Write(c + " ");

    a = b;
    b = c;
}