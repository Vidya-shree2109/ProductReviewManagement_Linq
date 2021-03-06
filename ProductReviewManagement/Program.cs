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
            reviewList.Add(new ProductReview() { ProductId = 2, UserId = 2, Rating = 4, ReviewList = "Nice", IsLike = "True" });
            reviewList.Add(new ProductReview() { ProductId = 3, UserId = 3, Rating = 4, ReviewList = "Nice", IsLike = "True" });
            reviewList.Add(new ProductReview() { ProductId = 4, UserId = 4, Rating = 4, ReviewList = "Nice", IsLike = "True" });
            reviewList.Add(new ProductReview() { ProductId = 5, UserId = 5, Rating = 2, ReviewList = "Normal", IsLike = "False" });
            reviewList.Add(new ProductReview() { ProductId = 6, UserId = 6, Rating = 1, ReviewList = "Worst", IsLike = "False" });
            reviewList.Add(new ProductReview() { ProductId = 7, UserId = 7, Rating = 5, ReviewList = "Good", IsLike = "True" });
            reviewList.Add(new ProductReview() { ProductId = 8, UserId = 8, Rating = 5, ReviewList = "Good", IsLike = "True" });
            reviewList.Add(new ProductReview() { ProductId = 9, UserId = 9, Rating = 4, ReviewList = "Nice", IsLike = "True" });
            reviewList.Add(new ProductReview() { ProductId = 10, UserId = 10, Rating = 3, ReviewList = "Average", IsLike = "True" });
            reviewList.Add(new ProductReview() { ProductId = 11, UserId = 10, Rating = 4, ReviewList = "Nice", IsLike = "True" });
            reviewList.Add(new ProductReview() { ProductId = 12, UserId = 10, Rating = 4, ReviewList = "Nice", IsLike = "True" });
            reviewList.Add(new ProductReview() { ProductId = 13, UserId = 10, Rating = 2, ReviewList = "Normal", IsLike = "False" });
            reviewList.Add(new ProductReview() { ProductId = 14, UserId = 10, Rating = 3, ReviewList = "Average", IsLike = "True" });
            reviewList.Add(new ProductReview() { ProductId = 15, UserId = 15, Rating = 3, ReviewList = "Average", IsLike = "True" });
            reviewList.Add(new ProductReview() { ProductId = 16, UserId = 16, Rating = 4, ReviewList = "Nice", IsLike = "True" });
            reviewList.Add(new ProductReview() { ProductId = 17, UserId = 17, Rating = 4, ReviewList = "Nice", IsLike = "True" });
            reviewList.Add(new ProductReview() { ProductId = 18, UserId = 18, Rating = 5, ReviewList = "Good", IsLike = "True" });
            reviewList.Add(new ProductReview() { ProductId = 19, UserId = 19, Rating = 1, ReviewList = "Worst", IsLike = "False" });
            reviewList.Add(new ProductReview() { ProductId = 20, UserId = 20, Rating = 2, ReviewList = "Normal", IsLike = "False" });
            reviewList.Add(new ProductReview() { ProductId = 21, UserId = 21, Rating = 3, ReviewList = "Average", IsLike = "True" });
            reviewList.Add(new ProductReview() { ProductId = 22, UserId = 22, Rating = 4, ReviewList = "Nice", IsLike = "True" });
            reviewList.Add(new ProductReview() { ProductId = 23, UserId = 23, Rating = 5, ReviewList = "Good", IsLike = "True" });
            reviewList.Add(new ProductReview() { ProductId = 24, UserId = 24, Rating = 3, ReviewList = "Average", IsLike = "True" });
            reviewList.Add(new ProductReview() { ProductId = 25, UserId = 25, Rating = 4, ReviewList = "Nice", IsLike = "True" });

            Operations operation = new Operations();
            bool verify = true;
            while (verify)
            {
                Console.WriteLine("\nEnter :\n1. Display Product Review\n2. Get Top 3 Three Records Having Highest Rating\n3. Retrieving Selected Records\n4. Retrieving Count Of Review\n5. Retrieving Only Product ID And Review\n6. Skip Top 5 Records\n7. Display Records Where IsLike Is True\n8. Display Records Where Review Is Nice\n9. Average Rating For Each Product ID\n10. Retrieving Records For User ID 10\n11. Exit\n");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        operation.Display(reviewList);
                        break;
                    case 2:
                        operation.GetTopRecords(reviewList);
                        break;
                    case 3:
                        operation.SelectedRecords(reviewList);
                        break;
                    case 4:
                        operation.RetrieveCountOfRecords(reviewList);
                        break;
                    case 5:
                        operation.RetrieveProductID_Review(reviewList);
                        break;
                    case 6:
                        operation.SkipTop5Records(reviewList);
                        break;
                    case 7:
                        operation.RetrieveRecords_WhenIsLikeIsTrue(reviewList);
                        break;
                    case 8:
                        operation.RetrieveRecords_WhereReviewIsNice(reviewList);
                        break;
                    case 9:
                        operation.AverageRating(reviewList);
                        break;
                    case 10:
                        operation.RetrievingOnlyParticularUserId(reviewList);
                        break;
                    case 11:
                        verify = false;
                        break;
                    default:
                        Console.WriteLine("\nEnter Valid Option.. !");
                        break;
                }
            }
        }
    }
}
