using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Security.Principal;
using TT.Constant;
using TT.Data;
using TT.Entities;
using TT.IService;
using TT.Model;
using TT.Service;

namespace TT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DonDangKiController : Controller
    {
        private readonly AppDbContext context;
        private readonly IAccount _account;

        public DonDangKiController(IAccount account)
        {
            context = new AppDbContext();
            _account = account;
        }
        [HttpPost, Authorize]
        public IActionResult Them(int daoTrangId)
        {
            string result = _account.getEmail();
            var ptId = context.phattus.FirstOrDefault(x => x.email == result);
            var newDK = new Dondangkis
            {
                ngayGuiDon = DateTime.Now,
                trangThaiDon = 0,
                phattuId = ptId.phatTuId,
                daotrangId = daoTrangId,
            };
            context.Add(newDK);
            context.SaveChanges();
            return Ok("Them thanh cong");
        }         
        [HttpPut("{donDangKiId}"), Authorize(Roles = "ADMIN")]
        public IActionResult Duyet(int donDangKiId)
        {
            var k = context.dondangkis.FirstOrDefault(x => x.dondangkiId == donDangKiId);
            if (k == null)
            {
                return BadRequest("Khong ton tai");
            }
            else
            {
                string result = _account.getEmail();
                var ptId = context.phattus.FirstOrDefault(x => x.email == result);
                k.ngayXuLy = DateTime.Now;
                k.trangThaiDon = 1;
                k.nguoiXuLy = ptId.phatTuId;
                context.Update(k);
                var daotrang = context.daotrangs.FirstOrDefault(x => x.daotrangId == k.daotrangId);
                daotrang.soThanhVienThamGia++;
                context.Update(daotrang);
                context.SaveChanges();
                return Ok("Duyet thanh cong");
            }
        }
    }
}
