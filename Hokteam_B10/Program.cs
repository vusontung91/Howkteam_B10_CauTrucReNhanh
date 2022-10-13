using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hokteam_B10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Vidu_1
            //string strk;
            //Console.WriteLine("Nhap so k:");
            //strk = Console.ReadLine();
            //int k = int.Parse(strk);
            //switch (k)
            //{
            //    case 3:
            //        Console.WriteLine("Tung");
            //        Console.ReadKey();
            //        break;
            //    case 9:
            //        Console.WriteLine("Thoc");
            //        Console.ReadKey();
            //        break;
            //    case 10:
            //        Console.WriteLine("Huyen");
            //        Console.ReadKey();
            //        break;
            //}
            //Console.ReadKey();
            #endregion

            #region Viet chuong trinh tinh nam am lich tu nam duong lich
            //Năm âm lịch = Can + Chi
            //Can = Phần dư của phép chia năm dương lịch cho 10
            //Chi = Phần dư của phép chia năm dương lịch cho 12

            //int NamDuongLich;
            //string Can = "";string Chi = "";
            //Console.WriteLine("Nhap nam duong lich can tinh:");
            //string strA = Console.ReadLine();
            //if (int.TryParse(strA, out NamDuongLich) == false)
            //{
            //    Console.WriteLine("Du lieu nhap vao khong dung:");
            //}
            //else 
            //{
            //    switch(NamDuongLich%10)
            //    {
            //        case 0:Can = "Canh";
            //            break;
            //        case 1:Can = "Tan";
            //            break;
            //        case 2:Can = "Nham";
            //            break;
            //        case 3:Can = "Quy";
            //            break;
            //        case 4:Can = "Giap";
            //            break;
            //        case 5:Can = "At";
            //            break;
            //        case 6:Can = "Binh";
            //            break;
            //        case 7:Can = "Dinh";
            //            break;
            //        case 8:Can = "Mau";
            //            break;
            //        case 9:Can = "Ky";
            //            break;
            //    }
            //    switch(NamDuongLich%12)
            //    {
            //        case 0:Chi = "Than";
            //            break;
            //        case 1:Chi = "Dau";
            //            break;
            //        case 2:Chi = "Tuat";
            //            break;
            //        case 3:Chi = "Hoi";
            //            break;
            //        case 4:Chi = "Ty";
            //            break;
            //        case 5:Chi = "Suu";
            //            break;
            //        case 6:Chi = "Dan";
            //            break;
            //        case 7:Chi = "Mao";
            //            break;
            //        case 8:Chi = "Thin";
            //            break;
            //        case 9:Chi = "Ty";
            //            break;
            //        case 10:Chi = "Ngo";
            //            break;
            //        case 11:Chi = "Mui";
            //            break;
            //    }
            //    Console.WriteLine("Nam am lich la:{0} +{1}", Can, Chi);


            //}
            //Console.ReadKey();
            #endregion

            #region Tính chu vi và diện tích hình tròn

            //double r;
            //double ChuVi;
            //double DienTich;
            //Console.WriteLine("Nhap ban kinh hinh tron:");
            //string strR = Console.ReadLine();
            //if(double.TryParse(strR,out r))
            //{
            //    ChuVi = r * 2 * 3.14;
            //    DienTich = 3.14*r*r;
            //    Console.WriteLine("Chu vi hinh tron la:{0}",ChuVi);
            //    Console.WriteLine("Dien tich hinh tron la: {0}", DienTich);

            //}
            //else
            //{
            //    Console.WriteLine("Du lieu nhap sai");
            //}
            //Console.ReadKey();
            #endregion

            #region Kiểm tra số chẵn lẻ
            int n1, n2;
            bool bothEven1;
            bool bothEven2;
            Console.WriteLine("Nhap so thu nhat:");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap so thu hai:");
            n2 = Convert.ToInt32(Console.ReadLine());

            bothEven1 = (n1 % 2 == 0)? true : false;
            bothEven2 = (n2 % 2 == 0) ? true : false;
            Console.WriteLine(bothEven1 ? "so thu nhat la so chan" : "so thu nhat la so le");
            Console.WriteLine(bothEven2 ? "so thu hai la so chan" : "so thu hai la so le");
            Console.ReadKey();

            #endregion


        }
    }
}
