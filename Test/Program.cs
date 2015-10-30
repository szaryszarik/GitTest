using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes =
            {
                new Square(5, "Square #1"),
                new Circle(3, "Circle #1"),
                new Rectangle(4,5,"Rectangle #1")
            };

            Console.WriteLine("Shapes Collection");
            foreach (Shape s in shapes)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }
    }

    class Person
    {
        private string myName = "N/A";
        private int myAge = 0;

        public string Name
        {
            get
            {
                return myName;
            }
            set
            {
                myName = value;
            }
        }

        public int Age
        {
            get
            {
                return myAge;
            }
            set
            {
                myAge = value;
            }
        }

        public override string ToString()
        {
            return "Name = " + Name + ", Age = " + Age;
        }
    }
}
