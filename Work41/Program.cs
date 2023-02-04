// Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.Clear();

Console.WriteLine ("Введите n чисел:");
string numbers = Console.ReadLine()!;

string [] num = new string [numbers.Length];
int n = 0;
for (int i = 0; i < num.Length; i++)
{
    if (numbers[i] == ',' || numbers[i] == ' ' || numbers[i] == '.')
    {
        n++;
    }
    else
    {
        num[n] = num[n]+$"{numbers[i]}";
    }
}
n++;

int [] result = new int[n];
PrintArray (result, num);
int count = 0;
for (int i = 0; i < n; i++)
{
    if (result[i]>0)
    {
        count++;
    }
}
Console.WriteLine ($"Количество чисел больше 0: {count}");

void PrintArray (int [] myArray, string [] volue)
{
    for (int i = 0; i < myArray.Length; i++)
    {
        myArray[i] = Convert.ToInt32(volue[i]);
    }
    Console.WriteLine();
}