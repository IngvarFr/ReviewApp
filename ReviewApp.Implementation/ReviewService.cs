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

        public double AverageGradeFromReviewer(int reviewer)
        {
            var grades = Reviews.Where(r => r.Reviewer == reviewer).Select(r => r.Grade);
            return grades.Average();
        }

        public int GradeCountFromReviewer(int reviewer, int grade)
        {
            var list = Reviews.Where(r => r.Reviewer == reviewer && r.Grade == grade);
            return list.Count();
        }

        public int ReviewsFromReviewer(int reviewer)
        {
            var list = Reviews.Where(r => r.Reviewer == reviewer);
            return list.Count();
        }
    }
}
