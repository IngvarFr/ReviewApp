using JsonParseTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReviewApp.Implementation
{
    public class ReviewService : IReviewService
    {
        public List<Review> Reviews { get; set; }

        public int HowManyReviewsFromReviewer(int reviewer)
        {
            var list = Reviews.Where(r => r.Reviewer == reviewer);
            return list.Count();
        }
    }
}
