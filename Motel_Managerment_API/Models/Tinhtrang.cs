using System;
using System.Collections.Generic;

namespace Motel_Managerment_API.Models
{
    public partial class Tinhtrang
    {
        public Tinhtrang()
        {
            Phongtros = new HashSet<Phongtro>();
        }

        public int MaTinhTrang { get; set; }
        public string? TinhTrang1 { get; set; }

        public virtual ICollection<Phongtro> Phongtros { get; set; }
    }
}
