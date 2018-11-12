using JsonParseTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReviewApp.Implementation
{
    public class ReviewService : IReviewService
    {
        public IEnumerable<Review> Reviews { get; set; }

        public double AverageGradeFromReviewer(int reviewer)
        {
            var grades = Reviews.Where(r => r.Reviewer == reviewer).Select(r => r.Grade);
            return Math.Round(grades.Average(), 2, MidpointRounding.AwayFromZero);
        }

        public double AverageGradeOfMovie(int movie)
        {
            var grades = Reviews.Where(r => r.Movie == movie).Select(r => r.Grade);
            return Math.Round(grades.Average(),2, MidpointRounding.AwayFromZero);
        }

        public int GradeCountForMovie(int movie, int grade)
        {
            var list = Reviews.Where(r => r.Movie == movie && r.Grade == grade);
            return list.Count();
        }

        public int GradeCountFromReviewer(int reviewer, int grade)
        {
            var list = Reviews.Where(r => r.Reviewer == reviewer && r.Grade == grade);
            return list.Count();
        }

        public int ReviewerCountForMovie(int movie)
        {
            var list = Reviews.Where(r => r.Movie == movie).Select(r => r.Reviewer).Distinct();
            return list.Count();
        }

        public int ReviewsFromReviewer(int reviewer)
        {
            var list = Reviews.Where(r => r.Reviewer == reviewer);
            return list.Count();
        }

        public List<int> MostTopGradesMovies()
        {
            var list = Reviews.Where(r => r.Grade == 5).Select(r => r.Movie).GroupBy(i => i).OrderByDescending(grp => grp.Count()).Select(grp => grp.Key).Distinct().Take(10);
            return list.ToList();
        }

        public List<int> TopReviewers()
        {
            var list = Reviews.Select(r => r.Reviewer).GroupBy(i => i).OrderByDescending(grp => grp.Count()).Select(grp => grp.Key).Distinct().Take(10);
            return list.ToList();
        }

        public List<int> TopMovies(int count)
        {
            var group = Reviews.GroupBy(r => r.Movie).Select(r => new
            {
                Movie = r.Key,
                AvgGrade = r.Select(v => v.Grade).Average()
            });

            return group.OrderByDescending(r => r.AvgGrade).Select(r => r.Movie).Take(count).ToList();
        }

        public List<int> MoviesByReviewer(int reviewer)
        {
            var list = Reviews.Where(r => r.Reviewer == reviewer).OrderByDescending(r => r.Grade).ThenByDescending(r => r.Date).Select(r => r.Movie).Distinct();
            return list.ToList();
        }

        public List<int> ReviewersOfMovie(int movie)
        {
            var list = Reviews.Where(r => r.Movie == movie).OrderByDescending(r => r.Grade).ThenByDescending(r => r.Date).Select(r => r.Reviewer).Distinct();
            return list.ToList();
        }
    }
}
