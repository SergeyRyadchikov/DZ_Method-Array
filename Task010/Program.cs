Console.Write("Введите число  ");
string number = Console.ReadLine();

char[] num = new Char[number.Length];
int index = 0;
while (index < number.Length)
{
    num[index] = number[index];
    index++;
}
foreach  (char b in num)                                                   
Console.Write(b + "; ");
Console.WriteLine();

Console.Write(num[1]);


