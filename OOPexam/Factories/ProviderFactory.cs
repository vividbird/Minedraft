using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPexam
{
    class ProviderFactory
    {
        public Provider GetProvider(List<string> input)
        {
            var type = input[1];
            Provider provider=null;

            switch(type)
            {
                case "Solar":
                    provider = new Solar(input[2], double.Parse(input[3]));
                    break;
                case "Pressure":
                    provider = new Pressure(input[2], double.Parse(input[3]));
                    break;
            }
            return provider;
        }
    }
}
