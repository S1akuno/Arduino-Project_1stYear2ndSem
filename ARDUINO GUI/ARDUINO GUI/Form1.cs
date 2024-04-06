using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Net.Http.Headers;      //For Reading Serial data from Arduino

namespace ARDUINO_GUI
{
    public partial class arduinoGUI : Form
    {
        String dataReceived = string.Empty;
        public arduinoGUI()
        {
            InitializeComponent();      // This will run the application
        }


        private void arduinoGUI_Load(object sender, EventArgs e)
        {
            statusTxt.Text = "DISCONNECTED";
            statusTxt.ForeColor = Color.Red;
            statusBar.Value = 0;

            comboBox_baudRate.Text = "9600";
            String[] portLists = SerialPort.GetPortNames();
            comboBox_portList.Items.AddRange(portLists);



            //Clickability of the button at the start of the program
            closePort.Enabled = false;
            openPort.Enabled = true;
            comboBox_baudRate.Enabled = true ;
            comboBox_portList.Enabled = true ;

            LCSnav.Enabled = false;
            EQASnav.Enabled = false;
            GASnav.Enabled = false;
            FASDSnav.Enabled = false;
            TBAnav.Enabled = false;


            LCS_button1.Enabled = false;
            LCS_button2.Enabled = false;
            LCS_button3.Enabled = false;
            LCS_button4.Enabled = false;
            LCS_ONbutton.Enabled = false;
            LCS_OFFbutton.Enabled = false;

            EQAS_drillButton.Enabled = false;
            EQAS_earthquakeButton.Enabled = false;

            GAS_openButton.Enabled = false;
            GAS_closeButton.Enabled = false;
        }


        //For having an alert box confirmation when exiting
        private void exitButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Exit?", "Arduino Controller", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void openPort_Click(object sender, EventArgs e)
        {
            try
            {
                arduinoPort.PortName = comboBox_portList.Text;
                arduinoPort.BaudRate = Convert.ToInt32(comboBox_baudRate.Text);
                arduinoPort.Open();

                statusTxt.Text = "   CONNECTED";
                statusTxt.ForeColor = Color.LawnGreen;
                statusBar.Value = 100;

                comboBox_baudRate.Enabled = false;
                comboBox_portList.Enabled = false;
                closePort.Enabled = true;
                openPort.Enabled = false;

                LCSnav.Enabled = true;
                EQASnav.Enabled = true;
                GASnav.Enabled = true;
                FASDSnav.Enabled = true;
                TBAnav.Enabled = true;


                LCS_button1.Enabled = true;
                LCS_button2.Enabled = true;
                LCS_button3.Enabled = true;
                LCS_button4.Enabled = true;
                LCS_ONbutton.Enabled = true;
                LCS_OFFbutton.Enabled = true;

                EQAS_drillButton.Enabled = true;
                EQAS_earthquakeButton.Enabled = true;

                GAS_openButton.Enabled = true;
                GAS_closeButton.Enabled = true;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void closePort_Click(object sender, EventArgs e)
        {
            if (arduinoPort.IsOpen)
            {
                try
                {
                    arduinoPort.Close();

                    statusTxt.Text = "DISCONNECTED";
                    statusTxt.ForeColor = Color.Red;
                    statusBar.Value = 0;
                    closePort.Enabled = false;
                    openPort.Enabled = true;
                    comboBox_baudRate.Enabled = true ;
                    comboBox_portList.Enabled = true ;


                    LCSnav.Enabled = false;
                    EQASnav.Enabled = false;
                    GASnav.Enabled = false;
                    FASDSnav.Enabled = false;
                    TBAnav.Enabled = false;


                    LCS_button1.Enabled = false;
                    LCS_button2.Enabled = false;
                    LCS_button3.Enabled = false;
                    LCS_button4.Enabled = false;
                    LCS_ONbutton.Enabled = false;
                    LCS_OFFbutton.Enabled = false;

                    EQAS_drillButton.Enabled = false;
                    EQAS_earthquakeButton.Enabled = false;

                    GAS_openButton.Enabled = false;
                    GAS_closeButton.Enabled = false;
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);

                }
            }
        }



        private void arduinoPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            dataReceived = arduinoPort.ReadLine();

            switch (dataReceived) {

                case "Red LED turned ON":
                    LCS_button1.BackColor = Color.FromArgb(98, 208, 233);
                    LCS_OFFbutton.BackColor = Color.FromArgb(225, 225, 225);
                    break;
                case "Red LED turned OFF":
                    LCS_button1.BackColor = Color.FromArgb(225, 225, 225);
                    LCS_ONbutton.BackColor = Color.FromArgb(225, 225, 225);
                    break;
                case "Blue LED turned ON":
                    LCS_button2.BackColor = Color.FromArgb(98, 208, 233);
                    LCS_OFFbutton.BackColor = Color.FromArgb(225, 225, 225);
                    break;
                case "Blue LED turned OFF":
                    LCS_button2.BackColor = Color.FromArgb(225, 225, 225);
                    LCS_ONbutton.BackColor = Color.FromArgb(225, 225, 225);
                    break;
                case "Yellow LED turned ON":
                    LCS_button3.BackColor = Color.FromArgb(98, 208, 233);
                    LCS_OFFbutton.BackColor = Color.FromArgb(225, 225, 225);
                    break;
                case "Yellow LED turned OFF":
                    LCS_button3.BackColor = Color.FromArgb(225, 225, 225);
                    LCS_ONbutton.BackColor = Color.FromArgb(225, 225, 225);
                    break;
                case "White LED turned ON":
                    LCS_button4.BackColor = Color.FromArgb(98, 208, 233);
                    LCS_OFFbutton.BackColor = Color.FromArgb(225, 225, 225);
                    break;
                case "White LED turned OFF":
                    LCS_button4.BackColor = Color.FromArgb(225, 225, 225);
                    LCS_ONbutton.BackColor = Color.FromArgb(225, 225, 225);
                    break;
                case "ALL LEDs turned OFF":
                    LCS_OFFbutton.BackColor = Color.FromArgb(98, 103, 233);
                    LCS_ONbutton.BackColor = Color.FromArgb(225, 225, 225);
                    LCS_button1.BackColor = Color.FromArgb(225, 225, 225);
                    LCS_button2.BackColor = Color.FromArgb(225, 225, 225);
                    LCS_button3.BackColor = Color.FromArgb(225, 225, 225);
                    LCS_button4.BackColor = Color.FromArgb(225, 225, 225);
                    break;
                case "ALL LEDs turned ON":
                    LCS_OFFbutton.BackColor = Color.FromArgb(225, 225, 225);
                    LCS_ONbutton.BackColor = Color.FromArgb(96, 175, 231);
                    LCS_button1.BackColor = Color.FromArgb(98, 208, 233);
                    LCS_button2.BackColor = Color.FromArgb(98, 208, 233);
                    LCS_button3.BackColor = Color.FromArgb(98, 208, 233);
                    LCS_button4.BackColor = Color.FromArgb(98, 208, 233);
                    break;
                case "EARHTQUAKE ALARM ACTIVATED!!":
                    EQAS_drillButton.BackColor = Color.FromArgb(225, 225, 225);
                    EQAS_earthquakeButton.BackColor = Color.FromArgb(98, 208, 233);
        
                    break;
                case "EARHTQUAKE DRILL ALARM ACTIVATED!!":
                    EQAS_drillButton.BackColor = Color.FromArgb(98, 208, 233);
                    EQAS_earthquakeButton.BackColor = Color.FromArgb(225, 225, 225);

                    break;
                case "EARHTQUAKE ALARM DEACTIVATED!!":
                    EQAS_drillButton.BackColor = Color.FromArgb(225, 225, 225);
                    EQAS_earthquakeButton.BackColor = Color.FromArgb(225, 225, 225);

                    break;
                case "EARHTQUAKE DRILL ALARM DEACTIVATED!!":
                    EQAS_drillButton.BackColor = Color.FromArgb(225, 225, 225);
                    EQAS_earthquakeButton.BackColor = Color.FromArgb(225, 225, 225);

                    break;
                case "Gate Open":
                    GAS_openButton.BackColor = Color.FromArgb(98, 208, 233);
                    GAS_closeButton.BackColor = Color.FromArgb(225, 225, 225);

                    break;
                case "Gate Close":
                    GAS_openButton.BackColor = Color.FromArgb(225, 225, 225);
                    GAS_closeButton.BackColor = Color.FromArgb(225, 225, 22);

                    break;
            }

   
                     
            
        }


        //Lighting control System BUTTONS
        private void LCS_button1_Click(object sender, EventArgs e)
        {
            arduinoPort.Write("redLED");
        }

        private void LCS_button2_Click(object sender, EventArgs e)
        {
            arduinoPort.Write("blueLED");
        }

        private void LCS_button3_Click(object sender, EventArgs e)
        {
            arduinoPort.Write("yellowLED");
        }
        private void LCS_button4_Click(object sender, EventArgs e)
        {
            arduinoPort.Write("whiteLED");
        }

        private void LCS_ONbutton_Click(object sender, EventArgs e)
        {
            arduinoPort.Write("onAllLED");
        }

        private void LCS_OFFbutton_Click(object sender, EventArgs e)
        {
            arduinoPort.Write("offAllLED");
        }




        //EARTHQUAKE ALARM BUTTONS
        private void EQAS_drillButton_Click(object sender, EventArgs e)
        {
           arduinoPort.Write("Drill");
        }

        private void EQAS_earthquakeButton_Click(object sender, EventArgs e)
        {
            arduinoPort.Write("Emergency");
        }

        private void GAS_openButton_Click(object sender, EventArgs e)
        {
            arduinoPort.Write("Gate Open");
        }

        private void GAS_closeButton_Click(object sender, EventArgs e)
        {
            arduinoPort.Write("Gate Close");
        }

    /////////////////////////// NAVIGATION BAR /////////////////////////////////////

        // For Lighting Control
        private void LCSnav_MouseHover(object sender, EventArgs e)
        {
            LCSnav.ForeColor = Color.FromArgb(96, 175, 231);
        }
        private void LCSnav_MouseLeave(object sender, EventArgs e)
        {
            LCSnav.ForeColor = Color.White;
        }
        private void LCSnav_Click(object sender, EventArgs e)
        {
            
        }

        // For Earthquake Alarm
        private void EQASnav_MouseHover(object sender, EventArgs e)
        {
            EQASnav.ForeColor = Color.FromArgb(96, 175, 231);
        }
        private void EQASnav_MouseLeave(object sender, EventArgs e)
        {
            EQASnav.ForeColor = Color.White;
        }
        private void EQASnav_Click(object sender, EventArgs e)
        {
            
        }

        private void GASnav_MouseHover(object sender, EventArgs e)
        {
            GASnav.ForeColor = Color.FromArgb(96, 175, 231);
        }
        private void GASnav_MouseLeave(object sender, EventArgs e)
        {
            GASnav.ForeColor = Color.White;
        }
        private void GASnav_Click(object sender, EventArgs e)
        {

        }

        private void FASDSnav_MouseHover(object sender, EventArgs e)
        {
            FASDSnav.ForeColor = Color.FromArgb(96, 175, 231);
        }
        private void FASDSnav_MouseLeave(object sender, EventArgs e)
        {
            FASDSnav.ForeColor = Color.White;
        }
        private void FASDSnav_Click(object sender, EventArgs e)
        {

        }

        private void TBAnav_MouseHover(object sender, EventArgs e)
        {
            TBAnav.ForeColor = Color.FromArgb(96, 175, 231);
        }
        private void TBAnav_MouseLeave(object sender, EventArgs e)
        {
            TBAnav.ForeColor = Color.White;
        }
        private void TBAnav_Click(object sender, EventArgs e)
        {

        }
    }
}

