
using System.ComponentModel.DataAnnotations;

namespace TT.Entities
{
    public class Phattu
    {
        [Key]
        public int phatTuId { get; set; }
        public string? anhChup { get; set; }
        public int? daHoanTuc { get; set; }
        public string email { get; set; }
        public int gioiTinh { get; set; }
        public string ho { get; set; }
        public DateTime? ngayCapNhat { get; set; }
        public DateTime? ngayHoanTuc { get; set; }
        public DateTime ngaySinh { get; set; }
        public DateTime ngayXuatGia { get; set; }
        public string password { get; set; }
        public string phapDanh { get; set; }
        public string sdt { get; set; }
        public string ten { get; set; }
        public string tenDem { get; set; }
        public bool isActive { get; set; }

        public IEnumerable<Token>? tokens { get; set; }
        public int chuaId { get; set; }
        public Chuas? chua { get; set; }
        public int kieuthanhvienId { get; set; }
        public Kieuthanhviens? kieuthanhvien { get; set; }
        
        public IEnumerable<Phattudaotrangs>? phattudaotrangs { get;set; }
        public IEnumerable<Daotrangs>? daotrangs { get; set; }

    }
}
