using GamerSystemSimulation.Abstract;
using GamerSystemSimulation.Entities;

namespace GamerSystemSimulation.Concrete
{
    public class PlayersManager : IPlayer
    {
        IPlayerCheckService _usingcheckService;
        public PlayersManager(IPlayerCheckService checkService)
        {
            _usingcheckService = checkService;
        }
        public void Register(Players player)
        {
            if (_usingcheckService.CheckIfRealPlayer(player))
            {
                Console.WriteLine("Register successed: "+player.Name);
            }
            else
            {
                throw new Exception("Unvalid player.");
            }
        }

        public void Update(Players player)
        {
            Console.WriteLine("Player updated: "+player.Name);
        }

        public void Delete(Players player)
        {
            Console.WriteLine("Player Deleted: "+player.Name);
        }
  
    }
}
