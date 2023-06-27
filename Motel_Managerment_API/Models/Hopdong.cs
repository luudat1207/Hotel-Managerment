using System;
using System.Collections.Generic;

namespace Motel_Managerment_API.Models
{
    public partial class Hopdong
    {
        public string SoHopDong { get; set; } = null!;
        public int? Idcn { get; set; }
        public string? Cccd { get; set; }
        public string? MaPhong { get; set; }
        public double? GiaThue { get; set; }
        public DateTime? TuNgay { get; set; }
        public DateTime? DuKienTra { get; set; }
        public DateTime? NgayTra { get; set; }
        public bool? DaKetThuc { get; set; }

        public virtual Khachthue? CccdNavigation { get; set; }
        public virtual Chunha? IdcnNavigation { get; set; }
        public virtual Phongtro? MaPhongNavigation { get; set; }
    }
}
