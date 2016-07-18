using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csFormArduinoLedONOFF
{
/* This project needs Arduino UNO Board 
 * and .ino code already Build/Uploaded.
 * Application: LED ON/OFF with Arduino
 * using C Sharp Forms Application. Tested. OK.
 * */

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = System.IO.Ports.SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                lbSerialports.Items.Add(port);
            }

            lblMessage.Text =  "Arduino LED ON/OFF";

            if (!serialPort1.IsOpen)
            {
                btnSerialConnect.Text = "CONNECT";
                EtatDeconnecte();
            }
            else if (serialPort1.IsOpen)
                {
                btnSerialConnect.Text = "DISCONNECT";
                EtatConnecte();
            }
        }

        private void btnOn_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                btnOn.Enabled = false;
                btnOff.Enabled = true;
                serialPort1.Write("1");
                lblMessage.Text = "LED ON !";
            }
            
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                btnOff.Enabled = false;
                btnOn.Enabled = true;
                byte[] valueToSend = System.Text.Encoding.UTF8.GetBytes("0");
                serialPort1.Write(valueToSend,0,valueToSend.Length);

                lblMessage.Text = "LED OFF !";

            }
        }

        private void btnSerialConnect_Click(object sender, EventArgs e)
        {

            string buttontext = ((Control)sender).Text;
            if (buttontext.StartsWith("CON"))
            {


                if (serialPort1.IsOpen)
                {
                    lblMessage.Text = "Port déjà ouverte !";
                    return;
                }

                if (lbSerialports.Items.Count > 0)
                {
                    lbSerialports.SelectedIndex = 0;
                    this.Refresh();
                }
                else
                {
                    lblMessage.Text = "COM Port liste vide!";
                    EtatDeconnecte();
                    return;
                }

                try
                {
                    serialPort1.PortName = lbSerialports.SelectedItem.ToString();
                    serialPort1.BaudRate = 9600;
                    // if serial port is not open
                    if (!serialPort1.IsOpen)
                    {
                        // then open
                        serialPort1.Open();
                        Refresh();
                        // if open
                        if (serialPort1.IsOpen)
                        {
                            lblMessage.Text = "Connecté COM5.";

                            EtatConnecte();

                        }
                    }
                    else
                    {
                        lblMessage.Text = "Port déjà ouverte.";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }
            else if (buttontext.StartsWith("DIS"))
            {
                if (serialPort1.IsOpen)
                {
                    // lancer delegate fermeture connection
                    DelegateFermeture df = new DelegateFermeture(FermerCom);
                    df();
                    // arranger visuellement pour etat visuelle
                    EtatDeconnecte();
                }
            }
        }

        public void FermerCom()
        {
            serialPort1.Close();

            if (!serialPort1.IsOpen)
            {
                // display closed
                lblMessage.Text = "Porte fermé.";
            }
        }

        public delegate void DelegateFermeture();

        public void EtatDeconnecte()
        {
            btnOn.Visible = false;
            btnOff.Visible = false;
            if (!serialPort1.IsOpen)
            {
                btnSerialConnect.Text = "CONNECT";
                //EtatDeconnecte();
            }
            else if (serialPort1.IsOpen)
            {
                btnSerialConnect.Text = "DISCONNECT";
                //EtatConnecte();
            }
        }
        public void EtatConnecte()
        {
            btnOn.Visible = true;
            btnOff.Visible = true;
            if (!serialPort1.IsOpen)
            {
                btnSerialConnect.Text = "CONNECT";
                //EtatDeconnecte();
            }
            else if (serialPort1.IsOpen)
            {
                btnSerialConnect.Text = "DISCONNECT";
                //EtatConnecte();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                // lancer delegate fermeture connection
                DelegateFermeture df = new DelegateFermeture(FermerCom);
                df();
                // arranger visuellement pour etat visuelle
                EtatDeconnecte();
            }
        }

    }

}
