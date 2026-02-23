using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons_9_10
{
    class Order
    {
        public int Id { get; set; }
        public List<int> Prices { get; set; }

        public Order(int id, List<int> prices)
        {
            Id = id;
            Prices = prices;
        }
    }
}
