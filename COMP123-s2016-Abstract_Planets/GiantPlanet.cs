using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP123_s2016_Abstract_Planets
{
    public class GiantPlanet : Planet, IHasRings, IHasMoons
    {
        private string _type;

        public GiantPlanet(string name, string diameter, string mass, string type)
        {
            throw new System.NotImplementedException();
        }

        public bool HasMoons()
        {
            if (MoonCount >= 1)
            { }
            return true;
        }

        public bool HasRings()
        {
            throw new System.NotImplementedException();
        }
    }
}