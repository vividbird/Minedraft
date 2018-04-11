using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPexam
{
    class Sonic : Harvester
    {
        public int SonicFactor { get; set; }
        public Sonic(string id, double oreOutput, double energyR, int sonicFactor) : base(id, oreOutput, energyR)
        {
            this.SonicFactor = sonicFactor;
            this.EnergyRequirement = base.EnergyRequirement / sonicFactor;
        }

        
    }
}
