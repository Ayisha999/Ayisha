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
////    }
////}

////catch (Exception e)
////{
////    Console.WriteLine();
////}

//Console.WriteLine("Слова, содержащие букву 'k':");

//foreach (string word in words)
//{
//    bool hasK = false;

//    foreach (char ch in word)
//    {
//        if (ch == 'k' || ch == 'K' || ch == 'к' || ch == 'К')
//        {
//            hasK = true;
////            break;
////        }
////    }
////}
//using System.Net.NetworkInformation;

//Random random-new Random();
//for (int i = 0 i < matrix.GetLength(0); i++)
//{
//    for (int j = 0; j < matrix.GetLength(1); j++)
//    {
//        matrix[i, j] = (char)random.Next(40, 70);
//        Console.Write(matrix[i, j] + " ");
//    }
//    Console.WriteLine();
//}
//int sum = 0;
//for (int i = 0; i < matrix.GetLength(0); i++)
//{
//    for (int j = 0; j < matrix.GetLength(1); j++)
//    {
//        if (char.IsDigit(matrix[i, j])) sum += int.Parse(matrix[i, j].ToString());
//    }
////}
////I
////Console.WriteLine("Sum=+sum");

////средний уровень 30 вариант
//char[] mas = new char[15];
//Console.Write("Введите строку: ");
//ing stroka Console.ReadLine()!;
//mas stroka.ToArray();
//Console.Write("Введите строку поиска:");
//string word = Console.ReadLine()!;
//int count = 0;
//int wordLength word.Length;
//for (int i = 0; i < mas.Length wordLength; i++)
//{
//    bool match = true;
//    for (int j = 0; j < wordLength; j++)
//    {
//        if (mas[i + j] != word[j])
//        {
//            match = false;
//            break;
//        }
//        if (match) count++;
//    }
//    Console.WriteLine($"Слово (word) встречается в массиве (count) раз.");

//using System.Text.RegularExpressions;
//string s = "Бык тупогуб, тупогубенький бычок, у быка губа бела была тупа";
//Regex regex = new Regex(@"туп(\w*)");
//MatchCollection matches = regex.Matches(s);
//if (matches.Count > 0)
//{
//}
//foreach (Match match in matches)
//    Console.WriteLine(match.Value);
//else Console.WriteLine("Нет совпадений");

//using System.Text.RegularExpressions;
//string s = "456-435-2318";
//string pattern = "[0-9]{3}-[0-9]{3}-[0-9]{4}$";

//if (Regex.IsMatch(s, pattern, RegexOptions.IgnoreCase))
//    Console.WriteLine("OK");
//else Console.WriteLine("No");

//using static = "daria@mail.ru"
//string s = "daria@mail.ru";
//string pattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!
//P
//\.))][-!#$%&'
//\*\+/=\?\^^\{\}\\~\w])*)(?<=[0-9a-z])@))" +
//@"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-
//z][- backslash w]*[ theta-9a-z]* backslash.)+ [a - z*theta - 9]\{2, 17\} ))\$^ u ;

//if (Regex.IsMatch(s, pattern, RegexOptions.IgnoreCase))
//    Console.WriteLine("OK");
//else Console.WriteLine("No");

////Задание 5 средний ур
//char[] charArray = "The quick brown fox jumps over the lazy dog and a kitten".ToCharArray();
//string text = new string(charArray);
//char[] separators = new char[] { ' ', ',', '.', '!', '?', '-', ';', ':' };
//string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
//Console.WriteLine($"Исходный текст: {text}");
//Console.WriteLine("\nСлова, содержащие букву 'k':");
//bool found = false;
//foreach (string word in words)
//{
//    if (word.Contains("k", StringComparison.OrdinalIgnoreCase))
//    {
//        Console.WriteLine($"- {word}");
//        found = true;
//    }
//}
//if (!found)
//{
//    Console.WriteLine("Слова с буквой 'k' не найдены.");
//}
//    }
//}

////базовый
//using System.Text.RegularExpressions;

//string pattern = "^ [A-Za-z]$";
//Console.WriteLine("Введите строку:");
//string text = Console.ReadLine();
//for (int i = 0; i < text.Length; i++)
//}
//if (Regex.IsMatch(text[i].ToString(), pattern))
//{
//    text = text.Remove(i, 1);
//    i--;
//}
//Console.WriteLine(text);

//try
//{
//    Console.Write("Введите а:");
//    double a double.Parse(Console.ReadLine()!);
//    Console.Write("Введите b:");
//    double b double.Parse(Console.ReadLine()!);
//    Console.WriteLine($"z={Max(D}");
//}
////double Max(double x, double y)
////catch(Exception e)
////{
////    Console.WriteLine(e.Message);
////}
//int[] mas1 = new int[8];
//int[] mas2 = new int[8];
//mas1 = GetMas(mas1);
//mas2 = GetMas(mas2);
//Print(mas1);
//Print(mas2)

////Задание 23 средний уровень
//using System;

//class Program
//{
//    double Integrand(double x)
//    {
//        return Math.Pow(x, 3) + 2 * Math.Pow(x, 2) - 1;
//    }
//    double CalculateIntegral(double a, double b, int n)
//    {
//        double h = (b - a) / n;
//        double sum = 0.0;
//        for (int i = 0; i < n; i++)
//        {
//            double xi = a + i * h;
//            sum += Integrand(xi);
//        }
//        return h * sum;
//    }
//    void Run()
//    {
//        double a = 1.0;
//        double b = 4.0;
//        double result10 = CalculateIntegral(a, b, 10);
//        double result100 = CalculateIntegral(a, b, 100);
//        Console.WriteLine($"Значение интеграла при n = 10:  {result10}");
//        Console.WriteLine($"Значение интеграла при n = 100: {result100}");
//    }
//    static void Main()
//    {
//        Program program = new Program(); 
//        program.Run(); 
//    }
//}

//namespace EmployeeContracts
//{
//    struct Employee
//    {
//        public string LastName;
//        public string Position;
//        public DateTime ContractDate;
//        public int ContractDurationYears;
//        public decimal Salary;
//        public void PrintInfo()
//        {
//            Console.WriteLine($"Фамилия: {LastName}, Должность: {Position}, " +
//                              $"Дата контракта: {ContractDate:dd.MM.yyyy}, " +
//                              $"Срок (лет): {ContractDurationYears}, Оклад: {Salary:C}");
//        }
//    }

//    class Program
//    {
//        static void Main()
//        {
//            DateTime oneYearAgo = DateTime.Now.AddYears(-1);
//            List<Employee> employees = new List<Employee>
//            {
//                new Employee
//                {
//                    LastName = "Иванов",
//                    Position = "Инженер",
//                    ContractDate = DateTime.Now.AddMonths(-6),
//                    ContractDurationYears = 2,
//                    Salary = 85000
//                },
//                new Employee
//                {
//                    LastName = "Петров",
//                    Position = "Менеджер",
//                    ContractDate = DateTime.Now.AddYears(-2),
//                    ContractDurationYears = 5,
//                    Salary = 70000
//                },
//                new Employee
//                {
//                    LastName = "Сидорова",
//                    Position = "Бухгалтер",
//                    ContractDate = DateTime.Now.AddDays(-100),
//                    ContractDurationYears = 1,
//                    Salary = 75000
//                }
//            };
//            Console.WriteLine("Работники, подписавшие контракт менее года назад:\n");
//            var recentEmployees = employees.Where(e => e.ContractDate > oneYearAgo);
//            foreach (var emp in recentEmployees)
//            {
//                emp.PrintInfo();
//            }
//        }
//    }
//}

////lab8
//using System.Data;
//DateTime datal = new DateTime();
//Console.WriteLine(datal);
//DateTime dateNow DateTime.Now;
//Console.WriteLine(dateNow);
//DateTime date2 = new DateTime(2026, 11, 21);
//Console.WriteLine(date2);
//DateTime date3 = new DateTime(2026, 11, 21, 12, 37, 45);
//Console.WriteLine(date3);
//Console.WriteLine(DateTime.Now);
//Console.WriteLine(DateTime.UtcNow);
//Console.WriteLine(DateTime.Today);
//Console.WriteLine(dateNow.Year);
//Console.WriteLine(dateNow.Month);
//Console.WriteLine(dateNow.Day);
//Console.WriteLine(dateNow.Date);
//Console.WriteLine(dateNow.Minute);
//Console.WriteLine(dateNow.Hour);
//Console.WriteLine(dateNow.Second);
//Console.WriteLine(dateNow.Millisecond);
//Console.WriteLine(dateNow.Second)

namespace TechSupportApp
{
    struct SupportRequest
    {
        public DateTime CallDate;
        public TimeSpan CallTime;
        public string Address;
        public string IssueType;
        public string Status;
        public int GetDayOfWeekNumber()
        {
            int day = (int)CallDate.DayOfWeek;
            return day == 0 ? 7 : day;
        }
        public void PrintInfo(bool showDayOfWeek = false)
        {
            string dayInfo = showDayOfWeek ? $" | День недели: {GetDayOfWeekNumber()}" : "";
            Console.WriteLine($"Дата: {CallDate:dd.MM.yyyy} | Время: {CallTime:hh\\:mm}{dayInfo}");
            Console.WriteLine($"Адрес: {Address}");
            Console.WriteLine($"Неисправность: {IssueType} | Статус: {Status}");
            Console.WriteLine(new string('-', 55));
        }
    }
    class Program
    {
        static void Main()
        {
            List<SupportRequest> requests = new List<SupportRequest>
            {
                new SupportRequest
                {
                    CallDate = DateTime.Today.AddDays(-5),
                    CallTime = new TimeSpan(10, 15, 0),
                    Address = "ул. Ленина, д. 12, кв. 45",
                    IssueType = "Нет доступа в интернет",
                    Status = "устранено"
                },
                new SupportRequest
                {
                    CallDate = DateTime.Today.AddDays(-2),
                    CallTime = new TimeSpan(14, 30, 0),
                    Address = "пр. Мира, д. 88, кв. 10",
                    IssueType = "Низкая скорость соединения",
                    Status = "ведутся работы"
                },
                new SupportRequest
                {
                    CallDate = DateTime.Today.AddDays(-1),
                    CallTime = new TimeSpan(18, 05, 0),
                    Address = "ул. Гагарина, д. 3, кв. 7",
                    IssueType = "Обрыв кабеля в подъезде",
                    Status = "в очереди"
                },
                new SupportRequest
                {
                    CallDate = DateTime.Today,
                    CallTime = new TimeSpan(09, 40, 0),
                    Address = "ул. Пушкина, д. 21, кв. 14",
                    IssueType = "Не работает роутер",
                    Status = "устранено"
                }
            };
            Console.WriteLine("все заявки (с номером недели)");
            foreach (var req in requests)
            {
                req.PrintInfo(showDayOfWeek: true);
            }
            Console.WriteLine("\n невыполненные заявки за последние 3 дня");
            DateTime threeDaysAgo = DateTime.Today.AddDays(-3);
            bool found = false;

            foreach (var req in requests)
            {
                bool isUnfinished = !req.Status.Equals("устранено", StringComparison.OrdinalIgnoreCase);
                bool isRecent = req.CallDate.Date >= threeDaysAgo && req.CallDate.Date <= DateTime.Today;

                if (isUnfinished && isRecent)
                {
                    req.PrintInfo(showDayOfWeek: false);
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("Подходящих заявок не найдено.");
            }
        }
    }
}