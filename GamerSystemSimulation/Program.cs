

using GamerSystemSimulation.Adapters;
using GamerSystemSimulation.Concrete;
using GamerSystemSimulation.Entities;

MernisService mernis = new MernisService();
PlayersManager playersManager = new PlayersManager(mernis);

Players players1 = new Players();
players1.Id = 1;
players1.Name = "Berkay";
players1.LastName = "Kaplan";
players1.DateOfBirth = new DateTime(2001,4,9);
players1.TcNo = "12345678910";


playersManager.Register(players1);


Game game1 = new Game();
Game game2 = new Game();    
game1.GameName = "Horizon Zero Dawn";
game1.GamePrice = 224;
game1.Id = 1;
GamesManager gamesManager = new GamesManager();
gamesManager.AddGames(game1);


game2.GameName = "Watch Dogs 2";
game2.GamePrice = 179;
game2.Id = 2;



Campaign campaign1 = new Campaign();
campaign1.Discount = 20;
campaign1.CampaignName = "Summer Sale";
campaign1.CampaignStart = new DateTime(2024, 6, 15);
campaign1.CampaignEnd = new DateTime(2024, 7, 15);
campaign1.Id = 1;


CampaignManager campaignManager1 = new CampaignManager();
campaignManager1.CampaignAdd(campaign1);


gamesManager.Sale(game1 , players1 , campaign1);



