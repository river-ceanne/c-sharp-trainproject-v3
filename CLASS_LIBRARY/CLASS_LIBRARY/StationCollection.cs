//******************************************************
// File: StationCollection.cs
//
// Purpose: Contains private variables, methods, and properties of class StationCollection. 
//          Includes constructors, both regular and default.
//          Includes overriden ToString() to output instance of StationCollection in nice formatting.
//          Includes overloaded methods FindStation to find a Station in StationCollection by id or name
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
    public class StationCollection
    {

        #region private member variables

        private List<Station> m_stations;

        #endregion

        #region methods

        //****************************************************
        // Method: public StationCollection()
        //
        // Purpose: Default contructor for StationCollection
        //          Calls new on List<Station> object m_stations 
        //****************************************************
        public StationCollection()
        {
            m_stations = new List<Station>();
        }


        //****************************************************
        // Method: public StationCollection(List<Station> s)
        //
        // Purpose: Normal contructor with parameters for StationCollection  
        //          to initialize private member variables
        //****************************************************
        public StationCollection(List<Station> s)
        {
            m_stations = s;
        }

        //****************************************************
        // Method: public override string ToString()
        //
        // Purpose: To override Object.ToString() to output variables of StationCollection in nice formatting.
        //****************************************************        
        public override string ToString()
        {
            string stationString = "";

            foreach(Station i in stations)
            {
                stationString += i;
            }

            return stationString;
        }


        //****************************************************
        // Method:  public Station FindStation(int stationId)
        //
        // Purpose: Finds a Station in StationCollection by id
        //          (Overloaded function)
        //****************************************************    
        public Station FindStation(int stationId)
        {
            for(int i = 0; i < stations.Count; i++)
            {
                if (stationId == stations[i].id)
                {
                    return stations[i];
                }
            }

            return null;
        }


        //****************************************************
        // Method:   public Station FindStation(string stationName)
        //
        // Purpose: Finds a Station in StationCollection by name
        //          (Overloaded function)
        //****************************************************   
        public Station FindStation(string stationName)
        {
            for (int i = 0; i < stations.Count; i++)
            {
                if (stationName == stations[i].name)
                {
                    return stations[i];
                }
            }

            return null;
        }

        #endregion

        #region properties

        [DataMember(Name = "stations")]
        public List<Station> stations
        {
            get
            {
                return m_stations;
            }
            set
            {
                m_stations = value;
            }
        }

        #endregion

    }
}
