using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsChatClient
{
    public partial class Form1 : Form
    {
        //TcpClient tcpClient = new TcpClient();
        //NetworkStream networkStream = default(NetworkStream);
        //string readData = null;
        delegate void UpdateTextBoxDelegate(string value);
        public Form1()
        {
            InitializeComponent();

            //if (this.InvokeRequired)
            //    this.Invoke(new MethodInvoker(StartServer));

            //new Thread(StartServer).Start();

            
        }



        private void buttonSendToServer_Click(object sender, EventArgs e)
        {
            ConnectAndSend(textBoxConnectIP.Text,int.Parse(textBoxPort.Text),textBoxMsg.Text); 
        }

        private void ConnectAndSend(string server,int port, string message)
        {
            try
            {
                // Create a TcpClient.
                // Note, for this client to work you need to have a TcpServer
                // connected to the same address as specified by the server, port
                // combination.
                //Int32 port = 13000;
                TcpClient client = new TcpClient(server, port);
               
                // Translate the passed message into ASCII and store it as a Byte array.
                Byte[] data = System.Text.Encoding.ASCII.GetBytes(message);

                // Get a client stream for reading and writing.
                //  Stream stream = client.GetStream();

                NetworkStream stream = client.GetStream();

                // Send the message to the connected TcpServer.
                stream.Write(data, 0, data.Length);

                Console.WriteLine("Sent: {0}", message);

                // Receive the TcpServer.response.

                // Buffer to store the response bytes.
                //data = new Byte[256];

                //// String to store the response ASCII representation.
                string responseData = String.Empty;

                //// Read the first batch of the TcpServer response bytes.
                int bytes = stream.Read(data, 0, data.Length);
                responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
                Console.WriteLine("Received: {0}", responseData);

                // Close everything.
                stream.Close();
                client.Close();
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("ArgumentNullException: {0}", e);
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }

            Console.WriteLine("\n message sent");
            //Console.Read();
        }

        public void StartServer()
        {
            TcpListener server = null;
            try
            {
                // Set the TcpListener to a port.
                Int32 port = int.Parse(textBoxPort.Text);
                IPAddress localAddr = IPAddress.Parse(textBoxIP.Text);

                // TcpListener server = new TcpListener(port);
                server = new TcpListener(localAddr, port);

                // Start listening for client requests.
                server.Start();

                // Buffer for reading data
                Byte[] bytes = new Byte[256];
                String data = null;

                // Enter the listening loop.
                while (true)
                {
                    Console.Write("Waiting for a connection... ");

                    // Perform a blocking call to accept requests.
                    // You could also use server.AcceptSocket() here.
                    TcpClient client = server.AcceptTcpClient();
                    Console.WriteLine("Connected!");
                    //client.Client.RemoteEndPoint; remote ip - ip and port of connected client
                    data = null;

                    // Get a stream object for reading and writing
                    NetworkStream stream = client.GetStream();
                    
                    int i;

                    // Loop to receive all the data sent by the client.
                    while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                    {
                        // Translate data bytes to a ASCII string.
                        data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                        Console.WriteLine("Received: {0}", data);

                        // Process the data sent by the client.
                        data = data.ToUpper();

                        byte[] msg = System.Text.Encoding.ASCII.GetBytes(data);

                        // Send back a response.
                        stream.Write(msg, 0, msg.Length);
                        Console.WriteLine("Sent: {0}", data);
                    }
                    UpdateChatWindow(DateTime.Now.ToString());
                    //different thread
                    //textBoxChatWindow.Invoke((Action)delegate
                    //{
                    //    textBoxChatWindow.Text = "data";
                    //}
                    //);

                    // Shutdown and end connection
                    client.Close();
                }
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }
            finally
            {
                // Stop listening for new clients.
                server.Stop();
            }

            Console.WriteLine("\nHit enter to continue...");
            Console.Read();
        }

        private void UpdateChatWindow(string value)
        {
            //if (this.InvokeRequired)
            //    this.Invoke(new MethodInvoker(UpdateChatWindow));
            //else
            //    textBoxChatWindow.Text = textBoxChatWindow.Text + Environment.NewLine + " >> " + "bolle";

            //if (InvokeRequired)
            //{
            //    this.Invoke((MethodInvoker)delegate () { UpdateChatWindow(value); });
            //    return;
            //}
            //textBoxChatWindow.Text = value;


            //if (InvokeRequired)
            //{
            //    this.Invoke(new Action<string>(UpdateChatWindow), new object[] { value });
            //    return;
            //}
            //textBoxChatWindow.Text += value;

            //if (this.textBoxChatWindow.InvokeRequired)
            //    this.textBoxChatWindow.Invoke(new UpdateTextBox(UpdateChatWindow), new object[] { value });
            //else
            //    this.textBoxChatWindow.Text = value;

            if (InvokeRequired)
            {
                this.Invoke(new UpdateTextBoxDelegate(UpdateChatWindow), value);
                return;
            }

            this.textBoxChatWindow.Text = value;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            //Why we use invoke in C#?
            //Calling Invoke helps us because it allows a background thread to "do stuff" on a UI thread -it works because 
            //    it doesn't directly call the method, rather it sends a Windows message that says "run this when you get the chance to".

            //if (this.InvokeRequired)
            //    this.Invoke(new MethodInvoker(StartServer));

            Thread t = new Thread(new ThreadStart(StartServer));
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            while (t.IsAlive)
            {
                Application.DoEvents();
            }
        }
    }
}
