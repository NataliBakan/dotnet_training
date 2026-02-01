// 1
using Lessons_3_4;
using Lessons_3_4.Enums;
using System.Text.RegularExpressions;

int CountVowels(string text)
{
    string vowels = "аеёиоуыэюя";


    int count = 0;

    foreach (var letter in text)
    {
        if (vowels.Contains(char.ToLower(letter)))
        {
            count += 1;
        }
    }

    return count;
}

Console.WriteLine(CountVowels("Привет"));
Console.WriteLine(CountVowels("Овсянка"));
Console.WriteLine(CountVowels(""));

// 2
string ReverseWords(string text)
{
    string[] words = text.Split(" ");
    Array.Reverse(words);



    return string.Join(" ", words);
}

Console.WriteLine(ReverseWords("Я изучаю Шарпы"));

// 3
var geometryHelper = new GeometryHelper();
Console.WriteLine(geometryHelper.RectangleArea(5, 3));

// 4 
bool IsValidPassword(string password)
{
    if (password.Length < 8)
    {
        return false;
    }    

    return Regex.IsMatch(password, @"\d") && Regex.IsMatch(password, @"[A-Z]");
}

Console.WriteLine(IsValidPassword("F8ersff"));
Console.WriteLine(IsValidPassword("qersff122ewewe"));
Console.WriteLine(IsValidPassword("qersff122eweW"));

// 5
string Greet(string name, int hour)
{
    string greeting;
    if (hour < 0 || hour > 23) {
        return "Некорректное время";
    }

    if (hour >= 0 && hour <= 5) {
        greeting = "Доброй ночи";
    }
    else if (hour > 5 && hour <= 11)
    {
        greeting = "Доброе утро";
    }
    else if (hour > 11 && hour <= 17)
    {
        greeting = "Добрый день";
    }
    else
    { 
        greeting = "Добрый вечер";
    }

    return $"{greeting}, {name}";
}

Console.WriteLine(Greet("Natali", 12));
Console.WriteLine(Greet("Vlad", 3));
Console.WriteLine(Greet("Artem", 30));

// 6

bool IsWeekend(Day day) {
    return day == Day.SATURDAY || day == Day.SUNDAY; ;
}

Console.WriteLine(IsWeekend(Day.SUNDAY));
Console.WriteLine(IsWeekend(Day.MONDAY));

// 7
bool IsPassed(Grade grade)
{
    return (int)grade >= 3;
}

Console.WriteLine(IsPassed(Grade.F));
Console.WriteLine(IsPassed(Grade.A));
Console.WriteLine(IsPassed(Grade.C));

// 8
Direction Opposite(Direction direction)
{
    switch (direction)
    {
        case Direction.NORTH:
            return Direction.SOUTH;
        case Direction.SOUTH:
            return Direction.NORTH;
        case Direction.EAST:
            return Direction.WEST;
        case Direction.WEST:
            return Direction.EAST;
        default:
            return Direction.WEST;
    }
}

Console.WriteLine(Opposite(Direction.EAST));
Console.WriteLine(Opposite(Direction.NORTH));

// 9
Book book = new Book("Ядро и IPS", "Л.Н. Лазарев", 1869, 420);
Console.WriteLine(book.GetInfo());

// 10
Student ivan = new Student("Иван", 51, 4.7);
Student petr = new Student("Петр", 10, 3.9);
Console.WriteLine(ivan.IsExcellent());
Console.WriteLine(petr.IsExcellent());

// 11 
Rectangle rect1 = new Rectangle(10, 3);
Rectangle rect2 = new Rectangle(4, 4);
Console.WriteLine($"Rectangle: width={rect1.Width}; height={rect1.Height}");
Console.WriteLine(rect1.GetPerimeter());
Console.WriteLine(rect1.GetArea());
Console.WriteLine(rect1.IsSquare());
Console.WriteLine($"Rectangle: width={rect2.Width}; height={rect2.Height}");
Console.WriteLine(rect2.GetPerimeter());
Console.WriteLine(rect2.GetArea());
Console.WriteLine(rect2.IsSquare());

// 12 
Calculator calculator = new Calculator();
Console.WriteLine(calculator.Multiply(2, 5));
Console.WriteLine(calculator.Multiply(2.5, 10));
Console.WriteLine(calculator.Multiply(3, 3, 5));