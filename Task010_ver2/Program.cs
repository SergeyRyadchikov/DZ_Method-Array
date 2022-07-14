Console.Write("Введите число  ");
string number = Console.ReadLine();

int lenght = number.Length;
char[] num = new Char[lenght];
num = number.ToCharArray(0, lenght);
Console.WriteLine(num);
Console.Write("Вторая цифра - " + num[1]);