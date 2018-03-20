//******************************************************
// File: TrainScheduleUnitTesting.cs
//
// Purpose: Contains methods for testing each property of classes Station and StationArrival
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

namespace CLASS_LIBRARY
{
    public class TrainScheduleUnitTesting
    {

        #region methods

        //****************************************************
        // Method: public void UnitTestStation()
        //
        // Purpose: Test all properties of class Station.
        //****************************************************
        public void UnitTestStation()
        {
            Station s = new Station();
            int testId = 100;
            string testName = "Test Name";
            string testLocation = "Test Location";
            int testFarezone = 1;
            double testMileageToPenn = 11.1;
            string testPicFilename = "TestFilename.jpg";
            
            s.id = testId;
            s.name = testName;
            s.location = testLocation;
            s.fareZone = testFarezone;
            s.mileageToPenn = testMileageToPenn;
            s.picFilename = testPicFilename;

            if (s.id == testId)
            {
                Console.WriteLine("Station Id Property: Pass");
            }
            else
            {
                Console.WriteLine("Station Id Property: FAIL!");
            }

            if (s.name == testName)
            {
                Console.WriteLine("Station Name Property: Pass");
            }
            else
            {
                Console.WriteLine("Station Name Property: FAIL!");
            }

            if(s.location == testLocation)
            {
                Console.WriteLine("Station Location Property: Pass");
            }
            else
            {
                Console.WriteLine("Station Location Property: FAIL!");
            }

            if(s.fareZone == testFarezone)
            {
                Console.WriteLine("Station Farezone Property: Pass");
            }
            else
            {
                Console.WriteLine("Station Farezone Property: FAIL!");
            }

            if(s.mileageToPenn == testMileageToPenn)
            {
                Console.WriteLine("Station MileageToPenn Property: Pass");
            }
            else
            {
                Console.WriteLine("Station MileageToPenn Property: FAIL!");
            }

            if(s.picFilename == testPicFilename)
            {
                Console.WriteLine("Station PicFilename Property: Pass");
            }
            else
            {
                Console.WriteLine("Station PicFilename Property: FAIL!");
            }

        }//end of UnitTestStation()

        //****************************************************
        // Method: public void UnitTestStationArrival()
        //
        // Purpose: Test all properties of class StationArrival.
        //****************************************************
        public void UnitTestStationArrival()
        {
            StationArrival sa = new StationArrival();
            int testID = 100;
            DateTime testTime = new DateTime(2017,9,24,1,0,0);
          //  bool testTransferReq = false;

            sa.ID = testID;
            sa.time = testTime;
           // sa.transferRequired = testTransferReq;

            if(sa.ID == testID)
            {
                Console.WriteLine("StationArrival ID Property: Pass");
            }
            else
            {
                Console.WriteLine("StationArrival ID Property: FAIL!");
            }

            if(sa.time == testTime)
            {
                Console.WriteLine("StationArrival Time Property: Pass");
            }
            else
            {
                Console.WriteLine("StationArrival Time Property: FAIL!");
            }

         /*   if(sa.transferRequired == testTransferReq)
            {
                Console.WriteLine("StationArrival TransferRequired Property: Pass");
            }
            else
            {
                Console.WriteLine("StationArrival TransferRequired Property: FAIL!");
            }
            */

        }//end of UnitTestStationArrival()

        #endregion

    }//end of class 
}//end of namespace
