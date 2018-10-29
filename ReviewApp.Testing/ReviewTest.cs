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
            Assert.True(service.HowManyReviewsFromReviewer(1) == 4);
            Assert.True(service.HowManyReviewsFromReviewer(2) == 4);
        }

        [Fact]
        public void AverageGradeTest()
        {
            IReviewService service = new ReviewService();
            var reviews = new List<Review>()
            {
                new Review(){ Reviewer = 1, Movie = 2341, Grade = 1, Date = "2003-02-03" },
                new Review(){ Reviewer = 1, Movie = 2341, Grade = 2, Date = "2003-02-03" },
                new Review(){ Reviewer = 1, Movie = 2341, Grade = 3, Date = "2003-02-03" },
                new Review(){ Reviewer = 1, Movie = 2341, Grade = 5, Date = "2003-02-03" },
                new Review(){ Reviewer = 2, Movie = 2341, Grade = 4, Date = "2003-02-03" },
                new Review(){ Reviewer = 2, Movie = 2341, Grade = 5, Date = "2003-02-03" },
                new Review(){ Reviewer = 2, Movie = 2341, Grade = 3, Date = "2003-02-03" },
                new Review(){ Reviewer = 2, Movie = 2341, Grade = 1, Date = "2003-02-03" },
                new Review(){ Reviewer = 3, Movie = 2341, Grade = 2, Date = "2003-02-03" },
                new Review(){ Reviewer = 3, Movie = 2341, Grade = 4, Date = "2003-02-03" },
            };
            service.Reviews = reviews;

            Assert.True(service.AverageGradeFromReviewer(1) == 2.75);
            Assert.True(service.AverageGradeFromReviewer(2) == 3.25);
            Assert.True(service.AverageGradeFromReviewer(3) == 3);
        }
    }
}
