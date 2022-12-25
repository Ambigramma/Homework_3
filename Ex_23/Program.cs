// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.

static void Cub(int n)
{
    int count = 1;

    while(count <= n)
    {
        Console.WriteLine(Math.Pow(count, 3));
        count++;
    }
    
}

int n = int.Parse(Console.ReadLine());
Cub(n);