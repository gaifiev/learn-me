// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567, "-2", "computer science"] -> [-2]
// ["Russia", "Denmark", "Kazan"] -> []
Console.Clear();
string[] one = { "hello", "2", "world", ":-)", "1234", "1567" };
string[] two = new string[one.Length];
int j = 0;
void LongArray(string[] one, string[] two) //метод для перебора элементов массива
{
    int i = 0;
    while (i < one.Length)
    {
        if (one[i].Length <= 3)
        {
            two[j] = one[i];
            j++;
        }
        i++;
    }
}

void Print(string[] inputArray) // метод для вывода печати
{

    int i = 0; //Буфферная переменная
    Console.Write("[");
    while (i < j - 1) //Пробегаем все элементы массива
    {
        Console.Write(inputArray[i] + ", "); //Выводим элемент массива
        i++; //Увеличиваем инкремент
    }
    Console.Write(inputArray[i] + "");
    Console.Write("]");
}
LongArray(one, two);
Print(two);