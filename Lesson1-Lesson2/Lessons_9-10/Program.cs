namespace Lessons_9_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1
            List<int> numbers = new List<int> { 5, 12, 7, 20, 33, 18, 2, 40 };

            var newNumbers = numbers.Where(num => num % 2 == 0).OrderBy(num => num).Select(num => num * 3);

            foreach (var num in newNumbers)
            {
                Console.WriteLine(num);
            }

            // 2
            var products = new List<Product>()
            {
                new Product("Milk", 57, 20),
                new Product("Bread", 101, 30),
                new Product("Eggs", 114, 10),
                new Product("Wine", 263, 3),
                new Product("Chocolate", 92, 8),
            };

            var newProducts = products.Where(p => p.Price > 100).OrderByDescending(p => p.Price).Select(p => p.Name);

            foreach (var p in newProducts)
            {
                Console.WriteLine(p);
            }

            // 3
            var students = new List<Student>()
            {
                new Student(5),
                new Student(4),
                new Student(4),
                new Student(5),
                new Student(3),
                new Student(3),
                new Student(2),
                new Student(3),
                new Student(4),
                new Student(4),
            };

            var hasLessTree = students.Any(s => s.Grade < 3);
            var isAllMoreThree = students.Any(s => s.Grade < 4);
            var countFives = students.Count(s => s.Grade > 4);

            Console.WriteLine(hasLessTree);
            Console.WriteLine(isAllMoreThree);
            Console.WriteLine(countFives);

            // 4
            var sumEven = numbers.Where(num => num % 2 == 0).Sum();
            var max = numbers.Max();
            var average = numbers.Average();

            Console.WriteLine(sumEven);
            Console.WriteLine(max);
            Console.WriteLine(average);

            // 5
            var groups = numbers.GroupBy(n => n % 2);

            foreach (var group in groups)
            {
                Console.WriteLine(string.Join(", ", group));
            }

            // 6 
            var persons = new List<Person>()
            {
                new Person("Ivan", 20),
                new Person("Petr", 15),
                new Person("Maria", 12),
                new Person("Mick", 36),
                new Person("Oleg", 31),
            };

            var olderEighteen = persons.Where(p => p.Age > 18).OrderBy(p => p.Age).Select(p => p.Name);

            foreach (var p in olderEighteen)
            {
                Console.WriteLine(p);
            }

            // 7
            var firstOldMen = persons.FirstOrDefault(p => p.Age > 30);
            Console.WriteLine(firstOldMen != null ? firstOldMen.Name : "Такого не существует");

            // 8
            var hasLessTwentyFive = persons.Any(p => p.Age < 25);
            var isAllElderEighteen = persons.Any(p => p.Age <= 18);

            Console.WriteLine(hasLessTwentyFive);
            Console.WriteLine(isAllElderEighteen);

            // 9 
            List<string> words = new() { "Artem", "Natali", "Yana", "Yulia", "Alex" };
            var newWords = words.Where(w => w.Length > 4).OrderBy(w => w);

            foreach (var w in newWords)
            {
                Console.WriteLine(w);
            }

            // 10
            var newWords2 = words.Where(w => w.ToLower().Contains('a')).Select(w => w.ToUpper());

            foreach (var w in newWords2)
            {
                Console.WriteLine(w);
            }

            // 11
            List<int> numbers2 = new List<int> { 1, 2, 3, 4, 5, 1, 4, 2, 1, 5, 3, 3 };
            var uniqNumbers = numbers2.Distinct().OrderByDescending(w => w);

            foreach (var n in uniqNumbers)
            {
                Console.WriteLine(n);
            }

            // 12
            var orders = new List<Order>()
            {
                new Order(0, new List<int>() { 5, 10, 15 }),
                new Order(1, new List<int>() { 3, 10, 13 }),
                new Order(2, new List<int>() { 20, 40, 100 }),
            };

            var prices = orders.SelectMany(o => o.Prices);
            var maxPrice = prices.Max();

            foreach (var p in prices)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine(maxPrice);

            // 13
            Action<User> getUserInfo = (user) => Console.WriteLine($"Имя: {user.Name}, Возраст: {user.Age}");
            var user = new User("Ivan", 21);
            getUserInfo(user);

            // 14
            Action<string> log = (str) =>  Console.WriteLine(str.ToUpper());
            log("new massage");

            // 15
            Func<double, double, double> getAverage = (a, b) => (a + b) / 2;
            Console.WriteLine(getAverage(4, 7));
        }
    }
}
