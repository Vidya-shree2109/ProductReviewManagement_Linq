using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    public class Operations
    {
        public void GetTopRecords(List<ProductReview> list)
        {
            var result = list.OrderByDescending(x => x.Rating).Take(3); // Method Synatx
            var data = from product in list orderby product.Rating descending select product; // Query Synatx
        }
        public void Display(List<ProductReview> list)
        {
            foreach (var data in list)
            {
                Console.WriteLine();
            }
        }
    }
}