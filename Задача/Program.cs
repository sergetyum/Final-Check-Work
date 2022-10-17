// Задача. 
// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


// 1. Создаем метод FillArray для считывания данных пользователя, объявления и инициализации исходного массива arr.
string[] FillArray()
{
    Console.Write("Введите элементы массива через пробел (используйте буквы, цифры, знаки): ");
    string[] arr = Console.ReadLine().Split(" ");
    return arr;
}

// 2. Создаем метод PrintArray для формирования формата вывода массива в терминал.
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

// 3. Создаем функцию NumberOfItemsLessThanOrEqualToZero для определения количества элементов в исходном массиве с количеством символов меньшим, либо равным 3.
int NumberOfItemsLessThanOrEqualToZero(string[] array)
{
    int numberOfElements = 0;
    foreach (string item in array)
    {
        if (item.Length <= 3) numberOfElements++;
    }
    return numberOfElements;
}

// 4. Создаем метод CreateANewArray, который формирует новый массив arrNew из элементов исходного массива arr с количеством символов меньше, либо равным 3.
string[] CreateANewArray(string[] array)
{
    int lengthNew = NumberOfItemsLessThanOrEqualToZero(array);
    string[] arrNew = new string[lengthNew];
    int i = 0;
    foreach (string item in array)
    {
        if (item.Length <= 3)
        {
            arrNew[i] = item;
            i++;
        }
    }
    return arrNew;
}

// 5. Вызываем методы для вывода результатов в терминал.
string[] arr = FillArray();
PrintArray(arr);
Console.Write("->");
string[] arrNew = CreateANewArray(arr);
PrintArray(arrNew);