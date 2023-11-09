using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDSV_TC.Objects
{
    internal class LopTinChi
    {
        public int MaLTC { set; get; }
        public string NienKhoa { set; get; }
        public int HocKy { set; get; }
        public String MaMH { set; get; }
        public int Nhom { set; get; }
        public String MaGV { set; get; }
        public String MaKhoa { set; get; }
        public int SVToiThieu { set; get; }
        public Boolean HuyLop { set; get; }


        public LopTinChi() { }

        public LopTinChi(int MaLTC, String NienKhoa, int HocKy, String MaMH, int Nhom,
            String MaGV, String MaKhoa, int SVToiThieu, Boolean HuyLop)
        {
            this.MaLTC = MaLTC;
            this.NienKhoa = NienKhoa;
            this.HocKy = HocKy;
            this.MaMH = MaMH;
            this.Nhom = Nhom;
            this.MaGV = MaGV;
            this.MaKhoa = MaKhoa;
            this.SVToiThieu = SVToiThieu;
            this.HuyLop = HuyLop;
        }
    }
}
