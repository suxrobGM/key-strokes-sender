using Server.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server.Views
{
    public partial class MainForm : Form
    {
        private ServerInstance _server;
        private NotifyIcon _notifyIcon;       

        public MainForm()
        {
            InitializeComponent();           

            _notifyIcon = new NotifyIcon
            {
                Icon = Icon,
                Text = "Server app",
                Visible = true,
                ContextMenu = new ContextMenu(new MenuItem[] 
                                            {
                                                new MenuItem("Exit", (s, e) => { Environment.Exit(0); })
                                            })
            };

            stopBtn.Enabled = false;
            ipAddressInput.Text = "127.0.0.1";
            statusLabel.Text = "";
        }

        private async void startBtn_Click(object sender, EventArgs e)
        {
            IPAddress iPAddress;
            if (ipAddressInput.Text.Trim() == String.Empty || !IPAddress.TryParse(ipAddressInput.Text, out iPAddress))
            {
                MessageBox.Show("Please enter valid ip4 address");
                return;
            }

            _server = new ServerInstance(ipAddressInput.Text);
            startBtn.Enabled = false;
            stopBtn.Enabled = true;

            try
            {
                statusLabel.Text = "Started listenning";
                await _server.StartListeningAsync(_notifyIcon);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }                
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {            
            _server.StopListening();
            startBtn.Enabled = true;
            stopBtn.Enabled = false;
            _notifyIcon.Icon = Icon;
            statusLabel.Text = "Stoped listenning";
        }        
    }
}
