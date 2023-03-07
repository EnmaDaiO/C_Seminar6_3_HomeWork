// Задача 41: Пользователь вводит с клавиатуры М чисел(Количество чисел пользователь задает сам). Посчитайте, сколько чисел 
// больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

int[] CreatArraySettinSize(int size)
{ 
    int[] result = new int[size];
    int count = 1;
    for (int i = 0; i < size; i++)
    {
        System.Console.WriteLine($"Вводите {count} число");
        count++;
        result[i] = Convert.ToInt32(Console.ReadLine());
    }
    return result;
}
System.Console.WriteLine("Введите количество чисел: ");
int[] array = CreatArraySettinSize(Convert.ToInt32(Console.ReadLine()));
int countNumbPlus = 0;
for(int i = 0; i< array.Length; i ++)
{
    if(array[i]>0)
    {
        countNumbPlus++;
    }
    
}
System.Console.WriteLine($"Количество положительных числе введенных пользоваетелем: {countNumbPlus}");