using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.Models
{
    public class PieRepository : IPieRepository
    {
        private readonly AppDbContext appDbContext;

        public PieRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public IEnumerable<Pie> GetAllPies()
        {
            return appDbContext.Pies;
        }

        public Pie GetPieById(int pieId)
        {
            return appDbContext.Pies.FirstOrDefault(pie => pie.Id == pieId);
        }
    }
}
