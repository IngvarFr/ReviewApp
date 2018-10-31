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

        /// <summary>
        /// Returns the number of reviews from the reviewer.
        /// </summary>
        /// <param name="reviewer"></param>
        /// <returns></returns>
        int ReviewsFromReviewer(int reviewer);

        /// <summary>
        /// Returns the average grade the reviewer has given.
        /// </summary>
        /// <param name="reviewer"></param>
        /// <returns></returns>
        double AverageGradeFromReviewer(int reviewer);

        /// <summary>
        /// Returns the number of times a reviewer has given a certain grade.
        /// </summary>
        /// <param name="reviewer"></param>
        /// <param name="grade"></param>
        /// <returns></returns>
        int GradeCountFromReviewer(int reviewer, int grade);

        /// <summary>
        /// Returns the amount of reviewers who have graded a certain movie.
        /// </summary>
        /// <param name="movie"></param>
        /// <returns></returns>
        int ReviewerCountForMovie(int movie);

        /// <summary>
        /// Returns the average grade of a certain movie.
        /// </summary>
        /// <param name="movie"></param>
        /// <returns></returns>
        double AverageGradeOfMovie(int movie);

        /// <summary>
        /// Returns the number of times a movie has been given a certain grade.
        /// </summary>
        /// <param name="movie"></param>
        /// <param name="grade"></param>
        /// <returns></returns>
        int GradeCountForMovie(int movie, int grade);

        /// <summary>
        /// Returns the 10 movies which have the most 5 grades.
        /// </summary>
        /// <returns></returns>
        List<int> MostTopGradesMovies();

        /// <summary>
        /// Returns the 10 Reviewers with the most reviews.
        /// </summary>
        /// <returns></returns>
        List<int> TopReviewers();

        /// <summary>
        /// Returns a number of movies with the highest average grade.
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        List<int> TopMovies(int count);

        /// <summary>
        /// Returns a list of movies a certain reviewer has reviewed.
        /// </summary>
        /// <param name="reviewer"></param>
        /// <returns></returns>
        List<int> MoviesByReviewer(int reviewer);

        /// <summary>
        /// Returns a list of reviewers which have reviewed a movie.
        /// </summary>
        /// <param name="movie"></param>
        /// <returns></returns>
        List<int> ReviewersOfMovie(int movie);
    }
}
