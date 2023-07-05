namespace Motel_Managerment_API.DTO
{
    public class HopDongDTO
    {
        public string SoHopDong { get; set; } = null!;
        public string? HoTenChuNha { get; set; }
        public string? HoTenKhachHang { get; set; } 
        public string? MaPhong { get; set; }
        public double? GiaThue { get; set; }
        public DateTime? TuNgay { get; set; }
        public DateTime? DuKienTra { get; set; }
        public DateTime? NgayTra { get; set; }
        public bool? DaKetThuc { get; set; }
        public int? Idcn { get; set; }
        public string? Cccd { get; set; }
        public string? ThongTinPhong { get; set; }

    }
}
