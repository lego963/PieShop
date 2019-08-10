using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.Models
{
    public class FeedbackRepository : IFeedbackRepository
    {
        private readonly AppDbContext appDbContext;

        public FeedbackRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public void AddFeedback(Feedback feedback)
        {
            appDbContext.Feedbacks.Add(feedback);
            appDbContext.SaveChanges();
        }
    }
}
