using System;

class Answer
{

    static void PrintResult(string[] array)
    {
        foreach (string line in array)
        {
            Console.WriteLine(line);
        }
    }

    public static void Main(string[] args)
    {
        string[] array;

        // Возвращаем массив с длиной элементов <= 3
        // Добавил массив с байтами indexer, в котором фиксирую индексы значений исходного массива, подходящие под условие задачи. Прошу дать комментарии(даёт ли это прирост в производительности?)
        string[] ShrinkToThree(string[] array)
        {
            int count = 0;
            byte[] indexer = new byte[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length <= 3)
                {
                    count++;
                    indexer[i] = 1;
                }
            }
            int pos = 0;
            string[] result = new string[count];
            for (int i = 0; i < array.Length; i++)
            {
                if (indexer[i] == 1)
                {
                    result[pos] = array[i];
                    pos++;
                }
            }
            return result;
        }


        if (args.Length >= 1)
        {
            // Объединяем все аргументы командной строки в одну строку
            string joinedArgs = string.Join(" ", args);

            // Разделяем строку по запятой с пробелом
            array = joinedArgs.Split(" ")
                                          .ToArray();

        }
        else
        {
            // Если аргументов на входе нет
            array = new string[] { "Hello", "2", "world", ":-)", "1234", "1567", "-2", "computer science", "Russia", "Denmark", "Kazan" }; // Создание массива
        }
        PrintResult(ShrinkToThree(array));
    }
}