using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BTH4_ADO;
namespace BTH4_ADO_TranMinhTan
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 c = new Class1();
            //câu 1
            Console.WriteLine("\n---------------Cau 1-------------------");
            c.DemSoLuongSinhVien();
            // Câu 2
            Console.WriteLine("\n---------------Cau 2-------------------");
            c.InHoTenSV();
            //Câu 3
            Console.WriteLine("\n-----------------Cau 3-----------------");
            Console.WriteLine("\nDanh sach sinh vien ban dau: ");
            c.kiemTraThemSV();
            c.ThemSV();
            Console.WriteLine("\nDanh sach sinh vien sau khi them: ");
            c.kiemTraThemSV();
            //Câu 4
            Console.WriteLine("\n----------------Cau 4------------------");
            c.CapNhatSV();
            Console.WriteLine("\nDanh sach sinh vien sau khi cap nhat: ");
            c.kiemTraThemSV();
            //Câu 5
            Console.WriteLine("\n-----------------Cau 5-----------------");
            c.XoaDeTai();
            Console.WriteLine("\nDanh sách đề tài sau khi xóa: ");
            c.kiemTraDeTai();
            Console.ReadKey();
        }
    }
}
