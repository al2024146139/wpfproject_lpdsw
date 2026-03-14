using System;
using System.Collections.Generic;
using System.Text;

namespace WpfProjectLpdsw.Models
{
    internal class Order
    {
        public int Id { get; set; }
        public string? OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalValue { get; set; }
    }
}
