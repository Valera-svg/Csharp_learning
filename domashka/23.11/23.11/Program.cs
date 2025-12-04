using System;
using System.ComponentModel.Design;
using System.Numerics;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static void Main(string[] args)
    {
        // Вызов задач
        /*Task1();
        Task2();      
        Task3();
        Task4();
        Task5();
        Task6();
        Task7();
        Task8();
        Task9();
        Task10();
        Task11();
        Task12();
        Task13();
        Task14();
        Task15();
        Task16();
        Task17();
        Task18();
        Task20();
        Task21();
        Task22();
        Task23();
        Task24();
        Task25();
        Task26();
        Task27();
        Task28();
        Task29();
        Task30();
        Task31();
        Task32();
        Task33();
        Task34();
        Task32();
        Task33();
        Task34();
        Task35();
        Task36();*/
        Task37();
        /*Task39();
        Task40();
        Task41();
        Task42();
        Task43();
        Task44();*/

    }
    // =========================== БЛОК 1. Условия ============================

    // Задача 1
    /* В вашем main классе должны присутствовать 2 int числа(a, b). Необходимо вывести True, если a>b.False, если a<b */

    static void Task1()
    {
        /*int a = 10;
        int b = 2;
        if (a > b)
        {
            Console.WriteLine("True");              // сделать через тернарная операция
        }
        else
        {
            Console.WriteLine("False");
        }*/
        int a = 10;
        int b = 2;

        string z = a > b ? "False" : "True";
        Console.WriteLine(z);

    }

    // Задача 2
    /* Программа при запуске должна генерировать целое число, после этого на вход необходимо принять значения двух переменных (a и b). Если a или b меньше сгенерированного числа, вывести False. Если оба значения больше, то вывести true.
    */

    static void Task2()
    {
        Random rnd = new Random();
        int number = rnd.Next(0, 101);
        Console.WriteLine($"Generated number: {number}");

        Console.Write("a=");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b=");
        int b = int.Parse(Console.ReadLine());

        if (a < number | b < number)
        {
            Console.WriteLine("False"); // a или b меньше сгенерированного числа: False
        }
        else if (a > number & b > number)
        {
            Console.WriteLine("True"); // Оба числа больше сгенерированного: True
        }
    }

    // Задача 3
    /*  Введите числа x и y. Если сумма x и y равна 98, выведите сообщение, что все true. Если сумма x и y не равна 98, выведите сообщение false */

    static void Task3()
    {
        Console.WriteLine("Is it equal to 98?");
        Console.Write("x=");
        int x = int.Parse(Console.ReadLine());
        Console.Write("y=");
        int y = int.Parse(Console.ReadLine());

        int z = 98;

        if (x + y == z)
        {
            Console.WriteLine("True");
        }
    }

    // Задача 4
    /* Введите числа x и y и z. Если x + y равняется z, выведите об этом сообщение */

    static void Task4()
    {
        Console.Write("x=");
        int x = int.Parse(Console.ReadLine());
        Console.Write("y=");
        int y = int.Parse(Console.ReadLine());
        Console.Write("z=");
        int z = int.Parse(Console.ReadLine());

        if (x + y == z)
        {
            Console.WriteLine($"{x} + {y} = {z}");
        }
        else
        {
            Console.WriteLine("False");
        }
    }

    // Задача 5
    /* Введите строку. Если длина строки больше 13 символов, выведите об этом сообщение. */

    static void Task5()
    {
        Console.Write("Type a string.");
        string text = Console.ReadLine();

        if (text.Length > 13)
        {
            Console.WriteLine("Error: Too much sharacters.");
        }
        else
        {
            Console.WriteLine(text);
        }
    }

    // ============================== БЛОК 2. Строки =====================================

    // Задача 6
    /* Заменить в строке все вхождения 'child' на 'children'. Удалить из текста все символы, являющиеся цифрами. */

    static void Task6()
    {
        /*string text = Console.ReadLine();
   
        text = text.Replace("child", "children");
        Console.WriteLine(text);*/
        Console.WriteLine(Console.ReadLine().Replace("child", "children"));
    }

    // Задача 7
    /*  Используя метод вывода значения в консоль, выполните конкатенацию слов и выведите на экран следующую фразу:
    Welcome to the godel team.
    Каждое слово должно быть записано отдельно и взято в кавычки, например "Welcome". Не забывайте о пробелах после каждого слова */

    static void Task7()
    {
        string s1 = "Welcome";
        string s2 = "to";
        string s3 = "the";
        string s4 = "godel";
        string s5 = "team";

        string text = s1 + " " + s2 + " " + s3 + " " + s4 + " " + s5;
        Console.Write(text);
    }

    // Задача 8
    /* Дана строка: Godelteamwithsomeofexcersicesabcwanttomakeitbetter.
    Необходимо найти в данной строке "abc", записав всё что до этих символов в первую переменную, а также всё, что после них во вторую. 
    Результат вывести в консоль. */

    static void Task8()
    {
        string text = "Godelteamwithsomeofexcersicesabcwanttomakeitbetter";
        string substring = "abc";

        //string[] part1 = text.Trim(new string[3] {substring});
        //Console.WriteLine(part1);

    }

    // Задача 9
    /* Дана строка: Плохой день.
    Необходимо с помощью метода substring удалить слово "плохой". После чего необходимо используя команду insert создать строку со значением: Хороший день!!!!!!!!!.
    Заменить последний "!" на "?" */

    static void Task9()
    {
        string text = "Bad day";

        string newtext = string.Concat(text, "!!!!!!!!!");
        text = text.Replace("Bad", "Good");
        text = text.Replace("!!!!!!!!!", "!!!!!!!!?");
        Console.Write(text);
    }

    // =================== БЛОК 3. Строки =================

    // Написать программу перевода чисел из шестнадцатеричной системы счисления в десятичную.
    static void Task10()
    {
        uint value = Convert.ToUInt32(Console.ReadLine(), 16);
        Console.WriteLine((decimal)value);
    }
    // Напишите консольную программу, пользователь вводит с клавиатуры число. Программа проверяет и выводит на консоль результат ""Число четное"" либо ""Число нечетное"", либо ""Введено некорректное значение"".

    static void Task11()
    {
        Console.Write("Type a number:");
        int number = int.Parse(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine("Even number");
        }
        else if (number % 2 != 0)
        {
            Console.WriteLine("Odd number");
        }
        else
        {
            Console.WriteLine("Incorrect value entered");
        }
    }

    // Пользователь вводит номер месяца (от 1 до 12). Вывести на консоль время года. 

    static void Task12()
    {
        Console.WriteLine("Month number: ");
        string month = (Console.ReadLine());

        if (month == "1")
        {
            Console.WriteLine("January");
        }
        else if (month == "2")
        {
            Console.WriteLine("February");
        }
        else if (month == "3")
        {
            Console.WriteLine("March");
        }
        else if (month == "4")
        {
            Console.WriteLine("April");
        }
        else if (month == "5")
        {
            Console.WriteLine("May");
        }
        else if (month == "6")
        {
            Console.WriteLine("June");
        }
        else if (month == "7")
        {
            Console.WriteLine("July");
        }
        else if (month == "8")
        {
            Console.WriteLine("August");
        }
        else if (month == "9")
        {
            Console.WriteLine("September");
        }
        else if (month == "10")
        {
            Console.WriteLine("October");
        }
        else if (month == "11")
        {
            Console.WriteLine("November");
        }
        else if (month == "12")
        {
            Console.WriteLine("December");
        }
        else
        {
            Console.WriteLine("Incorrect");
        }
    }

    // Напишите консольную программу, пользователь вводит с клавиатуры поочередно три числа a, b, c. Проверить: выполняется ли неравенство a < b < c; выполняется ли неравенство b > a > c.

    static void Task13()
    {
        Console.Write("Incert a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Incert b: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Incert c: ");
        int c = int.Parse(Console.ReadLine());

        Console.WriteLine((a < b) & (b < c) ? "a < b < c: True" : "a < b < c: False");
        Console.WriteLine((b > a) & (a > c) ? "b > a > c: True" : "b > a > c: False");
    }

    // Пользователь вводит с клавиатуры любую строку (предложение). Проверить и вывести на консоль результат, содержит ли строка подстроку ""тест"".

    static void Task14()
    {
        Console.Write("Input a string: ");
        string text = Console.ReadLine();
        string substring = "test";

        if (text.Contains(substring))
        {
            Console.WriteLine($"Text contains a word '{substring}'");
        }
    }

    // Пользователь вводит с консоли строку, которая может принимать 2 значения: 'ru' либо 'en'. Если она имеет значение 'ru', то вывести на консоль слово ""Брест"", а если имеет значение 'en' – то ""Brest"".  Решите задачу через if, через switch-case (должно быть 2 решения). Обработайте ситуацию, когда введенное значение не равно 'ru' либо 'en'. 

    static void Task15()
    {
        Console.Write("Input 'ru' or 'en': ");
        string text = Console.ReadLine();

        /*if (text == "ru")
        {
            Console.WriteLine("Брест");
        }
        else if (text == "en")
        {
            Console.WriteLine("Brest");                             // if...else
        }*/

        switch (text)
        {
            case "en":
                Console.WriteLine("Brest");
                break;
            case "ru":
                Console.WriteLine("Брест");
                break;                                          // switch/case
        }

        /*string lang = (text == "en") ? "Brest" : "Брест";
        Console.Write(lang);*/                                      // тернарная
    }

    // Используя тернарную операцию проверить, делится ли введенное с клавиатуры число на 8 без остатка.

    static void Task16()
    {
        Console.WriteLine(int.Parse(Console.ReadLine()) % 8 == 0 ? "Yes" : "No");
    }

    // Определить число, полученное выписыванием в обратном порядке цифр четырехзначного натурального числа n.

    static void Task17()
    {

        Console.WriteLine("Vvedite czetyroch znac'noe natural'noe czislo:");
        string number = Console.ReadLine();

        string reversed = new string(number.Reverse().ToArray());
        Console.WriteLine($" Czislo: {reversed}");

    }

    // Дано четырехзначное натуральное n. Верно ли, что это число содержи ровно две цифры 7?

    static void Task18()
    {
        Console.WriteLine("Brat dai Chislo");
        string number = Console.ReadLine();
        int amountOfSevenNumbers = 0;

        foreach (char numberSeven in number)
        {
            if (numberSeven == '7')
            {
                ++amountOfSevenNumbers;
            }
        }
        if (amountOfSevenNumbers == 2)
        {
            Console.WriteLine(true);
            Console.WriteLine(amountOfSevenNumbers);
        }
        else
        {
            Console.WriteLine(false);
            Console.WriteLine(amountOfSevenNumbers);
        }
    }

    // Дано четырехзначное натуральное n. Верно ли, что сумма первых двух цифр равна сумме двух оставшихся цифр числа?

    static void Task20()
    {
        Console.WriteLine("Brat dai Chislo");
        string number = Console.ReadLine();
        int[] massive = number.Select(ch => -0).ToArray();

        int a = number[0];
        int b = number[1];
        int c = number[2];
        int d = number[3];

        Console.WriteLine(((a + b) == (c + d)) ? true : false);
    }

    //  Определить, есть ли среди первых пяти цифр дробной части заданного положительного вещественного числа, цифра 0.

    static void Task21()
    {

        Console.WriteLine("Brat dai Chislo");
        string number = Console.ReadLine();
        string fractional = number.Split('.', ',')[1];
        Console.WriteLine(fractional);

        foreach (char i in fractional)
        {
            if (i == '0')
            {
                Console.WriteLine(true);
            }
        }
    }

    // Определить, есть ли среди первых четырех цифр дробной части заданного положительного вещественного числа, цифра 9.

    static void Task22()
    {
        Console.WriteLine("Brat dai Chislo");
        string number = Console.ReadLine();
        string fractional = number.Split('.', ',')[0];
        Console.WriteLine(fractional);

        foreach (char i in fractional)
        {
            if (i == '9')
            {
                Console.WriteLine(true);
            }
        }
    }

    // Определить, равна ли первая цифра дробной части заданного положительного вещественного числа четвертой цифре. 

    static void Task23()
    {
        Console.WriteLine("Brat dai Chislo");
        string number = Console.ReadLine();
        string fractional = number.Split('.', ',')[0];
        Console.WriteLine(fractional);
        int[] massive = number.Select(ch => -0).ToArray();

        int a = number[0];
        int b = number[1];
        int c = number[2];
        int d = number[3];

        Console.WriteLine((a == d) ? true : false);
    }

    // Присвоить логической переменной значение логического выражения, истинного при выполнении следующего условия и ложного в противном случае: целые числа x, y, z равны между собой;  

    static void Task24()
    {
        int x = 2;
        int y = 2;
        int z = 2;

        Console.WriteLine((x = y) == (y = z) ? true : false);
    }

    // Присвоить логической переменной значение логического выражения, истинного при выполнении следующего условия и ложного в противном случае:только одно из целых чисел x, y, z положительно;  

    static void Task25()
    {
        int x = 2;
        int y = 2;
        int z = 7;

        Console.WriteLine((x % 2 == 0) ^ (y % 2 == 0) ^ (z % 2 == 0));

    }

    // Присвоить логической переменной значение логического выражения, истинного при выполнении следующего условия и ложного в противном случае: год с порядковым номером y является високосным; 

    static void Task26()
    {
        int x = 2020;
        Console.Write(" Visokosnyj li god: ");
        int y = int.Parse(Console.ReadLine());

        Console.WriteLine(((x - y) % 2 == 0) ? "da" : "net");
    }

    // Даны действительные числа x, y, z. Поменять значения переменных так, чтобы x < y < z; 

    static void Task27()
    {
        int x = 5;
        int y = 10;
        int z = 15;

        if (x > y) { int i = y; y = x; x = i; }
        if (y > z) { int i = z; z = y; y = i; }
        if (z < x) { int i = x; x = z; z = i; }

    }

    // Даны вещественные x1, x2, x3, x4. Поменять значения переменных так, чтобы x1 < x3 < x2 < x4 .

    static void Task28()
    {
        double x1 = 1.1;
        double x2 = 2.2;
        double x3 = 3.3;
        double x4 = 4.4; // проверяем x1 < x3 < x2 < x4

        if (x1 > x3) { double x5 = x3; x3 = x1; x1 = x5; }
        if (x3 > x2) { double x5 = x2; x2 = x3; x3 = x5; }
        if (x2 > x4) { double x5 = x4; x4 = x2; x2 = x5; }
        if (x4 < x1) { double x5 = x1; x1 = x4; x4 = x5; }
    }

    // Решите эти задачи сначала через цикл while, а затем через цикл for. Выведите столбец чисел от 1 до 50.

    static void Task29()
    {
        int i = 1;

        //  for ( int i = 1; i < 51; i++ )
        //   Console.WriteLine(i) ;

        while (i < 51)
        {
            Console.WriteLine(i);
            i++;
        }
    }

    //  Напишите программу, которая считает сумму первых 10 натуральных чисел.

    static void Task30()
    {
        int number = 1;
        int sum = 0;

        while (number <= 10)
        {
            sum += number;
            number++;
        }
        Console.WriteLine(sum);
    }

    //  Дано число n=1000. Делите его на 2 столько раз, пока результат деления не станет меньше 50. Какое число получится? Посчитайте количество итераций, необходимых для этого(итерация - это проход цикла).

    static void Task31()
    {
        int n = 1000;

        /*while (n >= 50)
        {
            n = n / 2;
            Console.WriteLine(n);
        }*/
        for (n = 1000; n >= 50; n++)
        {
            n = n / 2;
            Console.WriteLine(n);
        }


    }

    // Пользователь вводит число. Выведите n строк, добавляя следующее натуральное число на каждой строке.

    static void Task32()
    {
        Console.WriteLine("Insert the number.");
        int UserNumber = int.Parse(Console.ReadLine());
        string previous = "";

        for (int i = 1; i <= UserNumber; i++)
        {
            previous = previous + i;
            Console.WriteLine(previous);
        }
    }

    // Написать консольный калькулятор.
    // Программа выводит меню с вариантами выполняемых операций например:
    // 1 выполнить сложение двух чисел
    // 2 выполнить вычитание двух чисел
    // 3 выполнить умножение двух чисел
    // 4 выполнить деление двух чисел
    // 5 выход из программ
    // После выбора операции запрашиваются исходные данные и выводится результат.Затем программа снова возвращается в меню.
    // Выход из программы выполняется при выборе отдельного пункта меню "выход их программы".
    // Предусмотреть поясняющие сообщения, что программа ожидает от пользователя.
    // Как выводить результат и в какой момент очищать экран от предыдущих выводов - решить самостоятельно исходя из условия удобства работы пользователя.

    static void Task33()
    {
        while (true)
        {
            Console.WriteLine("=================== KALkulaTOR ======================== \nVyberite operaciju dla dvuch cisel, vvedia sootvetstvyusij nomer. \nSlozenie - vvedite 1 \nVycitanie - vvedite 2 \nUmnozenie - vvedite 3 \nDelenie - vvedite 4 \nVyjyi - vvedite 5");
            string nomerOperacii = Console.ReadLine();

            if (nomerOperacii == "1")
            {
                Console.Write("\nOperacija clozenia. \n===== a + b ======= \nVvedite slogaemye: \na = ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("b = ");
                int b = int.Parse(Console.ReadLine());
                int c = a + b;
                Console.WriteLine($"Resultat: {a} + {b} = {c} \nVevite luboe znacenie, ctoby prodolzit'");
                string navigacia = Console.ReadLine();
                continue;
            }
            else if (nomerOperacii == "2")
            {
                Console.Write("\nOperacija vycitania. \n===== a - b ======= \nVvedite vycitaemye: \na = ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("b = ");
                int b = int.Parse(Console.ReadLine());
                int c = a - b;
                Console.WriteLine($"Resultat: {a} - {b} = {c} \nVevite luboe znacenie, ctoby prodolzit'");
                string navigacia = Console.ReadLine();
                continue;
            }
            else if (nomerOperacii == "3")
            {
                Console.Write("\nOperacija umnizenia. \n===== a * b ======= \nVvedite mnoziteli: \na = ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("b = ");
                int b = int.Parse(Console.ReadLine());
                int c = a * b;
                Console.WriteLine($"Resultat: {a} * {b} = {c} \nVevite luboe znacenie, ctoby prodolzit'");
                string navigacia = Console.ReadLine();
                continue;
            }
            else if (nomerOperacii == "4")
            {
                Console.Write("\nOperacija delenia. \n===== a / b ======= \nVvedite chisla: \na = ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("b = ");
                int b = int.Parse(Console.ReadLine());
                var c = a / b;
                Console.WriteLine($"Resultat: {a} / {b} = {c} \nVevite luboe znacenie, ctoby prodolzit'");
                string navigacia = Console.ReadLine();
                continue;
            }
            else if (nomerOperacii == "5")
            {
                Console.WriteLine("Do swidania!");
                break;
            }
            else
            {
                Console.WriteLine("Poprobujte ese raz.");
                continue;
            }
        }
    }

    // Написать игру "Угадай число".
    // Программа случайно выбирает число в диапазоне 0-100.
    // Пользователь должен угадать это число.
    // После ввода варианта пользователя выводиться сообщение "больше" если выбранное больше введенного пользователем.
    // "меньше" если выбранное число меньше введенного пользователем.
    // "правильно" если выбранное число совпало с введенным пользователем.
    // Предусмотреть возможность сыграть несколько раз без перезапуска программы.
    // По желанию разработчика можно предусмотреть вариант с ограничением количества попыток пользователя для угадывания числа.

    static void Task34()
    {
        Console.WriteLine("=================== GUESS THE NUMBER ======================== \nTHE RULES: \r\n//The program randomly selects a number between 0 and 100.\r\n// The user must guess this number.\r\n// After entering the user's guess, the message \"greater\" is displayed if the selected number is greater than the user's input.\r\n// \"less\" if the selected number is less than the user's input.\r\n// \"correct\" if the selected number matches the user's input.");
        Random rnd = new Random();
        int ProgramNumber = rnd.Next(0, 101);

        while (true)
        {
            Console.WriteLine("The number is: ");
            int userNumber = int.Parse(Console.ReadLine());

            if (userNumber > ProgramNumber)
            {
                Console.WriteLine("Your number is bigger. Try more...");
                continue;
            }
            else if (userNumber < ProgramNumber)
            {
                Console.WriteLine("Your number is less. Try more...");
                continue;
            }
            else if (userNumber == ProgramNumber)
            {
                Console.WriteLine($"Congragulation!!! The number is {ProgramNumber}");
                break;
            }
            else
            {
                Console.WriteLine("Error!!! Invalid value. Type enother number.");
                continue;
            }
        }
    }

    // Дан массив целых чисел.
    // Сделать:
    // 1. Вывести все чётные числа массива в одну строку через пробел.
    // 2. Посчитать среднее арифметическое всех чётных элементов.
    // 3. Если чётных нет — вывести сообщение "Нет чётных чисел".
    //   Console.WriteLine("Insert the number.");
    /*int UserNumber = int.Parse(Console.ReadLine());
    string previous = "";

       for (int i = 1; i <= UserNumber; i++)
        {
            current = previous + i;
            Console.WriteLine(previous);
            previous = cuttenr;
            
        }*/

    static void Task35()
    {
        int[] nums = new int[10] { 91, 12, 53, 44, 509, 63, 72, 80, 96, 103 };
        int x = 0;
        int previous = 0;
        int sum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] % 2 == 0)
            {
                Console.Write($"{nums[i]} ");
                x++;                                       // считай, сколько i вышло
                previous = previous + nums[i];
            }
            else if (sum == 0)
            {
                Console.WriteLine("No even numbers.");
            }
        }

        double average = (double)sum / x;
        Console.WriteLine($"\nThe average is: {average}");
    }

    // Дан массив строк (например, имена, слова и т.п.).
    // Сделать:
    // 1. Найти строку с максимальной длиной.
    // 2. Если таких несколько — взять первую, которая встретилась.
    // 3. Вывести:
    // • саму строку
    // • её длину

    static void Task36()
    {
        string[] pupsiki = new string[] { "Andrusha", "Kim SeokJin", "Kim NamJoon", "Min JoonGi", "Cheon HoeSeok", "Park JiMin", "Kin TaeHyung", "Jeon JungKook", "BTS" };
        string longestName = "";

        foreach (var pups in pupsiki)
        {
            if (pups.Length > longestName.Length)
            {
                longestName = pups;
            }
        }

        Console.WriteLine(longestName);
        Console.WriteLine($"Characters number: {longestName.Length}");

    }

    // Дан массив целых чисел и число N (можно считать, что N >= 0).
    // Сделать:
    // 1. Сдвинуть элементы массива вправо на N позиций.
    // 2. Элементы, “выталкиваемые” за пределы массива, должны переходить в начало.
    // 3. Вывести новый массив.


    static void Task37()
    {
        int[] nums = new int[] { 111, 222, 333, 444, 555, 666, 777, 888, 999, 101010, 111111, 121212 };
        Console.WriteLine("Input the number.");
        int n = int.Parse(Console.ReadLine());

        int m = nums.Length;
        n = n % m;                                        // чтобы сдвиг не был больше длины массива                                                                                    // величина сдвига
        int temp;                                         // переменная для запоминания значения, выпадаемого из массива

        for (int i = 0; i < n; i++)
        {
            temp = nums[m - 1];                          // последний элемент запоминается

            for (int j = m - 1; j > 0; j--)              // двигаем все вправо
            {
                nums[j] = nums[j - 1];
            }

            nums[0] = temp;                              // последний элемент ставим в начало
        }
        
        foreach (var x in nums)
        {
            Console.Write(x + " "); 
        }
        
        
        
        /*for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > nums.Length)                                                                   // чтобы индексы, которые больше длины массива, переносились вначало массива
            {
                nums[i] -= nums.Length;
            }

            temp = nums[i];
            nums[i] = nums[i + n];
            nums[i + n] = temp;
            Console.Write($"{nums[i]} ");

        }

        foreach (int z in nums)                                                                          // выводит новый массив
        {
            Console.WriteLine($"{z} \t");

        }*/


        /* TRY 1ST
         * int n = nums.Length;
        int k = n / 2;                                        // середина массива
        int temp;

            for (int i = 0; i<nums.Length; i++)
            {
                nums[i] = nums[i]* 2;

                temp = nums[i];
                nums[i] = nums[n - k];
                nums[n - k] = temp;
                k = k - 2;
            }*/
    }

    // Дан массив строк и одна отдельная строка pattern.
    // Сделать:
    // 1. Найти все элементы массива, которые содержат pattern как подстроку.
    // 2. Вывести их индексы и сами строки.
    // 3. Если ни одна строка не содержит pattern — вывести "Совпадений не найдено".

    static void Task38()
    {
        string[] names = new string[]
        {
            "TomError",
            "BarbaraError",
            "KateError",
            "MamiError",
            "Elena",
            "Sidney",
            "Ilya",
            "TemaError"
        };
        string pattern = "Error";
        int x = 0;

        for (int i = 0; i <= names.Length; i++)
        {

            if (names[i].EndsWith(pattern))
            {
                Console.WriteLine(i);
                x++;
            }

            if (x == 0)
            {
                Console.WriteLine("No matches found.");
            }
        }
    }

    // Дан массив целых чисел.
    // Нужно создать новый массив, в котором:
    // • остаются только первые вхождения каждого числа,
    // • все последующие дубликаты удаляются,
    // • порядок сохраняется.

    static void Task39()
    {
        int[] numbers = new int[10] { 1232, 9345, 8247, 2349, 3935, 7623, 24927, 1232, 9345, 1232 };
        int[] result = new int[10];

        for (int i = 0; i < numbers.Length; i++)
        {
            string number = numbers[i].ToString();             //  переводим первое число в строку  
            char first = number[0];                            // забираем только первый элемент строки
            numbers[i] = int.Parse(first.ToString());          // переводим опять в число
            result[i] = numbers[i];                            // записываем результат в новый массив
            Console.Write($"{result[i]} \t");

            /*for (int j = 0; j < result.Length; j++)
            {
                if (result[j] == numbers[i])
                {
                    result = result.Where(x => !numbers.Contains(x)).ToArray();
                    Console.Write($"{result[i]} \t");
                }
            }*/
            
        }
    }

    // Дан массив строк.
    // Нужно:
    // • каждую строку развернуть 
    // • вывести новый массив.

    // Пример:
    // ["cat", "hello"] → ["tac", "olleh"]

    static void Task40()
    {
        string[] names = new string[] { "cat", "hello" };
        int n = names.Length;
        char[] inverted = new char[n];
        string s = "";

        for (int i = 0; i < n; i++)
        {
            /*inverted[i] = names[n - i - 1];         // читаем с конца и пишем с начала
            Console.WriteLine(string.Join(" ", inverted));*/
            s = s + names[i].ToString();                  // запиываем значение элемента в строку, присоединяя к предыдущему значению
            inverted = s.ToCharArray();               // переводим в символы
            Array.Reverse(inverted);                  // разворачиваем символы наоборот

        }

        foreach (char i in inverted)
        {
            Console.Write(i);
        }

    }

    // Проверка, является ли массив палиндромом
    // Массив считается палиндромом, если читается одинаково слева направо и справа налево.
    // Пример:
    // [1, 2, 3, 2, 1] → True
    // [7, 5, 5] → False

    static void Task41()
    {
        int[] palindrom = new int[] { 1, 2, 3, 2, 1 };
        int n = palindrom.Length;
        int k = n / 2;

        bool isPalindrome = true;

        for (int i = 0; i < k; i++)
        {

            if (palindrom[i] != palindrom[n - i - 1])
            {
                isPalindrome = false;
                break;
            }
        }

        Console.WriteLine(isPalindrome ? "True" : "False");
    }

    // Дан массив чисел 
    // Нужно вывести на экран сколько раз определенное число встречается в этом массиве

    // Пример[1, 1, 2, 3, 3, 3]
    // 1 → 2 раза
    // 2 → 1 раз
    // 3 → 3 раза
    //            5if (num[i] == num[x - 1]) continue;

    static void Task42()
    {
        int[] num = new int[] { 2, 1, 1, 2, 3, 3, 3, 2 };
        int[] store = { };                                                 // пустой массив для записи чисел



        for (int i = 0; i < num.Length; i++)                              // перебираем массив 
        {
            bool IsAlreadyCounted = false;
            
            for (int j = 0; j < store.Length; j++)                        
            {
                if (store[j] == num[i])                                       // смотрим, не повторяется ли значение в новом массиве 
                {
                    IsAlreadyCounted = true;                                  // если уже есть, то пропускаем
                    break;
                }
                    
            }

            if (!IsAlreadyCounted)                                       // если еще нету в новом массиве, то считаем, сколько раз встречается
            {
                int counter = 0;                                         // вводим счетчик
                for (int x = 0; x < num.Length; x++)
                { 
                  if (num[i] == num[x])
                    {
                        counter++; 
                    }
                }

                Array.Resize(ref store, store.Length + 1);                  // увеличиваем массив для хранения на 1
                store[store.Length - 1] = num[i];                           // записываем туда значение совпавшего числа

                Console.WriteLine($"{num[i]} - {counter} times.");
            }   
        }


        /* TRY 1ST
         * for (int i = 0; i < num.Length; i++)                         // цикл который перебирает первое число для сравнения
        {
            for (int j = 0; j < num.Length; j++)                     // цикл который перебирает второе число для сравнения
            {
                if (i == j) continue;                                // чтобы не сравнивать число само с собой (смотрит по совпадению индекса)

                if (num[i] == num[j])                                // если значения одинкавые
                {
                    counter++;
                    for (int z = 0; z < store.Length; z++)           // перебираем массив для записи и проверяем нет ли уже такого значения
                    {
                        if (store[z] == num[i]) break;               // если есть то цикл прерывается
                        else                                         // если такого значения еще нет, то...
                        {
                            Array.Resize(ref store, store.Length + 1);                  // увеличиваем массив для хранения на 1
                            store[store.Length - 1] = num[i];                           // записываем туда значение совпавшего числа
                            Console.WriteLine($"{store[store.Length - 1]} - {counter} times.");        // выводим в консоль значение текущего элемента и количесво из счетчика
                        }
                    }
                }
            }
        }*/

        /* TRY 2ND
         * for (int i = 0; i < num.Length; i++)
        {
            int y = 1;                                     // счетчик сбрасывается до 1, когда цикл проверяет новое число в массиве
            

            for (int x = 0; x < num.Length; x++)           // цикл, который выбирает второе число для сравнения (оно всегда больше исходного на 1, т.е. следующее)
            {
                string n = "";

                if (num[i] == num[x])
                {
                    n = num[i].ToString();                                  // пусть будет строкой, которой присваивается значение элемента в массиве
                    y++;                                        // кол во раз выводит правильно
                    Console.WriteLine($"{n} - {y} times.");
                
                }
            }

        }*/

        /* TRY 3RD
         * for (int i = 0; i < num.Length; i++)
        {
            for (int x = 0; x < num.Length; x++)
            {
                if (i == x) continue;                   // чтобы не сравнивать число само с собой

                if (num[1] == num[x])
                {
                    y++;
                    Console.WriteLine($"{num[i]} - {y} times.");
                }
            }
        }*/
    }

    // Проверить, что в массиве нет двух соседних одинаковых чисел
    // Если есть две одинаковые подряд — вывести их индекс.
    // Пример:
    // [1, 2, 2, 3] → “Повтор на позиции: 2”
    // Если нет — вывести "Нет соседних повторов".

    static void Task43()
    {
        int[] nums = new int[] { 1, 2, 2, 3, 3, 4 };

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (i == j) continue;
                int x = i - j;

                if (nums[i] ==  nums[j] & x == 1)
                {
                    Console.WriteLine($"Repeated on position {i}");
                }
            }
        }
    }

    // Объединение двух массивов без дубликатов

        // Массивы:
    // A = [1, 2, 3, 3]
    // B = [3, 4, 5]
    // Результат:
    // [1, 2, 3, 4, 5]

    static void Task44()
    {
        int[] a = new int[] { 1, 2, 3, 3 };
        int[] b = new int[] { 3, 4, 5 };

        var common = a.Intersect(b).ToArray();                // находим элементы, которые присутствуют в обоих массивах

        a = a.Where(x => !common.Contains(x)).ToArray();      // убираем из массива "а" все, что есть в "b"

        int[] merged = new int[a.Length + b.Length];          // ВАЖНО!!! Новый массив длинной a.Length + b.Length создаем только после того, как вырежем ненужные элементы из а

        Array.Copy(a, 0, merged, 0, a.Length);                // скопировать a.Length элементов из массива a, начиная с индекса 0, и поместить их в merged, начиная с индекса 0.
        Array.Copy(b, 0, merged, a.Length, b.Length);         // копируем весь b начиная с 0 и вставляем в merged, начиная с позиции a.Length, то есть с индекса 3.

        foreach (int x in merged)
        {
            Console.WriteLine(x + " ");
        }

    }
}
            



