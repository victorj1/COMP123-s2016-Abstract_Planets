using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP123_s2016_Abstract_Planets
{
    /** <summary>
    * This abstract class defines planets.
    * </summary>
    * 
    * @class Planets
    */
    public abstract class Planet
    {
        // PRIVATE INSTANCE VARIABLES (FIELDS) ***********************************************
        private double _diameter;
        private double _mass;
        private int _moonCount;
        private string _name;
        private double _orbitalPeriod;
        private int _ringCount;
        private double _rotationPeriod;

        // PUBLIC PROPERTIES *****************************************************************
        /**
        * <summary>
        * This is a read only property for _diameter field
        *  </summary>
        *  
        * @property {double} Diameter
        */
        public double Diameter
        {
            get
            {
                return this._diameter;
            }
        }
        /**
        * <summary>
        * This is a read only property for _mass field
        *  </summary>
        *  
        * @property {double} Mass
        */
        public double Mass
        {
            get
            {
                return this._mass;
            }
        }
        /**
        * <summary>
        * This is a  property for _moonCount field
        *  </summary>
        *  
        * @property {int} MoonCount 
        */
        public int MoonCount
        {
            get
            {
                return this._moonCount;
            }
            set
            {
                this._moonCount = value;
            }
        }
        /**
        * <summary>
        * This is a read only property for _name field
        *  </summary>
        *  
        * @property {string} Name 
        */
        public string Name
        {
            get
            {
                return this._name;
            }
        }
        /**
        * <summary>
        * This is a property for _orbitalPeriod field
        *  </summary>
        *  
        * @property {double} OrbitalPeriod 
        */
        public double OrbitalPeriod
        {
            get
            {
                return this._orbitalPeriod;
            }
            set
            {
                this._orbitalPeriod = value;
            }
        }
        /**
        * <summary>
        * This is a property for _ringCount field
        *  </summary>
        *  
        * @property {int} RingCount 
        */
        public int RingCount
        {
            get
            {
                return this._ringCount;
            }
            set
            {
                this._ringCount = value;
            }
        }
        /**
        * <summary>
        * This is a property for _rotationPeriod field
        *  </summary>
        *  
        * @property {double} RotationPeriod 
        */
        public double RotationPeriod
        {
            get
            {
                return this._rotationPeriod;
            }

            set
            {
                this._rotationPeriod = value;
            }
        }

        // CONSTRUCTORS ***********************************************************
        /**
        * <summary>
        * This is the constructor that takes the name,diameter,mass parameteres and 
        * passes to instance variables.
        * </summary>
        *  
        * @constructor Planet 
        * @param {string} name 
        * @param {double} diameter  
        * @param {double} mass 
        */

        //PUBLIC METHOD **********************************************************
        /**
         * <summary>
         * This is the overriding method to change the return value.
         * </summary>
         *  
         * @method ToString 
         * @return {string}   
         */
        public Planet(string name, double diameter, double mass)
        {
            this._name = name;
            this._diameter = diameter;
            this._mass = mass;
        }

        public override string ToString()
        {
            return String.Format("Planet Name: {0} \nDiameter: {1} \nMass: {2}", this.Name, this.Diameter, this.Mass);
        }
    }
}