//******************************************************
// File: Station.cs
//
// Purpose: Contains private variables, methods, and properties of class Station. 
//          Includes constructors, both regular and default.
//          Includes overriden ToString() to output instance of Station in nice formatting.
//
// Written By: Reina Vencer 
//
// Compiler: Visual Studio 2015
//
//******************************************************


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace CLASS_LIBRARY
{
    [DataContract]
    public class Station
    {
        #region Private Member Variables

        private int m_id;
        private string m_name;
        private string m_location;
        private int m_fareZone;
        private double m_mileageToPenn;
        private string m_picFilename;

        #endregion //end of private variables region

        #region Methods

        //****************************************************
        // Method: public Station()
        //
        // Purpose: Default contructor for Station 
        //****************************************************
        public Station() { }


        //****************************************************
        // Method: public Station(int id, string n, string l, int f, double mp, string pf)
        //
        // Purpose: Normal contructor with parameters for Station 
        //          to initialize private member variables
        //****************************************************
        public Station(int id, string n, string l, int f, double mp, string pf)
        {
            m_id = id;
            m_name = n;
            m_location = l;
            m_fareZone = f;
            m_mileageToPenn = mp;
            m_picFilename = pf;
        }

        //****************************************************
        // Method: public override string ToString()
        //
        // Purpose: To override Object.ToString() to output variables of Station in nice formatting.
        //****************************************************        
        public override string ToString()
        {
            return string.Format("Station ID: {0}   Station Name: {1}   Location: {2}   Fare Zone: {3}  Mileage To Penn: {4}    Pic Filename: {5}\n",m_id,m_name,m_location,m_fareZone,m_mileageToPenn,m_picFilename);
        }

        #endregion // end of methods region

        #region properties

        [DataMember(Name = "id")]
        public int id
        {
            get
            {
                return m_id;
            }

            set
            {
                m_id = value;
            }
        }

        [DataMember(Name = "name")]
        public string name
        {
            get
            {
                return m_name;
            }

            set
            {
                m_name = value;
            }
        }

        [DataMember(Name = "location")]
        public string location
        {
            get
            {
                return m_location;
            }

            set
            {
                m_location = value;
            }
        }

        [DataMember(Name = "fare_zone")]
        public int fareZone
        {
            get
            {
                return m_fareZone;
            }

            set
            {
                m_fareZone = value;
            }
        }

        [DataMember(Name = "mileage_to_penn")]
        public double mileageToPenn
        {
            get
            {
                return m_mileageToPenn;
            }

            set
            {
                m_mileageToPenn = value;
            }
        }

        [DataMember(Name = "pic_filename")]
        public string picFilename
        {
            get
            {
                return m_picFilename;
            }

            set
            {
                m_picFilename = value;
            }
        }
        #endregion // end of properties region

    }//end of class

}//end of namespace
