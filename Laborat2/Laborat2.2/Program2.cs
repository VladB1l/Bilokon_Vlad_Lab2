using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborat2._2
{
    class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть сумму грошей, яка видiлена на купiвлю iграшок:");
            int budget = Convert.ToInt32(Console.ReadLine());
            var gamingRoom = new GamingRoom(budget);

            var ball = new Ball(50,"Невеликий М'яч", ToySize.Medium);
            var doll = new Doll(70,"Маленька Лялька", ToySize.Small);
            var cube = new Cube(30,"Маленький Кубик", ToySize.Small);
            var car = new Car(100,"Велика Машинка", ToySize.Big);

            Console.Clear();
            Console.WriteLine("1. Невеликий М'яч(50) ;");
            Console.WriteLine("2. Маленька Лялька(70);");
            Console.WriteLine("3. Маленький Кубик(30);");
            Console.WriteLine("4. Велика Машинка(100);");
            Console.WriteLine("5. Нiчого бiльше не купляти;");
            while (true)
            {
                Console.WriteLine("Введiть iграшку яку хочете купити:");
                int n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        gamingRoom.BuyToy(ball);
                        break;

                    case 2:
                        gamingRoom.BuyToy(doll);
                        break;

                    case 3:
                        gamingRoom.BuyToy(cube);
                        break;

                    case 4:
                        gamingRoom.BuyToy(car);
                        break;

                    case 5:
                        break;

                    default:
                        Console.WriteLine("Немає такої iграшки!");
                        break;
                }
                if (n == 5) 
                {
                    break;
                }
                Console.WriteLine($"Залишилось грошей: {gamingRoom.Budget}\n");
            }
            Console.WriteLine("Список придбаних iграшок:");
            Console.Write("[");
            foreach (var item in gamingRoom.Toys)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("]");

            Console.WriteLine("\nВiдсортований список придбаних iграшок по цiнi:");
            gamingRoom.SortPrice();
            Console.WriteLine("\nВiдсортований список придбаних iграшок по розмiру:");
            gamingRoom.SortSize();
            Console.WriteLine("Введiть данi iграшки, яку хочете знайти");
            Console.WriteLine("Введiть цiну iграшки");
            int Fprice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введiть розмiр iграшки  (1-Велика, 2-Середня, 3-Маленька)");
            int Fsize = Convert.ToInt32(Console.ReadLine());
            gamingRoom.FindToy( Fprice, Fsize);
            Console.WriteLine("\nКiнець програми.");
        }

    }
}
