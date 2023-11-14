﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Usings for common part of the API
using Hbm.Api.Common;
using Hbm.Api.Common.Exceptions;
using Hbm.Api.Common.Entities;
using Hbm.Api.Common.Entities.Problems;
using Hbm.Api.Common.Entities.Connectors;
using Hbm.Api.Common.Entities.Channels;
using Hbm.Api.Common.Entities.Signals;
using Hbm.Api.Common.Entities.Filters;
using Hbm.Api.Common.Entities.ConnectionInfos;
using Hbm.Api.Common.Enums;

//Usings for logging
using Hbm.Api.Logging;
using Hbm.Api.Logging.Enums;
using Hbm.Api.Logging.Logger;

//Usings for sensor database access
using Hbm.Api.SensorDB.Entities.Sensors;
using Hbm.Api.SensorDB.Entities.Scalings;

//Usings for common API events 
using Hbm.Api.Common.Messaging;

//Usings for PMX (only necessary, if you want to use special features of PMX devices)
using Hbm.Api.Pmx;
using Hbm.Api.Pmx.Connectors;
using Hbm.Api.Pmx.Channels;
using Hbm.Api.Pmx.Signals;


//Usings for QuantumX (only necessary, if you want to use special features of QuantumX devices)
using Hbm.Api.QuantumX;
using Hbm.Api.QuantumX.Connectors;
using Hbm.Api.QuantumX.Channels;
using Hbm.Api.QuantumX.Signals;

using Hbm.Api.SensorDB;
using Hbm.Api.SensorDB.Entities;

namespace GrammerApp
{
    public partial class Form1 : Form
    {

        #region Global variables

        // Variables used to show the general workflow 
        private DaqEnvironment _daqEnvironment;   // main object to scan, connect and parameterize devices
        private DaqMeasurement _daqMeasurement;   // main object to execute measurements
        private Device _myDevice;         // device to connect and to use within this demo
        private List<Signal> _signalsToMeasure; // list of signals to use for a continuous measurement
        private bool _runMeasurement;   // true, while data acquisition is running...
        private List<Device> _deviceList;       // list of devices found by the scan

        private delegate void VisualizeDeviceEventHandler(DeviceEventArgs e); // delegate for our event handling

        // Sensor data base access
        private ISensorDB _sensorDBManagerForHbmSensorDatabase;  // sensor manager, used to access the HBM sensor database 
        private ISensorDB _sensorDBManagerForUserSensorDatabase; // sensor manager, used to access a user sensor database

        // Logging
        private ILogger _logger;                     // a logger object that can be used to log messages
        private LogContext _logContextApiDemoMeasuring; // context to log messages in a hierarchical way here: Messages related to measurement issues

        private LogContext
            _logContextApiDemoProblems; // context to log messages in a hierarchical way here: Messages related to problems that occurred during the execution of the demo

        private int _logNumberDummy = 0; // just a counter used to generate different log entries...

        #endregion

        //
        public Form1()
        {
            InitializeComponent();
            detectChannelOnStartup();
        }

        private void detectChannelOnStartup()
        {
            try
            {
                // check, which device families are supported...
                List<string> supportedDeviceFamilies = _daqEnvironment.GetAvailableDeviceFamilyNames();

                foreach (string family in supportedDeviceFamilies)
                {
                    AddToProtocol("Supported device family:" + family);
                }

                // scan for all supported device families               _deviceList = _daqEnvironment.Scan(supportedDeviceFamilies);

                // notice that the list of devices already has some information about the devices - 
                // although they are NOT yet connected. The information is delivered by the scan!

                //sort the list by device name
                _deviceList = _deviceList.OrderBy(n => n.Name).ToList();

                AddToProtocol(string.Format("Found devices:{0}", _deviceList.Count));

                foreach (Device dev in _deviceList)
                {
                    AddToProtocol(string.Format("Devicename: {0} Serialnumber: {1}  FirmwareVersion: {2}", dev.Name.PadRight(22), dev.SerialNo.PadRight(16), dev.FirmwareVersion));
                }

                /*update comboBox with found devices and their IP addresses:
                _deviceListComboBox.Items.Clear();

                foreach (Device device in _deviceList)
                {
                    _deviceListComboBox.Items.Add(device.Name.PadRight(14) + " (" + (device.ConnectionInfo as EthernetConnectionInfo).IpAddress + ")");
                }

                //select first device within the 
                if (_deviceListComboBox.Items.Count > 0)
                {
                    _deviceListComboBox.SelectedIndex = 0;
                }*/

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.ToString());
            }
        }

        private void AddToProtocol(string message)
        {
            ProtocolTb.AppendText(message + Environment.NewLine);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Copiez les valeurs RGB de Just Color Picker
            panel1.BackColor = Color.FromArgb(1, 80, 147); // code couleur RGB

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void stopbutton_Click(object sender, EventArgs e)
        {
            
        }

        private void Start_Click(object sender, EventArgs e)
        {
           
        }

        private void logo_Click(object sender, EventArgs e)
        {

        }
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
       

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
