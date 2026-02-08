using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons_5_6
{
    class Transport
    {
        public double Speed { get; set; }
        public string Name { get; set; }

        public Transport(double speed, string name) 
        {
            Speed = speed;
            Name = name;
        }

        public virtual void Move()
        {
            Console.WriteLine("Транспорт движется");
        }
    }

    class Car : Transport {
        public Car(double speed, string name): base(speed, name) {}

        public override void Move()
        {
            Console.WriteLine($"Машина едет со скоростью {Speed}");
        }
    }

    class Bicycle : Transport
    {
        public Bicycle(double speed, string name) : base(speed, name) { }

        public override void Move()
        {
            Console.WriteLine($"Велосипед едет со скоростью {Speed}");
        }
    }
}
