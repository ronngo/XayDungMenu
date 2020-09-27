using System;

namespace XayDungMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 8;
            double cd;
            double cr;
            double a;
            double r;

            while (choice != 0)
            {
                
                Console.WriteLine("1. Khoi tao hinh vuong ");
                Console.WriteLine("2. Khoi tao hinh chu nhat ");
                Console.WriteLine("3. Khoi tao hinh tron");
                Console.WriteLine("4. In ra dien tich va chu vi hinh vuong");
                Console.WriteLine("5. In ra dien tich va chu vi hinh chu nhat");
                Console.WriteLine("6. In ra dien tich va chu vi hinh tron");
                Console.WriteLine("7. Ket thuc ");
                Console.WriteLine("\n");
                Console.Write("Enter your choice: ");
                choice = Int32.Parse(Console.ReadLine());

                ChuviDientich chuvidientich = new ChuviDientich();
                Console.WriteLine();
                switch (choice)
                {

                    case 1:
                        Console.WriteLine("Nhap canh hinh vuong : ");
                        a = double.Parse(Console.ReadLine());
                        break;

                    case 2:
                        Console.WriteLine("Nhap chieu dai : ");
                        cd = double.Parse(Console.ReadLine());
                        Console.WriteLine("Nhap chieu rong : ");
                        cr = double.Parse(Console.ReadLine());
                        break;

                    case 3:
                        Console.WriteLine("Nhap ban kinh hinh tron : ");
                        r = double.Parse(Console.ReadLine());
                        break;

                    case 4:                        
                        Console.WriteLine("Dien tich hinh vuong la :" + chuvidientich.dtHV());
                        Console.WriteLine("Chu vi hinh vuong la :" + chuvidientich.cvHV());
                        break;

                    case 5:
                        
                        Console.WriteLine("Dien tich hinh chu nhat la :" + chuvidientich.dtHCN());
                        Console.WriteLine("Chu vi hinh chu nhat la :" + chuvidientich.cvHCN());
                        break;

                    case 6:

                        Console.WriteLine("Dien tich hinh tron la :" + chuvidientich.dtHT());
                        Console.WriteLine("Chu vi hinh tron la :" + chuvidientich.cvHT());
                        break;

                    case 7:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("No choice!");
                        break;
                }

            }
        }
    }
}