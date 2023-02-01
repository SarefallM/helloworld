using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;

namespace ConsoleApp1
{
     class Dog: IAnimal
    {
        public float Age { get; set; }
        public float Weight { get; set; }
        public string Name { get; set; }
        public float Food { get; set; }

        public float Calculation()
        {
            return  132* Weight * Age / 100;
        }
    }
    class Cat : IAnimal
    {
        public float Age { get; set; }
        public float Weight { get; set; }
        public float Food { get; set; }
        public string Name { get; set; }

        public float Calculation()
        {
            return 125*Weight*Age / 120;
        }
    }
}
