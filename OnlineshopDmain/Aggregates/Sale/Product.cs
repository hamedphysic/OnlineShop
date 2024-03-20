using OnlineshopDmain.Frameworks.Abstracts;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineshopDmain.Aggregates.Sale
{
    public class Product:IMainEntity,IDbSetEntity
    {
        //keys
        public Guid Id { get; set; }
        //navigation
        public ProductCategory ProductCategory { get; set; }
        //properties
        public int ProductCategoryId { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }
        public decimal UnitPrice { get; set; }
        public string EntityDescription { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateCreatedLatin { get; set; }
        public string DateCreatedPersian { get; set; }
        public bool IsModified { get; set; }
        public DateTime DateModifiedLatin { get; set; }
        public string DateModifiedPersian { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DateSoftDeletedLatin { get; set; }
        public string DateSoftDeletedPersian { get; set; }
        long ICodedEntity<long>.Code { get; set; }
    }
}
