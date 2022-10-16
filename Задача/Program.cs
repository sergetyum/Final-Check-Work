// Задача. 
// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


// 1. Приглашение пользователю ввести символы массива.
Console.Write("Введите элементы массива через пробел (используйте буквы, цифры, знаки): ");

// 2. Считываем строку из терминала и получаем из этой строки строчный массив array.
string[] array = Console.ReadLine().Split(" ");

// 3. С помощью метода PrintArray формируем формат вывода массива в терминал.
void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"\"{array[i]}\", ");
    }
    Console.Write($"\"{array[array.Length - 1]}\"");
    Console.Write("]");
}

// 4. Определяем количество элементов исходного массива с количеством символов меньшим, либо равным 3.
int NumberOfItemsLessThanOrEqualToZero(string[] array)
{
    int numberOfElements = 0;
    foreach (string item in array)
    {
        if (item.Length <= 3) numberOfElements++;
    }
   return numberOfElements;
}

// Формируем массив из элементов исходного массива с количеством символов меньше, либо равным 3.
//void CreateANewArray(string[] array)
//{
int lengthNew = NumberOfItemsLessThanOrEqualToZero(array);
string[] arrayNew = new string[lengthNew];
int i = 0;
foreach (string item in array)
{
    if (item.Length <= 3) 
    {
        arrayNew[i] = item; 
        i++;
    }
}
//}

PrintArray(array);
Console.Write("->");
//NumberOfItemsLessThanOrEqualToZero(array);
//CreateANewArray(array);
PrintArray(arrayNew);