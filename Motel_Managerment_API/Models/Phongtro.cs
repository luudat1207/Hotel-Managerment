using System;
using System.Collections.Generic;

namespace Motel_Managerment_API.Models
{
    public partial class Phongtro
    {
        public Phongtro()
        {
            Hopdongs = new HashSet<Hopdong>();
        }

        public string MaPhong { get; set; } = null!;
        public int? MaTinhTrang { get; set; }
        public string? ThongTin { get; set; }
        public double? GiaPhong { get; set; }
        public string? GhiChu { get; set; }

        public virtual Tinhtrang? MaTinhTrangNavigation { get; set; }
        public virtual ICollection<Hopdong> Hopdongs { get; set; }
    }
}
