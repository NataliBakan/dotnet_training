using Lessons_5_6.Structures;

namespace Lessons_5_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1
            Point point = new Point(3, 4);

            Console.WriteLine(point.DistanceFromZero());

            // 2
            DayInfo info1 = new DayInfo(2, 7);
            DayInfo info2 = new DayInfo(-1, 10);
            DayInfo info3 = new DayInfo(32, 13);

            Console.WriteLine(info1.IsValid());
            Console.WriteLine(info2.IsValid());
            Console.WriteLine(info3.IsValid());

            // 3
            User user1 = new User();
            User user2 = new User();
            User user3 = new User();
            User user4 = new User();

            Console.WriteLine(User.TotalUsers);

            // 4
            Console.WriteLine(MathHelper.Add(3, 5));
            Console.WriteLine(MathHelper.Subtract(3, 5));
            Console.WriteLine(MathHelper.Multiply(3, 5));

            // 5
            var storage1 = new FileStorage();
            var storage2 = new MemoryStorage();

            storage1.Save("hello");
            storage2.Save("hello");

            // 6
            var stepCounter = new StepCounter();
            stepCounter.AddSteps(5);
            stepCounter.AddSteps(4);
            Console.WriteLine(stepCounter.GetSteps());
            stepCounter.Reset();
            Console.WriteLine(stepCounter.GetSteps());

            // 7 
            var car = new Car(100, "BMW");
            var bicycle = new Bicycle(30, "Aist");
            car.Move();
            bicycle.Move();

            // 8 
            Shape[] shapes = new Shape[] { new Rectangle(4, 5), new Circle(5), new Rectangle(1, 7) };

            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape.GetArea());
            }
        }
    }
}
