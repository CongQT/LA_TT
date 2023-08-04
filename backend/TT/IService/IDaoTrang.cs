using TT.Constant;
using TT.Entities;
using TT.Model;

namespace TT.IService
{
    public interface IDaoTrang
    {
        ErrorMessage Them(DaoTrang daoTrang);
        ErrorMessage Sua(DaoTrang daoTrang);
        ErrorMessage Xoa(int daoTrangId);
        PageResult<Daotrangs> Timkiem(string? noiDung,string? noiToChuc, Pagination pagination);
    }
}
