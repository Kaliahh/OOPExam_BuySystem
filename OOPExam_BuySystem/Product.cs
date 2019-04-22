using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam_BuySystem
{
    class Product
    {
        protected int ID { get; }
        protected string Name { get; }
        protected double Price { get; }
        protected bool Active { get; }
        protected bool CanBeBoughtOnCredit { get; }

        public Product(int id, string name, double price, bool active, bool canBeBoughtOnCredit)
        {
            ID = id;
            Name = name;
            Price = price;
            Active = active;
            CanBeBoughtOnCredit = canBeBoughtOnCredit;
        }

        public override string ToString()
        {
            return string.Format($"{ID} | {Name} | {Price}");
        }
    }
}
