using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDSV_TC.Objects
{
    internal class MonHoc
    {
        public string MaMH { set; get; }
        public string TenMH { set; get; }
        public int STLT { set; get; }
        public int STTH { set; get; }

        

        public MonHoc() { }

        public MonHoc(String MaMH,String TenMH, int STLT, int STTH)
        {
            this.MaMH = MaMH;
            this.TenMH = TenMH;
            this.STLT = STLT;
            this.STTH = STTH;
            
            

        }
    }
}
