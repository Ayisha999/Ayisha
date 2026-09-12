Console.Write("Введите y:");
double y = double.Parse(Console.ReadLine());
Console.Write("Введите w:");
double w = double.Parse(Console.ReadLine());
double G = (9.33 * w * w + Math.Sqrt(w)) / (Math.Log(y + 3.5)+Math.Sqrt(y));
Console.WriteLine($"G={G:F2}");