using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam_BuySystem
{
    class BuySystem
    {
        private List<User> Users { get; }
        private List<Product> Products { get; }

        public BuySystem()
        {
            Users = new List<User>();
        }

        public void AddUser(User user)
        {
            Users.Add(user);
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public void BuyProduct(User user, Product product)
        {

        }

        public void AddCreditstoAccount(User user, double amount)
        {

        }

        public void ExecuteTransaction(Transaction transaction)
        {

        }

        public void GetProductByID()
        {

        }

        // TODO: Implement predicate
        public void GetUsers()
        {

        }

        public void GetUserByUsername(string username)
        {

        }

        public void GetTransactions(User user, int count)
        {

        }

        public void ActiveProducts()
        {

        }
    }
}
