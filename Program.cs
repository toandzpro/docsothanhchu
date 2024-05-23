using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Write("Nhập số cần đọc: ");
        int Số = Convert.ToInt32(Console.ReadLine());
        if (Số >= 0 && Số < 10)
        {
            switch (Số)
            {
                case 0:
                    Console.WriteLine("Khong");
                    break;
                case 1:
                    Console.WriteLine("Một");
                    break;
                case 2:
                    Console.WriteLine("Hai");
                    break;
                case 3:
                    Console.WriteLine("Ba");
                    break;
                case 4:
                    Console.WriteLine("Bốn");
                    break;
                case 5:
                    Console.WriteLine("Năm");
                    break;
                case 6:
                    Console.WriteLine("Sáo");
                    break;
                case 7:
                    Console.WriteLine("Bảy");
                    break;
                case 8:
                    Console.WriteLine("Tám");
                    break;
                case 9:
                    Console.WriteLine("Chín");
                    break;
            }
        }
        else if (Số >= 10 && Số < 20)
        {
            int Một = Số % 10;
            switch (Một)
            {
                case 0:
                    Console.WriteLine("Mười");
                    break;
                case 1:
                    Console.WriteLine("Mười Một");
                    break;
                case 2:
                    Console.WriteLine("Mười Hai");
                    break;
                case 3:
                    Console.WriteLine("Mười Ba");
                    break;
                case 4:
                    Console.WriteLine("Mười Tư");
                    break;
                case 5:
                    Console.WriteLine("Mười Năm");
                    break;
                case 6:
                    Console.WriteLine("Mười Sáo" );
                    break;
                case 7:
                    Console.WriteLine("Mười bảy");
                    break;
                case 8:
                    Console.WriteLine("Mười Tám");
                    break;
                case 9:
                    Console.WriteLine("Mười Chín");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Hết Khả năng");
        }
    }
}