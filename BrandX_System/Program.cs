using System;
using System.Collections.Generic;

namespace BrandX_System
{
    class Program
    {
        /*
         Important points to remember:
            a) Please use proper variable names.
                - ตั้งตามโจทย์ ไม่มีเว้นวรรค แต่ละตัวน่าจะสื่อความหมายดีแล้ว
            b) Write three lines of what issues you had about writing this console app with respect to your
                 1. โจทย์ไม่ชัดเจน
                    - ข้อ 3 RegisterCar ไม่เข้าใจว่าให้ลงทะเบียนอะไรมั่ง
                    - ข้อ 4 ข้อนี้ยังไม่เข้าใจโจทย์ว่าเงื่อนไข very low, low, over คือเท่าไหร่
                 2. ไม่เหมาะเอามาทำระบบ เพราะยังไม่มีระบบตัด stock หรืออื่น ๆ เกี่ยวกับบันทึกลง ฐานข้อมูล
            understanding of programming so far.
                 สำหรับผู้เริ่มต้นน่าจะสอนยากไป Assignment # 2 ก็เข้าเนื้อหา oop แล้ว
                 น่าจะทำความเข้าใจคำสั่งพื้นฐาน ชนิดตัวแปร แต่ละตัวก่อน 
         
         */
        static void Main(string[] args)
        {
            //a) Login using username and password(You can set a fixed username and password)
            Console.Write("Please provide username to access the BrandX system: ");
            string Username = Console.ReadLine(); // input username
            Console.Write("Please provide password : ");
            string Password = Console.ReadLine(); // input password
            if (Username == "admin" && Password == "1234") //fix user password (user: Admin / password: 1234)
            {
                //b) Following options should be shown to the user after successful login
                while (true) //loop infinity คือทำงานไปเรื่อย ๆ จนกว่า user จะกดปิดโปรแกรม
                {
                    //• On successful login a list of options should be presented:
                    Console.WriteLine("****** Here are your options ******");
                    Console.WriteLine("Please select the action.");
                    Console.WriteLine("1. Show stock count");
                    Console.WriteLine("2. Show total value of all cars in stock");
                    Console.WriteLine("3. Register one car sold");
                    Console.WriteLine("4. Get stock status");
                    Console.Write("option:  ");
                    string option = Console.ReadLine(); //รับค่าจากหน้า console เอามาเก็บไว้ที่ตัวแปร option (type string)
                    /* 
                     * Solution ideas 
                     *      • Create a class named CarStock  and have properties for TypeName, Price, TotalInStockAlpha,
                                TotalInStockBravo, TotalInStockCharlie
                      FileName: CarStock.cs
                            • Create a Processor class and One method named Process() in that class.
                      FileName: Processor.cs  
                    */
                    List<CarStock> AllData = Processor.Process(); //Load all data from class Processor in method Process()
                    switch (option)
                    {
                        case "1": ShowStockCount(AllData); 
                            /* ถ้า option = 1 ให้ไปทำงานที่ method ShowStockCount() บรรทัด 
                             โดยส่ง ข้อมูลทั้งหมด (AllData) ไปด้วย*/
                            break;
                        case "2": ShowToatalValueOfAllCare(AllData);
                            /* ถ้า option = 2 ให้ไปทำงานที่ method ShowToatalValueOfAllCare() บรรทัด 
                                โดยส่ง ข้อมูลทั้งหมด (AllData) ไปด้วย*/
                            break;
                        case "3": RegisterCar(AllData);
                            /* ถ้า option = 3 ให้ไปทำงานที่ method RegisterCar() บรรทัด 
                                 โดยส่ง ข้อมูลทั้งหมด (AllData) ไปด้วย*/
                            break;
                        case "4": Getstockstatus(AllData);
                            /* ถ้า option = 4 ให้ไปทำงานที่ method Getstockstatus() บรรทัด 
                                โดยส่ง ข้อมูลทั้งหมด (AllData) ไปด้วย*/
                            break;
                        default:
                            break;
                    }
                }
            }
            else
            {
                /*
                 If password and username are wrong. Please show following text and exit the app.
                    “You are not authorized to access this service”
                 */
                Console.WriteLine("You are not authorized to access this service");
            }
            Console.ReadLine();
        }
        public static void ShowStockCount(List<CarStock> AllData)// 1. Show stock count
        {
            foreach (var i in AllData)//Loop all data for sum quantity
            {
                int SumQty = i.TotalInStockAlpha + i.TotalInStockBravo + i.TotalInStockCharlie; // Sum all quantity 
                Console.WriteLine("Type Name: {0} ", i.TypeName); // Show Type name
                Console.WriteLine("Total car in stock: {0} ", SumQty); // Show quantity
                Console.WriteLine("---------------------");
            }
        }
        public static void ShowToatalValueOfAllCare(List<CarStock> AllData)//2. Show total value of all cars in stock
        {

            foreach (var i in AllData)
            {
                int SumQty = i.TotalInStockAlpha + i.TotalInStockBravo + i.TotalInStockCharlie; // Sum all quantity 
                double SumValue = i.Price * SumQty; // quantity * price
                Console.WriteLine("Type Name: {0} ", i.TypeName);
                Console.WriteLine("Value of all car in stock: {0} USD", SumValue);
                Console.WriteLine("---------------------");
            }
        }
        public static void RegisterCar(List<CarStock> AllData)//3. Register one car sold
        {
            int option = 1;
            foreach (var i in AllData)// Loop for display Typename
            {
                Console.WriteLine("{0} {1}", option, i.TypeName);
                option++;
            }
            string OptionSelected = Console.ReadLine(); //รับค่าจากหน้า console เอามาเก็บไว้ที่ตัวแปร OptionSelected (type string)
            if (OptionSelected == "1") //กด 1 CarAlpha sold
            {
                Console.WriteLine("CarAlpha sold.");
            }
            else if (OptionSelected == "2") //กด 2 CarBravo sold
            {
                Console.WriteLine("CarBravo sold.");
            }
            else if (OptionSelected == "3") //กด 3 CarCharlie sold
            {
                Console.WriteLine("CarCharlie sold.");
            }
        }
        public static void Getstockstatus(List<CarStock> AllData)//4. Get stock status //veryLow, Low, Normal, Over
        {
            /*
             * ข้อนี้ยังไม่เข้าใจโจทย์ว่าเงื่อนไข very low, low, over คือเท่าไหร่
             * เลยกำหนดจำนวนขึ้นมาเอง คือ
             * จำนวนใน stock น้อยกว่า หรือเท่ากับ 5 => very Low
             * จำนวนใน stock อยู่ระหว่าง 5-10 => Low
             * จำนวนใน stock อยู่ระหว่าง 10-15 => Normal
             * จำนวนใน stock มากกว่า 15 => Over
            
             */
            foreach (var i in AllData)
            {
                Console.WriteLine("Stock in Type {0}: ",i.TypeName);
                int SumQty = i.TotalInStockAlpha + i.TotalInStockBravo + i.TotalInStockCharlie;
                if (SumQty <= 5)
                {
                    Console.WriteLine("very Low");
                }
                else if (SumQty > 5 && SumQty <= 10)
                {
                    Console.WriteLine("Low");
                }
                else if(SumQty > 10 && SumQty <= 15)
                {
                    Console.WriteLine("Normal");
                }
                else
                {
                    Console.WriteLine("Over");
                }
                Console.WriteLine("---------------------");
            }
        }
    }
}
