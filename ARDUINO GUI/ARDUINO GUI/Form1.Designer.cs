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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.eqdrill = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.turnOnAll = new System.Windows.Forms.Button();
            this.led3 = new System.Windows.Forms.Button();
            this.led2 = new System.Windows.Forms.Button();
            this.led1 = new System.Windows.Forms.Button();
            this.turnOffAll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.flowLayoutPanel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM6";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Disaster Alarm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // eqdrill
            // 
            this.eqdrill.Location = new System.Drawing.Point(121, 3);
            this.eqdrill.Name = "eqdrill";
            this.eqdrill.Size = new System.Drawing.Size(112, 23);
            this.eqdrill.TabIndex = 6;
            this.eqdrill.Text = "EarthQuake Drill";
            this.eqdrill.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.SystemColors.Desktop;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(526, 21);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(262, 188);
            this.flowLayoutPanel2.TabIndex = 8;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.SystemColors.Info;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(526, 232);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(262, 193);
            this.flowLayoutPanel3.TabIndex = 9;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.flowLayoutPanel4.Controls.Add(this.button1);
            this.flowLayoutPanel4.Controls.Add(this.eqdrill);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(12, 232);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(262, 193);
            this.flowLayoutPanel4.TabIndex = 11;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.flowLayoutPanel5.Location = new System.Drawing.Point(293, 21);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(217, 404);
            this.flowLayoutPanel5.TabIndex = 12;
            // 
            // turnOnAll
            // 
            this.turnOnAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.turnOnAll.Location = new System.Drawing.Point(14, 56);
            this.turnOnAll.Name = "turnOnAll";
            this.turnOnAll.Size = new System.Drawing.Size(75, 23);
            this.turnOnAll.TabIndex = 3;
            this.turnOnAll.Text = "OPEN";
            this.turnOnAll.UseVisualStyleBackColor = false;
            this.turnOnAll.Click += new System.EventHandler(this.turnOnAll_Click);
            // 
            // led3
            // 
            this.led3.Location = new System.Drawing.Point(155, 102);
            this.led3.Name = "led3";
            this.led3.Size = new System.Drawing.Size(75, 23);
            this.led3.TabIndex = 2;
            this.led3.Text = "LED3";
            this.led3.UseVisualStyleBackColor = true;
            this.led3.Click += new System.EventHandler(this.led3_Click);
            // 
            // led2
            // 
            this.led2.Location = new System.Drawing.Point(14, 140);
            this.led2.Name = "led2";
            this.led2.Size = new System.Drawing.Size(75, 23);
            this.led2.TabIndex = 1;
            this.led2.Text = "LED2";
            this.led2.UseVisualStyleBackColor = true;
            this.led2.Click += new System.EventHandler(this.led2_Click);
            // 
            // led1
            // 
            this.led1.Location = new System.Drawing.Point(14, 102);
            this.led1.Name = "led1";
            this.led1.Size = new System.Drawing.Size(75, 23);
            this.led1.TabIndex = 0;
            this.led1.Text = "LED1";
            this.led1.UseVisualStyleBackColor = true;
            this.led1.Click += new System.EventHandler(this.led1_Click);
            // 
            // turnOffAll
            // 
            this.turnOffAll.Location = new System.Drawing.Point(155, 56);
            this.turnOffAll.Name = "turnOffAll";
            this.turnOffAll.Size = new System.Drawing.Size(75, 23);
            this.turnOffAll.TabIndex = 4;
            this.turnOffAll.Text = "CLOSE";
            this.turnOffAll.UseVisualStyleBackColor = true;
            this.turnOffAll.Click += new System.EventHandler(this.turnOffAll_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "LIGHTING CONTROL SYSTEM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.turnOffAll);
            this.panel1.Controls.Add(this.led1);
            this.panel1.Controls.Add(this.turnOnAll);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.led2);
            this.panel1.Controls.Add(this.led3);
            this.panel1.Location = new System.Drawing.Point(15, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 176);
            this.panel1.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(155, 140);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "LED4";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel5);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.flowLayoutPanel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button eqdrill;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Button turnOnAll;
        private System.Windows.Forms.Button led3;
        private System.Windows.Forms.Button led2;
        private System.Windows.Forms.Button led1;
        private System.Windows.Forms.Button turnOffAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
    }
}

