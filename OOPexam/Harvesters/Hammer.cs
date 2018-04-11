using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPexam
{
    class Hammer : Harvester
    {
        public Hammer(string id, double oreOutput, double energyR) : base(id, oreOutput, energyR)
        {
            this.OreOutput = oreOutput + 2 * oreOutput;
            this.EnergyRequirement = energyR +  energyR;
        }
    }
}
