﻿using JsonParseTest;
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

            Assert.True(service.ReviewsFromReviewer(3) == 2);
            Assert.True(service.ReviewsFromReviewer(1) == 4);
            Assert.True(service.ReviewsFromReviewer(2) == 4);
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

            Assert.True(service.AverageGradeFromReviewer(2) == 2.75);
            Assert.True(service.AverageGradeFromReviewer(2) == 3.25);
            Assert.True(service.AverageGradeFromReviewer(3) == 3);
        }

        [Fact]
        public void GradeCountTest()
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
                new Review(){ Reviewer = 2, Movie = 2341, Grade = 5, Date = "2003-02-03" },
                new Review(){ Reviewer = 3, Movie = 2341, Grade = 2, Date = "2003-02-03" },
                new Review(){ Reviewer = 3, Movie = 2341, Grade = 4, Date = "2003-02-03" },
            };
            service.Reviews = reviews;

            Assert.True(service.GradeCountFromReviewer(1, 1) == 1);
            Assert.True(service.GradeCountFromReviewer(2, 5) == 2);
            Assert.True(service.GradeCountFromReviewer(3, 4) == 1);
        }

        [Fact]
        public void HowManyReviewsForMovieTest()
        {
            IReviewService service = new ReviewService();
            var reviews = new List<Review>()
            {
                new Review(){ Reviewer = 1, Movie = 1000, Grade = 1, Date = "2003-02-03" },
                new Review(){ Reviewer = 1, Movie = 2341, Grade = 2, Date = "2003-02-03" },
                new Review(){ Reviewer = 1, Movie = 2341, Grade = 3, Date = "2003-02-03" },
                new Review(){ Reviewer = 1, Movie = 2341, Grade = 5, Date = "2003-02-03" },
                new Review(){ Reviewer = 2, Movie = 2341, Grade = 4, Date = "2003-02-03" },
                new Review(){ Reviewer = 2, Movie = 6343, Grade = 5, Date = "2003-02-03" },
                new Review(){ Reviewer = 2, Movie = 2341, Grade = 3, Date = "2003-02-03" },
                new Review(){ Reviewer = 2, Movie = 2341, Grade = 5, Date = "2003-02-03" },
                new Review(){ Reviewer = 3, Movie = 2341, Grade = 2, Date = "2003-02-03" },
                new Review(){ Reviewer = 3, Movie = 6343, Grade = 4, Date = "2003-02-03" },
            };
            service.Reviews = reviews;

            Assert.True(service.ReviewerCountForMovie(2341) == 3);
            Assert.True(service.ReviewerCountForMovie(6343) == 2);
            Assert.True(service.ReviewerCountForMovie(1000) == 1);
        }

        [Fact]
        public void AverageGradeForMovieTest()
        {
            IReviewService service = new ReviewService();
            var reviews = new List<Review>()
            {
                new Review(){ Reviewer = 1, Movie = 1000, Grade = 1, Date = "2003-02-03" },
                new Review(){ Reviewer = 1, Movie = 2341, Grade = 2, Date = "2003-02-03" },
                new Review(){ Reviewer = 1, Movie = 2341, Grade = 3, Date = "2003-02-03" },
                new Review(){ Reviewer = 1, Movie = 2341, Grade = 5, Date = "2003-02-03" },
                new Review(){ Reviewer = 2, Movie = 2341, Grade = 4, Date = "2003-02-03" },
                new Review(){ Reviewer = 2, Movie = 6343, Grade = 5, Date = "2003-02-03" },
                new Review(){ Reviewer = 2, Movie = 2341, Grade = 3, Date = "2003-02-03" },
                new Review(){ Reviewer = 2, Movie = 2341, Grade = 5, Date = "2003-02-03" },
                new Review(){ Reviewer = 3, Movie = 2341, Grade = 2, Date = "2003-02-03" },
                new Review(){ Reviewer = 3, Movie = 6343, Grade = 4, Date = "2003-02-03" },
            };
            service.Reviews = reviews;

            Assert.True(service.AverageGradeOfMovie(1000) == 1);
            Assert.True(service.AverageGradeOfMovie(6343) == 4.5);
            Assert.True(service.AverageGradeOfMovie(2341) == 3.43);
        }

        [Fact]
        public void GradeCountForMovieTest()
        {
            IReviewService service = new ReviewService();
            var reviews = new List<Review>()
            {
                new Review(){ Reviewer = 1, Movie = 1000, Grade = 1, Date = "2003-02-03" },
                new Review(){ Reviewer = 1, Movie = 2341, Grade = 2, Date = "2003-02-03" },
                new Review(){ Reviewer = 1, Movie = 2341, Grade = 3, Date = "2003-02-03" },
                new Review(){ Reviewer = 1, Movie = 2341, Grade = 5, Date = "2003-02-03" },
                new Review(){ Reviewer = 2, Movie = 2341, Grade = 4, Date = "2003-02-03" },
                new Review(){ Reviewer = 2, Movie = 6343, Grade = 5, Date = "2003-02-03" },
                new Review(){ Reviewer = 2, Movie = 2341, Grade = 3, Date = "2003-02-03" },
                new Review(){ Reviewer = 2, Movie = 2341, Grade = 5, Date = "2003-02-03" },
                new Review(){ Reviewer = 3, Movie = 2341, Grade = 2, Date = "2003-02-03" },
                new Review(){ Reviewer = 3, Movie = 6343, Grade = 4, Date = "2003-02-03" },
            };
            service.Reviews = reviews;

            Assert.True(service.GradeCountForMovie(2341, 5) == 2);
            Assert.True(service.GradeCountForMovie(2341, 3) == 2);
        }

        [Fact]
        public void TopGradeMoviesTest()
        {
            IReviewService service = new ReviewService();
            var reviews = new List<Review>()
            {
                new Review(){ Reviewer = 1, Movie = 1000, Grade = 5, Date = "2003-02-03" },
                new Review(){ Reviewer = 1, Movie = 2341, Grade = 2, Date = "2003-02-03" },
                new Review(){ Reviewer = 1, Movie = 2341, Grade = 3, Date = "2003-02-03" },
                new Review(){ Reviewer = 1, Movie = 2341, Grade = 5, Date = "2003-02-03" },
                new Review(){ Reviewer = 2, Movie = 2341, Grade = 4, Date = "2003-02-03" },
                new Review(){ Reviewer = 2, Movie = 6343, Grade = 5, Date = "2003-02-03" },
                new Review(){ Reviewer = 2, Movie = 2341, Grade = 3, Date = "2003-02-03" },
                new Review(){ Reviewer = 2, Movie = 2341, Grade = 5, Date = "2003-02-03" },
                new Review(){ Reviewer = 3, Movie = 2341, Grade = 2, Date = "2003-02-03" },
                new Review(){ Reviewer = 3, Movie = 6343, Grade = 4, Date = "2003-02-03" },
            };
            service.Reviews = reviews;

            Assert.True(service.MostTopGradesMovies()[0] == 2341);
            Assert.True(service.MostTopGradesMovies()[1] == 1000);
            Assert.True(service.MostTopGradesMovies().Count == 3);
        }

        [Fact]
        public void TopReviewersTest()
        {
            IReviewService service = new ReviewService();
            var reviews = new List<Review>()
            {
                new Review(){ Reviewer = 1, Movie = 1000, Grade = 5, Date = "2003-02-03" },
                new Review(){ Reviewer = 1, Movie = 2341, Grade = 2, Date = "2003-02-03" },
                new Review(){ Reviewer = 1, Movie = 2341, Grade = 3, Date = "2003-02-03" },
                new Review(){ Reviewer = 1, Movie = 2341, Grade = 5, Date = "2003-02-03" },
                new Review(){ Reviewer = 2, Movie = 2341, Grade = 4, Date = "2003-02-03" },
                new Review(){ Reviewer = 2, Movie = 6343, Grade = 5, Date = "2003-02-03" },
                new Review(){ Reviewer = 2, Movie = 2341, Grade = 3, Date = "2003-02-03" },
                new Review(){ Reviewer = 2, Movie = 2341, Grade = 5, Date = "2003-02-03" },
                new Review(){ Reviewer = 3, Movie = 2341, Grade = 2, Date = "2003-02-03" },
                new Review(){ Reviewer = 3, Movie = 6343, Grade = 4, Date = "2003-02-03" },
            };
            service.Reviews = reviews;

            Assert.True(service.TopReviewers()[0] == 1);
            Assert.True(service.TopReviewers()[1] == 2);
            Assert.True(service.TopReviewers().Count == 3);
        }

        [Fact]
        public void TopMoviesTest()
        {
            IReviewService service = new ReviewService();
            var reviews = new List<Review>()
            {
                new Review(){ Reviewer = 1, Movie = 1000, Grade = 5, Date = "2003-02-03" },
                new Review(){ Reviewer = 1, Movie = 2341, Grade = 2, Date = "2003-02-03" },
                new Review(){ Reviewer = 1, Movie = 2341, Grade = 3, Date = "2003-02-03" },
                new Review(){ Reviewer = 1, Movie = 2341, Grade = 5, Date = "2003-02-03" },
                new Review(){ Reviewer = 2, Movie = 2341, Grade = 4, Date = "2003-02-03" },
                new Review(){ Reviewer = 2, Movie = 6343, Grade = 5, Date = "2003-02-03" },
                new Review(){ Reviewer = 2, Movie = 2341, Grade = 3, Date = "2003-02-03" },
                new Review(){ Reviewer = 2, Movie = 2341, Grade = 5, Date = "2003-02-03" },
                new Review(){ Reviewer = 3, Movie = 2341, Grade = 2, Date = "2003-02-03" },
                new Review(){ Reviewer = 3, Movie = 6343, Grade = 4, Date = "2003-02-03" },
            };
            service.Reviews = reviews;
            var result = service.TopMovies(3);           
            Assert.True(service.TopMovies(3)[0] == 1000);
            Assert.True(service.TopMovies(3)[1] == 6343);
            Assert.True(service.TopMovies(3)[2] == 2341);
        }

        [Fact]
        public void MoviesByReviewerTest()
        {
            IReviewService service = new ReviewService();
            var reviews = new List<Review>()
            {
                new Review(){ Reviewer = 1, Movie = 1000, Grade = 5, Date = "2003-02-03" },
                new Review(){ Reviewer = 1, Movie = 2341, Grade = 2, Date = "2003-02-03" },
                new Review(){ Reviewer = 1, Movie = 2341, Grade = 3, Date = "2003-02-03" },
                new Review(){ Reviewer = 1, Movie = 2341, Grade = 5, Date = "2003-02-03" },
                new Review(){ Reviewer = 2, Movie = 2341, Grade = 4, Date = "2003-02-03" },
                new Review(){ Reviewer = 2, Movie = 6343, Grade = 5, Date = "2003-02-03" },
                new Review(){ Reviewer = 2, Movie = 2341, Grade = 3, Date = "2003-02-03" },
                new Review(){ Reviewer = 2, Movie = 2341, Grade = 5, Date = "2003-02-03" },
                new Review(){ Reviewer = 3, Movie = 2341, Grade = 2, Date = "2003-02-03" },
                new Review(){ Reviewer = 3, Movie = 6343, Grade = 4, Date = "2003-02-03" },
            };
            service.Reviews = reviews;

            Assert.True(service.MoviesByReviewer(1)[0] == 1000);
            Assert.True(service.MoviesByReviewer(1).Count == 2);
        }

        [Fact]
        public void ReviewersOfMovieTest()
        {
            IReviewService service = new ReviewService();
            var reviews = new List<Review>()
            {
                new Review(){ Reviewer = 1, Movie = 1000, Grade = 5, Date = "2003-02-03" },
                new Review(){ Reviewer = 1, Movie = 2341, Grade = 2, Date = "2003-02-03" },
                new Review(){ Reviewer = 1, Movie = 2341, Grade = 3, Date = "2003-02-03" },
                new Review(){ Reviewer = 1, Movie = 2341, Grade = 5, Date = "2003-02-03" },
                new Review(){ Reviewer = 2, Movie = 2341, Grade = 4, Date = "2003-02-03" },
                new Review(){ Reviewer = 2, Movie = 6343, Grade = 5, Date = "2003-02-03" },
                new Review(){ Reviewer = 2, Movie = 2341, Grade = 3, Date = "2003-02-03" },
                new Review(){ Reviewer = 2, Movie = 2341, Grade = 5, Date = "2003-02-03" },
                new Review(){ Reviewer = 3, Movie = 2341, Grade = 2, Date = "2003-02-03" },
                new Review(){ Reviewer = 3, Movie = 6343, Grade = 4, Date = "2003-02-03" },
            };
            service.Reviews = reviews;

            Assert.True(service.ReviewersOfMovie(2341)[0] == 1);
            Assert.True(service.ReviewersOfMovie(2341)[1] == 2);
            Assert.True(service.ReviewersOfMovie(2341).Count == 3);
        }
    }

}
