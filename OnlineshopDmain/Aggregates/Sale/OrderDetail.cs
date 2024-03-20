using OnlineshopDmain.Frameworks.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineshopDmain.Aggregates.Sale
{
    public class OrderDetail:IDbSetEntity
    {
        //keys
        public Guid ProductId { get; set; }
        public Guid OrderHeaderId { get; set; }
        //navigation
        public Product Product { get; set; }    
        public OrderHeader OrderHeader { get; set; }
        //properties
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
