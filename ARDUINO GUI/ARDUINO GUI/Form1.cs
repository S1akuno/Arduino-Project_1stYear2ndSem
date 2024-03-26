using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARDUINO_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            serialPort1.Close();
            serialPort1.Open();
        }

        private void led1_Click(object sender, EventArgs e)
        {
            serialPort1.Write("redLED");
        }

        private void led2_Click(object sender, EventArgs e)
        {
            serialPort1.Write("blueLED");
        }

        private void led3_Click(object sender, EventArgs e)
        {
            serialPort1.Write("yellowLED");
        }

        private void turnOnAll_Click(object sender, EventArgs e)
        {
            serialPort1.Write("onAllLED");
        }

        private void turnOffAll_Click(object sender, EventArgs e)
        {
            serialPort1.Write("offAllLED");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.Write("Emergency");
        }
        private void eqdrill_Click(object sender, EventArgs e)
        {
            serialPort1.Write("Drill");
        }
    }
}

