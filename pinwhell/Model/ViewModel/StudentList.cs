using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ViewModel
{
    public class StudentList
    {
        public int? MaHS { get; set; }
        public String TenHS { get; set; }
        public String TenPH { get; set; }
        public string MonHoc { get; set; }
        public int? Lop { get; set; }
        public int? HocPhi { get; set; }
        public DateTime? NgayDangKi { get; set; }
        public DateTime? NgayBatDauHoc { get; set; }
        public String TinhTranHocTap { get; set; }
        public String TinhTrangHocPhi { get; set; }
        public String LoiNhac { get; set; }
        public DateTime NgayDongHocPhi { get; set; }
        public bool? Status { get; set; }
    }
}
