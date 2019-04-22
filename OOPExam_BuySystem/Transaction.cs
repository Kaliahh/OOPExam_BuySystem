using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam_BuySystem
{
    interface ITransaction
    {
        int ID { get; }
        User User { get; }
        DateTime Date { get; }
        double Amount { get; }

        void Execute();
        string ToString();
    }

    abstract class Transaction
    {
        protected int ID { get; }
        protected User User { get; }
        protected DateTime Date { get; }
        protected double Amount { get; }

        public Transaction(int id, User user, DateTime date, double amount)
        {
            ID = id;
            User = user;
            Date = date;
            Amount = amount;
        }

        abstract public void Execute();

        public override string ToString()
        {
            return string.Format("{0} | {1}, {2}, {3}", Date, ID, User.ToString(), Amount);
        }
    }

    class InsertCashTransaction : Transaction
    {

        public InsertCashTransaction(int id, User user, DateTime date, double amount) : base(id, user, date, amount)
        {
            
        }

        public override void Execute()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return string.Format($"{Date} | {ID} | Deposit | {User.ToString()} | {Amount}");
        }
    }

    class BuyTransaction : Transaction
    {
        public BuyTransaction(int id, User user, DateTime date, double amount) : base(id, user, date, amount)
        {

        }

        public override void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
