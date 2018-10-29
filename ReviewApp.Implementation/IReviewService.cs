﻿using JsonParseTest;
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
    }
}
