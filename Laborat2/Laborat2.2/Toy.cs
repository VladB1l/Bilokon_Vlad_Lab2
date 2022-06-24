using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborat2._2
{
    public enum ToySize
    {
        Big = 1,
        Medium,
        Small
    }
    class Toy
    {
        public int Price { get; set; }
        public  string Name { get; set; }
        public ToySize Size { get; set; }
        public Toy(int price, string name, ToySize size)
        {
            Price = price;
            Name = name;
            Size = size;
        }

        public override string ToString()
        {
            return String.Format("{0};  ", Name);
        }
    }
    class Ball : Toy
    {
        public Ball(int price, string name, ToySize size) : base( price, name,size)

        {

        }
    }

    class Car : Toy
    {
        public Car(int price, string name, ToySize size) : base(price, name,size)
        {

        }
    }

    class Doll : Toy
    {
        public Doll(int price, string name, ToySize size) : base(price, name, size)
        {

        }
    }

    class Cube : Toy
    {
        public Cube(int price, string name, ToySize size) : base(price, name,size)
        {

        }
    }

}
