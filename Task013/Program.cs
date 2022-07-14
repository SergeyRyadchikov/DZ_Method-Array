Console.Write("Введите число  ");
string number = Console.ReadLine();

int lenght = number.Length;
char[] num = new char[lenght];
num = number.ToCharArray(0, lenght);
Console.WriteLine(num);
if (lenght < 3)
{
    Console.Write("Третьей цифры нет");
}
else
{
    Console.Write("Третья цифра - " + num[2]);
}
