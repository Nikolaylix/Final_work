System.Console.Write("Enter string: ");
string? str = Console.ReadLine();

// Делим введённые данные на массив строк.
char[] delimeters = { ' ', ',', '.' };
string[]? strArray = str?.Split(delimeters, StringSplitOptions.RemoveEmptyEntries);

// Выводим массив и сразу считаем количество искомых элементов.
int count = 0;
for (int i = 0; i < strArray?.Length; i++)
{
    if (strArray[i].Length <= 3)
        count++;
    System.Console.WriteLine($"strArray[{i}] = " + strArray[i]);
}
System.Console.WriteLine();

// Описываем новый массив и заводим счетчик для второго массива.
string[] newArray = new string[count];
int k = 0;
for (int i = 0; i < strArray?.Length; i++)
{
    if (strArray[i].Length <= 3)
    {
        newArray[k] = strArray[i];
        k++;
    }
}

// Выводим новый массив.
if (k != 0)
{
    for (int i = 0; i < newArray.Length; i++)
    {
        System.Console.Write($"[{newArray[i]}]" + " ");
    }
}
else System.Console.WriteLine("No elements");