// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символам. Первоночальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться
// колекциями, лучше обойтись исключительно массивами.

string[] MainArray (int size)
{
    string[] mainarray = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i+1} строку: ");
        mainarray[i] = Console.ReadLine();
    }
    return mainarray;
}
void ShowArray(string[] array)//показать массив
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] mainarray = MainArray(size);

ShowArray (mainarray);