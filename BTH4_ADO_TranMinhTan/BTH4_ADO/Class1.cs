using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTH4_ADO
{
    public class Class1
    {
        SqlConnection thisConnection = new SqlConnection("data source=DESKTOP-7RNKS49;initial catalog=ThucTap; Integrated Security=true");
        public void Run()
        {

        }
        #region 1.	Đếm số lượng sinh viên thực thập
        public void DemSoLuongSinhVien()
        {
            thisConnection.Open();
            SqlCommand nonqueryCommand = thisConnection.CreateCommand();
            Console.WriteLine("1. Đếm số lượng sinh viên thực thập");
            nonqueryCommand.CommandText = "SELECT COUNT(*) FROM TBLHuongDan";

            Console.WriteLine("So luong SV thuc tap: "+nonqueryCommand.ExecuteScalar());
            thisConnection.Close();
        }
        #endregion
        #region 2.	In ra màn hình danh sách HoTen sinh viên
        public void InHoTenSV()
        {
            thisConnection.Open();
            SqlCommand nonqueryCommand = thisConnection.CreateCommand();
            Console.WriteLine("2. In ra man hinh danh sach HoTen sinh vien");
            nonqueryCommand.CommandText = "SELECT Hotensv FROM TBLSinhVien";
            var reader = nonqueryCommand.ExecuteReader();
            while(reader.Read())
            {
                var tensv = reader["Hotensv"].ToString();
                Console.WriteLine(tensv);
            }
            thisConnection.Close();
        }
        #endregion
        #region 3.	Thêm một sinh viên tên: Trần Nam Dương/Geo/1995/Ho Chi Minh
        public void ThemSV()
        {
            thisConnection.Open();
            SqlCommand nonqueryCommand = thisConnection.CreateCommand();
            Console.WriteLine("3. Them mot sinh vien ten: Trần Nam Dương/Geo/1995/Ho Chi Minh");
            nonqueryCommand.CommandText = "INSERT INTO TBLSinhVien VALUES (9, N'Trần Nam Dương' , 'Geo', 1995, N'Ho Chi Minh')";
            nonqueryCommand.ExecuteNonQuery();
            thisConnection.Close();
        }
        public void kiemTraThemSV()
        {
            thisConnection.Open();
            SqlCommand nonqueryCommand = thisConnection.CreateCommand();
            nonqueryCommand.CommandText = "SELECT * FROM TBLSinhVien";
            var reader = nonqueryCommand.ExecuteReader();
            while (reader.Read())
            {
                var ma = reader["Masv"].ToString();
                var tensv = reader["Hotensv"].ToString();
                var makhoa = reader["Makhoa"].ToString();
                var namsinh = reader["Namsinh"].ToString();
                var quequan = reader["Quequan"].ToString();
                var kq = "Ma SV " + ma + " Ten SV " + tensv + " Khoa " + makhoa + " Nam sinh " + namsinh + " Que quan " + quequan;
                Console.WriteLine(kq);
            }
            thisConnection.Close();
        }
        #endregion
        #region 4.	Cập nhật sinh viên Le Thi Van năm sinh 2018, Quê quán Ha nam
        public void CapNhatSV()
        {
            thisConnection.Open();
            SqlCommand nonqueryCommand = thisConnection.CreateCommand();
            Console.WriteLine("4. Cap nhat sinh vien Le Thi Van nam sinh 2018, Que quan Ha nam");
            nonqueryCommand.CommandText = "UPDATE TBLSinhVien SET Namsinh=2018,Quequan='Ha nam' WHERE Hotensv=N'Le Thi Van'";
            nonqueryCommand.ExecuteNonQuery();
            thisConnection.Close();
        }
        #endregion
        #region 5.	Xóa đề tài Dt04
        public void XoaDeTai()
        {
            thisConnection.Open();
            SqlCommand nonqueryCommand = thisConnection.CreateCommand();
            Console.WriteLine("5. Xoa đe tai Dt04");
            nonqueryCommand.CommandText = "DELETE  FROM TBLHuongDan WHERE Madt='Dt04'";
            nonqueryCommand.ExecuteNonQuery();
            nonqueryCommand.CommandText = "DELETE  FROM TBLDeTai WHERE Madt='Dt04'";
            nonqueryCommand.ExecuteNonQuery();
            thisConnection.Close();
        }
        public void kiemTraDeTai()
        {
            thisConnection.Open();
            SqlCommand nonqueryCommand = thisConnection.CreateCommand();
            nonqueryCommand.CommandText = "SELECT * FROM TBLDeTai";
            var reader = nonqueryCommand.ExecuteReader();
            while (reader.Read())
            {
                var ma = reader["Madt"].ToString();
                var tendt = reader["Tendt"].ToString();
                var khinhphi = reader["Kinhphi"].ToString();
                var noithuctap = reader["Noithuctap"].ToString();
                var kq = "Ma DT " + ma + " Ten DT " + tendt + " Kinh phi " + khinhphi + " Noi thuc tap " + noithuctap;
                Console.WriteLine(kq);
            }
            thisConnection.Close();
        }
        #endregion
    }
}
