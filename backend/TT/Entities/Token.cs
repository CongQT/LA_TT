using System.ComponentModel.DataAnnotations;

namespace TT.Entities;

public class Token
{
    [Key]
    public int Id { get; set; }
    public string stoken { get; set; }
    public int? expired { get; set; }
    public int? revoked { get; set; }
    public enum token_type { }
    public int phattuId { get; set; }
    public Phattu? phattu { get; set; }

}
