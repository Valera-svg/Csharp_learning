using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        // Вызов задач
        Task1();
        Task2();
        Task3();
        Task4();
        Task5();
        Task6();
    }
    // =================== БЛОК 1. Условия ===================

    // Задача 1
    static void Task1()
    {
        int a = 10;
        int b = 2;
        if (a > b)
            Console.WriteLine("True");
        else
            Console.WriteLine("False");
    }
    // Задача 2
    static void Task2()
    {
        Random rnd = new Random();
        int number = rnd.Next(0, 101);
        Console.WriteLine($"Generated number: {number}");

        Console.Write("a=");
        string aStr = Console.ReadLine();
        Console.Write("b=");
        string bStr = Console.ReadLine();

        // преобразую строки в числа
        int a = int.Parse(aStr);
        int b = int.Parse(bStr);

        if (a < number | b < number)
            Console.WriteLine("False"); // a или b меньше сгенерированного числа: False
       if (a > number & b > number)
            Console.WriteLine("True"); // Оба числа больше сгенерированного: True
    }
    // Задача 3
    static void Task3()
    {
        Console.WriteLine("Is it equal to 98?");
        Console.Write("x=");
        string xStr = Console.ReadLine();
        Console.Write("y=");
        string yStr = Console.ReadLine();

        int x = int.Parse(xStr);
        int y = int.Parse(yStr);

        int z = 98;

        if (x + y == z)
            Console.WriteLine("True");
        else if (x + y != z)
            Console.WriteLine("False");
    }
    // Задача 4
    static void Task4()
    {
        Console.Write("x=");
        string xStr = Console.ReadLine();
        Console.Write("y=");
        string yStr = Console.ReadLine();
        Console.Write("z=");
        string zStr = Console.ReadLine();

        int x = int.Parse(xStr);
        int y = int.Parse(yStr);
        int z = int.Parse(zStr);

        if (x + y == z)
            Console.WriteLine($"{x} + {y} = {z}");
        else 
            Console.WriteLine("False");
    }
    // Задача 5
    static void Task5()
    {
        Console.Write("Type a string.");
        string text = Console.ReadLine();

        int count = text.Length;
        int x = 13;

        if (count > x)
            Console.WriteLine("Error: Too much sharacters.");
        else
            Console.WriteLine(text);
    }
    // =================== БЛОК 2. Строки =================

    // Задача 6
    static void Task6()
    {

    }
    // =================== БЛОК 3. Строки =================

}
