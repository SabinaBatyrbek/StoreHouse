using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storehouse
{
    public class Store : IAccount,IProduct,Search
    {
        public string Address;
        public decimal Area;

        int _sum;

        public string NameProduct { get; set; }
        public Store(string Name, int sum)
        {
            NameProduct = Name;
            _sum = sum;

        }
        public int CurrentSum { get { return _sum; } }
        public void Put(int sum)
        {
            _sum += sum;
        }

        public void Search(int num)
        {
            throw new NotImplementedException();
        }
    }
}
