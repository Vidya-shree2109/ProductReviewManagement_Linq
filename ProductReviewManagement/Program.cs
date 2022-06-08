using System;
using System.Collections.Generic;

namespace ProductReviewManagement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t\tWELCOME TO PRODUCT REVIEW MANAGEMENT\t\t\t\t\t\n");
            List<ProductReview> reviewList = new List<ProductReview>();
            reviewList.Add(new ProductReview() { ProductId = 1, UserId = 1, Rating = 5, ReviewList = "Good", IsLike = "True" });
            reviewList.Add(new ProductReview() { ProductId = 2, UserId = 2, Rating = 4, ReviewList = "Ok", IsLike = "True" });
            reviewList.Add(new ProductReview() { ProductId = 3, UserId = 3, Rating = 4, ReviewList = "OK", IsLike = "True" });
            reviewList.Add(new ProductReview() { ProductId = 4, UserId = 4, Rating = 3, ReviewList = "Average", IsLike = "True" });
            reviewList.Add(new ProductReview() { ProductId = 5, UserId = 5, Rating = 2, ReviewList = "Normal", IsLike = "False" });
            reviewList.Add(new ProductReview() { ProductId = 6, UserId = 6, Rating = 1, ReviewList = "Worst", IsLike = "False" });
            reviewList.Add(new ProductReview() { ProductId = 7, UserId = 7, Rating = 5, ReviewList = "Good", IsLike = "True" });
            reviewList.Add(new ProductReview() { ProductId = 8, UserId = 8, Rating = 5, ReviewList = "Good", IsLike = "True" });
            reviewList.Add(new ProductReview() { ProductId = 9, UserId = 9, Rating = 4, ReviewList = "Ok", IsLike = "True" });
            reviewList.Add(new ProductReview() { ProductId = 10, UserId = 10, Rating = 3, ReviewList = "Average", IsLike = "True" });
            reviewList.Add(new ProductReview() { ProductId = 11, UserId = 11, Rating = 4, ReviewList = "Ok", IsLike = "True" });
            reviewList.Add(new ProductReview() { ProductId = 12, UserId = 12, Rating = 4, ReviewList = "Ok", IsLike = "True" });
            reviewList.Add(new ProductReview() { ProductId = 13, UserId = 13, Rating = 2, ReviewList = "Normal", IsLike = "False" });
            reviewList.Add(new ProductReview() { ProductId = 14, UserId = 14, Rating = 3, ReviewList = "Average", IsLike = "True" });
            reviewList.Add(new ProductReview() { ProductId = 15, UserId = 15, Rating = 3, ReviewList = "Average", IsLike = "True" });
            reviewList.Add(new ProductReview() { ProductId = 16, UserId = 16, Rating = 4, ReviewList = "Ok", IsLike = "True" });
            reviewList.Add(new ProductReview() { ProductId = 17, UserId = 17, Rating = 4, ReviewList = "Ok", IsLike = "True" });
            reviewList.Add(new ProductReview() { ProductId = 18, UserId = 18, Rating = 5, ReviewList = "Good", IsLike = "True" });
            reviewList.Add(new ProductReview() { ProductId = 19, UserId = 19, Rating = 1, ReviewList = "Worst", IsLike = "False" });
            reviewList.Add(new ProductReview() { ProductId = 20, UserId = 20, Rating = 2, ReviewList = "Normal", IsLike = "False" });
            reviewList.Add(new ProductReview() { ProductId = 21, UserId = 21, Rating = 3, ReviewList = "Average", IsLike = "True" });
            reviewList.Add(new ProductReview() { ProductId = 22, UserId = 22, Rating = 4, ReviewList = "Ok", IsLike = "True" });
            reviewList.Add(new ProductReview() { ProductId = 23, UserId = 23, Rating = 5, ReviewList = "Good", IsLike = "True" });
            reviewList.Add(new ProductReview() { ProductId = 24, UserId = 24, Rating = 3, ReviewList = "Average", IsLike = "True" });
            reviewList.Add(new ProductReview() { ProductId = 25, UserId = 25, Rating = 4, ReviewList = "Ok", IsLike = "True" });

            Operations operation = new Operations();
        }
    }
}