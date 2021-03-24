using System;
using System.Collections.Generic;
using System.Text;

namespace BrandX_System
{
    public class CarStock
    {
        /*
         Create a class named CarStock and have properties for 
                TypeName, 
                Price, 
                TotalInStockAlpha,
                TotalInStockBravo, 
                TotalInStockCharlie
        Hot Key การสร้าง properties ให้พิมพ์ prop แล้วกด Tab 2 ครั้ง จะได้โครงสร้าง properties แบบด้วนล่าง
         */
        public string TypeName { get; set; }
        public double Price { get; set; }
        public int TotalInStockAlpha { get; set; }
        public int TotalInStockBravo { get; set; }
        public int TotalInStockCharlie { get; set; }
    }
}
