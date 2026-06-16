int a = 0;
int b = 1;
int c;

for (int i = 3; i <= 20; i++)
{
    c = a + b;

    Console.Write(c + ", ");

    a = b;
    b = c;
}

//finalizado