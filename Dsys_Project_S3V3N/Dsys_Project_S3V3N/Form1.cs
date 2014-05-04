using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dsys_Project_S3V3N
{
    public partial class Form1 : Form
    {
        private string text;
        private int size;
        
        private  TcpClient tcpclnt;
        private  NetworkStream stm;
        private string _originalFile;
        private string _changesFile;
        private string _textFile;
        private StreamWriter _stream;

        public Form1()
        {
            InitializeComponent();

            IPHostEntry host;
            string localIP = "";
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    localIP = ip.ToString();
                    ipSelectList_HOST.Items.Add(localIP);
                }
            }

            ipSelectList_HOST.SelectedIndex = 0;
        }

        private void hostButton_Click(object sender, EventArgs e)
        {
            if (newRadioButton.Checked)
            {
                text = "";
            }
            else
            {
                // Show the dialog and get result.
                openFileDialog1.Filter = "Text files (*.txt)|*.txt";
                openFileDialog1.Multiselect = false;
                openFileDialog1.FileName = "";

                DialogResult result = openFileDialog1.ShowDialog();
                if (result == DialogResult.OK) // Test result.
                {
                    string file = openFileDialog1.FileName;
                    try
                    {
                        text = File.ReadAllText(file);
                        size = text.Length;
                    }
                    catch (IOException)
                    {
                        Console.WriteLine("Exception occured in reading text from file.");
                        text = "";
                    }

                    Console.WriteLine(size); // <-- Shows file size in debugging mode.
                    Console.WriteLine(result); // <-- For debugging use.
                }
                else
                    return;
            }

            // Go to the next FORM
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            if (ipAddress_CONNECT.TextLength > 0)
            {
                tcpclnt = new TcpClient();
                try
                {
                    tcpclnt.Connect(ipAddress_CONNECT.Text, 20130);
                    stm = tcpclnt.GetStream();

                    ASCIIEncoding asen = new ASCIIEncoding();
                    byte[] ba = asen.GetBytes("0");
                    Console.WriteLine("Transmitting.....");
                    stm.Write(ba, 0, ba.Length);


                    byte[] bb11 = new byte[10];
                    stm.Read(bb11, 0, 10);
                    string l1 = System.Text.Encoding.Default.GetString(bb11);
                    int l11 = int.Parse(l1);

                    byte[] bb22 = new byte[10];
                    stm.Read(bb22, 0, 10);
                    string l2 = System.Text.Encoding.Default.GetString(bb22);
                    int l22 = int.Parse(l2);

                    byte[] bb33 = new byte[10];
                    stm.Read(bb33, 0, 10);
                    string l3 = System.Text.Encoding.Default.GetString(bb33);
                    int l33 = int.Parse(l3);


                    byte[] bb1 = new byte[l11];
                    stm.Read(bb1, 0, l11);
                    string temp1 = System.Text.Encoding.Default.GetString(bb1);
                    //for (int i = 0; i < k; i++)
                    Console.Write("client : " + temp1);

                    byte[] bb2 = new byte[l22];
                    int k2 = stm.Read(bb2, 0, l22);
                    string temp2 = System.Text.Encoding.Default.GetString(bb2);
                    //for (int i = 0; i < k; i++)
                    Console.Write("client : " + temp2);

                    byte[] bb3 = new byte[l33];
                    int k3 = stm.Read(bb3, 0, l33);
                    string temp3 = System.Text.Encoding.Default.GetString(bb3);
                    //for (int i = 0; i < k; i++)
                    Console.Write("client : " + temp3);

                    long tmp = System.DateTime.Now.Ticks % 10000;
                    _originalFile = "original" + tmp + ".txt";
                    _changesFile = "changes" + tmp + ".txt";
                    _textFile = "text" + tmp + ".txt";

                    _stream = new StreamWriter(_originalFile);

                    _stream.Write(temp1);
                    _stream.Close();

                    _stream = new StreamWriter(_changesFile);
                    _stream.Write(temp2);
                    _stream.Close();

                    _stream = new StreamWriter(_textFile);
                    _stream.Write(temp3);
                    _stream.Close();
                }
                catch (SocketException)
                {
                    MessageBox.Show("Unable to connect to Host !!!");
                }

            }
        }
    }
}
