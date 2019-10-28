using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatteryMonitor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Task.Delay(new TimeSpan(0, 0, 15)).ContinueWith(o =>{ closeApp(); } );
            label7.Text = GetBatteryStatus().ToString() + '%';
            label8.Text = GetPowerSource();
            
        }

        private void closeApp()
        {
            throw new NotImplementedException();
        }

        public String GetPowerSource()
        {
            string strPowerLineStatus = "Default";
            // Getting the current system power status.
            switch (SystemInformation.PowerStatus.PowerLineStatus)
            {
                case PowerLineStatus.Offline:
                    strPowerLineStatus = "Battery";
                    break;
                case PowerLineStatus.Online:
                    strPowerLineStatus = "AC Power";
                    break;
                case PowerLineStatus.Unknown:
                    strPowerLineStatus = "Unknown";
                    break;
            }
            return strPowerLineStatus;
        }

        public float GetBatteryStatus()
        {
            float batterylife;
            batterylife = SystemInformation.PowerStatus.BatteryLifePercent;
            batterylife *= 100.0f;

            return batterylife;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        //private void label1_Click(object sender, EventArgs e)
        //{

        //}

        //private void label2_Click(object sender, EventArgs e)
        //{

        //}

        private void button3_Click(object sender, EventArgs e)
        {
          

        }

        //private void label4_Click(object sender, EventArgs e)
        //{
        //    GetPowerSource();
        //}

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
