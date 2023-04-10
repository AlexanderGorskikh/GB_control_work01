// Создаем исходный массив
string [] array = new string[10];

void FillArrayWithConsole ()
{
    for(int i=0;i<array.Length;i++)
    {
        System.Console.Write($"Введите {i+1} строку:"); 
        array[i] = Console.ReadLine();
    }
}

void PrintArray (string [] array)
{
    for(int i=0;i<array.Length;i++)
    {  
        Console.Write(array[i]+" | ");
    }
}

FillArrayWithConsole();
PrintArray (array);

