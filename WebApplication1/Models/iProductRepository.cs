using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportStore.Models
{
    public interface iProductRepository
    {
        IEnumerable<Product> Products { get; }
    }
}
