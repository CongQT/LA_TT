using TT.Constant;
using TT.Data;
using TT.Entities;
using TT.IService;

namespace TT.Service
{
    public class PhatTuService : IPhatTu
    {
        private readonly AppDbContext context;
        public PhatTuService()
        {
            context = new AppDbContext();
        }

        public ErrorMessage Xoa(int phatTuId)
        {
            var k = context.phattus.Find(phatTuId);
            if (k == null)
            {
                return ErrorMessage.KhongTonTai;
            }
            else
            {
                k.isActive = false;
                context.Update(k);
                context.SaveChanges();
                return ErrorMessage.ThanhCong;
            }
        }

        PageResult<Phattu> IPhatTu.Timkiem(string? ten, string? phapDanh, string? email, int? gioiTinh, Pagination pagination)
        {
            var list = context.phattus.Where(x=>x.isActive==true).ToList();
            if (!string.IsNullOrEmpty(ten))
            {
                list = list.Where(x => x.ten.ToLower().Contains(ten.ToLower())).ToList();
            }
            if (!string.IsNullOrEmpty(email))
            {
                list = list.Where(x => x.email.ToLower().Contains(email.ToLower())).ToList();
            }
            if (!string.IsNullOrEmpty(phapDanh))
            {
                list=list.Where(x=>x.phapDanh.ToLower().Contains(phapDanh.ToLower())).ToList();
            }
            if (gioiTinh.HasValue)
            {
                list = list.Where(x => x.gioiTinh.Equals(gioiTinh)).ToList();
            }
            var result = PageResult<Phattu>.ToPageResult(pagination, list);
            pagination.TotalCount = list.Count();
            return new PageResult<Phattu>(pagination, result);
        }
    }
}
