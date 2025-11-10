using System;
class LinearExpressions1
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        double m, n, x, b, a;
        Console.Write("Введіть число m: ");
        m = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введіть число n: ");
        n = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введіть число x: ");
        x = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введіть число b: ");
        b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введіть число a: ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введіть число c: ");
        double z1=((m-1)*Math.Sqrt(m)-(n-1)*Math.Sqrt(n))/ (Math.Sqrt(Math.Pow(m, 3) * n) + n * m + m * m - m);
        Console.WriteLine($"\nРезультат обчислення z1 = {z1}");
        double z2 = (Math.Sqrt(m)- Math.Sqrt(n))/m;
        Console.WriteLine($"\nРезультат обчислення z2 = {z2}");
        double y = 2.4* Math.Abs((x*x+b)/a)+(a-b)* Math.Sqrt(Math.Sin(a-b),2)+ Math.Sqrt(10, -2)*(x-b);
        Console.WriteLine($"\nРезультат обчислення z2 = {z2}");
    }
}
