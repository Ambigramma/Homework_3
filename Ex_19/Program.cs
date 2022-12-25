// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.

static void Palindrom(){
    Console.WriteLine("Введите пятизначное число ");
string num = Console.ReadLine();
while (num.Length == 5)
{
    if (num[0] == num[4] && num[1] == num[3])
    {
        Console.WriteLine("Является палиндромом.");
        break;
    }
    else
    {
        Console.WriteLine("Нет, не является.");
        break;
    }
}
}

