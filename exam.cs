        Console.Write("Enter strings with space: ");         // Шаг 1: Запрос у пользователя ввести строки, разделенные пробелами
        string? input = Console.ReadLine();         // Считываем ввод, используя null
        if (input != null)
        {
            string[] originalArray = input.Split(' ');      // Шаг 2: Разбиваем введенную строку на массив строк по пробелам

            string[] resultArray = FilterStrings(originalArray);        // Шаг 3: Применяем фильтрацию к исходному массиву строк

            DisplayResult(resultArray);         // Шаг 4: Выводим результат
        }

    string[] FilterStrings(string[] inputArray)         // Метод для фильтрации строк по длине
    {
        int count = CountStrings(inputArray, str => str.Length <= 3);       // Шаг 1: Подсчитываем количество строк, удовлетворяющих условию

        string[] resultArray = new string[count];       // Шаг 2: Создаем новый массив и заполняем его отфильтрованными строками
        int index = 0;

        foreach (string str in inputArray)       // Шаг 3: Интегрируем по исходному массиву и добавляем строки, которые удовлетворяют условию, в новый массив
        {
            if (str.Length <= 3)
            {
                resultArray[index++] = str;
            }
        }

        return resultArray;
    }

   int CountStrings(string[] inputArray, Func<string, bool> condition)      // Метод для подсчета строк, удовлетворяющих условию
    {
        int count = 0;      // Шаг 1: Инициализируем счетчик

        foreach (string str in inputArray)      // Шаг 2: Интегрируем по массиву строк и увеличиваем счетчик для каждой строки, удовлетворяющей условию
        {
            if (condition(str))
            {
                count++;
            }
        }

        return count;
    }

    void DisplayResult(string[] resultArray)         // Метод для вывода результатов
    {
        Console.WriteLine("Result:");       // Шаг 1: Выводим заголовок результата
        foreach (string? str in resultArray)        // Шаг 2: Интегрируем по массиву строк результата и выводим каждую строку
        {
            Console.WriteLine(str);
        }
    }
