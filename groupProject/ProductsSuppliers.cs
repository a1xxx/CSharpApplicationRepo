using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//*******************************************************************
//*                                                                 *
//*                             ALEX                                *
//*                                                                 *
//*******************************************************************

namespace groupProject
{
    public class ProductsSuppliers
    {
        public ProductsSuppliers() { }
        public int ProductSupplierId { get; set; }
        public int ProductId { get; set; }
        public int SupplierId { get; set; }
        public string SupName { get; set; }
        public string ProdName { get; set; }
    }
}
