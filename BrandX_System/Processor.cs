using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BrandX_System
{
    /*• In the Process Method start with writing code for creating object fill it with any fake values.
     * จาก  Solution ideas เค้าให้สร้าง class Processor แล้วมี method ชื่อ Process 
     * แล้วใน method Process ให้สร้างข้อมูลปลอมขึ้นมา 1 ชุด เลยเอาข้อมูลมาจก Scenario:
     * A car showroom in Gotham sells cars with the name BrandX. The showroom sells three types of cars
        (CarAlpha, CarBravo, CarCharlie) and price is in same respective order (60000 USD, 75000 USD, 95000
        USD)
     */
    public class Processor
    {
        public static List<CarStock> Process()
        {
            List<CarStock> Lstcar = new List<CarStock>
            {
                new CarStock{ TypeName = "CarAlpha", Price = 60000, TotalInStockAlpha = 10 },
                new CarStock{ TypeName = "CarBravo", Price = 75000, TotalInStockBravo = 5 },
                new CarStock{ TypeName = "CarCharlie", Price = 95000, TotalInStockCharlie = 2 }
            };
            return Lstcar;
        }
    }
}
