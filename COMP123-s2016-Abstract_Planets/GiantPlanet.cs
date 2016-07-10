using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP123_s2016_Abstract_Planets
{
    /**
   * <summary>
   * GiantPlanet is a subclass of the Planets Abstract class. This class will also implement
   * both the IHasMoons and IHasRings interfaces 
   * </summary>
   *
   * @class GiantPlanet
   * @extends Planet
   */
    public class GiantPlanet : Planet, IHasRings, IHasMoons
    {

        // PRIVATE INSTANCE VARIABLE **************************************************

        private string _type;

        // PUBLIC PROPERTIES **************************************************
        
        /**<summary>
        * This is a property for our _type field.
        * </summary>
        *
        * @property Type
        */

        public string Type
        {
            get
            {
                return this._type;
            }

            set
            {
                this._type = value;
            }
        }

        // CONSTRUCTOR *******************************************

        /** <summary>
        * This constructor method takes all parameters of the Planet base class as well as type
        * as a local variable and sets the related instance variable (_type) to its value
        * </summary>
        *
        * @constructor GiantPlanet
        * @param {string} name
        * @param {double} diameter
        * @param {double} mass
        * @param {string} type
        */

        public GiantPlanet(string name, double diameter, double mass,string type)
        : base(name, diameter, mass)
        {
            this._type = type;
        }

        // PUBLIC METHODS ****************************************

        /** <summary>
         * HasMoon() method returns true if the MoonCount property is greater than zero
         * </summary>
         *
         * @method HasMoon
         * @returns {bool}
         */
        public bool HasMoons()
        {
            if (MoonCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /** <summary>
         * HasRings() method returns true if the RingCount property is greater than zero
         * </summary>
         *
         * @method RingCount
         * @returns {bool}
         */
        public bool HasRings()
        {
            if (RingCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}