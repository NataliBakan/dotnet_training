// 1
using System;

int score = 3;
int Score = 42;
int SCORE = 1;

Console.WriteLine(score);
Console.WriteLine(Score);
Console.WriteLine(SCORE);

// 2 
string name = "Бакштай Виталий";
int age = 25;
bool isStudent = true;

Console.WriteLine(name);
Console.WriteLine(age);
Console.WriteLine(isStudent);

// 3 
string str = "Он сказал: \"Привет\n\tМир!\"";

Console.WriteLine(str);

// 4
byte b = 255;
sbyte sb = 127;
short sh = 32767;
ushort us = 65535;
int i = 2147483647;
uint ui = 4294967295;
long l = 9223372036854775807;
ulong ul = 18446744073709551615;

// 5
var lang = "C#";
var year = 2026;
var sign = '!';

//6
//int age2 = Convert.ToInt32(Console.ReadLine());
//double weight = Convert.ToDouble(Console.ReadLine());
//decimal salary = Convert.ToDecimal(Console.ReadLine());

//7 
int a = 300;
byte ba = (byte)a;
Console.WriteLine(ba);

try
{
    int ba2 = checked((byte)a);
    Console.WriteLine(ba2);
}
catch (OverflowException ex)
{
    Console.WriteLine(ex.Message);
}

// 8
int x = 42;
object o = x;

int newX = (int)o;

Console.WriteLine(x);
Console.WriteLine(o);
Console.WriteLine(newX);

// 9 
string s = "123";
int number = int.Parse(s);

Console.WriteLine(number);

// 10
object obj = "Hello";
if (obj is string) {
    Console.WriteLine(obj);
}
var a2 = obj as string;
if (a2 != null) {
    Console.WriteLine(a2);
}

// 11
//Console.WriteLine("Enter number:");
//int number1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter another number:");
//int number2 = Convert.ToInt32(Console.ReadLine());

//if (number1 > number2)
//{
//    Console.WriteLine(number1);
//}
//else if (number2 > number1)
//{
//    Console.WriteLine(number2);
//}
//else {
//    Console.WriteLine("Numbers are equal!!!");
//}

// 12
//Console.WriteLine("Enter number:");
//int num = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(num > 0 ? "Положительное" : "Не положительное");

//13
//Console.WriteLine("Enter grade:");
//int grade = Convert.ToInt32(Console.ReadLine());

//switch (grade) {
//    case 5:
//        Console.WriteLine("Отлично");
//        break;
//    case 4:
//        Console.WriteLine("Хорошо");
//        break;
//    case 3:
//        Console.WriteLine("Удовлетворительно");
//        break;
//    case 2:
//    case 1:
//        Console.WriteLine("Неудовлетворительно");
//        break;
//    default:
//        Console.WriteLine("Неверная оценка");
//        break;
//}

// 14
int sum = 0;
for (int t = 0; t < 100; t++) 
{
    if (t % 2 == 1) {
        sum +=t;
    }
}

Console.WriteLine(sum);

// 15
double[] array = { 2.3, 1.4, 1.42, 5, 7};
Console.WriteLine(array.Length);
Console.WriteLine(array[2]);

// 16 
string[] fruits = { "apple", "BANANA", "Cherry" };
foreach (var fruit in fruits) 
{
    Console.WriteLine(fruit.ToLower());
}