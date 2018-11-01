using JsonParseTest;
using ReviewApp.Implementation;
using System;

namespace ReviewApp.Cnsl
{
    class Program
    {
        static void Main(string[] args)
        {
            var parser = new Parser();
            IReviewService service = new ReviewService();
            Console.WriteLine("Starting parsing");
            var start = DateTime.Now;
            parser.ParseReviews();
            service.Reviews = parser.Reviews;
            var end = DateTime.Now;
            var time = end - start;
            Console.WriteLine($"Time of parsing: {time}");
            
            Console.ReadLine();

            Console.WriteLine("Starting function one");
            start = DateTime.Now;
            Console.WriteLine($"Number of reviews from reviewer 1: {service.ReviewsFromReviewer(1)}");
            end = DateTime.Now;
            time = end - start;
            Console.WriteLine($"Time: {time}");
            Console.ReadLine();

            Console.WriteLine("Starting function two");
            start = DateTime.Now;
            Console.WriteLine($"Average rating from reviewer 1: {service.AverageGradeFromReviewer(1)}");
            end = DateTime.Now;
            time = end - start;
            Console.WriteLine($"Time: {time}");
            Console.ReadLine();

            Console.WriteLine("Starting function three");
            start = DateTime.Now;
            Console.WriteLine($"How many times has reviewer 6 given a rating of 4: {service.GradeCountFromReviewer(6, 4)}");
            end = DateTime.Now;
            time = end - start;
            Console.WriteLine($"Time: {time}");
            Console.ReadLine();

            Console.WriteLine("Starting function four");
            start = DateTime.Now;
            Console.WriteLine($"How many reviewers have reviewed movie 543865: {service.ReviewerCountForMovie(543865)}");
            end = DateTime.Now;
            time = end - start;
            Console.WriteLine($"Time: {time}");
            Console.ReadLine();

            Console.WriteLine("Starting function five");
            start = DateTime.Now;
            Console.WriteLine($"Average rating for movie 543865: {service.AverageGradeOfMovie(543685)}");
            end = DateTime.Now;
            time = end - start;
            Console.WriteLine($"Time: {time}");
            Console.ReadLine();

            Console.WriteLine("Starting function six");
            start = DateTime.Now;
            Console.WriteLine($"How many times has movie 543865 gotten a grade of 3: {service.GradeCountForMovie(543865, 3)}");
            end = DateTime.Now;
            time = end - start;
            Console.WriteLine($"Time: {time}");
            Console.ReadLine();

            Console.WriteLine("Starting function seven");
            start = DateTime.Now;
            Console.WriteLine("What are the movies with the most 5 ratings: ");
            foreach (var movie in service.MostTopGradesMovies())
            {
                Console.Write(movie + ", ");
            }
            end = DateTime.Now;
            time = end - start;
            Console.WriteLine();
            Console.WriteLine($"Time: {time}");
            Console.ReadLine();

            Console.WriteLine("Starting function eight");
            start = DateTime.Now;
            Console.WriteLine("What reviewers have the most reviews: ");
            foreach (var reviewer in service.TopReviewers())
            {
                Console.Write(reviewer + ", ");
            }
            end = DateTime.Now;
            time = end - start;
            Console.WriteLine();
            Console.WriteLine($"Time: {time}");
            Console.ReadLine();

            Console.WriteLine("Starting function nine");
            start = DateTime.Now;
            Console.WriteLine("What are the top 10 movies (average rating): ");
            foreach (var movie in service.TopMovies(10))
            {
                Console.Write(movie + ", ");
            }
            end = DateTime.Now;
            time = end - start;
            Console.WriteLine();
            Console.WriteLine($"Time: {time}");
            Console.ReadLine();

            Console.WriteLine("Starting function ten");
            start = DateTime.Now;
            Console.WriteLine("What movies has reviewer 20 reviewed: ");
            foreach (var movie in service.MoviesByReviewer(20))
            {
                Console.Write(movie + ", ");
            }
            end = DateTime.Now;
            time = end - start;
            Console.WriteLine();
            Console.WriteLine($"Time: {time}");
            Console.ReadLine();

            Console.WriteLine("Starting function eleven");
            start = DateTime.Now;
            Console.WriteLine("What reviewers have reviewed movie 543865: ");
            foreach (var reviewer in service.ReviewersOfMovie(543865))
            {
                Console.Write(reviewer + ", ");
            }
            end = DateTime.Now;
            time = end - start;
            Console.WriteLine();
            Console.WriteLine($"Time: {time}");
            Console.ReadLine();
        }
    }
}
