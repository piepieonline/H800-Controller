using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using USBHIDDRIVER;

using System.Runtime.InteropServices;

namespace H800_Controls
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll", SetLastError = true)]
        static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);
        public const int KEYEVENTF_EXTENDEDKEY = 0x0001;    //Key down flag
        public const int KEYEVENTF_KEYUP = 0x0002;          //Key up flag

        public Form1()
        {
            InitializeComponent();
        }

        //Logitech H800
        private USBHIDDRIVER.USBInterface usb = new USBInterface("vid_046d", "pid_0a29");

        //Key Dict
        private Dictionary<string, byte> keyMapping = new Dictionary<string, byte>();

        //Settings control
        private bool settingsMode;

        /* Known Keys:
         *      Song Down: 120
         *      Song Up: 140
         *      Play: 110
         *      Volume Up: 101
         *      Volume Down: 102
         */

        String usbOut= "";

        private void Form1_Load(object sender, EventArgs e)
        {
            keyMapping["101"] = 0xAF;//"VOLUME_UP"
            keyMapping["102"] = 0xAE;//"VOLUME_DOWN"
            keyMapping["110"] = 0xB3;//"MEDIA_PLAY_PAUSE"
            keyMapping["120"] = 0xB0;//"MEDIA_NEXT"
            keyMapping["140"] = 0xB1;//"MEDIA_PREVIOUS"
            
            if (usb.Connect())
                updateConnectionStatus(true);
            else
                updateConnectionStatus(false);

            usb.write( new byte[] { 0 } );

            usb.enableUsbBufferEvent(new System.EventHandler(headsetEventCatcher));
            usb.startRead();

            this.Show();

            while( true )
            {
                Application.DoEvents();
                if (usbOut != "" && usbOut.Length == 3)
                {
                    if (keyMapping.ContainsKey(usbOut))
                    {
                        if (settingsMode)
                        {
                            //pressedLabel.Text = usbOut;
                            currentAssignmentText.Text = keyMapping[usbOut].ToString();
                        }
                        else
                        {
                            //SendKeys.Send("{" + keyMapping[usbOut] + "}");
                            keybd_event(keyMapping[usbOut], 0, KEYEVENTF_EXTENDEDKEY, 0);
                            keybd_event(keyMapping[usbOut], 0, KEYEVENTF_KEYUP, 0);
                        }
                    }
                    usbOut = "";
                }
                System.Threading.Thread.Sleep(100);
            }
        }

        private void headsetEventCatcher(object sender, EventArgs e)
        {
            USBHIDDRIVER.List.ListWithEvent a = USBHIDDRIVER.USBInterface.usbBuffer;

            byte[] eve = (byte[])USBHIDDRIVER.USBInterface.usbBuffer[0];
            USBHIDDRIVER.USBInterface.usbBuffer.RemoveAt(0);

            usbOut = "";
            foreach( byte v in eve )
                usbOut += v;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;

            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
        }

        private void openStatusWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trayIcon.Dispose();
            Environment.Exit(0);
        }

        private void updateConnectionStatus( bool connected )
        {
            String outText = "";
            if (connected)
                outText = "Connected";
            else
                outText = "Disconnected";

            statusLabel.Text = outText;
            statusMenuItem.Text = outText;
        }

        private void settingsModeChk_CheckedChanged(object sender, EventArgs e)
        {
            settingsMode = settingsModeChk.Checked;
        }
    }
}
