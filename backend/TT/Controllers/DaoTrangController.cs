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
    public class DaoTrangController : Controller
    {
        private readonly IDaoTrang daoTrangService;
        public DaoTrangController()
        {
            daoTrangService = new DaoTrangService();
        }
        [HttpPost, Authorize(Roles = "ADMIN")]
        public IActionResult Them(DaoTrang daoTrang)
        {
            var k = daoTrangService.Them(daoTrang);
            if (k == ErrorMessage.DaTonTai)
            {
                return BadRequest("Da ton tai");
            }
            else return Ok("Them thanh cong");
        }
        [HttpPut, Authorize(Roles = "ADMIN")]
        public IActionResult Sua(DaoTrang daoTrang)
        {
            var k = daoTrangService.Sua(daoTrang);
            if (k == ErrorMessage.KhongTonTai)
            {
                return BadRequest("khong ton tai");
            }
            else return Ok("Sua thanh cong");
        }
        [HttpDelete("{daoTrangId}"), Authorize(Roles = "ADMIN")]
        public IActionResult Xoa(int daoTrangId)
        {
            var k = daoTrangService.Xoa(daoTrangId);
            if (k == ErrorMessage.KhongTonTai)
            {
                return BadRequest("Dao trang can xoa khong ton tai");
            }
            else return Ok("Xoa thanh cong");
        }
        [HttpGet("Tim"), Authorize]
        public IActionResult Tim([FromQuery] string? noidung, [FromQuery] string? noitochuc, [FromQuery] Pagination pagination)
        {
            var k = daoTrangService.Timkiem(noidung, noitochuc, pagination);
            return Ok(k);
        }

    }
}
