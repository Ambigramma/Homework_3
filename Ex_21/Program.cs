// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

static void Space()
{
    double a1 = double.Parse(Console.ReadLine());
    double a2 = double.Parse(Console.ReadLine());
    double a3 = double.Parse(Console.ReadLine());
    double b1 = double.Parse(Console.ReadLine());
    double b2 = double.Parse(Console.ReadLine());
    double b3 = double.Parse(Console.ReadLine());
    
    double ab = Math.Round(Math.Sqrt((Math.Pow(a1-b1, 2))+(Math.Pow(a2-b2, 2))+(Math.Pow(a3-b3, 2))), 2);
    
    Console.WriteLine(ab);
}

Space();


