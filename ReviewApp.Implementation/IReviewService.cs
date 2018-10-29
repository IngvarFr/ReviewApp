using JsonParseTest;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReviewApp.Implementation
{
    public interface IReviewService
    {
        List<Review> Reviews { get; set; }

        int HowManyReviewsFromReviewer(int reviewer);
        
    }
}
