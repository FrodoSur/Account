using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Product
    {
        public int id;
        public int cost;
        public string name;

        public Product(object id, object cost, object name)
        {
            this.id = int.Parse(id.ToString());
            this.cost = int.Parse(cost.ToString());
            this.name = name.ToString();
        }
    }
}
