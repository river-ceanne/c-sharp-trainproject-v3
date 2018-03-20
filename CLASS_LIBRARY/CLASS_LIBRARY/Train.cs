//******************************************************
// File: Train.cs
//
// Purpose: Contains private variables, methods, and properties of class Train. 
//          Includes constructors, both regular and default.
//          Includes overriden ToString() to output instance of Train in nice formatting.
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
    public class Train
    {
        #region private member variables

        private int m_trainID;
        private List<StationArrival> m_stationArrivals;

        #endregion

        #region methods

        //****************************************************
        // Method: public Train()
        //
        // Purpose: Default contructor for Train
        //          Calls new on List<StationArrival> object m_stationArrivals 
        //****************************************************
        public Train()
        {
            m_stationArrivals = new List<StationArrival>();
        }


        //****************************************************
        // Method: public Train(int id, List<StationArrival> sa)
        //
        // Purpose: Normal contructor with parameters for Train  
        //          to initialize private member variables
        //****************************************************
        public Train(int id, List<StationArrival> sa)
        {
            m_trainID = id;
            m_stationArrivals = sa;
        }

        //****************************************************
        // Method: public override string ToString()
        //
        // Purpose: To override Object.ToString() to output variables of Train in nice formatting.
        //****************************************************        
        public override string ToString()
        {
            string stationArrivals = "";

            foreach(StationArrival sa in m_stationArrivals)
            {
                stationArrivals += sa.ToString();
            }

            return string.Format("Train ID: {0}\nStation Arrivals: {1}\n",m_trainID,stationArrivals);
        }

        #endregion

        #region properties

        [DataMember(Name = "id")]
        public int trainID
        {
            get
            {
                return m_trainID;
            }
            set
            {
                m_trainID = value;
            }
        }

        [DataMember(Name = "station_arrivals")]
        public List<StationArrival> stationArrivals
        {
            get
            {
                return m_stationArrivals;
            }
            set
            {
                m_stationArrivals = value;
            }
        }

        #endregion 

    }
}
