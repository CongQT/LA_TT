using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net.Mail;
using System.Net;
using System.Security.Cryptography;
using TT.Data;
using TT.Entities;
using TT.IService;
using TT.Model;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.WebUtilities;
using System;
using Microsoft.AspNetCore.Authorization;
using TT.Service;
using Newtonsoft.Json.Linq;

namespace TT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IConfiguration _configuration;
        private readonly IAccount _account;

        public AccountController(IConfiguration configuration,IAccount account)
        {
            _configuration = configuration;
            _context = new AppDbContext();
            _account = account;
        }

        
        [HttpPost("register")]
        public async Task<IActionResult> Register(SignUp request)
        {
            if (_context.phattus.Any(u => u.email == request.Email))
            {
                return BadRequest("Email đã tồn tại");
            }
            if (_context.phattus.Any(u => u.sdt == request.sdt))
            {
                return BadRequest("Sdt đã tồn tại");
            }
            int k;
            if (request.gioiTinh.ToLower().Contains("nam")) k = 1;
            else k = 0;
            var phatTu = new Phattu
            {
                email = request.Email,
                password = request.Password,
                gioiTinh=k,
                ho=request.ho,
                ten=request.ten,
                tenDem=request.tenDem,
                phapDanh=request.phapDanh,
                sdt=request.sdt,
                ngaySinh=request.ngaySinh,
                chuaId=request.chuaId,
                kieuthanhvienId=request.kieuthanhvienId,
                isActive=true
            };
            _context.phattus.Add(phatTu);
            await _context.SaveChangesAsync();
            string token = CreateToken(phatTu);
            var newtoken = new Token
            {
                stoken = token,
                expired = 0,
                revoked = 0,
                phattuId = phatTu.phatTuId
            };
            await _context.tokens.AddAsync(newtoken);
            await _context.SaveChangesAsync();

            return Ok("Đăng kí thành công");
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(SignIn request)
        {
            var user = await _context.phattus.FirstOrDefaultAsync(u => u.email == request.Email);
            if (user == null)
            {
                return BadRequest("Tài khoản không tồn tại");
            }

            if (request.Password!=user.password)
            {
                return BadRequest("Mật khẩu sai");
            }
            var token = await _context.tokens.FirstOrDefaultAsync(x => x.phattuId == user.phatTuId);
            return Ok(token.stoken);
        }


        [HttpPost("forgot-password")]
        public async Task<IActionResult> ForgotPassword(string email)
        {
            var user = await _context.phattus.FirstOrDefaultAsync(u => u.email == email);
            if (user == null)
            {
                return BadRequest("Tài khoản không tồn tại");
            }

            var token = await _context.tokens.FirstOrDefaultAsync(u => u.phattuId == user.phatTuId);

            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("thanhcong2521@gmail.com", "yknjqgpdyoleeupz"),
                EnableSsl = true,
            };
            string subject = "Đây là liên kết để đặt lại mật khẩu của bạn";
            string content = "Xin chào. Bạn đã yêu cầu đặt lại mật khẩu của mình. Dùng mã sau để thay đổi mật khẩu:"
                + $"{token.stoken}";
            smtpClient.Send("thanhcong2521@gmail.com", email, subject,content);
            return Ok("Đã gửi thông báo vào email của bạn");
        }

        [HttpPost("reset-password")]
        public async Task<IActionResult> ResettPassword(string stoken, string password)
        {
            var token = await _context.tokens.FirstOrDefaultAsync(u => u.stoken == stoken);
            var user = await _context.phattus.FirstOrDefaultAsync(u => u.phatTuId == token.phattuId);
            if (user == null)
            {
                return BadRequest("Tài khoản không tồn tại");
            }

            user.password = password;
            token.expired = 1;

            await _context.SaveChangesAsync();

            return Ok("Thay đổi mật khẩu thành công");
        }

        private string CreateToken(Phattu user)
        {
            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.Email, user.email),
                new Claim(ClaimTypes.Role, "MEMBER")
            };

            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(
                _configuration.GetSection("AppSettings:Token").Value));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddDays(10),
                signingCredentials: creds);

            var jwt = new JwtSecurityTokenHandler().WriteToken(token);

            return jwt;
        }
        private string url(string url)
        {
            var callbackUrl = Url.Page(
                    "/Account/ResetPassword",
                    "null",
                    values: new { url },
                    protocol: Request.Scheme);
            return callbackUrl;
        }
    }
}

