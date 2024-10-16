using GamerSystemSimulation.Abstract;
using GamerSystemSimulation.Entities;
using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerSystemSimulation.Adapters
{
    public class MernisService : IPlayerCheckService
    {
        public bool CheckIfRealPlayer(Players player)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            Task<TCKimlikNoDogrulaResponse> tcKimlikNo = client.TCKimlikNoDogrulaAsync(Convert.ToInt64(player.TcNo),player.Name,player.LastName,player.DateOfBirth.Year);
            return tcKimlikNo.Result.Body.TCKimlikNoDogrulaResult;
        }   
    }
}
