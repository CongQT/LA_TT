using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TT.Entities
{
    public class Chuas
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int chuaId { get; set; }
        public DateTime? capnhat { get; set; }
        public string diaChi { get; set; }
        public DateTime ngayThanhLap { get; set; }
        public string tenChua { get; set; }
        public int trutri { get; set; }
        public IEnumerable<Phattu>? phattus { get; set; }
    }
}
