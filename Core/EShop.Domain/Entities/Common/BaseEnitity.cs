using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.Entities.Common
{
    public class BaseEnitity
    {
        public Guid Id { get; set; }
        public DateTime CreatedTime { get; set; }
    }
}
