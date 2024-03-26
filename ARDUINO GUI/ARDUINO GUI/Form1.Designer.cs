namespace ARDUINO_GUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.led1 = new System.Windows.Forms.Button();
            this.led2 = new System.Windows.Forms.Button();
            this.led3 = new System.Windows.Forms.Button();
            this.turnOnAll = new System.Windows.Forms.Button();
            this.turnOffAll = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.eqdrill = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // led1
            // 
            this.led1.Location = new System.Drawing.Point(12, 73);
            this.led1.Name = "led1";
            this.led1.Size = new System.Drawing.Size(75, 23);
            this.led1.TabIndex = 0;
            this.led1.Text = "LED1";
            this.led1.UseVisualStyleBackColor = true;
            this.led1.Click += new System.EventHandler(this.led1_Click);
            // 
            // led2
            // 
            this.led2.Location = new System.Drawing.Point(12, 117);
            this.led2.Name = "led2";
            this.led2.Size = new System.Drawing.Size(75, 23);
            this.led2.TabIndex = 1;
            this.led2.Text = "LED2";
            this.led2.UseVisualStyleBackColor = true;
            this.led2.Click += new System.EventHandler(this.led2_Click);
            // 
            // led3
            // 
            this.led3.Location = new System.Drawing.Point(12, 161);
            this.led3.Name = "led3";
            this.led3.Size = new System.Drawing.Size(75, 23);
            this.led3.TabIndex = 2;
            this.led3.Text = "LED3";
            this.led3.UseVisualStyleBackColor = true;
            this.led3.Click += new System.EventHandler(this.led3_Click);
            // 
            // turnOnAll
            // 
            this.turnOnAll.Location = new System.Drawing.Point(12, 202);
            this.turnOnAll.Name = "turnOnAll";
            this.turnOnAll.Size = new System.Drawing.Size(75, 23);
            this.turnOnAll.TabIndex = 3;
            this.turnOnAll.Text = "OPEN";
            this.turnOnAll.UseVisualStyleBackColor = true;
            this.turnOnAll.Click += new System.EventHandler(this.turnOnAll_Click);
            // 
            // turnOffAll
            // 
            this.turnOffAll.Location = new System.Drawing.Point(12, 245);
            this.turnOffAll.Name = "turnOffAll";
            this.turnOffAll.Size = new System.Drawing.Size(75, 23);
            this.turnOffAll.TabIndex = 4;
            this.turnOffAll.Text = "CLOSE";
            this.turnOffAll.UseVisualStyleBackColor = true;
            this.turnOffAll.Click += new System.EventHandler(this.turnOffAll_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM5";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(179, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Disaster Alarm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // eqdrill
            // 
            this.eqdrill.Location = new System.Drawing.Point(179, 117);
            this.eqdrill.Name = "eqdrill";
            this.eqdrill.Size = new System.Drawing.Size(112, 23);
            this.eqdrill.TabIndex = 6;
            this.eqdrill.Text = "EarthQuake Drill";
            this.eqdrill.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.eqdrill);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.turnOffAll);
            this.Controls.Add(this.turnOnAll);
            this.Controls.Add(this.led3);
            this.Controls.Add(this.led2);
            this.Controls.Add(this.led1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button led1;
        private System.Windows.Forms.Button led2;
        private System.Windows.Forms.Button led3;
        private System.Windows.Forms.Button turnOnAll;
        private System.Windows.Forms.Button turnOffAll;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button eqdrill;
    }
}

