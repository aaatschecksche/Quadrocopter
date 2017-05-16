using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;


namespace Quadrocopter
{
    public partial class Quadrocopter : Form
    {
        public SerialPort PORT;

        string COMPORT;
        int baudrate;

        Stopwatch LogTimer = new Stopwatch ();
        private String LogTimerString
        {
            get
            {
                return "[" + (LogTimer.ElapsedMilliseconds / 1000.0).ToString("0.00") + "s] ";
            }
        }

        enum Command
        {
            NO_COMMAND = 0,
            CALIBRATE_MOTORS,
            TOGGLE_DEBUG_MODE,
            SET_TAU,
            SET_KP,
            SET_KD,
            SET_KI,
            START_MEASUREMENT,
            SHUTDOWN,
            SET_KP_PITCH,
            SET_KD_PITCH,
            SET_KI_PITCH
        }

        bool Terminate = false, Running = true;
        String TerminationString;


        public Quadrocopter(String comPort, int baudrate)
        {
            InitializeComponent();

            COMPORT = comPort;
            this.baudrate = baudrate;

            // FILL COMMAND SELECTOR
            for (int i = 0; i < Enum.GetNames(typeof(Command)).Length; i++)
                CommandSelector.Items.Add(((Command)i).ToString());

            CommandSelector.SelectedIndex = 0;
        } 

        private void Connect()
        {
            try
            {
                PORT = new SerialPort(COMPORT, baudrate);
                PORT.DataReceived += PORT_DataRecieved;

                if (!PORT.IsOpen)
                    PORT.Open();

                StatusLabel.Text = "Connected!";
                StatusLabel.BackColor = Color.Green;

                TitleLabel.BackColor = Color.Green;

                LogTimer.Start();
            }

            catch (Exception e)
            {
                StatusLabel.Text = "Not Connected!";
                StatusLabel.BackColor = Color.Red;

                TitleLabel.BackColor = Color.Red;
            }
        }


        private void PORT_DataRecieved(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;

            if (Running)
            {
                string indata = sp.ReadExisting();

                string recieveBoxStringToAdd = "";
                foreach (char c in indata)
                {
                    if (c == (char)13)
                        continue;

                    if (c == (char)2)
                    {
                        Terminate = true;
                        continue;
                    }

                    if (c == (char)3)
                    {
                        Terminate = false;

                        if (TerminationString != "")
                            Invoke((MethodInvoker)delegate
                            {
                                DebugBox.Text = TerminationString;
                            });


                        TerminationString = "";

                        continue;
                    }

                    if (c == (char)0)
                        continue;


                    if (Terminate)
                        TerminationString += c;

                    else
                        recieveBoxStringToAdd += c;
                }

                try
                {
                    Invoke ( (MethodInvoker)delegate
                    {
                        RecieveBox.Text += recieveBoxStringToAdd;
                    } );
                }

                catch (Exception ex)
                {
                    Debug.WriteLine ( ex.Message );
                }
            }

            else
                sp.ReadExisting();
        }

        private void SendButton_Click ( object sender, EventArgs e )
        {
            float dataBytes;
            try
            {
                dataBytes = Convert.ToSingle ( SendBox.Text );
            }

            catch
            {
                dataBytes = 0;
            }

            byte command = (byte)(CommandSelector.SelectedIndex + 128);

            if (dataBytes >= 128)
            {
                MessageBox.Show ( "PISCH BEHINDERT?" );
                return;
            }

            Byte[] send = new Byte[4];
            send[0] = command;
            send[1] = (byte) dataBytes;
            send[2] = (byte) ((float)((dataBytes % 1)*100f));
            send[3] = 255;

            PORT.Write(send, 0, send.Length);

            RecieveBox.Text += LogTimerString + ((Command)(command-128)).ToString() + " - " + dataBytes.ToString() + "\n";
        }

        private void RecieveBox_TextChanged(object sender, EventArgs e)
        {
            RecieveBox.SelectionStart = RecieveBox.Text.Length;
            RecieveBox.ScrollToCaret ();
        }

        private void ClearConsole_Click(object sender, EventArgs e)
        {
            RecieveBox.Text = "";
            DebugBox.Text = "";
            LogTimer.Restart();
        }

        private void Quadrocopter_Load(object sender, EventArgs e)
        {
            Connect();
        }

        private void KPButton_Click ( object sender, EventArgs e )
        {
            float dataBytes;
            try
            {
                dataBytes = Convert.ToSingle ( KPBox.Text );
            }

            catch
            {
                dataBytes = 0;
            }

            if (dataBytes >= 128)
            {
                MessageBox.Show ( "PISCH BEHINDERT?" );
                return;
            }

            Byte[] send = new Byte[4];
            send[0] = (byte) (Command.SET_KP + 128);
            send[1] = (byte)dataBytes;
            send[2] = (byte)((float)((dataBytes % 1) * 100f));
            send[3] = 255;

            PORT.Write ( send, 0, send.Length );

            RecieveBox.Text += LogTimerString + ((Command)(send[0] - 128)).ToString () + " - " + dataBytes.ToString () + "\n";
        }

        private void KDButton_Click ( object sender, EventArgs e )
        {
            float dataBytes;
            try
            {
                dataBytes = Convert.ToSingle ( KDBox.Text );
            }

            catch
            {
                dataBytes = 0;
            }

            if (dataBytes >= 128)
            {
                MessageBox.Show ( "PISCH BEHINDERT?" );
                return;
            }

            Byte[] send = new Byte[4];
            send[0] = (byte)(Command.SET_KD + 128);
            send[1] = (byte)dataBytes;
            send[2] = (byte)((float)((dataBytes % 1) * 100f));
            send[3] = 255;

            PORT.Write ( send, 0, send.Length );

            RecieveBox.Text += LogTimerString + ((Command)(send[0] - 128)).ToString () + " - " + dataBytes.ToString () + "\n";
        }

        private void KIButton_Click ( object sender, EventArgs e )
        {
            float dataBytes;
            try
            {
                dataBytes = Convert.ToSingle ( KIBox.Text );
            }

            catch
            {
                dataBytes = 0;
            }

            if (dataBytes >= 128)
            {
                MessageBox.Show ( "PISCH BEHINDERT?" );
                return;
            }

            Byte[] send = new Byte[4];
            send[0] = (byte)(Command.SET_KI + 128);
            send[1] = (byte)dataBytes;
            send[2] = (byte)((float)((dataBytes % 1) * 100f));
            send[3] = 255;

            PORT.Write ( send, 0, send.Length );

            RecieveBox.Text += LogTimerString + ((Command)(send[0] - 128)).ToString () + " - " + dataBytes.ToString () + "\n";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Running ^= true;
        }
    }
}
