using OnlineshopDmain.Aggregates.UserManagment;
using OnlineshopDmain.Frameworks.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineshopDmain.Aggregates.Sale
{
    public class OrderHeader: IDbSetEntity
    {
        public Guid Id { get; set; }
        //public OnlineShopUser Seller { get; set; }
        //
        //public OnlineShopUser Buyer { get; set; }
        public string Code { get; set; }
        public string OrderDate { get; set; }
    }
}
