//******************************************************
// File: Branch.cs
//
// Purpose: Contains private variables, methods, and properties of class Branch. 
//          Includes constructors, both regular and default.
//          Includes overriden ToString() to output instance of Branch in nice formatting.
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
    public class Branch
    {
        #region private member variables

        private int m_id;
        private string m_name;
        private List<int> m_stationIds;

        #endregion

        #region methods

        //****************************************************
        // Method: public Branch()
        //
        // Purpose: Default contructor for Branch
        //          Calls new on List<int> object m_stationIds 
        //****************************************************
        public Branch()
        {
            m_stationIds = new List<int>();
        }


        //****************************************************
        // Method: public Branch(int id, string n, List<int> stIDs)
        //
        // Purpose: Normal contructor with parameters for Branch  
        //          to initialize private member variables
        //****************************************************
        public Branch(int id, string n, List<int> stIDs)
        {
            m_id = id;
            m_name = n;
            m_stationIds = stIDs;
        }

        //****************************************************
        // Method: public override string ToString()
        //
        // Purpose: To override Object.ToString() to output variables of Branch in nice formatting.
        //****************************************************        
        public override string ToString()
        {
            string stationIDs = "|";

            foreach(int i in m_stationIds)
            {
                stationIDs += i + "|";
            }

            return string.Format("Branch ID: {0}\nBranch Name: {1}\n Station Ids: {2}\n",m_id,m_name,stationIDs);
        }


        //****************************************************
        // Method:  public bool isBranchStation(int id)
        //
        // Purpose: Returns true if the given station id is a station on the branch and false otherwise.
        //          Checks to see if station id is on branch 
        //          
        //****************************************************
        public bool isBranchStation(int id)
        {
            foreach(int i in stationIds)
            {
                if(i == id)
                {
                    return true;
                }
            }

            return false;
        }

        #endregion

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

        [DataMember(Name = "station_ids")]
        public List<int> stationIds
        {
            get
            {
                return m_stationIds;
            }
            set
            {
                m_stationIds = value;
            }
        }

        #endregion


    }
}
