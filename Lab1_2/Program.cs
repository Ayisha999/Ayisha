try
{
    Console.Write("Введите первую переменую:!");
    double a = double.Parse(Console.ReadLine());
    Console.Write("Введите первую переменую:!");
    double c = double.Parse(Console.ReadLine());
    double b = Math.Sqrt(c * c - a * a);
    Console.WriteLine();
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}

