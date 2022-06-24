using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborat2
{
    class Car
    {
        public Car(string model, Engine engine)
        {
            Model = model;
            Gasoline = engine;
        }
        private string Model { get; set; }
        private Engine Gasoline { get; set; }
        private List<Wheel> wheels = new List<Wheel>();

        public void AddWheel(Wheel wheel)
        {
            wheels.Add(wheel);
        }

        private void PrintModel()
        {
            Console.WriteLine($"\nМарка автомобiля: {Model}");
        }
        private void GasolineChek()
        {
            if (Gasoline.Gasoline<= 0) 
            {
                Console.WriteLine("Немає бензину!!! ");
                Console.WriteLine("Заправляємося....");
                Gasoline.Gasoline = 55;
            }
        }
        private void ChangeWheels()
        {
            foreach (var item in wheels)
            {
                if (item.wheel==false)
                {
                    Console.WriteLine($"Колесо {item.Side} пошкоджено! Зараз змiнимо");
                    item.wheel = true;
                }
            }
        }

        public void Drive()
        {
            PrintModel();
            Engine.Start();
            ChangeWheels();
            GasolineChek();

            Console.WriteLine($"У автомобiля достатньо бензину {Gasoline.Gasoline}L ,немає проблем з колесами, вiн завiвся та поїхав.");
        }

    }
    class Wheel
    {
        public Wheel(Side side, bool wheel)
        {
            this.wheel = wheel;
            Side = side;
        }
        public bool wheel { get; set; }
        public Side Side { get;set; }
    }

    public enum Side{LeftForward, RigthForward,LeftBack,RigthBack};

    class Engine
    {
        public Engine(double Gasoline)
        {
            this.Gasoline = Gasoline;
        }
        public double Gasoline { get; set; }

        public static void Start()
        {
            Console.WriteLine("Заводимо двигун автомобiля.");
        }
    }

    class Program1
    {
        static void Main(string[] args)
        {
            string model = "Ferrari";
            Console.WriteLine("Введiть кiлькiсть бензину (у лiтрах)");
            double gasoline = Convert.ToInt32(Console.ReadLine());
            var engine = new Engine(gasoline);
            var car = new Car(model, engine);
            var wheel1 = new Wheel(Side.LeftForward, false);
            var wheel2 = new Wheel(Side.RigthForward, true);
            var wheel3 = new Wheel(Side.LeftBack, true);
            var wheel4 = new Wheel(Side.RigthBack, false);
            car.AddWheel(wheel1);
            car.AddWheel(wheel2);
            car.AddWheel(wheel3);
            car.AddWheel(wheel4);



            car.Drive();
        }
    }
}
