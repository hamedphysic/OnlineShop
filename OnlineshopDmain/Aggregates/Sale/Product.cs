using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineshopDmain.Aggregates.Sale
{
    public class Product
    {
        public Guid Id { get; set; }
        public int ProductCategoryId { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }
        public SqlMoney UnitPrice { get; set; }
    }
}
