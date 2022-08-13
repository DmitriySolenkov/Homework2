Console.WriteLine("Веедите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 99 && num < 1000)
{
    int num1 = (num % 100) /10;
    Console.WriteLine("Вторая цифра числа: "+ num1);
}
else
{
    if (num > -1000 && num < -99)
    {
        int num1 = (-num % 100) /10;
    Console.WriteLine("Вторая цифра числа: "+ num1);
    }
    else Console.WriteLine("Число не трехзначное!");
}