using OnlineshopDmain.Frameworks.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineshopDmain.Aggregates.Sale
{
    public class ProductCategory: IDbSetEntity
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string Title { get; set; }
    }
}
