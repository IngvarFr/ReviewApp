using JsonParseTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReviewApp.Implementation
{
    public class ReviewService : IReviewService
    {
        private List<Review> _reviews;
        public List<Review> Reviews
        {
            get{ return _reviews; }
  
            set
            {
                _reviews = value;
                PopulateMovies();
            }
        }
        public List<Movie> Movies { get; set; }

        public void PopulateMovies()
        {
            Movies = new List<Movie>();

            var list = _reviews.Select(r => r.Movie).Distinct();
            foreach (var movie in list)
            {
                Movies.Add(new Movie() { Id = movie });
            }

            foreach (var movie in Movies)
            {
                var grades = _reviews.Where(r => r.Movie == movie.Id).Select(r => r.Grade);
                movie.TopGrades = grades.Where(g => g == 5).Count();
                movie.AvgRating = Math.Round(grades.Average(), 2, MidpointRounding.AwayFromZero);
            }
        }

        public double AverageGradeFromReviewer(int reviewer)
        {
            var grades = _reviews.Where(r => r.Reviewer == reviewer).Select(r => r.Grade);
            return Math.Round(grades.Average(),2,MidpointRounding.AwayFromZero);
        }

        public double AverageGradeOfMovie(int movie)
        {
            var grades = _reviews.Where(r => r.Movie == movie).Select(r => r.Grade);
            return Math.Round(grades.Average(),2, MidpointRounding.AwayFromZero);
        }

        public int GradeCountForMovie(int movie, int grade)
        {
            var list = _reviews.Where(r => r.Movie == movie && r.Grade == grade);
            return list.Count();
        }

        public int GradeCountFromReviewer(int reviewer, int grade)
        {
            var list = _reviews.Where(r => r.Reviewer == reviewer && r.Grade == grade);
            return list.Count();
        }

        public int ReviewerCountForMovie(int movie)
        {
            var list = _reviews.Where(r => r.Movie == movie).Select(r => r.Reviewer).Distinct();
            return list.Count();
        }

        public int ReviewsFromReviewer(int reviewer)
        {
            var list = _reviews.Where(r => r.Reviewer == reviewer);
            return list.Count();
        }

        public List<int> MostTopGradesMovies()
        {
            var list = Movies.OrderByDescending(m => m.TopGrades).Take(10).Select(m => m.Id);
            return list.ToList();
        }

        public List<int> TopReviewers()
        {
            var list = _reviews.Select(r => r.Reviewer).GroupBy(i => i).OrderByDescending(grp => grp.Count()).Select(grp => grp.Key).Distinct().Take(10);
            return list.ToList();
        }

        public List<int> TopMovies(int count)
        {
            var list = Movies.OrderByDescending(m => m.AvgRating).Take(count).Select(m => m.Id);
            return list.ToList();
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
