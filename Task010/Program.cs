Console.Write("Введите число  ");
string number = Console.ReadLine();

char[] array = new Char[number.Length];
int index = 0;
while (index < number.Length)
{
    array[index] = number[index];
    index++;
}
foreach  (char num in array)                                                   
Console.Write(num + "; ");
Console.WriteLine();

Console.Write(array[1]);


