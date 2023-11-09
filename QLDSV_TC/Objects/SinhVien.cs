using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Ctrl + K + D: format toàn bộ code
// Ctrl + K + F: Format đoạn code bôi đen
// Ctrl + R + E: tạo setter, getter
// Alt + Shift + F10 + Enter: Thay đổi tên biến , hàm hàng Loạt
// Ctrl + L: Xóa dòng code đang đứng
// 
namespace QLDSV_TC.Objects
{
    class SinhVien
    {
        public string MaSV { set; get; }

        public string Ho { set; get; }

        public string Ten { set; get; }

        public bool Phai { set; get; }

        public string DiaChi { set; get; }

        public string NgaySinh { set; get; }

        public string MaLop { set; get; }

        public bool DangNghiHoc { set; get; }

        public string PassWord { set; get; }

        public SinhVien() { }

        public SinhVien(string maSV, string ho, string ten, bool phai, string diaChi, string ngaySinh, string maLop, bool dangNghiHoc)
        {
            this.MaSV = maSV;
            this.Ho = ho;
            this.Ten = ten;
            this.Phai = phai;
            this.DiaChi = diaChi;
            this.NgaySinh = ngaySinh;
            this.MaLop = maLop;
            this.DangNghiHoc = dangNghiHoc;
            
        }


    }
}
