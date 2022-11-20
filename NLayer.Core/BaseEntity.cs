using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatDate{ get; set; }
        public DateTime ModifiedDate{ get; set; }
        
    }
}
