Console.WriteLine("Введите числовое значение размерности массива : ");
int Length = Math.Abs(int.Parse(Console.ReadLine()));

string[] NewArray = new string[Length];
int count = 0;

for (int i = 0; i < NewArray.Length; i++)
{
    if (i < NewArray.Length)
    {
        Console.WriteLine($"Введите {i} элемент массива: ");
        NewArray[i] = Console.ReadLine();
        if (NewArray[i].Length <= 3)
        {
            count++;
        }
    }
}

Console.WriteLine();
Console.WriteLine("Введенный массив:" + "[" + String.Join(";", NewArray) + "]");

string[] FinalArray = new string[count];

int temp = 0;

for (int i = 0; i < NewArray.Length; i++)
{
    if (NewArray[i].Length <= 3)
    {
        FinalArray[temp] = NewArray[i];
        temp++;
    }
}

Console.WriteLine();
Console.WriteLine("Финальный массив:" + "[" + String.Join(";", FinalArray) + "]");
