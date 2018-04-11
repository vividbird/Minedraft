using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPexam
{
    class Harvester
    {

        private double oreOutput;
        private double energyRequirement;

        public Harvester(string id, double oreOutput, double energyR)
        {
            this.ID = id;
            this.OreOutput = oreOutput;
            this.EnergyRequirement = energyR;
        }
        public string ID { get; set; }
        public double OreOutput
        {
            get => oreOutput;
            protected set
            {
                if (value<0)
                {
                    throw new Exception("Harvester is not registered, because of its OreOutput");
                }
                oreOutput = value;
            }
        }
        public double EnergyRequirement
        {
            get => energyRequirement;
            protected set
            {
                if (value<0 || value>= 20000)
                {
                    throw new Exception("Harvester is not registered, because of its EnergyRequirement");
                }
                energyRequirement = value;
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.GetType().Name} Harvester - {ID}");
            sb.AppendLine($"Ore Output: {OreOutput}");
            sb.AppendLine($"Energy Requirement: {EnergyRequirement}");

            return sb.ToString().Trim();

        }
        /*•	id – a string.
•	oreOutput – a floating-point number. 
•	energyRequirement – a floating-point number.
/*/
    }
}
