Console.WriteLine("Введите день недели: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num>=1 && num <=7)
{
    if (num ==6 || num ==7) Console.WriteLine("Выбранный день недели является выходным");
    else Console.WriteLine("Выбранный день недели является будним");
}
else Console.WriteLine("Вы ввели неверное число");