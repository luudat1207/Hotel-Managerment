using System;
using System.Collections.Generic;

namespace Motel_Managerment_API.Models
{
    public partial class Hoadon
    {
        public Hoadon()
        {
            Cthoadons = new HashSet<Cthoadon>();
        }

        public int Idhd { get; set; }
        public int? Idcn { get; set; }
        public int? Idtt { get; set; }
        public string? SoHopDong { get; set; }
        public DateTime? NgayLap { get; set; }
        public double? TienGiam { get; set; }
        public double? TienPhat { get; set; }
        public double? SoTienTra { get; set; }
        public double? TongTien { get; set; }
        public string? GhiChu { get; set; }

        public virtual Thanhtoan? IdttNavigation { get; set; }
        public virtual ICollection<Cthoadon> Cthoadons { get; set; }
    }
}
