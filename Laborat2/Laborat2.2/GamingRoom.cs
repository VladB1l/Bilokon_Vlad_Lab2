using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborat2._2
{
    class GamingRoom
    {
        public GamingRoom(int budget)
        {
            Budget = budget;
            Toys = new List<Toy>();
        }
        public List<Toy> Toys { get; set; }
        public int Budget { get; set; }

        public void BuyToy(Toy toy)
        {
            if (Budget>=toy.Price)
            {
                Budget -= toy.Price;
                Toys.Add(toy);
                Console.WriteLine($"Куплено iграшку '{toy.Name}' за {toy.Price}");
            }
            else if (Budget==0)
            {
                Console.WriteLine("Грошi закiнчилися");
            }
            else
            {
                Console.WriteLine("Невистачає грошей на цю iграшку.");
            }
        }

        public void SortPrice()
        {
            var Price =
            from p in Toys
            orderby p.Price
            select p;
            foreach (var item in Price)
                Console.WriteLine("  "+ item.Price + " " + item);
        }
        public void SortSize()
        {
            var Size =
            from p in Toys
            orderby p.Size
            select p;
            foreach (var item in Size)
                Console.WriteLine("  " + item);
        }
        public void FindToy(int price, int size)
        {

            foreach (var item in Toys)
            {
                if (price == item.Price && size == (int)item.Size) 
                {
                    Console.WriteLine("\nIграшку знайдено");
                    Console.WriteLine(item.Name,item.Price,item.Size);
                }
               
            }
        }
    }
}
