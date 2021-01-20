using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    //snippet
    class Product  //bu tip kılaslarda sadece özellik olur
    {
        public int Id { get; set; } //kilit isimdir (tc kimlik gibi)
        public int CategoryId { get; set; } //referans anahtarı
        public string ProductName { get; set; }//urun ismi
        public double UnitPrice { get; set; }//birimfiyatı
        public int UnitsInStock { get; set; }//stokadedi
    }
}
