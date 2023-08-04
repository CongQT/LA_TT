using System.ComponentModel.DataAnnotations;

namespace TT.Entities
{
    public class Dondangkis
    {
        [Key]
        public int dondangkiId { get; set; }
        public DateTime ngayGuiDon { get; set; }
        public DateTime ngayXuLy { get; set; }
        public int? nguoiXuLy { get; set; }
        public int trangThaiDon { get; set; }
        public int daotrangId { get; set; }
        public Daotrangs? daotrang { get; set; }
        public int phattuId { get; set; }
        public Phattu? phattu { get; set; }

    }
}
