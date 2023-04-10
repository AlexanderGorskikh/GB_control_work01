// Создаем исходный массив
string [] FillArrayWithConsole()
{
    int size;
    while(true)
    {
    System.Console.WriteLine("Введите размер массива: ");
    size = Int32.Parse(Console.ReadLine());
    if (size>0) break;
    System.Console.WriteLine("Ошибка: размер массива не может быть отрицательным");
    }
    string [] array = new string[size];
    for(int i=0;i<array.Length;i++)
    {
        System.Console.Write($"Введите {i+1} строку:"); 
        array[i] = Console.ReadLine();
    }
    return array;
}

void PrintArray (string [] array,string text)
{
    System.Console.Write(text);
    for(int i=0;i<array.Length;i++)
    {  
        Console.Write(array[i]+" | ");
    }
    System.Console.WriteLine();
}

string [] FindThreeSumbolString (string [] array)
{
    string [] tmpArray = new string [array.Length];
    int current =0;
    for(int i =0;i<array.Length;i++)
    {
        if (array[i].Length<=3)
        {
        tmpArray[current] = array[i];
        current++;
        }
    }
    Array.Resize(ref tmpArray,current);
    return tmpArray;
}

string [] array = FillArrayWithConsole();
PrintArray (array,$"Искомый массив(Размера {array.Length}): ");
string [] newArray = FindThreeSumbolString (array);
PrintArray (newArray,$"Результирующий масссив(Размера {newArray.Length}): ");