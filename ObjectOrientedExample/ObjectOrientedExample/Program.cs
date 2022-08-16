// See https://aka.ms/new-console-template for more information
using ObjectOrientedExample;

Console.WriteLine("Hello, World!");
Abstraction_ProductTabletSaleInfo tablet1 = new Abstraction_ProductTabletSaleInfo() { NumberOfSales = 2500 };
Abstraction_ProductComputerSaleInfo computerSaleInfo = new Abstraction_ProductComputerSaleInfo() { NumberOfSales = 3000 };
Console.WriteLine("Tablet's total price tag: " + tablet1.GetPrice());
Console.WriteLine("Computer's total price tag: "+computerSaleInfo.GetPrice());
////////////////////////////////
Polymorphism_YoutubeUser user1 = new Polymorphism_YoutubeUser();
user1.WatchVideo();
Polymorphism_YoutubeUser user2 = new Polymorphism_YoutubePremiumUser();
user2.WatchVideo();
//////////////////////////////////
Interface_UserClass user3 = new Interface_UserClass();
user3.VoteMovie();
user3.AddWatchList();
////////////////////////////////////
Encapsulation_Database database1 = new Encapsulation_Database();
Console.WriteLine(database1.OracleDatabaseConnection());

