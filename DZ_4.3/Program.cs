// Задача 29: Пользователь вводит 8 чисел. Поместите их в массив и распечатайте.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine();
int[] Array = new int[8];
Console.WriteLine("Введите 8 чисел (на отдельной строке): ");
for (int i = 0; i < 8; i++)
    {
        Array[i] = int.Parse(Console.ReadLine());
    }
Console.WriteLine();
Console.WriteLine("Массив: ");
    for (int j = 0; j < 8; j++)
    {
       Console.Write(Array[j] + " ");
    }
        