using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storehouse
{
    public abstract class Product:IStore
    {
        public string name;
        public decimal SKUcode;
        public decimal price;

        public void Add()
        {
            Console.WriteLine("Добавить товар");
        }

        public void Count()
        {
            Console.WriteLine(price);
        }

        public abstract void Description();

        public void Put(int sum)
        {
            throw new NotImplementedException();
        }

        public void Search()
        {
            Console.WriteLine("Пойск по SKU");
        }

      
    }
}
