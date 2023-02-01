using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface IAnimal
    {
        public float Age { get; set; }
        public float Weight { get; set; }
        public float Food { get; set; }
        public string Name { get; set; }
        float Calculation();
    }
}
