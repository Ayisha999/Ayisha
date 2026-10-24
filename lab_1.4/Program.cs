//bool A = true;
//bool B = false;
//bool C = false;
//Console.WriteLine(!A || A && (B || C));
//try
//{
//    Console.Write("Введите x:");
//    double x = double.Parse(Console.ReadLine());
//    Console.Write("Введите y:");
//    double y = double.Parse(Console.ReadLine());
//    Console.WriteLine(x*x+y*y<=4);
//    Console.WriteLine((x >= 0) || (y * y != 4));
//    Console.WriteLine((x >= 0) && (y * y != 4));
//    Console.WriteLine((x * y) && ());
//}
//catch(Exception e)
//{
//    Console.WriteLine(e.Message);
//}


//int[] mas1 = new int[5];
//int[] mas2 = { 1, 4, 2, 9, 3 };
//int[] mas3 = mas2;
//mas3[3] = 12;
//Console.WriteLine(mas3[3]);
//Console.WriteLine(mas3[3]);

//ввод вручную 
//int[] mas4 = new int[5];
//for (int i = 0; i < mas4.Length; i++)
//    mas4  [i] = int.Parse(Console.ReadLine());
//for (int i = 0; i;< mas4.Length; i++)
//    Console.Write($"{mas4[i]}");


//задание
//int[] mas5 = new int[10];
//Random rnd= new Random();
//for (int i = 0;i < mas5.Length; i++)
//{
//    mas[i] = rnd.Next(-7, 8);
//    Console.Write($"{mas1[i]}");
//}
//Console.WriteLine();
//Console.Write("Введите n:");
//int n = int.Parse(Console.ReadLine());
//int index = -1;
//int less_n = 0;
//for (int i = 0; i < mas1.Length; i++)
//{
//    if (mas1[i] == n) index = i;
//    if (mas1[i] < n) less_n++;
//}
//Console.WriteLine($"Индекс последнего вхождения {n}={index}");
//Console.WriteLine($"Количество элеменетов меньших{n}={less_n}");

//try
//{
//    Console.Write("Введите n:");
//    int n = int.Parse(Console.ReadLine);
//    Random rnd = new Random();
//    int[] mas = new int[n];
//    for (int i = 0;i <mas.Length; i++)
//    {
//        mas[i] = rnd.Next(-10, 11);
//        Console.Write($"{mas[1]}");
//    }
//    Console.WriteLine();
//} 
//catch(Exception e)
//{
//    Console.WriteLine(e.Message);
//}

//отсортировать элементы массива по возрастанию
//Random rnd = new Random();
//int[] mas = new int[rnd.Next(10, 20)];
//for(int i = 0; < mas.Length; i++)
//{
//    mas[i] = rnd.Next(10, 100);
//    Console.Write($"{mas[i]}");
//}
//Console.WriteLine();
//for (int i = 0; i < mas.Length; i++) ;
//{
//    for (int j = i+1; j< mas.Length; j++)
//    {
//        if (mas[j]> mas[j])
//        {
//            int temp = mas[i];
//            mas[i] = mas[j];
//            mas[j] = temp;
//        }
//    }
//}
//foreach (int i in mas)  { Console.Write($"{i}");
//    Console.WriteLine();

//try
//{
//    Console.Write("Введите размер массива:");
//    int n = int.Parse(Console.ReadLine());
//    int[] mas = new int[n];
//    Random rnd = new Random();
//    int p = 1;
//    for (int i = 0; i < mas.Length; int++)
//    {
//        mas[i] = rnd.Next(-13, 12);
//        Console.Write($"{mas[i]}");
//        if (i % 2 != 0) p* mas[i];
//    }
//    Console.Write($"s={p}");
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}

//string? text = "Sam";
//string name = text ?? "Tom";
//Console.WriteLine(name);

//int? id = null;
//int personId = id ?? 1;
//Console.WriteLine(personId);


//try {
//    Console.Write("Введите дробное двоичное число: ");
//    string input = Console.ReadLine()!;
//    int dotIndex = input.IndexOf('.');
//    string intPart = dotIndex == -1 ? input : input.Substring(0, dotIndex);
//    string fracPart = dotIndex == -1 ? "" : input.Substring(dotIndex + 1);

//    while (intPart.Length % 3 != 0)
//    {
//        intPart = "0" + intPart;
//    }
//    while (fracPart.Length % 3 != 0)
//    {
//        fracPart = fracPart + "0";
//    }

//    Console.Write("Восьмеричное число: ");
//    bool isFirstNonZeroFound = false;
//    for (int i = 0; i < intPart.Length; i += 3)
//    {
//        int val = (intPart[i] - '0') * 4 + (intPart[i + 1] - '0') * 2 + (intPart[i + 2] - '0') * 1;

//        if (val != 0 || isFirstNonZeroFound || i == intPart.Length - 3)
//        {
//            Console.Write(val);
//            isFirstNonZeroFound = true;
//        }
//    }
//    if (fracPart.Length > 0)
////    {
////        Console.Write(".");
//for (int i = 0; i < fracPart.Length; i += 3)
//{
//int val = (fracPart[i] - '0') * 4 + (fracPart[i + 1] - '0') * 2 + (fracPart[i + 2] - '0') * 1;
//Console.Write(val);
//}
//    }

//    Console.WriteLine();
//}
//catch (Exception e)
//////{
////    Console.WriteLine($"Произошла ошибка: {e.Message}");
////}

//int[,] mas = new int[4, 4];
//for (int i = 0; i < mas.GetLength(0); i++)
//{
//    for (int j = 0; j < mas.GetLength(1); j++)
//    {
//        mas[i, j] = rnd.Next(-5, 6);
//        Console.Write($"{mas[i, j]}");
//    }
//    Console.WriteLine();
//}
////int min = mas[0, 0];

//Random rnd = new Random();
//int[,] mas = new int[rnd.Next(4, 9),rnd.Next(4, 9)];
//for (int i = 0; i < mas.GetLength(0); i++)
//{
//    for (int j = 0; j < mas.GetLength(1); j++)
//    {
//        mas[i, j] = rnd.Next(-3, 4);
//        Console.Write($"{mas[i, j]}");
//    }
//    Console.WriteLine();
//}
//int count = 0;
//for (int i = 0; i < mas.GetLength(0); i++) ;
//{
//    if (mas[int, 1] >  0) count++;
//}
//Console.WriteLine($"Количество отрицательных элементов во втором столбце {count}");

//30 вариарт средний уровень
//try
//{
//    Random rnd = new Random();
//    Console.Write("Введите количество строк:");
//    int n = int.Parse(Console.ReadLine()!);
//    Console.Write("Введите количество столбцов: ");
//    int m = int.Parse(Console.ReadLine()!);
//    int[,] mas = new int[n, m];
//    for (int i = 0; i < mas.GetLength(0); i++)
//    {
//        for (int j = 0; j < mas.GetLength(1); j++)
//        {
//            mas[i, j] = rnd.Next(1, 10);
//            Console.Write($"{mas[i, j]} ");
//        }
//        Console.WriteLine();
//    }
//    for (int i = 0; i < mas.GetLength(0); i++)
//    {
//        for (int j = 0; j < mas.GetLength(1); j++)

//            for (int j = 0; j < mas.GetLength(1); j++)
//            {
//                if (mas[i, j] > mas[i, k])
//        }
//    }
//}
//catch (Exception e)
////{
////    Console.WriteLine(e.Message);
////}

////30 вариант высокий уровень
//using System.Net.Security;
//I
//int[,] mas = new int[5, 5];
//for (int i = 0 i < mas.GetLength(0); i++)
//{
//    for (int j = 0 j < mas.GetLength(1); j++)
//    {
//        mas[i, j] = 1;
//    }
////}

//try
//{
//    Random rnd = new Random();
//    int rows = 5;
//    int cols = 4;
//    int[,] mas = new int[rows, cols];
//    for (int i = 0; i < rows; i++)
//    {
//        for (int j = 0; j < cols; j++)
//        {
//            mas[i, j] = rnd.Next(1, 50);
//        }
//    }
//}

//catch (Exception e)
//{
//    Console.WriteLine();
//}

Console.WriteLine("Слова, содержащие букву 'k':");

foreach (string word in words)
{
    bool hasK = false;

    foreach (char ch in word)
    {
        if (ch == 'k' || ch == 'K' || ch == 'к' || ch == 'К')
        {
            hasK = true;
            break;
        }
    }
}