using JsonParseTest;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReviewApp.Implementation
{
    public interface IReviewService
    {
        List<Review> Reviews { get; set; }

        int ReviewsFromReviewer(int reviewer);
        double AverageGradeFromReviewer(int reviewer);
        int GradeCountFromReviewer(int reviewer, int grade);
        int ReviewerCountForMovie(int movie);
        double AverageGradeOfMovie(int movie);
        int GradeCountForMovie(int movie, int grade);
        List<int> MostTopGradesMovies();
        List<int> TopReviewers();
        List<int> TopMovies(int count);
        List<int> MoviesByReviewer(int reviewer);
        List<int> ReviewersOfMovie(int movie);
    }
}
