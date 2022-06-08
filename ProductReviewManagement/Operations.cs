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
    }
}