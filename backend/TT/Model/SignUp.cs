using System.ComponentModel.DataAnnotations;
using TT.Entities;

namespace TT.Model
{
    public class SignUp
    {
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        
        [Required]
        public string ho { get; set; } = null!;
        [Required]
        public string tenDem { get; set; } = null!;
        [Required]
        public string sdt { get; set; }
        [Required]
        public string ten { get; set; } = null!;
        [Required]
        public string phapDanh { get; set; } = null!;
        [Required]
        public DateTime ngaySinh { get; set; }
        [Required]
        public string gioiTinh { get; set; }
        public int chuaId { get; set; }
        public int kieuthanhvienId { get; set; }

    }
}
