// Задача. 
// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []


// 1. Создаем метод FillArray для считывания данных пользователя, объявления и инициализации исходного массива arr.
string[] FillArray()
{
    Console.WriteLine("Задайте размерность массива:");
    int length = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите через Enter элементы массива различной длины (используйте буквы, цифры, знаки):");
    string[] arr = new string[length];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Console.ReadLine();
    }
    return arr;
}

// 2. Создаем метод PrintArray для формирования формата вывода массива в терминал.
void PrintArray(string[] array)
{
    if (array.Length == 0) Console.WriteLine("[]");
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"\"{array[i]}\", ");
    }
    Console.Write($"\"{array[array.Length - 1]}\"");
    Console.Write("]");
}

// 3. Создаем функцию NumberOfItemsLessThanOrEqualToZero для определения количества элементов в массиве с количеством символов меньшим, либо равным 3.
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

// 5. Вызываем методы для сборки кода, выводим результат в терминал.
string[] arr = FillArray();
PrintArray(arr);
Console.Write(" -> ");
string[] arrNew = CreateANewArray(arr);
PrintArray(arrNew);