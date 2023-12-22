//Задайте массив из N случайных целых чисел(N вводится пользователем).
//Найдите колличество чисел, которые оканчиваются на один и делятся нацело на 7

int[] FillArray (int num) //Заполнениие массива
{
    int[] numbers = new int [num];
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(1, 100);
    }
    return numbers;
}

void PrintArray(int[] num) //Вывод массива
{
    for (int i = 0; i < num.Length; i++)
    {
        Console.WriteLine(num[i]+ " ");
    }
}

bool IsCheck(int num) //Создание метода для проверки окончания и деления
{
    return ((num % 7 ==0) && (num % 10 == 1));
}

int GetCount(int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (IsCheck(array[i]))
        {
            count++;
        }
    }
    return count;
}

Console.WriteLine("Введите числа массива: ");
int size = Convert.ToInt32(Console.ReadLine()); //Конвертирование и считвание введенных данных

int[] list = FillArray(size);

PrintArray(list);

Console.WriteLine(GetCount(list));