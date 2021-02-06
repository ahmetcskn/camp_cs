using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        //hangi kategöriye ait olduğunu göstere id
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        //birim fiyatı
        public int UnitsInStock { get; set; }
        //stok adedi

    }
}
