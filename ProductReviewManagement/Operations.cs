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
                Console.WriteLine("\nProductID:- " + list.ProductId + " " + "UserID:- " + list.UserId + " " + "Rating:- " + list.Rating + " " + "Review:- " + list.ReviewList + " " + "IsLike:- " + list.IsLike);
            }
        }
        public void Display(List<ProductReview> list)
        {
            Console.WriteLine("********** DISPLAY OF PRODUCT REVIEW LIST **********\n");
            foreach (var data in list)
            {
                Console.WriteLine("\nProductID:- " + data.ProductId + " " + "UserID:- " + data.UserId + " " + "Rating:- " + data.Rating + " " + "Review:- " + data.ReviewList + " " + "IsLike:- " + data.IsLike);
            }
        }
    }
}