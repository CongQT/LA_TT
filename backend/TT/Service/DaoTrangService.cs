using TT.Constant;
using TT.Data;
using TT.Entities;
using TT.IService;
using TT.Model;

namespace TT.Service
{
    public class DaoTrangService : IDaoTrang
    {
        private readonly AppDbContext context;
        public DaoTrangService()
        {
            context = new AppDbContext();
        }
        public ErrorMessage Sua(DaoTrang daoTrang)
        {
            var k = context.daotrangs.Find(daoTrang.daotrangId);
            if (k == null)
            {
                return ErrorMessage.KhongTonTai;
            }
            else
            {
                k.noiDung=daoTrang.noiDung;
                k.noiToChuc=daoTrang.noiToChuc;
                k.thoiGianToChuc = daoTrang.thoiGianToChuc;
                context.Update(k);
                context.SaveChanges();
                return ErrorMessage.ThanhCong;
            }
        }
        public ErrorMessage Them(DaoTrang daoTrang)
        {
            var k = context.daotrangs.Find(daoTrang.daotrangId);
            if (k != null)
            {
                return ErrorMessage.DaTonTai;
            }
            else
            {
                var newDT = new Daotrangs
                {
                    daotrangId = daoTrang.daotrangId,
                    noiDung = daoTrang.noiDung,
                    noiToChuc = daoTrang.noiToChuc,
                    daKetThuc = 0,
                    thoiGianToChuc = daoTrang.thoiGianToChuc,
                    soThanhVienThamGia = 0,
                    nguoiTruTri=daoTrang.nguoiTruTri,
                };
                context.Add(newDT);
                context.SaveChanges();
                return ErrorMessage.ThanhCong;
            }
        }

        public PageResult<Daotrangs> Timkiem(string? noiDung, string? noiToChuc, Pagination pagination)
        {
            var list = context.daotrangs.ToList();
            if (!string.IsNullOrEmpty(noiDung))
            {
                list = list.Where(x => x.noiDung.ToLower().Contains(noiDung.ToLower())).ToList();
            }
            if (!string.IsNullOrEmpty(noiToChuc))
            {
                list = list.Where(x => x.noiToChuc.ToLower().Contains(noiToChuc.ToLower())).ToList();
            }
            var result = PageResult<Daotrangs>.ToPageResult(pagination, list);
            pagination.TotalCount = list.Count();
            return new PageResult<Daotrangs>(pagination, result);
        }

        public ErrorMessage Xoa(int daoTrangId)
        {
            var k = context.daotrangs.Find(daoTrangId);
            if (k == null)
            {
                return ErrorMessage.KhongTonTai;
            }
            else
            {
                context.Remove(k);
                context.SaveChanges();
                return ErrorMessage.ThanhCong;
            }
        }
    }
}
