
    static void Main()
    {
        Random random = new Random();

        while (true)
        {
            int secretNumber = random.Next(1, 101); 
            int attempts = 0; 
            bool isGuessed = false; 

            Console.WriteLine("Я загадал число от 1 до 100. Попробуйте угадать!");

            while (!isGuessed)
            {
                Console.Write("Введите ваше число: ");
                string input = Console.ReadLine();
                int userNumber;

                if (!int.TryParse(input, out userNumber))
                {
                    Console.WriteLine("Ошибка: Введите целое число.");
                    continue;
                }

                if (userNumber < 1 || userNumber > 100)
                {
                    Console.WriteLine("Ошибка: Число должно быть в диапазоне от 1 до 100.");
                    continue; 
                }

                attempts++;

                if (userNumber == secretNumber)
                {
                    isGuessed = true;
                    Console.WriteLine($"Поздравляю! Вы угадали число {secretNumber} за {attempts} попыток.");
                }
                else if (userNumber < secretNumber)
                {
                    Console.WriteLine("Больше!");
                }
                else
                {
                    Console.WriteLine("Меньше!");
                }
            }

            Console.Write("Сыграть еще раз? (yes / no): ");
            string playAgain = Console.ReadLine();

            playAgain = playAgain.ToLower();

            switch (playAgain)
            {
                case "yes":
                    Console.WriteLine("Загадано новое число!");
                    Console.WriteLine(); 
                    break;
                case "no":
                    Console.WriteLine("Спасибо за игру! До свидания.");
                    return; 
                default:
                    Console.WriteLine("Неизвестный ответ. Игра завершена.");
                    return;
            }
        }
    }
Main();