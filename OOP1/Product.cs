using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Product
    {
        //Ürün İd'si
        public int Id { get; set; }
        //Ürün kategorisi
        public int CategoryId { get; set; }
        //Ürün ismi
        public string ProductName { get; set; }
        //Ürün Bİrim Fiyatı
        public double UnitPrice { get; set; }
        //Ürün stok adedi 
        public int UnitsInStock { get; set; }
    }
}
