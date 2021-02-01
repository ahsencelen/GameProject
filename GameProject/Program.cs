using GameProject.Concrete;
using GameProject.Entities;
using GameProject.Manager;
using System;

namespace GameProject
{
    class Program
    {
        public static int Id { get; private set; }
        public static string Name { get; private set; }
        public static int DiscountRate { get; private set; }

        static void Main(string[] args)
        {
            
            Game game1 = new Game() { Id = 1, Name = "Grand Theft Auto", Price = 100 };
            Game game2 = new Game() { Id = 2, Name = "Counter Strike", Price = 90 };
            Game game3 = new Game() { Id = 3, Name = "World of Warcraft", Price = 110 };
            Game game3_update= new Game() { Id = 3, Name = "World of Warcraft 2020", Price = 120 };

            GameManager gameManager = new GameManager();


            gameManager.Add(game1);
            gameManager.Add(game2);
            gameManager.Add(game3);
            gameManager.List();
            gameManager.Remove(game2);
            gameManager.Update(3, game3_update);

            gameManager.List();

            ICampaign campaign1 = new Campaign() { Id = 1, Name = "New Year", DiscountRate = 30 };
            ICampaign campaign2 = new Campaign() { Id = 2, Name = "Weekly Discount", DiscountRate = 20 };

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Add(campaign2);

            campaignManager.List();

            campaignManager.ApplyDiscount(game1, campaign1);
            campaignManager.ApplyDiscount(game3, campaign2);

            gameManager.List();


            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer { Id = 1, BirthYear = 1997, FirstName = "Ahsen", LastName = "Çelen", IdentityNumber = 12345 });

            
        }
    }
}
