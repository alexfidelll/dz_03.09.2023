// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

string[] AddArray()
{
    Console.WriteLine("Введите числа через запятую !!!");
    string numberUser = Console.ReadLine();
    
    string[] split = numberUser.Split(',', ' ');

    return split;
}

void convertToInt(string[] array)
{
    int[] newArray = new int[array.Length];

    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        newArray[i] = Convert.ToInt32(array[i]);
        if (newArray[i] > 0)
        {
            count++;
        }
    }
    System.Console.WriteLine(string.Join(" ", newArray));
    System.Console.WriteLine(count);
}

string[] numberUser = AddArray();
convertToInt(numberUser);

