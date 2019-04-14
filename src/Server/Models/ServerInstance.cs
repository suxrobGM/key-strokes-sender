using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsInput;
using WindowsInput.Native;

namespace Server.Models
{
    public class ServerInstance
    {
        private TcpListener _listener;
        private IPAddress _iPAddress;
        private InputSimulator _simulator;
        private int _port;

        public ServerInstance(string ipAddress, int port = 2000)
        {
            _iPAddress = IPAddress.Parse(ipAddress);
            _port = port;
            _simulator = new InputSimulator();
        }

        public async Task StartListeningAsync(NotifyIcon notifyIcon)
        {
            try
            {
                _listener = new TcpListener(_iPAddress, _port);

                _listener.Start();
                byte[] data = new byte[64]; // buffer

                while (true)
                {
                    var client = await _listener.AcceptTcpClientAsync();
                    var stream = client.GetStream();

                    var builder = new StringBuilder();
                    int bytes = 0;
                    do
                    {
                        bytes = await stream.ReadAsync(data, 0, data.Length);
                        builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
                    } while (stream.DataAvailable);

                    string message = builder.ToString();

                    //if (message.Trim() != String.Empty)
                    //    MessageBox.Show(message);

                    HandleKeys(message, notifyIcon);
                }
            }
            catch(ObjectDisposedException)
            {
                throw new ObjectDisposedException("TcpListner _listener", "Connection has closed, please press \'Start\' button for restart listenning");
            }
            finally
            {
                StopListening();
            }
        }

        public void StopListening()
        {
            if (_listener != null)
            {
                _listener.Stop();
                _listener = null;
            }            
        }

        private void HandleKeys(string command, NotifyIcon notifyIcon)
        {
            if (command == "0")
            {
                // {Win}e
                _simulator.Keyboard.ModifiedKeyStroke(VirtualKeyCode.LWIN, VirtualKeyCode.VK_E);            
                notifyIcon.Icon = DrawIcon("0");               
            }
            else if (command == "1")
            {
                // {Win}r
                _simulator.Keyboard.ModifiedKeyStroke(VirtualKeyCode.LWIN, VirtualKeyCode.VK_R);                
                notifyIcon.Icon = DrawIcon("1");
            }
            else if (command == "2")
            {                              
                SendKeys.SendWait("n{ENTER}");
                notifyIcon.Icon = DrawIcon("2");
            }
            else if (command == "3")
            {                               
                SendKeys.SendWait("s{ENTER}");
                notifyIcon.Icon = DrawIcon("3");
            }
            else if (command == "4")
            {                                
                SendKeys.SendWait("W{ENTER}");
                notifyIcon.Icon = DrawIcon("4");
            }
            else if (command == "5")
            {                            
                SendKeys.SendWait("{F4}^A^C");
                notifyIcon.Icon = DrawIcon("5");
            }
            else if (command == "6")
            {                           
                SendKeys.SendWait("^%{TAB}{TAB}");
                notifyIcon.Icon = DrawIcon("6");
            }
            else if (command == "7")
            {                               
                SendKeys.SendWait("^A");
                notifyIcon.Icon = DrawIcon("7");
            }
            else if (command == "8")
            {                          
                SendKeys.SendWait("^C");
                notifyIcon.Icon = DrawIcon("8");
            }
            else if (command == "9")
            {
                SendKeys.SendWait("^v");
                notifyIcon.Icon = DrawIcon("9");               
            }
            else if (command == "10")
            {
                SendKeys.SendWait("^+n");
                notifyIcon.Icon = DrawIcon("10");                
            }
            else if (command == "11")
            {
                SendKeys.SendWait("{ENTER}");
                notifyIcon.Icon = DrawIcon("11");               
            }
            else if (command == "12")
            {
                SendKeys.SendWait("{BACKSPACE}");
                notifyIcon.Icon = DrawIcon("12");               
            }
            else if (command == "13")
            {
                SendKeys.SendWait("{CAPSLOCK}");
                notifyIcon.Icon = DrawIcon("13");                
            }
            else if (command == "14")
            {
                SendKeys.SendWait("{TAB}");
                notifyIcon.Icon = DrawIcon("14");                
            }
            else if (command == "15")
            {
                SendKeys.SendWait("+");
                notifyIcon.Icon = DrawIcon("15");               
            }
            else if (command == "16")
            {
                // {Win}
                _simulator.Keyboard.KeyPress(VirtualKeyCode.LWIN);
                notifyIcon.Icon = DrawIcon("16");                
            }
            else if (command == "17")
            {
                SendKeys.SendWait("%");
                notifyIcon.Icon = DrawIcon("17");     
            }
            else if (command == "18")
            {
                SendKeys.SendWait(" ");
                notifyIcon.Icon = DrawIcon("18");               
            }
            else if (command == "19")
            {
                SendKeys.SendWait("{LEFT}");
                notifyIcon.Icon = DrawIcon("19");                
            }
            else if (command == "20")
            {
                SendKeys.SendWait("{RIGHT}");
                notifyIcon.Icon = DrawIcon("20");               
            }
            else if (command == "21")
            {
                SendKeys.SendWait("{PGDN}");
                notifyIcon.Icon = DrawIcon("21");                
            }
            else if (command == "22")
            {
                SendKeys.SendWait("{PGUP}");
                notifyIcon.Icon = DrawIcon("22");                
            }
            else if (command == "23")
            {
                SendKeys.SendWait("{DELETE}");
                notifyIcon.Icon = DrawIcon("23");               
            }
            else if (command == "24")
            {
                SendKeys.SendWait("{INSERT} ");
                notifyIcon.Icon = DrawIcon("24");               
            }
            else if (command == "25")
            {
                SendKeys.SendWait("{PRTSC}");
                notifyIcon.Icon = DrawIcon("25");                
            }
            else if (command == "26")
            {
                SendKeys.SendWait("%{PRTSC}");
                notifyIcon.Icon = DrawIcon("26");                
            }
            else if (command == "27")
            {
                SendKeys.SendWait("^{HOME}");
                notifyIcon.Icon = DrawIcon("27");                
            }
            else if (command == "28")
            {
                SendKeys.SendWait("^{END}");
                notifyIcon.Icon = DrawIcon("28");                
            }
            else if (command == "29")
            {
                SendKeys.SendWait("{END}");
                notifyIcon.Icon = DrawIcon("29");                
            }
            else if (command == "30")
            {
                SendKeys.SendWait("{END}");
                notifyIcon.Icon = DrawIcon("30");                
            }
            else if (command == "31")
            {
                SendKeys.SendWait("+{HOME}");
                notifyIcon.Icon = DrawIcon("31");                
            }
            else if (command == "32")
            {
                SendKeys.SendWait("+{END}");
                notifyIcon.Icon = DrawIcon("32");                
            }
            else if (command == "33")
            {
                SendKeys.SendWait("^+{HOME}");
                notifyIcon.Icon = DrawIcon("33");                
            }
            else if (command == "34")
            {
                SendKeys.SendWait("^+{END}");
                notifyIcon.Icon = DrawIcon("34");                
            }
            else if (command == "35")
            {
                SendKeys.SendWait("^+{LEFT}");
                notifyIcon.Icon = DrawIcon("35");                
            }
            else if (command == "36")
            {
                SendKeys.SendWait("^+{RIGHT}");
                notifyIcon.Icon = DrawIcon("36");                
            }
            else if (command == "37")
            {
                SendKeys.SendWait("^o");
                notifyIcon.Icon = DrawIcon("37");               
            }
            else if (command == "38")
            {
                SendKeys.SendWait("^s");
                notifyIcon.Icon = DrawIcon("38");                
            }
            else if (command == "39")
            {
                SendKeys.SendWait("%{F4}");
                notifyIcon.Icon = DrawIcon("39");               
            }
            else if (command == "40")
            {
                SendKeys.SendWait("% x");
                notifyIcon.Icon = DrawIcon("40");                
            }
            else if (command == "41")
            {
                // {Win}++
                var addBtnList = new List<VirtualKeyCode>()
                {
                    VirtualKeyCode.ADD,
                    VirtualKeyCode.ADD
                };
                _simulator.Keyboard.ModifiedKeyStroke(VirtualKeyCode.LWIN, addBtnList);            
                notifyIcon.Icon = DrawIcon("41");               
            }
            else if (command == "42")
            {
                // {Win}--
                var subtarctBtnList = new List<VirtualKeyCode>()
                {
                    VirtualKeyCode.SUBTRACT,
                    VirtualKeyCode.SUBTRACT
                };
                _simulator.Keyboard.ModifiedKeyStroke(VirtualKeyCode.LWIN, subtarctBtnList);
                notifyIcon.Icon = DrawIcon("42");              
            }
            else if (command == "43")
            {
                // {Win}{ESC}
                _simulator.Keyboard.ModifiedKeyStroke(VirtualKeyCode.LWIN, VirtualKeyCode.ESCAPE);                
                notifyIcon.Icon = DrawIcon("43");               
            }
            else if (command == "44")
            {
                // {Win}d
                _simulator.Keyboard.ModifiedKeyStroke(VirtualKeyCode.LWIN, VirtualKeyCode.VK_D);               
                notifyIcon.Icon = DrawIcon("44");                
            }
            else if (command == "45")
            {
                SendKeys.SendWait("^++++++++");
                notifyIcon.Icon = DrawIcon("45");                
            }
            else if (command == "46")
            {
                SendKeys.SendWait("^L");
                notifyIcon.Icon = DrawIcon("46");                
            }
            else if (command == "47")
            {
                SendKeys.SendWait("{F12}");
                notifyIcon.Icon = DrawIcon("47");                
            }
            else if (command == "48")
            {
                SendKeys.SendWait("^j");
                notifyIcon.Icon = DrawIcon("48");                
            }
            else if (command == "49")
            {
                SendKeys.SendWait("^f");
                notifyIcon.Icon = DrawIcon("49");                
            }
            else if (command == "50")
            {
                SendKeys.SendWait("^u");
                notifyIcon.Icon = DrawIcon("50");                
            }
            else if (command == "51")
            {
                SendKeys.SendWait("^t");
                notifyIcon.Icon = DrawIcon("51");                
            }
            else if (command == "52")
            {
                SendKeys.SendWait("^n");
                notifyIcon.Icon = DrawIcon("52");                
            }
            else if (command == "53")
            {
                SendKeys.SendWait("{F5}");
                notifyIcon.Icon = DrawIcon("53");               
            }
            else if (command == "54")
            {
                SendKeys.SendWait("{F9}");
                notifyIcon.Icon = DrawIcon("54");                
            }
            else if (command == "55")
            {
                SendKeys.SendWait("%{HOME}");
                notifyIcon.Icon = DrawIcon("55");                
            }
            else if (command == "56")
            {
                SendKeys.SendWait("%{LEFT}");
                notifyIcon.Icon = DrawIcon("56");                
            }
            else if (command == "57")
            {                
                SendKeys.SendWait("%{RIGHT}");
				notifyIcon.Icon = DrawIcon("57");
            }
            else
            {
                SendKeys.SendWait(command);
            }
        }

        private Icon DrawIcon(string digit)
        {
            var bmp = new Bitmap("Icons\\Mask.bmp");
            //bmp.MakeTransparent();
            using (var graphics = Graphics.FromImage(bmp))
            {
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                var font = new Font("Arial", 7);
                var brush = new SolidBrush(Color.Black);
                var point = new PointF(-5, 0);
                graphics.DrawString(digit, font, brush, point);

                //var pen = new Pen(brush);
                //graphics.DrawEllipse(pen, 10, 10, 15, 15);
                graphics.Save();               
            }
            bmp.Save("LastCommand.bmp");
            return Icon.FromHandle(bmp.GetHicon());
        }
    }
}
