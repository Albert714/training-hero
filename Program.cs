using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Для доступа в зал, необходимо ввести пароль ");
        int passwordTrue = 123;
        int passwordAttempt = 3;
        bool accessGranted = false;

        // Авторизация
        while (passwordAttempt > 0)
        {
            Console.Write("Введите пароль: ");
            int password = Convert.ToInt32(Console.ReadLine());

            if (password == passwordTrue)
            {
                Console.WriteLine("Доступ разрешён :)");
                accessGranted = true;
                break;
            }
            else
            {
                passwordAttempt--;
                if (passwordAttempt > 0)
                {
                    Console.WriteLine($"Попробуй еще раз. У тебя осталось {passwordAttempt} попыток...");
                }
                else
                {
                    Console.WriteLine("Ты заблокирован :(");
                }
            }
        }

        // Меню доступно только при успешной авторизации
        if (accessGranted)
        {
            int selection;
            do
            {
                Console.WriteLine("Добро пожаловать в пространство прокачки! Выберите то, что желаете прокачать: ");
                Console.WriteLine("1 - Качаем выносливость");
                Console.WriteLine("2 - Качаем силу");
                Console.WriteLine("3 - Буду качать мозги");
                Console.WriteLine("0 - Выход");

                selection = Convert.ToInt32(Console.ReadLine());
                int numberSelection;

                switch (selection)
                {
                    case 1:
                        Console.WriteLine("Вы выбрали выносливость");
                        Console.Write("Сколько приседаний сделаешь? ");
                        int squats = Convert.ToInt32(Console.ReadLine());

                        for (int squatCount = 1; squatCount <= squats; squatCount++)
                        {
                            Console.WriteLine($"Приседание {squatCount} — сила в ногах растёт!");
                        }
                        Console.WriteLine("Приседания завершены. Молодец!\n");
                        break;

                    case 2:
                        Console.WriteLine("Вы выбрали силу");
                        Console.Write("Сколько отжиманий сделаешь? ");
                        int pushUps = Convert.ToInt32(Console.ReadLine());

                        int pushCount = 1;
                        while (pushCount <= pushUps)
                        {
                            Console.WriteLine($"Отжимание {pushCount} — мощь растёт!");
                            pushCount++;
                        }
                        Console.WriteLine("Отжимания завершены. Красава!\n");
                        break;

                    case 3:
                        Console.WriteLine("Вы выбрали ум");

                        do
                        {
                            Console.WriteLine("Выберите действие:");
                            Console.WriteLine("1. Таблица умножения на 2");
                            Console.WriteLine("2. Таблица умножения на 3");
                            Console.WriteLine("3. Я выхожу");
                            Console.Write("Введите ваш выбор: ");
                            numberSelection = Convert.ToInt32(Console.ReadLine());

                            if (numberSelection == 1)
                            {
                                Console.WriteLine("Таблица умножения на 2:");
                                for (int i = 1; i <= 10; i++)
                                {
                                    Console.WriteLine($"2 * {i} = {2 * i}");
                                }
                            }
                            else if (numberSelection == 2)
                            {
                                Console.WriteLine("Таблица умножения на 3:");
                                for (int i = 1; i <= 10; i++)
                                {
                                    Console.WriteLine($"3 * {i} = {3 * i}");
                                }
                            }
                        } while (numberSelection != 3);
                        break;

                    case 0:
                        Console.WriteLine("До встречи, герой!");
                        break;

                    default:
                        Console.WriteLine("Такого варианта ведь нет... Попробуй снова!");
                        break;
                }

            } while (selection != 0);
        }
    }
}




