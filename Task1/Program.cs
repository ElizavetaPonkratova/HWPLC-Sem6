/*Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

Console.WriteLine("Введите количество чисел: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] Arr = new int[num];
int count = 1;

for (int i = 0; i < Arr.Length; i++)
{
    Console.Write($"Введите число {count}: ");
    Arr[i] = Convert.ToInt32(Console.ReadLine());
    count++;
}

Console.WriteLine("Числа, которые Вы ввели: ");

for (int i = 0; i < Arr.Length; i++)
{
    Console.Write(Arr[i] + " ");
}

int sum = 0;
for (int i = 0; i < Arr.Length; i++)
{
    if (Arr[i] > 0)
    {
        sum++;
    }
}
Console.WriteLine();
Console.WriteLine($"Количество значений больше 0 => {sum}");
