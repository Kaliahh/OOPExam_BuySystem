using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam_BuySystem
{
    class Product
    {
        public int ID { get; }
        public string Name { get; }
        public double Price { get; }
        public bool Active { get; set; }
        public bool CanBeBoughtOnCredit { get; }

        public Product(int id, string name, double price, bool active, bool canBeBoughtOnCredit)
        {
            if (id >= 1)
            {
                ID = id;
            }

            else
            {
                throw new ProductIDNotValidException("Product ID cannot be less than 1");
            }


            if (name != null)
            {
                Name = name;
            }

            else
            {
                throw new ProductNameNotValidException("Product name cannot be null");
            }


            if (price >= 0)
            {
                Price = price;
            }

            else
            {
                throw new ProductPriceNotValidException("Product price cannot be less than 0");
            }

            Active = active;
            CanBeBoughtOnCredit = canBeBoughtOnCredit;
        }

        public override string ToString()
        {
            return string.Format($"{ID} | {Name} | {Price}");
        }

        public void Deactivate()
        {

        }
    }

    [Serializable]
    internal class ProductPriceNotValidException : Exception
    {
        public ProductPriceNotValidException()
        {
        }

        public ProductPriceNotValidException(string message) : base(message)
        {
        }

        public ProductPriceNotValidException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ProductPriceNotValidException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }

    [Serializable]
    internal class ProductNameNotValidException : Exception
    {
        public ProductNameNotValidException()
        {
        }

        public ProductNameNotValidException(string message) : base(message)
        {
        }

        public ProductNameNotValidException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ProductNameNotValidException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }

    [Serializable]
    internal class ProductIDNotValidException : Exception
    {
        public ProductIDNotValidException()
        {
        }

        public ProductIDNotValidException(string message) : base(message)
        {
        }

        public ProductIDNotValidException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ProductIDNotValidException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
