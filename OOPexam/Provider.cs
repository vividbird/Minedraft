using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPexam
{
    class Provider
    {
        private double energyOutput;
        public string ID { get; set; }
        public Provider(string id, double energyOut)
        {
            this.ID = id;
            this.EnergyOutput = energyOut;
        }
        public double EnergyOutput
        {
            get => energyOutput;
            protected set
            {
                if (value < 0 || value >= 10000)
                {
                    throw new Exception("Provider is not registered, because of its EnergyOutput");
                }
                energyOutput = value;
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.GetType().Name} Provider – {ID}");
            sb.AppendLine($"Energy Output: {energyOutput}");

            return sb.ToString().Trim();

        }
    }
}
