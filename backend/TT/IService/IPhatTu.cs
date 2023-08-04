using TT.Constant;
using TT.Entities;

namespace TT.IService
{
    public interface IPhatTu
    {
        ErrorMessage Xoa(int phatTuId);
        PageResult<Phattu> Timkiem(string? ten, string? phapDanh,string? email,int? gioiTinh, Pagination pagination);
    }
}
