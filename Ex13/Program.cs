Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
while (num>999 || num<-999)
{num=num/10;}
if (num > 99)
{
    int num3 = (num % 10);
    Console.WriteLine("Третья цифра числа: "+ num3);
}
else 
{
    if (num <-99)
    {
    int num3 = (-num % 10);
    Console.WriteLine("Третья цифра числа: "+ num3);
    }
    else Console.WriteLine("Третьей цифры нет!");
}