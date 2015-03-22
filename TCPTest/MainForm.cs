/*
 * Created by SharpDevelop.
 * User: XiaoSanya
 * Date: 2015/3/22
 * Time: 19:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Text;

namespace TCPTest
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		private Socket ServerSocket;
		private Hashtable AllClients;
		private bool isServer;
		private delegate void SetTextCB(string text);
		private const int MAXCLIENTS = 10;
		private const int RECEIVEBUFFERSIZE = 256;
		bool isLog;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			AllClients = new Hashtable();
			isServer =false;
			isLog = true;
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void CheckBoxTopMostCheckedChanged(object sender, EventArgs e)
		{
			this.TopMost = checkBoxTopMost.Checked;
		}
		
		void CheckBoxLogCheckedChanged(object sender, EventArgs e)
		{
			isLog = checkBoxLog.Checked;
		}
		
		public bool GetLocalIP()
        {
            try
            {
                string HostName = Dns.GetHostName();
                IPHostEntry IpEntry = Dns.GetHostEntry(HostName);
                for (int i = 0; i < IpEntry.AddressList.Length; i++)
                {
                    if (IpEntry.AddressList[i].AddressFamily == AddressFamily.InterNetwork)
                    {
                    	comboBoxIP.Items.Add(IpEntry.AddressList[i].ToString());
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
		
		void MainFormLoad(object sender, EventArgs e)
		{
			if(!GetLocalIP()){
				StatusLabelInfo.Text = "Get IP Failed.";
				return;}
			comboBoxIP.SelectedIndex = 0;
		}
		
		/// <summary>
		/// Start Server click button
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void ButtonStartClick(object sender, EventArgs e)
		{
			string ipstr = comboBoxIP.Text;
			string portstr = textBoxPort.Text;
			if((ipstr.Length ==0) ||(portstr.Length ==0))
			{
				StatusLabelInfo.Text = "Please input IP and Port.";
				return;
			}
			try{
				
				int port = int.Parse(textBoxPort.Text);
				StartServer(ipstr, port);
			}
			catch{
				StatusLabelInfo.Text = "Start TCP server falied.";
				return;
			}
			isServer = true;
			buttonStart.Enabled = false;
			buttonStop.Enabled = true;
			labellink.Text = "linked";
			SetText("TCP Server start.");
		}
		
		private void StartServer(string ip, int port)
		{
			ServerSocket = new Socket(SocketType.Stream,ProtocolType.Tcp);
			IPAddress ipa = IPAddress.Parse(ip);
			IPEndPoint ipe= new IPEndPoint(ipa,port);
			ServerSocket.Bind(ipe);
			ServerSocket.Listen(MAXCLIENTS);
			Thread lj = new Thread(new ThreadStart(WaitForConnect));
			lj.IsBackground = true;
			lj.Start();
		}
		
		private void WaitForConnect()
		{
			while(isServer)
			{
				Thread.Sleep(10);
				try{
					Socket client = ServerSocket.Accept();
					object oj = client;
					Thread ml = new Thread(new ParameterizedThreadStart(ReceiveLoop));
					ml.IsBackground = true;
					ml.Start(oj);
				}
				catch{
					if(ServerSocket != null)
						ServerSocket.Close();
					isServer = false;
				}
			}
		}
		/// <summary>
		/// Message Loop
		/// </summary>
		/// <param name="cl"></param>
		private void ReceiveLoop(object cl)
		{
			Socket client = cl as Socket;
			if(client == null)
				return;
			string clientName = client.RemoteEndPoint.ToString();
			AllClients.Add(clientName,client);
			SetText(clientName +" is connected.");
			byte[] rbytes = new byte[RECEIVEBUFFERSIZE];
			int count;
			while(true)
			{
				count =0;
				try{
					count = client.Receive(rbytes);
					if(count>0)
					{
						string restr = Encoding.Default.GetString(rbytes);
						SetText(clientName + " received: "+ restr);
						byte[] sbytes = rbytes;
						client.Send(sbytes, sbytes.Length, SocketFlags.None);
						string sestr = Encoding.Default.GetString(sbytes);
						SetText(clientName + " send: "+ sestr);
					}
				}
				catch{
					break;
				}
			}
			AllClients.Remove(clientName);
			SetText(clientName +" is disconnected.");
		}
		
		/// <summary>
		/// Stop the Server
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void ButtonStopClick(object sender, EventArgs e)
		{
			if(isServer)
			{
				ServerSocket.Close();
				isServer = false;
				buttonStart.Enabled = true;
				buttonStop.Enabled = false;
				labellink.Text = "unlink";
				SetText("TCP Server stop.");
			}
		}
		
		void SetText(string msg)
		{
			if(isLog)
			{
				if(textBoxReceive.InvokeRequired)
				{
					SetTextCB st = new SetTextCB(SetText);
					this.Invoke(st,new object[]{msg});
				}
				else{
					textBoxReceive.AppendText(msg+"\n");
				}
			}
		}
	}
}
