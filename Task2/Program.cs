// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Clear();
Console.WriteLine("Введите число: ");
int AnyNumber = Convert.ToInt32(Console.ReadLine());
string AnyNumberString = Convert.ToString(AnyNumber);
if (AnyNumber > 99)
{
    Console.WriteLine("третья цифра этого числа -> "+AnyNumberString[2]);
}
else
{
    Console.WriteLine("В данном числе нет третьей цифры");
}