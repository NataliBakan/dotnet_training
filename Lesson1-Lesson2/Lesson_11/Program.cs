namespace Lesson_11
{
    internal class Program
    {
        public record Employee(string Name, int Id, string Department, decimal Salary = 500)
        {
            public Employee Promote(Employee emp, decimal bonus)
            {
                return emp with { Salary = emp.Salary + bonus };
            }
        }

        async static Task<string> GetDataAsync(string sourceName, int delayMs)
        {
            await Task.Delay(delayMs);
            return $"Данные от {sourceName}";
        }

        static async Task Main(string[] args)
        {
            // 1
            var employee1 = new Employee("Ivan", 1, "IT");
            var employee2 = new Employee("Ivan", 1, "IT");

            Console.WriteLine(employee1 == employee2);
            Console.WriteLine(employee1.Equals(employee2));

            // 2 
            var employee3 = new Employee("Petr", 2, "Sales", 1000);
            var employee4 = employee3.Promote(employee3, 200);
            Console.WriteLine(employee3.Salary);
            Console.WriteLine(employee4.Salary);

            // 3
            var taskA = GetDataAsync("Task A", 3000);
            var taskB = GetDataAsync("Task B", 1000);

            var winner = await Task.WhenAny(taskA, taskB);
            Console.WriteLine(winner.Result);
        }
    }
}
