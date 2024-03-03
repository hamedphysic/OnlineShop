using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineshopDmain.Frameworks.Abstracts
{
    public interface IMainEntity:IEntity<Guid>,ICodedEntity<long>,ITitledEntity,IDescribedEntity,IActiveEntity,ICreatedEntity,IModifiedEntity,ISoftDeletedEntity
    {
    }
}
