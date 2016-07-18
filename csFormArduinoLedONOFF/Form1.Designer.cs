namespace csFormArduinoLedONOFF
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
            this.btnOn = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnOff = new System.Windows.Forms.Button();
            this.btnSerialConnect = new System.Windows.Forms.Button();
            this.lbSerialports = new System.Windows.Forms.ListBox();
            this.gbConnection = new System.Windows.Forms.GroupBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbConnection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOn
            // 
            this.btnOn.Location = new System.Drawing.Point(177, 297);
            this.btnOn.Name = "btnOn";
            this.btnOn.Size = new System.Drawing.Size(97, 26);
            this.btnOn.TabIndex = 0;
            this.btnOn.Text = "LED ON";
            this.btnOn.UseVisualStyleBackColor = true;
            this.btnOn.Click += new System.EventHandler(this.btnOn_Click);
            // 
            // btnOff
            // 
            this.btnOff.Location = new System.Drawing.Point(177, 329);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(97, 26);
            this.btnOff.TabIndex = 1;
            this.btnOff.Text = "LED OFF";
            this.btnOff.UseVisualStyleBackColor = true;
            this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
            // 
            // btnSerialConnect
            // 
            this.btnSerialConnect.Location = new System.Drawing.Point(177, 244);
            this.btnSerialConnect.Name = "btnSerialConnect";
            this.btnSerialConnect.Size = new System.Drawing.Size(97, 26);
            this.btnSerialConnect.TabIndex = 2;
            this.btnSerialConnect.Text = "#";
            this.btnSerialConnect.UseVisualStyleBackColor = true;
            this.btnSerialConnect.Click += new System.EventHandler(this.btnSerialConnect_Click);
            // 
            // lbSerialports
            // 
            this.lbSerialports.FormattingEnabled = true;
            this.lbSerialports.Location = new System.Drawing.Point(17, 29);
            this.lbSerialports.Name = "lbSerialports";
            this.lbSerialports.Size = new System.Drawing.Size(108, 82);
            this.lbSerialports.TabIndex = 3;
            // 
            // gbConnection
            // 
            this.gbConnection.Controls.Add(this.lbSerialports);
            this.gbConnection.Location = new System.Drawing.Point(12, 233);
            this.gbConnection.Name = "gbConnection";
            this.gbConnection.Size = new System.Drawing.Size(141, 122);
            this.gbConnection.TabIndex = 4;
            this.gbConnection.TabStop = false;
            this.gbConnection.Text = "Available Serial Ports:";
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMessage.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(8, 9);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(278, 37);
            this.lblMessage.TabIndex = 5;
            this.lblMessage.Text = "WELCOME";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::csFormArduinoLedONOFF.Properties.Resources.arduino;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(8, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(278, 178);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(298, 379);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnOff);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnOn);
            this.Controls.Add(this.gbConnection);
            this.Controls.Add(this.btnSerialConnect);
            this.Name = "Form1";
            this.Text = "ARDUINO";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbConnection.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOn;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnOff;
        private System.Windows.Forms.Button btnSerialConnect;
        private System.Windows.Forms.ListBox lbSerialports;
        private System.Windows.Forms.GroupBox gbConnection;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

