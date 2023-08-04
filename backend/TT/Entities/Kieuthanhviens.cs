using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TT.Entities
{
    public class Kieuthanhviens
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int kieuthanhvienId { get; set; }

        public string code { get; set; }
        public string tenKieu { get; set; }
        public IEnumerable<Phattu>? phattus { get; set; }

    }
}
