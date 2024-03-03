using OnlineshopDmain.Frameworks.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineshopDmain.Aggregates.Sale
{
    public class ProductCategory:IDbSetEntity
    {
        //keys
        public int Id { get; set; }
        //navigation
        public Product product { get; set; }
        //public ProductCategory ProductCategoryParentId { get; set; }
        //properties
        public int ParentId { get; set; }
        public string Title { get; set; }
    }
}
