using GamerSystemSimulation.Abstract;
using GamerSystemSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerSystemSimulation.Concrete
{
    public class GamesManager : IGames
    {
        public void AddGames(Game game)
        {
            Console.WriteLine("Game added: "+game.GameName);
        }

        public void Remove(Game game)
        {
            Console.WriteLine("Game removed: "+game.GameName);
        }

        public void Sale(Game game , Players player , Campaign campaign)
        {
            game.GamePrice = (game.GamePrice * campaign.Discount) / 100;
            
            Console.WriteLine("The game saled "+game.GameName+ " was bought by a player named "+player.Name+" for "+game.GamePrice+" TL with a % "+campaign.Discount+" discount");
        }
    }
}
