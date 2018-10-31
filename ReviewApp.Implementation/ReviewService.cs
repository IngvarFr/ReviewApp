using JsonParseTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReviewApp.Implementation
{
    public class ReviewService : IReviewService
    {
        private IEnumerable<Review> _reviews;
        public IEnumerable<Review> Reviews
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
            var movies = _reviews.Select(r => r.Movie).Distinct();

            foreach (var movie in movies)
            {
                Movies.Add(new Movie() { Id = movie, Grades = new List<int>() });
            }

            //foreach (var rev in _reviews)
            //{
            //    GetMovieById(rev.Movie).Grades.Add(rev.Grade);
            //}

            //foreach (var movie in Movies)
            //{
            //    var grades = _reviews.Where(r => r.Movie == movie.Id).Select(r => r.Grade);
            //    movie.TopGrades = grades.Where(g => g == 5).Count();
            //    movie.AvgRating = Math.Round(grades.Average(), 2, MidpointRounding.AwayFromZero);
            //}
        }

        private Movie GetMovieById(int id)
        {
            return Movies.FirstOrDefault(m => m.Id == id);
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
            var list = _reviews.Where(r => r.Grade == 5).Select(r => r.Movie).GroupBy(i => i).OrderByDescending(grp => grp.Count()).Select(grp => grp.Key).Distinct().Take(10);
            return list.ToList();
        }

        public List<int> TopReviewers()
        {
            var list = _reviews.Select(r => r.Reviewer).GroupBy(i => i).OrderByDescending(grp => grp.Count()).Select(grp => grp.Key).Distinct().Take(10);
            return list.ToList();
        }

        public List<int> TopMovies(int count)
        {
            //foreach (var movie in Movies)
            //{
            //    movie.AverageGrade = Math.Round(movie.Grades.Average(), 2, MidpointRounding.AwayFromZero);
            //}

            return Movies.OrderByDescending(m => m.AverageGrade).Take(count).Select(m => m.Id).ToList();
        }

        public List<int> MoviesByReviewer(int reviewer)
        {
            var list = _reviews.Where(r => r.Reviewer == reviewer).OrderByDescending(r => r.Grade).ThenByDescending(r => r.Date).Select(r => r.Movie).Distinct();
            return list.ToList();
        }

        public List<int> ReviewersOfMovie(int movie)
        {
            var list = _reviews.Where(r => r.Movie == movie).OrderByDescending(r => r.Grade).ThenByDescending(r => r.Date).Select(r => r.Reviewer).Distinct();
            return list.ToList();
        }
    }
}
