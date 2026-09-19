//Console.WriteLine($"{Math.PI:F2}");
//Console.WriteLine($"{Math.E:F1}");
//int a = int.Parse(Console.ReadLine());
//Console.WriteLine($"Вы ввели число {a}");

//int a = int.Parse(Console.ReadLine());
//Console.WriteLine($"{a} - Вот какое число вы ввели");
//Console.WriteLine("1 13 49");
//Console.WriteLine("7\t15\t100");
//try
//{
//    Console.Write("Введите a:");
//    double a = double.Parse(Console.ReadLine());
//    Console.Write("Введите b:");
//    double b = double.Parse(Console.ReadLine());
//    Console.Write("Введите c:");
//    double c = double.Parse(Console.ReadLine());
//    double d = (-b + Math.Sqrt(b * b - 4 * a * c)) / (2);
//    Console.WriteLine($"{d:F2}");
//}
//catch(Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
//try
//{
//    Console.Write("Введите радиус");
//    double R = double.Parse(Console.ReadLine()));
//    double D = 2 * R;
//    Console.WriteLine($"Диаметр окружности:{D:F2}");
//}
//catch(Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
//try
//{
//    Console.Write("Введите x:");
//    double x = double.Parse(Console.ReadLine());
//    Console.Write("Введите y:");
//    double y = double.Parse(Console.ReadLine());
//    double z = (x + ((2 + y) / x * x)) / (y + (1 / Math.Sqrt(x * x + 10)));
//    Console.WriteLine($"Диаметр окружности:{z;F2}");

//}
//catch(Exception ex);
//{
//    Console.WriteLine(ex.Message); 

//}
//try
//{
//    Console.Write("Введите количество сантиметров:");
//    int sm = int.Parse(Console.ReadLine());
//    int m = sm / 100;
//    Console.WriteLine($"Полных метров{m}");

//}
//catch (Exception ex);
//{
//    Console.WriteLine(ex.Message);
//}

//try
//{
//    Console.Write("Введите количество килограммов:");
//    int kg = int.Parse(Console.ReadLine());
//    int cen = kg / 100;
//    Console.WriteLine($"Полных цементров {m}");

//}
//catch (Exception ex);
//{
//    Console.WriteLine(ex.Message);
//}

//try
//{
//    Console.Write("Введите количество килограммов:");
//    int kg = int.Parse(Console.ReadLine());
//    int ton = kg/1000
//    Console.WriteLine($"Полных тонн {m}");

//}
//catch (Exception ex);
//{
//    Console.WriteLine(ex.Message);
//}

//try
//{
//    Console.Write("Введите количество метров:");
//    int m = int.Parse(Console.ReadLine());
//    int km = m / 1000
//    Console.WriteLine($"Полных километров {m}");

//}
//catch (Exception ex);
//{
//    Console.WriteLine(ex.Message);
//}\

//Console.Write("Введите количество секунд");
//int n = int.Parse(Console.ReadLine());
//int hour = n / 3600;
//int minute = n % 3600 / 60;
//int second = n % 3600 % 60;
//Console.WriteLine($"{hour}:{minute}:{second}");

//try
//{
//    Console.Write("Введите четырехзначное число:");
//    int n = int.Parse(Console.ReadLine());
//    int a = n % 10;
//    int b = n % 100 / 10;
//    int c = n % 1000 / 100;
//    int d = n / 1000;
//    int s = a + b + c + d;
//    Console.WriteLine(s);
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

try
{
    Console.Write("Введите трехзначное число:");
    int n = int.Parse(Console.ReadLine());
    int b = n / 100;
    int a = n / 10 % 10;
    int c = n % 10;
    int x = a * 100 + b * 10 + c;
    Console.WriteLine(x);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}