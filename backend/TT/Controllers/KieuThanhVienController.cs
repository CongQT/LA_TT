﻿using Microsoft.AspNetCore.Authorization;
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
    public class KieuThanhVienController : Controller
    {
        private readonly IKieuThanhVien kieuTVService;
        public KieuThanhVienController()
        {
            kieuTVService = new KieuThanhVienService();
        }
        [HttpPost, Authorize(Roles = "ADMIN")]
        public IActionResult Them(KieuThanhVien kieuThanhVien)
        {
            var k = kieuTVService.Them(kieuThanhVien);
            if (k == ErrorMessage.DaTonTai)
            {
                return BadRequest("Kieu thanh vien da ton tai");
            }
            else return Ok("Them thanh cong");
        }
        [HttpPut, Authorize(Roles = "ADMIN")]
        public IActionResult Sua(KieuThanhVien kieuThanhVien)
        {
            var k = kieuTVService.Sua(kieuThanhVien);
            if (k == ErrorMessage.KhongTonTai)
            {
                return BadRequest("Kieu thanh vien can sua khong ton tai");
            }
            else return Ok("Sua thanh cong");
        }
        [HttpDelete("{kieuThanhVienId}"), Authorize(Roles = "ADMIN")]
        public IActionResult Xoa(int kieuThanhVienId)
        {
            var k = kieuTVService.Xoa(kieuThanhVienId);
            if (k == ErrorMessage.KhongTonTai)
            {
                return BadRequest("Kieu thanh vien can xoa khong ton tai");
            }
            else return Ok("Xoa thanh cong");
        }
    }
}
