using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Application.Paginations
{
    public record Pagination
    {
        public int Size { get; set; } = 5;
        public int Page { get; set; } = 0;
    }
}
