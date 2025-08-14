using System;

Console.WriteLine("Решение квадратного уравнения ax^2 + bx + c = 0");

        // Ввод коэффициентов
        Console.Write("Введите a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        // Проверка, что это действительно квадратное уравнение
        if (a == 0)
        {
            Console.WriteLine("Это не квадратное уравнение (a не должно быть 0).");
            return;
        }

        // Вычисление дискриминанта
        double discriminant = b * b - 4 * a * c;

        Console.WriteLine($"Дискриминант D = {discriminant}");

        if (discriminant > 0)
        {
            // Два корня
            double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine($"Уравнение имеет два корня: x1 = {x1}, x2 = {x2}");
        }
        else if (discriminant == 0)
        {
            // Один корень
            double x = -b / (2 * a);
            Console.WriteLine($"Уравнение имеет один корень: x = {x}");
        }
        else
        {
            // Нет действительных корней
            Console.WriteLine("Уравнение не имеет действительных корней.");
        }
