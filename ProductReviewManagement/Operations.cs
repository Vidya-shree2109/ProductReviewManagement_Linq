using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    public class Operations
    {
        public readonly DataTable datatable = new DataTable();
        public void GetTopRecords(List<ProductReview> listProductReview)
        {
            var recordedData = (from productReview in listProductReview
                                orderby productReview.Rating descending
                                select productReview).Take(3);
            Console.WriteLine("\n********** TOP 3 RECORDS WHOSE RATING IS HIGH **********");
            foreach (var list in recordedData)
            {
                Console.WriteLine("\nProduct ID:- " + list.ProductId + " " + "User ID:- " + list.UserId + " " + "Rating:- " + list.Rating + " " + "Review :- " + list.ReviewList + " " + "Is Like:- " + list.IsLike);
            }
        }
        public void Display(List<ProductReview> list)
        {
            Console.WriteLine("********** DISPLAY OF PRODUCT REVIEW LIST **********\n");
            foreach (var data in list)
            {
                Console.WriteLine("\nProduct ID:- " + data.ProductId + " " + "User ID:- " + data.UserId + " " + "Rating:- " + data.Rating + " " + "Review :- " + data.ReviewList + " " + "Is Like:- " + data.IsLike);
            }
        }
        public void SelectedRecords(List<ProductReview> listProductReview)
        {
            var recordedData = from productReview in listProductReview
                               where (productReview.ProductId == 1 || productReview.ProductId == 4 || productReview.ProductId == 9) && productReview.Rating > 3 select productReview;
            Console.WriteLine("\n********** RETRIEVING SELECTED RECORDS **********");
            foreach (var list in recordedData)
            {
                Console.WriteLine("\nProduct ID:- " + list.ProductId + " " + "User ID:- " + list.UserId + " " + "Rating:- " + list.Rating + " " + "Review:- " + list.ReviewList + " " + "Is Like:- " + list.IsLike);
            }
        }
        public void RetrieveCountOfRecords(List<ProductReview> listProductReview)
        {
            var recordedData = listProductReview.GroupBy(y => y.ProductId).Select(x => new { ProductId = x.Key, Count = x.Count() });
            Console.WriteLine("\n********** COUNT OF REVIEW PRESENT FOR EACH PRODUCT ID **********");
            foreach (var list in recordedData)
            {
                Console.WriteLine("\nProduct Id:- " + list.ProductId + "\t\t" + "Count:- " + list.Count);
            }
        }
        public void RetrieveProductID_Review(List<ProductReview> listProductReview)
        {
            var recordedData = listProductReview.Select(x => new { ProductID = x.ProductId, ProductReview = x.ReviewList });
            Console.WriteLine("\n********** RETRIEVING ONLY PRODUCT ID AND REVIRE **********\n");
            foreach (var list in recordedData)
            {
                Console.WriteLine("Product ID:- " + list.ProductID + "\t\t" + "Review:- " + list.ProductReview);
            }
        }
        public void SkipTop5Records(List<ProductReview> listProductReview)
        {

            var recordedData = (from productReviews in listProductReview select productReviews).Skip(5).ToList();
            Console.WriteLine("\n********** DISPLAY OF RECORDS BY SKIPPING TOP 5 RECORDS **********\n");
            foreach (var list in recordedData)
            {
                Console.WriteLine("Product ID:- " + list.ProductId + "\t\t" + "User ID:- " + list.UserId + "\t\t" + "Rating:- " + list.Rating + "\t\t" + "Review:- " + list.ReviewList + "\t\t" + "Is Like:- " + list.IsLike);
            }
        }
        public void RetrieveRecords_WhenIsLikeIsTrue(List<ProductReview> listProductReview)
        {
            var recordedData = from productReview in listProductReview
                               where productReview.IsLike == "True"
                               select productReview;
            Console.WriteLine("\n********** DISPLAYING RECORDS WHERE ISLIKE IS TRUE **********\n");
            foreach (var list in recordedData)
            {
                Console.WriteLine("Product ID:- " + list.ProductId + "\t\t" + "User ID:- " + list.UserId + "\t\t" + "Rating:- " + list.Rating + "\t\t" + "Review:- " + list.ReviewList + "\t\t" + "Is Like:- " + list.IsLike);
            }
        }
    }
}