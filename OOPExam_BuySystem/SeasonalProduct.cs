using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam_BuySystem
{
    class SeasonalProduct : Product
    {
        DateTime SeasonStartDate { get; }
        DateTime SeasonEndDate { get; }

        public SeasonalProduct(int id, string name, double price, bool active, bool canBeBoughtOnCredit, DateTime seasonStartDate, DateTime seasonEndDate) : base(id, name, price, active, canBeBoughtOnCredit)
        {
            SeasonStartDate = seasonStartDate;
            SeasonEndDate = seasonEndDate;
        }

        public override string ToString()
        {
            return string.Format($"{ID} | {Name}, {Price} | {SeasonStartDate}, {SeasonEndDate}");
        }
    }
}
