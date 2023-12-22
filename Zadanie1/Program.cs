// Задайте одномерный массив, заполненный случайными числами.Определите кол-во простых чисел в массиве.

int [] list = new int [10]; // Задаем массив

void FillArray(int[] collection) //Заполнениие массива
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(1, 100);
        index ++;
    }
}
FillArray(list);
// вывод массива
void PrintArray(int[] col) //метод, который ничего не возвращает
{
int ccount = col.Length; //Обозначение колличества эллементов
int position = 0; //обозначение текущей позиции
while (position < ccount) // пока позиция меньше, чем колличество эллементов выполняем
{
    Console.WriteLine(col[position]);
    position++;
}
}
PrintArray(list);

bool IsPrime(int num)
{
    for (int i = 2; i < num; i++)
    {
        if (num % i == 0)
        {
            return false;
        }
    }
    return true;
}

int GetCountPrimeNumber(int[] array) //Метод, который возвращает кол-во эллементовс простыми значениями
{
    int count = 0; // присвоение count значение 0
    for (int i = 0; i < array.Length; i++)
    {
       if(IsPrime(array[i]))
       {
        count++;
       } 
    }
    
return count;
}
Console.WriteLine();
Console.WriteLine(GetCountPrimeNumber(list));