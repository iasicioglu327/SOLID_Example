// See https://aka.ms/new-console-template for more information
using SOLID_Example;

Console.WriteLine("Hello, World!");
SRP_AddWatchlist watched = new SRP_AddWatchlist() { Watchlist = true};
SRP_MovieVoting voting1 = new SRP_MovieVoting() { MovieVoting=9};
SRP_MovieInfo movie1 = new SRP_MovieInfo() { ID = 1, MovieTitle = "Top Gun", MovieGenre = "Action", MovieVoting = voting1.MovieVoting, Watchlist=watched.Watchlist  };
movie1.GetMovieInfos();

OCP_MainProductSaleInfo product1 = new OCP_MainProductSaleInfo() { ProductName = "Computer 1", NumberOfSales = 500 };
OCP_MainProductSaleInfo product2 = new OCP_ProductFirstVersionSaleInfo() { ProductName =" Computer 2018 model", NumberOfSales=200};
Console.WriteLine(product1.ProductName.ToString() +": " + product1.CalculatePrice());
Console.WriteLine(product2.ProductName.ToString() +": " + product2.CalculatePrice());

LSP_YoutubeMember user1 = new LSP_YoutubeMember();
LSP_YoutubePremiumMember user2 = new LSP_YoutubePremiumMember();
user1.WatchVideo();
user2.LockScreen();

DIP_UserCardInfo card1 = new DIP_UserCardInfo() { UserName = "user 1", IBANNumber = "1234" };
DIP_ReturnProduct payment1 = new DIP_ReturnProduct(card1);
Console.WriteLine(payment1.RefundMoney());

ISP_BuyerAccount buyer1 = new ISP_BuyerAccount();
buyer1.BuyProduct();
buyer1.CommentProduct();
ISP_SellerAccount seller1 = new ISP_SellerAccount();
seller1.SellProduct();
seller1.CommentProduct();

