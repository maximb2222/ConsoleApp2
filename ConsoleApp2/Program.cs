//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        int x = 10;
//        int y = 0;

//        try
//        {
//            if (y == 0)
//                throw new DivideByZeroException("Деление на ноль невозможно.");
//            int z = x / y;
//            Console.WriteLine(z);
//        }
//        catch (DivideByZeroException ex)
//        {
//            Console.WriteLine($"Ошибка: {ex.Message}");
//        }
//    }
//}


//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        int x = 11; 
//        Console.WriteLine(x);
//    }
//}



//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        string s = "Hello"; 
//        int x = s.Length;   
//        Console.WriteLine(x); 
//    }
//}


//using System;

//class Program
//{
//    enum DayOfWeek
//    {
//        Monday,
//        Tuesday,
//        Wednesday,
//        Thursday,
//        Friday,
//        Saturday,
//        Sunday
//    }

//    static void PrintDayInRussian(DayOfWeek day)
//    {
//        string dayInRussian = day switch
//        {
//            DayOfWeek.Monday => "Понедельник",
//            DayOfWeek.Tuesday => "Вторник",
//            DayOfWeek.Wednesday => "Среда",
//            DayOfWeek.Thursday => "Четверг",
//            DayOfWeek.Friday => "Пятница",
//            DayOfWeek.Saturday => "Суббота",
//            DayOfWeek.Sunday => "Воскресенье",
//            _ => "Неизвестный день"
//        };

//        Console.WriteLine(dayInRussian);
//    }

//    static void Main(string[] args)
//    {
//        PrintDayInRussian(DayOfWeek.Monday);    
//        PrintDayInRussian(DayOfWeek.Sunday);    
//    }
//}

//using System;

//class Program
//{
//    enum Color
//    {
//        Red,
//        Green,
//        Blue,
//        Yellow,
//        Cyan,
//        Magenta
//    }

//    static string GetHexCode(Color color)
//    {
//        return color switch
//        {
//            Color.Red => "#FF0000",
//            Color.Green => "#00FF00",
//            Color.Blue => "#0000FF",
//            Color.Yellow => "#FFFF00",
//            Color.Cyan => "#00FFFF",
//            Color.Magenta => "#FF00FF",
//            _ => "#000000" 
//        };
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine(GetHexCode(Color.Red));     
//        Console.WriteLine(GetHexCode(Color.Cyan));    
//    }
//}


//using System;

//class Program
//{
//    enum Operation
//    {
//        Add,
//        Subtract,
//        Multiply,
//        Divide
//    }

//    static double PerformOperation(double a, double b, Operation operation)
//    {
//        return operation switch
//        {
//            Operation.Add => a + b,
//            Operation.Subtract => a - b,
//            Operation.Multiply => a * b,
//            Operation.Divide => b != 0 ? a / b : throw new DivideByZeroException("Деление на ноль невозможно."),
//            _ => throw new InvalidOperationException("Неизвестная операция.")
//        };
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine(PerformOperation(10, 5, Operation.Add));       
//        Console.WriteLine(PerformOperation(10, 5, Operation.Subtract));  
//        Console.WriteLine(PerformOperation(10, 5, Operation.Multiply));  
//        Console.WriteLine(PerformOperation(10, 5, Operation.Divide));    
//    }
//}
