using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TT.Entities
{
    public class Daotrangs
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int daotrangId { get; set; }
        public int daKetThuc { get; set; }
        public string noiDung { get; set; }
        public string noiToChuc { get; set; }
        public int soThanhVienThamGia { get; set; }
        public DateTime thoiGianToChuc { get; set; }
        public IEnumerable<Dondangkis>? dondangkis { get;set; }
        public int nguoiTruTri { get; set; }
        public IEnumerable<Phattudaotrangs>? phattudaotrangs { get; set; }

    }
}
