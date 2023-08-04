using System.ComponentModel.DataAnnotations;

namespace TT.Entities
{
    public class Phattudaotrangs
    {
        [Key]
        public int phattudaotrangId { get; set; }
        public int daThamGia { get; set; }
        public string lyDoKhongThamGia { get; set; }
        public int daotrangId { get; set; }
        public Daotrangs? daotrang { get; set; }
        public int phattuId { get; set; }
        public Phattu? phattu { get; set; }

    }
}
