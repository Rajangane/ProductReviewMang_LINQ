// See https://aka.ms/new-console-template for more information
//Console.WriteLine("************* Welcome To Product Review Management *****************");
using ProductReviewMang_LINQ;
Console.Write("Select Number:\n1)CreateProducts");
int option = Convert.ToInt32(Console.ReadLine());
switch (option)
{
    case 1:
        //UC1
        List<ProductReview> productReviewList = new List<ProductReview>()
        {
            new ProductReview(){ProducID=1,UserID=1,Rating=2,Review="Good",isLike=true},
            new ProductReview(){ProducID=2,UserID=1,Rating=4,Review="Good",isLike=true},
            new ProductReview(){ProducID=3,UserID=1,Rating=5,Review="Good",isLike=true},
            new ProductReview(){ProducID=4,UserID=1,Rating=6,Review="Good",isLike=false},
            new ProductReview(){ProducID=5,UserID=1,Rating=2,Review="nice",isLike=true},
            new ProductReview(){ProducID=6,UserID=1,Rating=1,Review="bad",isLike=true},
            new ProductReview(){ProducID=7,UserID=1,Rating=10,Review="Good",isLike=false},
            new ProductReview(){ProducID=8,UserID=1,Rating=9,Review="nice",isLike=true},
            new ProductReview(){ProducID=9,UserID=1,Rating=10,Review="nice",isLike=true},
            new ProductReview(){ProducID=10,UserID=1,Rating=8,Review="nice",isLike=true},

        };

        foreach (var list in productReviewList)
        {
            Console.WriteLine("ProductID:- " + list.ProducID + " " + "UserID:- " + list.UserID
                + " " + "Rating:- " + list.Rating + " " + "Review:- " + list.Review + " " + "isLike:- " + list.isLike);
        }
        break;
}