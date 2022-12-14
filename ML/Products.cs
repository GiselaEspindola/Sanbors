using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Products
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public ML.Suppliers Suppliers { get; set; }
        public ML.Categories Categories { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
        public short UnitsOnOrder { get; set; }
        public short ReorderLevel { get; set; }
        public bool Discontinued { get; set; }
        public ML.Orders Orders { get; set; }
        public List<object> Productos { get; set; }
        public Customers Custumers { get; set; }
        public OrderDetails OrderDetails { get; set; }
        //public string OrderDate { get; set; }
    }
}
