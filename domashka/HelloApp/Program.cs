// See https://aka.ms/new-console-template for more information
/*{
    Console.WriteLine("Hello");
    Console.WriteLine("Welcome to the C#");
}
{
    {
        Console.WriteLine("First block");
    }
    {
        Console.WriteLine("Second block");
    }
}
string name = "Tom";
Console.WriteLine(name);
name = "Bob";
Console.WriteLine(name);
Console.WriteLine("Hello \n\nworld");

// Tack 1 //
Console.OutputEncoding = System.Text.Encoding.UTF8;
string Name = "Lera";
int age = 24;
double weight = 59.5;
bool beautiful = true;
Console.WriteLine($"Имя: {Name}, Возраст: {age}, Вес: {weight}, Кросивоя? {beautiful}");

// Task 2 //
string Name2 = "Lera";
int Age = 24;
double Weight = 59.5;
Console.WriteLine("Имя: {0}  Возраст: {2}  Рост: {1}м", Name2, Weight, Age);

// Task 3 //
Console.Write($"Name: {name} Age: {age} Weight: {weight}");

// Task 4 //
Console.Write("\nType a name: ");
string? name3 = Console.ReadLine();
Console.WriteLine($"Hello {name3}-какашка!))))))))))))");
Console.WriteLine("Tigr");
Console.WriteLine('2');
Console.WriteLine("Koshka");

// Инкременты //
int x = 5;
int b = --x;
int c = x++;
int z = c-- + ++x;
Console.WriteLine(b + c + x + z);

// Домашка к 23.11 //
Console.WriteLine("Hello! This solution is able to help you to count how many latters you have in your name. \nOf cours, you are free to use it to somehow else.");
Console.Write("Give your name ");
string name = Console.ReadLine();
int SymbolCount = name.Length;
Console.WriteLine($"Result is: {SymbolCount}");
*/

// block 1 условные операции //
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        int a = 10;
        int b = 2;
        if (a > b)
            Console.WriteLine("True");
        else
            Console.WriteLine("False");
    }
}

