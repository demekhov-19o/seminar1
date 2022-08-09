// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

int i = 0;

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

while (i <= number)
{
    if (i % 2 != 1)
    {
        Console.Write(i + ", ");
    }
    i+=2;
}
