using TT.Constant;
using TT.Model;

namespace TT.IService
{
    public interface IKieuThanhVien
    {
        ErrorMessage Them(KieuThanhVien kieuThanhVien);
        ErrorMessage Xoa(int kieuThanhVienId);
        ErrorMessage Sua(KieuThanhVien kieuThanhVien);
    }
}
