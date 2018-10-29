using JsonParseTest;
using ReviewApp.Implementation;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ReviewApp.Testing
{
    public class ReviewTest
    {
        [Fact]
        public void HowManyReviewsTest()
        {
            IReviewService service = new ReviewService();
            var reviews = new List<Review>()
            {
                new Review(){ Reviewer = 1, Movie = 2341, Grade = 3, Date = "2003-02-03" },
                new Review(){ Reviewer = 1, Movie = 2341, Grade = 3, Date = "2003-02-03" },
                new Review(){ Reviewer = 1, Movie = 2341, Grade = 3, Date = "2003-02-03" },
                new Review(){ Reviewer = 1, Movie = 2341, Grade = 3, Date = "2003-02-03" },
                new Review(){ Reviewer = 2, Movie = 2341, Grade = 3, Date = "2003-02-03" },
                new Review(){ Reviewer = 2, Movie = 2341, Grade = 3, Date = "2003-02-03" },
                new Review(){ Reviewer = 2, Movie = 2341, Grade = 3, Date = "2003-02-03" },
                new Review(){ Reviewer = 2, Movie = 2341, Grade = 3, Date = "2003-02-03" },
                new Review(){ Reviewer = 3, Movie = 2341, Grade = 3, Date = "2003-02-03" },
                new Review(){ Reviewer = 3, Movie = 2341, Grade = 3, Date = "2003-02-03" },
            };
            service.Reviews = reviews;

            Assert.True(service.HowManyReviewsFromReviewer(3) == 2);
        }
    }
}
