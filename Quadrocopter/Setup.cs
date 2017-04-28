using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Quadrocopter
{
    public partial class Setup : Form
    {
        public String COMPort;
        public int Baudrate;

        public Setup()
        {
            InitializeComponent();


            PortSelector.Items.AddRange(SerialPort.GetPortNames());

            // TRY READING SETTINGS
            try
            {
                Settings settings = new Settings();
                XmlSerializer xmlSerializer = new XmlSerializer(settings.GetType());
                FileStream readStream = new FileStream("QuadrocopterSettings.xml", FileMode.Open);
                settings = (Settings)xmlSerializer.Deserialize(readStream);
                readStream.Close();


                PortSelector.SelectedItem = PortSelector.Items[PortSelector.FindString(settings.COM)];
                BaudSelector.SelectedItem = BaudSelector.Items[BaudSelector.FindString(settings.BAUD)];

                AutoConnect.Checked = settings.AUTO_CONNECT;
            }

            catch
            {
                MessageBox.Show("ERROR WITH LOADING SETTINGS FILE");
                // STANDARD 

                PortSelector.Items.Add("COM4");
                PortSelector.SelectedItem = PortSelector.Items[PortSelector.FindString("COM4")];
                BaudSelector.SelectedItem = BaudSelector.Items[BaudSelector.FindString("57600")];

                AutoConnect.Checked = false;
            }

            
        }

        private void B_START_Click(object sender, EventArgs e)
        {
            COMPort = PortSelector.SelectedItem.ToString();
            Baudrate = Convert.ToInt32(BaudSelector.SelectedItem);


            // CREATE SETTINGS OBJECT
            Settings settings;
            settings.COM = COMPort;
            settings.BAUD = Baudrate.ToString();
            settings.AUTO_CONNECT = AutoConnect.Checked;

            // SAVE SETTINGS OBJECT
            XmlSerializer writer = new XmlSerializer(settings.GetType());
            StreamWriter file = new StreamWriter("QuadrocopterSettings.xml");
            writer.Serialize(file, settings);
            file.Close();

            DialogResult = DialogResult.OK;
            Close();
        }

        private void Setup_Load(object sender, EventArgs e)
        {
            if (AutoConnect.Checked)
                B_START_Click(this, null);
        }

        public struct Settings
        {
            public String COM;
            public String BAUD;
            public bool AUTO_CONNECT;
        }
    }


}
