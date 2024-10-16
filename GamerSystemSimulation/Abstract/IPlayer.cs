using GamerSystemSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerSystemSimulation.Abstract
{
    public interface IPlayer
    {
        void Register(Players gamers);
        void Update(Players gamers);
        void Delete(Players gamers);

    }
}
