using Storehouse.Emp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storehouse
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Store store = new Store("SomeProduct", 200);
            store.Put(5);
            Console.WriteLine("Добавить продукт "+ store.NameProduct );
            Console.WriteLine("Указать  цену  "+  store.CurrentSum);
            Console.Read();

            Employee[] employees = new Employee[4];
            employees[0] = new Director();
            employees[1] = new Manage();
            employees[2] = new Worker();
            
            Product[] products = new Product[6];
            products[0] = new Fluid();
            products[1] = new Bulk();
            products[2] = new Goborite();
            products[3] = new Piece_goods();


            foreach(var p in products)
            {
                if (p is Fluid)
                {
                    Fluid fluid = (Fluid)p;
                    fluid.Add();
                }
                p.Description();   
            }

            
        }
    }
}
