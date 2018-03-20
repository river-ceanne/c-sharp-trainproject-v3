//******************************************************
// File: BranchSchedule.cs
//
// Purpose: Contains private variables, methods, and properties of class BranchSchedule. 
//          Includes constructors, both regular and default.
//          Includes overriden ToString() to output instance of BranchSchedule in nice formatting.
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
    public class BranchSchedule
    {
        #region private member variables

        private int m_branchId;
        private List<int> m_trainIds;

        #endregion

        #region methods

        //****************************************************
        // Method: public BranchSchedule()
        //
        // Purpose: Default contructor for BranchSchedule
        //          Calls new on List<int> object m_trainIds 
        //****************************************************
        public BranchSchedule()
        {
            m_trainIds = new List<int>();
        }


        //****************************************************
        // Method: public BranchSchedule(int bID, List<int> tIDs)
        //
        // Purpose: Normal contructor with parameters for BranchSchedule  
        //          to initialize private member variables
        //****************************************************
        public BranchSchedule(int bID, List<int> tIDs)
        {
            m_branchId = bID;
            m_trainIds = tIDs;
        }

        //****************************************************
        // Method: public override string ToString()
        //
        // Purpose: To override Object.ToString() to output variables of BranchSchedule in nice formatting.
        //****************************************************        
        public override string ToString()
        {
            string output = Convert.ToString(m_branchId) + ": ";

            foreach (int t in m_trainIds)
            {
                output += t + "/";
            }

            output += "\n";

            return output;
        }

        #endregion

        #region properties

        [DataMember(Name = "id")]
        public int branchId
        {
            get
            {
                return m_branchId;
            }
            set
            {
                m_branchId = value;
            }
        }

        [DataMember(Name = "train_ids")]
        public List<int> trainIds
        {
            get
            {
                return m_trainIds;
            }
            set
            {
                m_trainIds = value;
            }
        }

        #endregion
    }
}
