using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storehouse
{
    public class Bulk : Product
    {
        public override void Description()
        {
            Console.WriteLine("Сыпучие товары");
        }
    }
}
