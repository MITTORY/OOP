using System;
using System.Reflection;

public class Square
{ 

    private readonly double a;

    public Square(double a)
    {
        this.a = a;
    }

    public double Perimetr() => 4 * a;
    public double Ploshad() => a * a;
    public double Radius() => Diametr() / 2;
    public double Diametr() => a * Math.Sqrt(2);

}

public class Cube
{
    private readonly double a1, b, c;

    public Cube(double a1, double b, double c)
    {
        this.a1 = a1;
        this.b = b;
        this.c = c;
    }

    public double V() => a1 * b * c;

    public double PloshadPoverh() => 6 * (a1 * a1);

    public double Diagonal() => Math.Round(a1 * Math.Sqrt(3));
}

class Program
{

    static void Main()
    {
        double a = 0, a1 =0, b = 0, c = 0;
        Square square = new (a);
        Cube cube = new (a1, b, c);
        

        Console.WriteLine("Выберите фигуру:");
        Console.WriteLine("1. Квадрат.");
        Console.WriteLine("2. Куб.");
        Console.Write("Выбор: ");

        string num = Console.ReadLine();
        for(int i = 0; i <=3;) 
        {
        switch (num) 
        {
            case "1":
                    Console.Clear();
                    Console.WriteLine("Выберите:");
                    Console.WriteLine("1: Ввод длин сторон.");
                    Console.WriteLine("2: Вывод длин сторон.");
                    Console.WriteLine("3: Периметр.");
                    Console.WriteLine("4: Площадь.");
                    Console.WriteLine("5: Радиус.");
                    Console.WriteLine("6: Диаметр.");
                    string input1 = Console.ReadLine();
                    switch (input1)
                    {
                        case "1":
                            Console.Write("Введите a: ");
                            a = double.Parse(Console.ReadLine());
                            square = new Square(a);
                            break;
                        case "2":
                            Console.WriteLine("Сторона a: " + a);
                            break;
                        case "3":
                            Console.WriteLine("Периметр: " + square.Perimetr());
                            break;
                        case "4":
                            Console.WriteLine("Площадь: " + square.Ploshad());
                            break;
                        case "5":
                            Console.WriteLine("Радиус: " + square.Radius());
                            break;
                        case "6":
                            Console.WriteLine("Диаметр: " + square.Diametr());
                            break;
                    }
                    break;
            case "2":
                    Console.Clear();
                    Console.WriteLine("Список команд:");
                    Console.WriteLine("1: Ввод длин сторон.");
                    Console.WriteLine("2: Вывод длин сторон.");
                    Console.WriteLine("3: Объём.");
                    Console.WriteLine("4: Площадь.");
                    Console.WriteLine("5: Длина диагонали.");
                    string input2 = Console.ReadLine();
                    switch (input2)
                    {
                        case "1":
                            Console.Write("Введите a: ");
                            a1 = double.Parse(Console.ReadLine());
                            Console.Write("Введите b: ");
                            b = double.Parse(Console.ReadLine());
                            Console.Write("Введите c: ");
                            c = double.Parse(Console.ReadLine());
                            cube = new Cube(a1, b, c);
                            break;
                        case "2":
                            Console.WriteLine("Сторона a: " + a1 + ", b: " + b + ", c: " + c + ".");
                            break;
                        case "3":
                            Console.WriteLine("Объем: " + cube.V());
                            break;
                        case "4":
                            Console.WriteLine("Площадь: " + cube.PloshadPoverh());
                            break;
                        case "5":
                            Console.WriteLine("Длина диагонали: " + cube.Diagonal());
                            break;
                    }
                    break;
        }
        Console.ReadLine();
        }
    }
}