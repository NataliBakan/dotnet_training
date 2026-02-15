namespace Lessons_7_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1
            var person = new Person("Ivan", new DateTime(1990, 5, 26));
            Console.WriteLine(person.GetAge());

            // 2
            var workSession = new WorkSession(new DateTime(2026, 2, 3, 14, 56, 12), new DateTime(2026, 2, 12, 8, 1, 37));
            Console.WriteLine(workSession.GetDuration());
            Console.WriteLine(workSession.GetFormattedDuration());

            // 3 

            var students = new List<Student>()
            {
                new Student("Ivan", 4),
                new Student("Petr", 5),
                new Student("Mariya", 3),
                new Student("Olga", 5),
                new Student("Michail", 2),
                new Student("Nataliya", 3),
            };

            var excellentStudents = students.FindAll(student => student.Grade >= 4);

            foreach (var s in excellentStudents)
            {
                Console.WriteLine(s.Name);
            }

            // 4
            var booksDictionary = new Dictionary<int, Book>();

            var book1 = new Book(0, "Капитанская дочка", "Пушкин А.С.");
            var book2 = new Book(1, "Герой нашего времени", "Лермонтов М.Ю.");
            var book3 = new Book(2, "Мертвые души", "Гоголь Н.В.");
            var book4 = new Book(3, "Война и мир", "Толстой Л.Н.");


            booksDictionary.TryAdd(book1.Id, book1);
            booksDictionary.TryAdd(book2.Id, book2);
            booksDictionary.TryAdd(book3.Id, book3);
            booksDictionary.TryAdd(book4.Id, book4);


            if (booksDictionary.TryGetValue(3, out Book book))
            { 
                Console.WriteLine($"\"{book.Title}\" {book.Author}");
            }

            // 5
            var employeeDictionary = new Dictionary<int, List<Employee>>();

            var department1 = new Department(1, "IT");
            var department2 = new Department(2, "Sales");
            var department3 = new Department(3, "Marketing");

            var depOneEmployees = new List<Employee>()
            { 
                new Employee(11, "Petr"),
                new Employee(12, "Mariya"),
            };
            
            var depTwoEmployees = new List<Employee>()
            { 
                new Employee(21, "Nick"),
                new Employee(22, "Mick"),
                new Employee(23, "Olga"),
            };
            
            var depThreeEmployees = new List<Employee>()
            { 
                new Employee(31, "Victor"),
                new Employee(32, "Oleg"),
            };

            employeeDictionary.TryAdd(department1.Id, depOneEmployees);
            employeeDictionary.TryAdd(department2.Id, depTwoEmployees);
            employeeDictionary.TryAdd(department3.Id, depThreeEmployees);

            void GetDepartmentEmployees(int depId)
            {
                if (employeeDictionary.TryGetValue(depId, out List<Employee> employees))
                {
                    Console.WriteLine($"Сотрудники отдела №{depId}:");
                    foreach (var employee in employees)
                    {
                        Console.WriteLine(employee.Name);
                    }
                }
            }

            GetDepartmentEmployees(department1.Id);
            GetDepartmentEmployees(department3.Id);

            // 6
            var tasksList = new LinkedList<string>();
            tasksList.AddFirst("Запуск плагина Канбан");
            tasksList.AddFirst("Запуск редактора документов");
            tasksList.AddLast("Исправление багов");
            tasksList.AddLast("Тестирование");

            tasksList.RemoveFirst();

            foreach (var task in tasksList)
            {
                Console.WriteLine(task);
            }

            // 7
            var printJobQueue = new Queue<PrintJob>();
            printJobQueue.Enqueue(new PrintJob("Должностная инструкция", 12));
            printJobQueue.Enqueue(new PrintJob("Накладная", 5));
            printJobQueue.Enqueue(new PrintJob("Справка", 1));

            PrintJob job = printJobQueue.Dequeue();
            Console.WriteLine($"Печать документа \"{job.DocumentName}\" страниц: {job.Pages}");

            foreach (var doc in printJobQueue)
            {
                Console.WriteLine($"Документ \"{doc.DocumentName}\" страниц: {doc.Pages} - ожидает печати");
            }

            // 8
            var userActionStack = new Stack<UserActionHistory>();
            userActionStack.Push(new UserActionHistory("Зашел на страницу", new DateTime(2026, 2, 13, 15, 23, 52)));
            userActionStack.Push(new UserActionHistory("Открыл карточку товара", new DateTime(2026, 2, 13, 15, 25, 0)));
            userActionStack.Push(new UserActionHistory("Добавил товар в корзину", new DateTime(2026, 2, 13, 15, 29, 15)));

            userActionStack.Pop();

            foreach (var userAction in userActionStack)
            {
                Console.WriteLine($"{userAction.ActionName} в {userAction.Time}");
            }
        }
    }
}
