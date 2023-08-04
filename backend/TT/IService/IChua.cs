using TT.Constant;
using TT.Entities;
using TT.Model;

namespace TT.IService
{
    public interface IChua
    {
        ErrorMessage Them(Chua chua);
        ErrorMessage Sua(Chua chua);
        ErrorMessage Xoa(int chuaId);
        PageResult<Chuas> Timkiem(string? ten, Pagination pagination);
    }
}
