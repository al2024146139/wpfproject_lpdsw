using System;
using System.Collections.Generic;
using System.Text;

namespace WpfProjectLpdsw.Models
{
    internal class WarehouseStock
    {
        public int Id { get; set; }
        public string? ProductName { get; set; }
        public int Quantity { get; set; }
        public string? Location { get; set; }
    }
}
