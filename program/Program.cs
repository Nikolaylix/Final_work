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

