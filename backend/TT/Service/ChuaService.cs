using TT.Constant;
using TT.Data;
using TT.Entities;
using TT.IService;
using TT.Model;

namespace TT.Service
{
    public class ChuaService : IChua
    {
        private readonly AppDbContext context;
        public ChuaService()
        {
            context = new AppDbContext();
        }
        public ErrorMessage Sua(Chua chua)
        {
            var k=context.chuas.Find(chua.chuaId);
            if (k == null)
            {
                return ErrorMessage.KhongTonTai;
            }
            else
            {
                k.diaChi=chua.diaChi;
                k.ngayThanhLap=chua.ngayThanhLap;
                k.tenChua=chua.tenChua;
                k.trutri=chua.trutri;
                k.capnhat = DateTime.Now;
                context.Update(k);
                context.SaveChanges();
                return ErrorMessage.ThanhCong;
            }
        }

        public ErrorMessage Them(Chua chua)
        {
            var k = context.chuas.Find(chua.chuaId);
            if (k != null)
            {
                return ErrorMessage.DaTonTai;
            }
            else
            {
                var newChua = new Chuas
                {
                    chuaId=chua.chuaId,
                    diaChi = chua.diaChi,
                    ngayThanhLap= chua.ngayThanhLap,
                    tenChua= chua.tenChua,
                    trutri= chua.trutri,
                };
                context.Add(newChua);
                context.SaveChanges();
                return ErrorMessage.ThanhCong;
            }
        }

        public PageResult<Chuas> Timkiem(string? ten, Pagination pagination)
        {
            var list = context.chuas.ToList();
            if (!string.IsNullOrEmpty(ten))
            {
                list = list.Where(x => x.tenChua.ToLower().Contains(ten.ToLower())).ToList();
            }
            var result = PageResult<Chuas>.ToPageResult(pagination, list);
            pagination.TotalCount = list.Count();
            return new PageResult<Chuas>(pagination, result);
        }

        public ErrorMessage Xoa(int chuaId)
        {
            var k = context.chuas.Find(chuaId);
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
