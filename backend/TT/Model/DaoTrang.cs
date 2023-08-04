using TT.Entities;

namespace TT.Model
{
    public class DaoTrang
    {
        public int daotrangId { get; set; }
        public string noiDung { get; set; }
        public string noiToChuc { get; set; }
        public DateTime thoiGianToChuc { get; set; }
        public int nguoiTruTri { get; set; }
    }
}
