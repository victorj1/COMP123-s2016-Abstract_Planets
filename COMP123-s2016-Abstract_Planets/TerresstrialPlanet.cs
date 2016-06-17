using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP123_s2016_Abstract_Planets
{
    public class TerresstrialPlanet : Planet, IHasMoons, IHabitable
    {
        private bool _oxygen;

        public TerresstrialPlanet(string name, string diameter, string mass, string oxygen)
        {
            throw new System.NotImplementedException();
        }

        public bool Habitable()
        {
            throw new System.NotImplementedException();
        }

        public bool HasMoons()
        {
            throw new System.NotImplementedException();
        }
    }
}