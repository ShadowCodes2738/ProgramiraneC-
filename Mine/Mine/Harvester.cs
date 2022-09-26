using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mine
{
    class Harvester
    {
        private string id;
        private double oreOutput;
        private double energyRequirement;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public double OreOutput
        {
            get { return oreOutput; }
            set { oreOutput = value; }
        }

        public double EnergyRequirment
        {
            get { return energyRequirement; }
            set { if (value <= 0 || value > 20000) 
            { throw new ArgumentException("Enegry must be between 0 and 20000"); }
            else
            { energyRequirement = value; }
        }
    }

        public Harvester(string id,double oreOutput,double energyRequriment )
        {
            this.Id = id;
            this.OreOutput = oreOutput;
            this.EnergyRequirment = energyRequirement;
        }
    }
}
