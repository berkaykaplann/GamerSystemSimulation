using GamerSystemSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerSystemSimulation.Abstract
{
    public interface IGames
    {
        void AddGames(Game game);
        void Remove(Game game);
        void Sale(Game game,Players player,Campaign campaign);
    }
}
