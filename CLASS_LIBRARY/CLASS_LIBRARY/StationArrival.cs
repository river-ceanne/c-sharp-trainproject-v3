//******************************************************
// File: StationArrival.cs
//
// Purpose: Contains private variables, methods, and properties of class StationArrival. 
//          Includes constructors, both regular and default.
//          Includes overriden ToString() to output instance of StationArrival in nice formatting.
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
    public class StationArrival
    {
        #region Private Member Variables

        private int m_stationID;
        private DateTime m_time;
        //private bool m_transferRequired;
        private int m_trainID;

        #endregion

        #region Methods

        //****************************************************
        // Method: public StationArrival()
        //
        // Purpose: Default contructor for StationArrival 
        //****************************************************
        public StationArrival() { }


        //****************************************************
        // Method: public StationArrival(int id, DateTime t, int trID)
        //
        // Purpose: Normal contructor with parameters for StationArrival  
        //          to initialize private member variables
        //****************************************************
        public StationArrival(int id, DateTime t, int trID)//bool tr)
        {
            m_stationID = id;
            m_time = t;
            //m_transferRequired = tr;
            m_trainID = trID;
        }


        //****************************************************
        // Method: public override string ToString()
        //
        // Purpose: To override Object.ToString() to output variables of StationArrival in nice formatting.
        //****************************************************
        public override string ToString()
        {
            return string.Format("Station ID: {0}   Time: {1}   Train IDs: {2}\n", m_stationID, m_time, m_trainID);//m_transferRequired);
        }
        
        #endregion // end of Methods region
        
        #region properties 

        [DataMember(Name = "id")]
        public int ID
        {
            get
            {
                return m_stationID;
            }

            set
            {
                m_stationID = value;
            }
        }

        [DataMember(Name = "time")]
        public DateTime time
        {
            get
            {
                return m_time;
            }

            set
            {
                m_time = value;
            }
        }

       /* [DataMember(Name = "transfer_required")]
        public bool transferRequired
        {
            get
            {
                return m_transferRequired;
            }

            set
            {
                m_transferRequired = value;
            }
        }*/

        [DataMember(Name = "train_id")]
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

        #endregion // end of properties region


    }//end of class
}//end of namespace
