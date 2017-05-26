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
using System.IO;

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
            SET_KP_ROLL,
            SET_KD_ROLL,
            SET_KI_ROLL,
            START_MEASUREMENT,
            SHUTDOWN,
            SET_KP_PITCH,
            SET_KD_PITCH,
            SET_KI_PITCH,
            SET_KP_YAW,
            SET_KI_YAW
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

                LogTimer.Start();
            }

            catch
            {
                StatusLabel.Text = "Not Connected!";
                StatusLabel.BackColor = Color.Red;
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

        private void KP_RollButton_Click ( object sender, EventArgs e )
        {
            float dataBytes;
            try
            {
                dataBytes = Convert.ToSingle ( KP_RollBox.Text );
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
            send[0] = (byte) (Command.SET_KP_ROLL + 128);
            send[1] = (byte)dataBytes;
            send[2] = (byte)((float)((dataBytes % 1) * 100f));
            send[3] = 255;

            PORT.Write ( send, 0, send.Length );

            RecieveBox.Text += LogTimerString + ((Command)(send[0] - 128)).ToString () + " - " + dataBytes.ToString () + "\n";
        }

        private void KD_RollButton_Click ( object sender, EventArgs e )
        {
            float dataBytes;
            try
            {
                dataBytes = Convert.ToSingle ( KD_RollBox.Text );
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
            send[0] = (byte)(Command.SET_KD_ROLL + 128);
            send[1] = (byte)dataBytes;
            send[2] = (byte)((float)((dataBytes % 1) * 100f));
            send[3] = 255;

            PORT.Write ( send, 0, send.Length );

            RecieveBox.Text += LogTimerString + ((Command)(send[0] - 128)).ToString () + " - " + dataBytes.ToString () + "\n";
        }

        private void KI_RollButton_Click ( object sender, EventArgs e )
        {
            float dataBytes;
            try
            {
                dataBytes = Convert.ToSingle ( KI_RollBox.Text );
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
            send[0] = (byte)(Command.SET_KI_ROLL + 128);
            send[1] = (byte)dataBytes;
            send[2] = (byte)((float)((dataBytes % 1) * 100f));
            send[3] = 255;

            PORT.Write ( send, 0, send.Length );

            RecieveBox.Text += LogTimerString + ((Command)(send[0] - 128)).ToString () + " - " + dataBytes.ToString () + "\n";
        }

        private void KP_PitchButton_Click ( object sender, EventArgs e )
        {
            float dataBytes;
            try
            {
                dataBytes = Convert.ToSingle ( KP_PitchBox.Text );
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
            send[0] = (byte)(Command.SET_KP_PITCH + 128);
            send[1] = (byte)dataBytes;
            send[2] = (byte)((float)((dataBytes % 1) * 100f));
            send[3] = 255;

            PORT.Write ( send, 0, send.Length );

            RecieveBox.Text += LogTimerString + ((Command)(send[0] - 128)).ToString () + " - " + dataBytes.ToString () + "\n";
        }

        private void KD_PitchButton_Click ( object sender, EventArgs e )
        {
            float dataBytes;
            try
            {
                dataBytes = Convert.ToSingle ( KD_PitchBox.Text );
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
            send[0] = (byte)(Command.SET_KD_PITCH + 128);
            send[1] = (byte)dataBytes;
            send[2] = (byte)((float)((dataBytes % 1) * 100f));
            send[3] = 255;

            PORT.Write ( send, 0, send.Length );

            RecieveBox.Text += LogTimerString + ((Command)(send[0] - 128)).ToString () + " - " + dataBytes.ToString () + "\n";
        }

        private void KI_PitchButton_Click ( object sender, EventArgs e )
        {
            float dataBytes;
            try
            {
                dataBytes = Convert.ToSingle ( KI_PitchBox.Text );
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
            send[0] = (byte)(Command.SET_KI_PITCH + 128);
            send[1] = (byte)dataBytes;
            send[2] = (byte)((float)((dataBytes % 1) * 100f));
            send[3] = 255;

            PORT.Write ( send, 0, send.Length );

            RecieveBox.Text += LogTimerString + ((Command)(send[0] - 128)).ToString () + " - " + dataBytes.ToString () + "\n";
        }

        private void KP_YawButton_Click ( object sender, EventArgs e )
        {
            float dataBytes;
            try
            {
                dataBytes = Convert.ToSingle ( KP_YawBox.Text );
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
            send[0] = (byte)(Command.SET_KP_YAW + 128);
            send[1] = (byte)dataBytes;
            send[2] = (byte)((float)((dataBytes % 1) * 100f));
            send[3] = 255;

            PORT.Write ( send, 0, send.Length );

            RecieveBox.Text += LogTimerString + ((Command)(send[0] - 128)).ToString () + " - " + dataBytes.ToString () + "\n";
        }

        private void KI_YawButton_Click ( object sender, EventArgs e )
        {
            float dataBytes;
            try
            {
                dataBytes = Convert.ToSingle ( KI_YawBox.Text );
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
            send[0] = (byte)(Command.SET_KI_YAW + 128);
            send[1] = (byte)dataBytes;
            send[2] = (byte)((float)((dataBytes % 1) * 100f));
            send[3] = 255;

            PORT.Write ( send, 0, send.Length );

            RecieveBox.Text += LogTimerString + ((Command)(send[0] - 128)).ToString () + " - " + dataBytes.ToString () + "\n";
        }

        private void ExportButton_Click ( object sender, EventArgs e )
        {
            SaveFileDialog dialog = new SaveFileDialog ();
            dialog.Filter = "Quadrocopter Regulation Value Set|*.set";
            dialog.InitialDirectory = Application.StartupPath;
            dialog.FileName = "RegValSet01";
            var result = dialog.ShowDialog ();

            if (result == DialogResult.OK)
            {
                String saveText = "";

                saveText += "KP_ROLL;" + KP_RollBox.Text + "\n";
                saveText += "KD_ROLL;" + KD_RollBox.Text + "\n";
                saveText += "KI_ROLL;" + KI_RollBox.Text + "\n";

                saveText += "KP_PITCH;" + KP_PitchBox.Text + "\n";
                saveText += "KD_PITCH;" + KD_PitchBox.Text + "\n";
                saveText += "KI_PITCH;" + KI_PitchBox.Text + "\n";

                saveText += "KP_YAW;" + KP_YawBox.Text + "\n";
                saveText += "KP_YAW;" + KI_YawBox.Text + "\n";

                try
                { 
                    File.WriteAllText ( dialog.FileName, saveText );
                }

                catch ( Exception ex )
                {
                    MessageBox.Show ( ex.Message );
                }
            }
        }

        private void ImportButton_Click ( object sender, EventArgs e )
        {
            OpenFileDialog dialog = new OpenFileDialog ();
            dialog.Filter = "Regulation Value Set|*.set";
            dialog.InitialDirectory = Application.StartupPath;

            var result = dialog.ShowDialog ();

            if (result == DialogResult.OK)
            {
                try
                {
                    string[] lines = System.IO.File.ReadAllLines ( dialog.FileName );

                    KP_RollBox.Text = lines[0].Split ( ';' )[1];
                    KD_RollBox.Text = lines[1].Split ( ';' )[1];
                    KI_RollBox.Text = lines[2].Split ( ';' )[1];

                    KP_PitchBox.Text = lines[3].Split ( ';' )[1];
                    KD_PitchBox.Text = lines[4].Split ( ';' )[1];
                    KI_PitchBox.Text = lines[5].Split ( ';' )[1];

                    KP_YawBox.Text = lines[6].Split ( ';' )[1];
                    KI_YawBox.Text = lines[7].Split ( ';' )[1];
                }

                catch (Exception ex)
                {
                    MessageBox.Show ( ex.Message );
                }
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Running ^= true;
        }
    }
}
