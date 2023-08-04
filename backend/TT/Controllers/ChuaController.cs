using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using TT.Constant;
using TT.Entities;
using TT.IService;
using TT.Model;
using TT.Service;

namespace TT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChuaController : Controller
    {
        private readonly IChua chuaService;
        public ChuaController()
        {
            chuaService=new ChuaService();
        }
        [HttpPost, Authorize(Roles = "ADMIN")]
        public IActionResult Them(Chua chua)
        {
            var k = chuaService.Them(chua);
            if (k == ErrorMessage.DaTonTai)
            {
                return BadRequest("Chua da ton tai");
            }
            
            else return Ok("Them thanh cong");
        }
        [HttpPut, Authorize(Roles = "ADMIN")]
        public IActionResult Sua(Chua chua)
        {
            var k = chuaService.Sua(chua);
            if (k == ErrorMessage.KhongTonTai)
            {
                return BadRequest("Chua can sua khong ton tai");
            }
            else return Ok("Sua thanh cong");
        }
        [HttpDelete("{chuaId}"), Authorize(Roles = "ADMIN")]
        public IActionResult Xoa(int chuaId)
        {
            var k = chuaService.Xoa(chuaId);
            if (k == ErrorMessage.KhongTonTai)
            {
                return BadRequest("Chua can xoa khong ton tai");
            }
            else return Ok("Xoa thanh cong");
        }
        [HttpGet("Tim"), Authorize(Roles = "ADMIN")]
        public IActionResult Tim([FromQuery] string? ten, [FromQuery] Pagination pagination)
        {
            var k = chuaService.Timkiem(ten, pagination);
            return Ok(k);
        }
    }
}
