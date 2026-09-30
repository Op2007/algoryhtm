        Console.WriteLine("Выберите действие:");
        Console.WriteLine("1 - Зашифровать слово");
        Console.WriteLine("2 - Расшифровать слово");

        int mode = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите слово: ");
        string inputWord = Console.ReadLine();

        Console.Write("Введите число (на сколько букв сдвигать): ");
        int key = Convert.ToInt32(Console.ReadLine());

        char[] result = inputWord.ToCharArray();
        
        for (int i = 0; i < result.Length; i++)
        {
            char currentLetter = result[i];

            if (currentLetter >= 'а' && currentLetter <= 'я')
            {
                switch (mode)
                {
                    case 1:
                        currentLetter = (char)('а' + (currentLetter - 'а' + key) % 32);
                        break;

                    case 2:
                        currentLetter = (char)('а' + (currentLetter - 'а' - key + 32) % 32);
                        break;
                }
                result[i] = currentLetter;
            }
        }
        Console.Write("Результат: ");
        foreach (char letter in result)
        {
            Console.Write(letter);
        }
