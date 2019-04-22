using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam_BuySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            BuySystem buySystem = new BuySystem();

            User user = new User(1234, "Noget", "Andet", "HEJSA", "noget@andet", 67);
            buySystem.AddUser(user);

            SeasonalProduct product = new SeasonalProduct(45345, "Apple", 7.4, true, true, DateTime.Now, new DateTime(2022, 4, 30));

            Console.WriteLine(product.ToString());

            //Transaction transaction = new Transaction(5645645, user, DateTime.Now, 78);

            //Console.WriteLine(transaction.ToString());

            Console.ReadKey();
        }
    }
}
