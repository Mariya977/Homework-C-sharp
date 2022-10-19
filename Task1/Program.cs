
Console.Clear();
Console.WriteLine("Введите трехзначное число: ");
int numbers = Convert.ToInt32(Console.ReadLine());
string stringnumbers = Convert.ToString(numbers);
// int length = stringnumbers.Length;
Console.WriteLine("вторая цифра этого числа -> "+stringnumbers[1]);
// if (stringnumbers.Length > 100 && stringnumbers.Length < 999 )
// {
//     Console.WriteLine("вторая цифра этого числа -> "+stringnumbers[1]);
// }
// else
// {
//     Console.WriteLine("Вы ввели не трехначное число");
// }

// Не получается ограничить программу трехзначным числом, подскажите, как можно это сделать, мой способ закомментированный почему-то не работает...


