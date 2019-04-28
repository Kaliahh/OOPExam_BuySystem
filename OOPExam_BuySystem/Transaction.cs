using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
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

    abstract class Transaction : ITransaction
    {
        public int ID { get; }
        public User User { get; }
        public DateTime Date { get; }
        public double Amount { get; }

        public Transaction(int id, ref User user, DateTime date, double amount)
        {
            ID = id;
            
            if (user != null)
            {
                User = user;
            }

            else
            {
                throw new TransactionUserNullException("Transaction user was null");
            }

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
        public InsertCashTransaction(int id, ref User user, DateTime date, double amount) : base(id, ref user, date, amount)
        {
            
        }

        public override void Execute()
        {
            User.Balance += Amount;
        }

        public override string ToString()
        {
            return string.Format($"{Date} | {ID} | Deposit | {User.ToString()} | {Amount}");
        }
    }

    class BuyTransaction : Transaction
    {
        public Product Product;

        public BuyTransaction(int id, ref User user, DateTime date, double amount, Product product) : base(id, ref user, date, amount)
        {
            if (product == null)
            {
                throw new BuyTransactionProductNullException("Buy transaction product was null", ID);
            }

            else if (product.Active == false)
            {
                throw new BuyTransactionProductNotActiveException("Buy transaction product was not active", ID);
            }

            else
            {
                Product = product;
            }

            Product = product;
        }

        public override void Execute()
        {
            if (User.Balance - Product.Price < 0)
            {
                throw new InsufficientCreditsException("User did not have sufficient credits", User, Product);
            }

            else
            {
                User.Balance -= Product.Price;
            }
        }

        public override string ToString()
        {
            return string.Format($"{Date} | {ID} | Purchase | {User.ToString()} | {Amount} | {Product.ToString()}");
        }
    }

    [Serializable]
    internal class TransactionUserNullException : Exception
    {
        public TransactionUserNullException()
        {
        }

        public TransactionUserNullException(string message) : base(message)
        {
        }

        public TransactionUserNullException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected TransactionUserNullException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }

    [Serializable]
    internal class BuyTransactionProductNotActiveException : Exception
    {
        private string message;
        private int ID;

        public BuyTransactionProductNotActiveException()
        {
        }

        public BuyTransactionProductNotActiveException(string message) : base(message)
        {
        }

        public BuyTransactionProductNotActiveException(string message, int ID)
        {
            this.message = message;
            this.ID = ID;
        }

        public BuyTransactionProductNotActiveException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected BuyTransactionProductNotActiveException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }

    [Serializable]
    internal class BuyTransactionProductNullException : Exception
    {
        private string message;
        private int ID;

        public BuyTransactionProductNullException()
        {
        }

        public BuyTransactionProductNullException(string message) : base(message)
        {
        }

        public BuyTransactionProductNullException(string message, int ID)
        {
            this.message = message;
            this.ID = ID;
        }

        public BuyTransactionProductNullException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected BuyTransactionProductNullException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }

    [Serializable]
    internal class InsufficientCreditsException : Exception
    {
        private string message;
        private User user;
        private Product product;

        public InsufficientCreditsException()
        {
        }

        public InsufficientCreditsException(string message) : base(message)
        {
        }

        public InsufficientCreditsException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public InsufficientCreditsException(string message, User user, Product product)
        {
            this.message = message;
            this.user = user;
            this.product = product;
        }

        protected InsufficientCreditsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
