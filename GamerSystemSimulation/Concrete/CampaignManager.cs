using GamerSystemSimulation.Abstract;
using GamerSystemSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerSystemSimulation.Concrete
{
    public class CampaignManager : ICampaign
    {
        public void CampaignAdd(Campaign campaign)
        {
            Console.WriteLine("Campaign started: "+campaign.CampaignName+" Discount: "+campaign.Discount+" Start Date "+campaign.CampaignStart+" End Date "+campaign.CampaignEnd);
        }

        public void CampaignRemove(Campaign campaign)
        {
            Console.WriteLine("Campaign ended: "+campaign.CampaignName);
        }
    }
}
