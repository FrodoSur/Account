using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Recording
    {
        public DateTime datePurchase;
        public int idPurchase;
        public int amount;
        public bool hasCard;
        public int overallCost;

        public Recording(object datePurchase,object idPurchase,object amount,object hasCard)
        {
            this.datePurchase = (DateTime)datePurchase;
            this.idPurchase = int.Parse(idPurchase.ToString());
            this.amount = int.Parse(amount.ToString());
            this.hasCard = (bool)hasCard;
        }
        public void CountOverAllCost(int cost)
        {
            overallCost = cost * amount;
        }
    }
}
