//******************************************************
// File: MainWindow.xaml.cs
//
// Purpose: Contains partial class Main Window;
//          Includes functions for event handling 
//          on its WPF controls.
//
// Written By: Reina Vencer 
//
// Compiler: Visual Studio 2015
//
//******************************************************


using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CLASS_LIBRARY;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

namespace Assignment_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region private member variables

        private StationCollection sc;

        #endregion

        #region methods

        public MainWindow()
        {
            InitializeComponent();
        }

        //****************************************************
        // Method: private void button_Click(object sender, RoutedEventArgs e)
        //
        // Purpose: Handle button click event to open JSON file of StationCollection
        //          and add to items on listview for the station collection
        private void button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open StationCollection From JSON";
            dlg.InitialDirectory = Directory.GetCurrentDirectory(); 
            dlg.Filter = "JSON files (*.json)|*.json";

            if (dlg.ShowDialog() == true)
            {
               
                FileStream reader = new FileStream(dlg.FileName, FileMode.Open, FileAccess.Read);

                DataContractJsonSerializer inputSerializer;
                inputSerializer = new DataContractJsonSerializer(typeof(StationCollection));

                sc = (StationCollection)inputSerializer.ReadObject(reader);
                reader.Close();

                foreach(Station s in sc.stations)
                {
                    listViewStationCollection.Items.Add(s);
                }

                textBoxFilename.Text = dlg.FileName;
            }
        }

        
        //****************************************************
        // Method: private void button1_Click(object sender, RoutedEventArgs e)
        //
        // Purpose: Handle button click event to Show Station Data in assigned textboxes
        //****************************************************
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Station found = new Station();
            found = sc.FindStation(Convert.ToInt32(textBoxId.Text));

            if(found != null)
            {
                textBoxName.Text = found.name;
                textBoxLocation.Text = found.location;
                textBoxFareZone.Text = Convert.ToString(found.fareZone);
                textBoxMTP.Text = Convert.ToString(found.mileageToPenn);
                textBoxPicFilename.Text = found.picFilename;
            }
            else
            {
                MessageBox.Show("No station was found with Id entered.","Error");
            }//end of if else

        }//end of button1_click

        #endregion
    }//end of partial class MainWindow
}//end of namespace
