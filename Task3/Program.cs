// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear();
Console.WriteLine("Введите цифру, обозначающую день недели: ");
int DayNumber = Convert.ToInt32(Console.ReadLine());
string DayNumberString = Convert.ToString(DayNumber);
if (DayNumber > 7 || DayNumber < 1)
{
    Console.WriteLine("Вы ввели значение, не подходящее под день недели");
}
else if (DayNumber == 6 || DayNumber == 7)
{
    Console.WriteLine("Этот день является выходным");
}
else
{
    Console.WriteLine("Этот день не является выходным");
}