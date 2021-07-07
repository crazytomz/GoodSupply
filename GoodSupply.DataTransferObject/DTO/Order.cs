using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodSupply.DataTransferObject.DTO
{
    public class Order
    {
        public int ID { get; set; }
        public string OrderNumber { get;set; }
        public string OrderDate { get; set; }
        [ForeignKey("Supplier")]
        public int SupplierID { get; set; }
        public Supplier Supplier { get; set; }
    }
    public class OrderDetail
    {
        public int ID { get; set; }        
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public decimal Rate { get; set; }
        [ForeignKey("Order")]
        public int OrderID { get; set; }
        public Order Order { get; set; }
    }
}
