using System;
using System.Collections.Generic;

namespace Motel_Managerment_API.Models
{
    public partial class Cthoadon
    {
        public int Idhd { get; set; }
        public int MaDv { get; set; }
        public double? SoLuong { get; set; }
        public double? GiaTien { get; set; }

        public virtual Hoadon IdhdNavigation { get; set; } = null!;
        public virtual Dichvu MaDvNavigation { get; set; } = null!;
    }
}
