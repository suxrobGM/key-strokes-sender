using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.Models;

namespace Client.Views
{
    public partial class MainForm : Form
    {
        private ClientInstance _client;
        private bool _usedTimer;
        private bool _asynchronouslySend;

        public MainForm()
        {
            InitializeComponent();
            ipAddressInput.Text = "127.0.0.1";
            sendStatusLabel.Text = "";
            echoTimer.Interval = 1000; // 1 sec

            intervalTimer.Tick += async (s, e) => 
            {
                await _client.SendMessageAsync(sendInput.Text);
                sendStatusLabel.Text = $"Sent command \'{sendInput.Text}\' during {intervalTimer.Interval} ms";
            };

            echoTimer.Tick += async (s, e) =>
            {
                await ProccessAsync();
                echoTimer.Stop();
            };
        }

        private void timeIntervalChB_CheckedChanged(object sender, EventArgs e)
        {
            _usedTimer = timeIntervalChB.Checked;
            timeIntervalInput.Enabled = _usedTimer;

            if (intervalTimer.Enabled && !_usedTimer)
            {
                intervalTimer.Stop();
                sendStatusLabel.Text = "";
            }
        }

        private void asynchronouslySendChB_CheckedChanged(object sender, EventArgs e)
        {
            _asynchronouslySend = asynchronouslySendChB.Checked;
        }

        private void sendInput_TextChanged(object sender, EventArgs e)
        {
            if (_asynchronouslySend)
            {
                echoTimer.Start();
            }
        }

        private async void sendBtn_Click(object sender, EventArgs e)
        {
            await ProccessAsync();
        }      

        private async void sendInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                await ProccessAsync();
            }
        }

        private async Task ProccessAsync()
        {
            IPAddress iPAddress;
            if (ipAddressInput.Text == String.Empty || !IPAddress.TryParse(ipAddressInput.Text, out iPAddress))
            {
                if (echoTimer.Enabled)
                    echoTimer.Stop();

                MessageBox.Show("Please enter valid server ip4 address");
                return;
            }            

            _client = new ClientInstance(ipAddressInput.Text, 2000);

            try
            {
                if (_usedTimer)
                {
                    intervalTimer.Interval = Int32.Parse(timeIntervalInput.Text);
                    intervalTimer.Start();
                }
                else
                {
                    await _client.SendMessageAsync(sendInput.Text);
                    sendStatusLabel.Text = $"Sent command \'{sendInput.Text}\' during 0 ms";
                }

                sendInput.Text = "";
            }
            catch (Exception ex)
            {
                if (echoTimer.Enabled)              
                    echoTimer.Stop();
                
                MessageBox.Show(ex.Message);               
            }
        }                
    }
}
