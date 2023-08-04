using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Data;
using TT.Constant;
using TT.Entities;
using TT.IService;
using TT.Service;

namespace TT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhatTuController : ControllerBase
    {
        private readonly IPhatTu phatTu;
        public PhatTuController()
        {
            phatTu=new PhatTuService();
        }
        [HttpGet, Authorize(Roles = "ADMIN")]
        public IActionResult Tim([FromQuery] string? ten, [FromQuery] string? phapDanh, [FromQuery] string? email, [FromQuery] int? gioiTinh, [FromQuery] Pagination pagination)
        {
            var k = phatTu.Timkiem(ten,phapDanh, email,gioiTinh, pagination);
            return Ok(k);
        }
        [HttpDelete("{phatTuId}"), Authorize(Roles = "ADMIN")]
        public IActionResult Xoa(int phatTuId)
        {
            var k = phatTu.Xoa(phatTuId);
            if (k == ErrorMessage.KhongTonTai)
            {
                return BadRequest("Phat tu can xoa khong ton tai");
            }
            else return Ok("Xoa thanh cong");
        }
        
    }
}
