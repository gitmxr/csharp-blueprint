using Microsoft.EntityFrameworkCore;

namespace BethanysPieShop.Models
{
    public class PieRepository : IPieRepository
    {
        private readonly BethanysPieShopDbContext _bethanysPieShopDbContext;
        public PieRepository(BethanysPieShopDbContext bethanysPieShopDbContext)
        {
            _bethanysPieShopDbContext = bethanysPieShopDbContext;
        }
       public IEnumerable<Pie> AllPies 
        {
            get
            {
                return _bethanysPieShopDbContext.Pies.Include(c => c.Category);
            }
        }
        public IEnumerable<Pie> PiesOfTheWeek 
        {
            get
            { 
                return _bethanysPieShopDbContext.Pies.Include(_ => _.Category).Where(p =>
                p.IsPieOfTheWeek);
            }
        }
       public  Pie? GetPieById(int pieid)
        {
            return _bethanysPieShopDbContext.Pies.FirstOrDefault( p => p.PieId == pieid);
        }
    }
}
