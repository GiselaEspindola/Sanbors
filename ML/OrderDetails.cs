using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class OrderDetails
    {
        public int OrderID { get; set; }
        public ML.Products Products { get; set; }
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public Single Discount { get; set; }
    }
}
