using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPexam
{
    class HarvesterFactory
    {
        public Harvester GetHarvester(List<string> input)
        {
            var type = input[1];

            Harvester harvester = null;
            switch (type)
            {
                case "Sonic":
                    harvester = new Sonic(input[2], double.Parse(input[3]), double.Parse(input[4]), int.Parse(input[5]));
                    break;
                case "Hammer":
                    harvester = new Hammer(input[2], double.Parse(input[3]), double.Parse(input[4]));
                    break;
                default:
                    harvester = null;
                    break;
            }
            return harvester;
        }
    }
}
