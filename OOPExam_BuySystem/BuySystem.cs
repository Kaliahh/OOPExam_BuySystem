using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam_BuySystem
{
    class BuySystem
    {
        public List<User> Users { get; }
        public List<Product> ActiveProducts { get; }
        public List<Product> InActiveProducts { get; }

        public List<ITransaction> Transactions { get; } 

        public BuySystem()
        {
            Users = new List<User>();
            ActiveProducts = new List<Product>();
            InActiveProducts = new List<Product>();

            Transactions = new List<ITransaction>();
        }

        public void AddUser(User user)
        {

            try
            {
                Users.Add(user);
            }
            
            catch (FirstNameException e)
            {
                Console.WriteLine(e.Message);
            }

            catch (LastNameException e)
            {
                Console.WriteLine(e.Message);
            }

            catch (UserNameException e)
            {
                Console.WriteLine(e.Message);
            }

            catch (EmailException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void AddProduct(Product product)
        {
            try
            {
                // TODO: Skal lige gennemsøge InActiveProducts
                //if (InActiveProducts.Contains(product))
                //{
                //    ActiveProducts.Add(InActiveProducts.Find(product));
                //}

                ActiveProducts.Add(product);
            }

            catch (ProductIDNotValidException e)
            {
                Console.WriteLine(e.Message);
            }

            catch (ProductNameNotValidException e)
            {
                Console.WriteLine(e.Message);
            }

            catch (ProductPriceNotValidException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void DeactiveProduct(Product product)
        {
            ActiveProducts.Remove(product);
            product.Deactivate();

            InActiveProducts.Add(product);
        }

        public void ActivateProduct(Product product)
        {

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
        public void GetUsers(Func<User, bool> predicate)
        {

        }

        public void GetUserByUsername(string username)
        {

        }

        public void GetTransactions(User user, int count)
        {

        }
    }
}
