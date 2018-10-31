using JsonParseTest;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReviewApp.Implementation
{
    public interface IReviewService
    {
        // The container for the reviews parsed into the application.
        IEnumerable<Review> Reviews { get; set; }

        // Returns the number of reviews from the reviewer.
        int ReviewsFromReviewer(int reviewer);

        // Returns the average grade the reviewer has given.
        double AverageGradeFromReviewer(int reviewer);

        // Returns the number of times a reviewer has given a certain grade.
        int GradeCountFromReviewer(int reviewer, int grade);

        // Returns the amount of reviewers who have graded a certain movie.
        int ReviewerCountForMovie(int movie);

        // Returns the average grade of a certain movie.
        double AverageGradeOfMovie(int movie);

        // Returns the number of times a movie has been given a certain grade.
        int GradeCountForMovie(int movie, int grade);

        // Returns the 10 movies which have the most 5 grades.
        List<int> MostTopGradesMovies();

        // Returns the 10 Reviewers with the most reviews.
        List<int> TopReviewers();

        // Returns a number of movies with the highest average grade. 
        List<int> TopMovies(int count);

        // Returns a list of movies a certain reviewer has reviewed.
        List<int> MoviesByReviewer(int reviewer);

        // Returns a list of reviewers which have reviewed a movie
        List<int> ReviewersOfMovie(int movie);
    }
}
