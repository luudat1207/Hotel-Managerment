using System;
using System.Collections.Generic;

namespace Motel_Managerment_API.Models
{
    public partial class Chunha
    {
        public Chunha()
        {
            Hopdongs = new HashSet<Hopdong>();
        }

        public int Idcn { get; set; }
        public string? HoTen { get; set; }
        public string? Sdt { get; set; }
        public string? DiaChi { get; set; }
        public string? GhiChu { get; set; }

        public virtual ICollection<Hopdong>? Hopdongs { get; set; }
    }
}
