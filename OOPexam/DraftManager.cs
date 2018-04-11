using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPexam
{
    class DraftManager
    {
        private List<Harvester> harvesters = new List<Harvester>();
        private List<Provider> providers= new List<Provider>();
        HarvesterFactory harvesterFactory = new HarvesterFactory();
        ProviderFactory providerFactory = new ProviderFactory();

        double totalEnergyStored;
        double totalMinedOre;
        public string mode;

        public bool shutdown;
        public DraftManager()
        {
            this.mode = "Full";
            totalEnergyStored = 0;
            totalMinedOre = 0;
            shutdown = false;
        }
        public string RegisterHarvester(List<string> comArgs)
        {
            Harvester harvester = null;

            if (!harvesters.Any(x => x.ID == comArgs[2]))
            {
                harvester = harvesterFactory.GetHarvester(comArgs);
                harvesters.Add(harvester);
            }
            else
            {
                throw new Exception("");
            }
            return $"Successfully registered {harvester.GetType().Name} Harvester - {harvester.ID}";
        }
        public string RegisterProvider(List<string> comArgs)
        {
            Provider provider = null;

            if (!providers.Any(x => x.ID == comArgs[2]))
            {
                provider = providerFactory.GetProvider(comArgs);
                providers.Add(provider);
            }
            else
            {
                throw new Exception("");
            }
            return $"Successfully registered {provider.GetType().Name} Harvester - {provider.ID}";
        }
        public string Mode(List<string> comArgs)
        {
            this.mode = comArgs[1];
            return $"Successfully changed working mode to {mode} Mode.";
        }

        public string Check(List<string> comArgs)
        {
            if (harvesters.Any(x=>x.ID==comArgs[1]))
            {
                return $"{harvesters.First(x => x.ID == comArgs[1])}";
            }
            else if (providers.Any(x=>x.ID==comArgs[1]))
            {
                return $"{providers.First(x => x.ID == comArgs[1])}";
            }
           
            throw new Exception($"No element found with id – {comArgs[1]}");
        }
        public string Day()
        {
            StringBuilder sb = new StringBuilder();
            double energyStored = 0;
            double harvestersEnergy = 0;
            double plumbusOreMined = 0;
            energyStored = providers.Sum(x => x.EnergyOutput);
            harvestersEnergy = harvesters.Sum(x => x.EnergyRequirement);


            totalEnergyStored += energyStored;
            if (mode == "Full")
            {
                if (harvestersEnergy <= totalEnergyStored)
                {
                    plumbusOreMined += harvesters.Sum(x => x.OreOutput);
                    totalEnergyStored -= harvestersEnergy;
                }
            }
            else if (mode == "Half")
            {
                harvestersEnergy = harvestersEnergy * 0.6;
                if (harvestersEnergy <= totalEnergyStored)
                {
                    plumbusOreMined += harvesters.Sum(x => x.OreOutput) * 0.5;
                    totalEnergyStored -= harvestersEnergy;
                }
            } 


            totalMinedOre += plumbusOreMined;

            sb.AppendLine("A day has passed.");
            sb.AppendLine($"Energy Provided: {energyStored}");
            sb.AppendLine($"Plumbus Ore Mined: {plumbusOreMined}");
            return sb.ToString().Trim();
        }
        public string Shutdown()
        {
            /*/System Shutdown
 Total Energy Stored: {totalEnergyStored}
 Total Mined Plumbus Ore: {totalMinedOre}”.
/*/
            shutdown = true;

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("System Shutdown");
            sb.AppendLine($"Total Energy Stored: { totalEnergyStored}");
            sb.AppendLine($"Total Mined Plumbus Ore: {totalMinedOre}");

            return sb.ToString().Trim();

        }
    }
}
