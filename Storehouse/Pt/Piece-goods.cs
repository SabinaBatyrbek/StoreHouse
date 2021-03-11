using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storehouse
{
    public class Piece_goods : Product
    {
        public override void Description()
        {
            Console.WriteLine("Штучные товары");
        }
    }
}
