using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storehouse
{
    public class Fluid : Product, IStore
    {
        
        public void Add()
        {
            Console.WriteLine("Добавить жидкий товар");
        }

        public override void Description()
        {
            Console.WriteLine("Жидкие товары");
        }
    }
}
