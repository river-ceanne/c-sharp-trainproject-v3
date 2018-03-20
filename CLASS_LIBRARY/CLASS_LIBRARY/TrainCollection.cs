//******************************************************
// File: TrainCollection.cs
//
// Purpose: Contains private variables, methods, and properties of class TrainCollection. 
//          Includes constructors, both regular and default.
//          Includes overriden ToString() to output instance of TrainCollection in nice formatting.
//          Includes a method FindTrain to find a Train in TrainCollection by id
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
    public class TrainCollection
    {

        #region private member variables

        private List<Train> m_trains;

        #endregion

        #region methods

        //****************************************************
        // Method: public TrainCollection()
        //
        // Purpose: Default contructor for TrainCollection
        //          Calls new on List<Train> object m_trains
        //****************************************************
        public TrainCollection()
        {
            m_trains = new List<Train>();
        }


        //****************************************************
        // Method: public TrainCollection(List<Train> t)
        //
        // Purpose: Normal contructor with parameters for TrainCollection  
        //          to initialize private member variables
        //****************************************************
        public TrainCollection(List<Train> t)
        {
            m_trains = t;
        }

        //****************************************************
        // Method: public override string ToString()
        //
        // Purpose: To override Object.ToString() to output variables of TrainCollection in nice formatting.
        //****************************************************        
        public override string ToString()
        {
            string trains = "";

            foreach (Train t in m_trains)
            {
                trains += t;
            }

            return trains;
        }

        //****************************************************
        // Method:  public Train FindTrain(int id)
        //
        // Purpose: Finds a Train in TrainCollection by id
        //          
        //****************************************************   
        public Train FindTrain(int id)
        {
            foreach(Train t in trains)
            {
                if(id == t.trainID)
                {
                    return t;
                }
            }

            return null;
        }

        #endregion

        #region properties

        [DataMember(Name = "trains")]
        public List<Train> trains
        {
            get
            {
                return m_trains;
            }
            set
            {
                m_trains = value;
            }
        }

        #endregion

    }
}
