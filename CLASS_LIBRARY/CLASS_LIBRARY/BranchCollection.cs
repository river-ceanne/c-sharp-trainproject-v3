//******************************************************
// File: BranchCollection.cs
//
// Purpose: Contains private variables, methods, and properties of class BranchCollection. 
//          Includes constructors, both regular and default.
//          Includes overriden ToString() to output instance of BranchCollection in nice formatting.
//          Includes overloaded methods FindBranch to find a Branch in BranchCollection by id or name
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
    public class BranchCollection
    {
        #region private member variables

        private List<Branch> m_branches;

        #endregion

        #region methods

        //****************************************************
        // Method: public BranchCollection()
        //
        // Purpose: Default contructor for BranchCollection
        //          Calls new on List<Branch> object m_branches 
        //****************************************************
        public BranchCollection()
        {
            m_branches = new List<Branch>();
        }


        //****************************************************
        // Method: public BranchCollection(List<Branch> b)
        //
        // Purpose: Normal contructor with parameters for BranchCollection  
        //          to initialize private member variables
        //****************************************************
        public BranchCollection(List<Branch> b)
        {
            m_branches = b;
        }

        //****************************************************
        // Method: public override string ToString()
        //
        // Purpose: To override Object.ToString() to output variables of BranchCollection in nice formatting.
        //****************************************************        
        public override string ToString()
        {
            string output = "";

            foreach(Branch b in m_branches)
            {
                output += b;
            }

            return output;
        }


        //****************************************************
        // Method:  public Branch FindBranch(int id)
        //
        // Purpose: Finds a Branch in BranchCollection by id
        //          (Overloaded function)
        //****************************************************        
        public Branch FindBranch(int id)
        {
            foreach (Branch b in branches)
            {
                if (id == b.id)
                {
                    return b;
                }
            }

            return null;
        }


        //****************************************************
        // Method:  public Branch FindBranch(string name)
        //
        // Purpose: Finds a Branch in BranchCollection by name
        //          (Overloaded function)
        //****************************************************        
        public Branch FindBranch(string name)
        {
            foreach (Branch b in branches)
            {
                if (name == b.name)
                {
                    return b;
                }
            }

            return null;
        }

        #endregion

        #region properties

        [DataMember(Name = "branches")]
        public List<Branch> branches
        {
            get
            {
                return m_branches;
            }
            set
            {
                m_branches = value;
            }
        }

        #endregion

    }
}
