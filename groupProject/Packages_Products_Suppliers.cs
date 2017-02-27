using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace groupProject
{
    class Packages_Products_Suppliers
    {
        public int PackageId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductSupplierId { get; set; }        
        
        public int SupplierId { get; set; }
    }
}
