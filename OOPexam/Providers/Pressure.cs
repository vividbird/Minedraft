using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPexam
{
    class Pressure : Provider
    {
        public Pressure(string id, double energyOut) : base(id, energyOut)
        {
            this.EnergyOutput = energyOut + 0.5 * energyOut;
        }
    }
}
