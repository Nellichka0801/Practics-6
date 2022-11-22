// Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите длину массива ");
int length = int.Parse(Console.ReadLine()!);// длина массива

int[] CreativeArrayFromInput(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
     {
        Console.WriteLine("Введите число массива и нажмите клавишу enter");
        int numbers = int.Parse(Console.ReadLine()!);
        array[i] = numbers;
     }

     return array;
} 

void Print(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i != array.Length - 1)
        Console.Write(", ");
    }

Console.WriteLine();
}
        
int CounterOfPositiveDigits (int[] array)
{
    int result=0;
    for (int i = 0; i < length; i++)
    {
        if (array[i] > 0) result ++;
    }
    return result;
}

var array = CreativeArrayFromInput(length);
Print(array);
var count = CounterOfPositiveDigits (array);
Console.WriteLine("Количество, введенных чисел больше нуля: " + count);
System.Console.WriteLine();
    