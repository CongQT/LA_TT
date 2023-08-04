using TT.Constant;
using TT.Data;
using TT.Entities;
using TT.IService;
using TT.Model;

namespace TT.Service
{
    public class KieuThanhVienService : IKieuThanhVien
    {
        private readonly AppDbContext context;
        public KieuThanhVienService()
        {
            context = new AppDbContext();
        }
        public ErrorMessage Sua(KieuThanhVien kieuThanhVien)
        {
            var k = context.Kieuthanhviens.Find(kieuThanhVien.kieuthanhvienId);
            if (k == null)
            {
                return ErrorMessage.KhongTonTai;
            }
            else
            {
                k.code = kieuThanhVien.code;
                k.tenKieu = kieuThanhVien.tenKieu;
                context.Update(k);
                context.SaveChanges();
                return ErrorMessage.ThanhCong;
            }
        }

        public ErrorMessage Them(KieuThanhVien kieuThanhVien)
        {
            var k = context.Kieuthanhviens.Find(kieuThanhVien.kieuthanhvienId);
            if (k != null)
            {
                return ErrorMessage.DaTonTai;
            }
            else
            {
                var kieu = new Kieuthanhviens
                {
                    kieuthanhvienId = kieuThanhVien.kieuthanhvienId,
                    code = kieuThanhVien.code,
                    tenKieu = kieuThanhVien.tenKieu,
                };
                context.Add(kieu);
                context.SaveChanges();
                return ErrorMessage.ThanhCong;
            }
        }

        public ErrorMessage Xoa(int kieuThanhVienId)
        {
            var k = context.Kieuthanhviens.Find(kieuThanhVienId);
            if (k == null)
            {
                return ErrorMessage.KhongTonTai;
            }
            else
            {
                context.Remove(k); context.SaveChanges();
                return ErrorMessage.ThanhCong;
            }
        }
    }
}
