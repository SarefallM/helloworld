using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;

namespace ConsoleApp1
{
    public class SearchInfo
    {
        internal void InfoCat(IEnumerable<Cat> cats)
        {
            Console.WriteLine("\nВсе кошечки");
            foreach (var item in cats)
            {
                
                Console.WriteLine("Кличка {0},Возраст {1},Вес {2},Нужное количество корма {3}"
                    , item.Name, item.Age, item.Weight, item.Food);
            }
        }
        internal void InfoDog(IEnumerable<Dog> dogs)
        {
            Console.WriteLine("\nВсе песики");
            foreach (var item in dogs)
            {
                
                Console.WriteLine("Кличка {0},Возраст {1},Вес {2},Нужное количество корма {3}"
                    , item.Name, item.Age, item.Weight, item.Food);
            }
        }
        internal void InfoCatMax(IEnumerable<Cat> cats)
        {
           
           
            float m = cats.Max(x => x.Food);
            var i = cats.Where(x => x.Food == m);


            foreach (var item in i)
            {
                Console.WriteLine("\nКошечка которой нужно больше корма \n");
                Console.WriteLine("Кличка {0}", item.Name);
                Console.WriteLine("Возраст {0}", item.Age);
                Console.WriteLine("Вес {0}", item.Weight);
                Console.WriteLine("Нужное количество корма {0}\n", item.Food);
            }

        }
        internal void InfoDogMax(IEnumerable<Dog> dogs)
        {
            float m = dogs.Max(x => x.Food);
            var i = dogs.Where(x => x.Food == m);

            foreach (var item in i)
            {
                Console.WriteLine("\nПесик которому нужно больше корма\n");
                Console.WriteLine("Кличка {0}", item.Name);
                Console.WriteLine("Возраст {0}", item.Age);
                Console.WriteLine("Вес {0}", item.Weight);
                Console.WriteLine("Нужное количество корма {0}", item.Food);
            }

        }

    }
}
