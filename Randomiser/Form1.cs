using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Randomiser
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void close_button(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimize_button(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void randomize_button(object sender, EventArgs e)
        {
            if (ChoicesInputBox.Text.Length == 0)
            {
                MessageBox.Show(text: "Input text cannot be empty.", caption: "Randomiser", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Exclamation);
            } else
            {
                (string choice, int words) = randomChoice(ChoicesInputBox.Text);
                string text = "Randomized Data " +
                    $"\n\nTotal words: {words}" +
                    $"\nRandom choice: {choice}";
                MessageBox.Show(text: text, caption: "Randomiser", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.None);
            }
        }

        private (string, int) randomChoice(string text)
        {
            string[] data = text.Split(" ");
            Random rand = new Random();
            int index = rand.Next(data.Length);
            return (data[index], data.Length);
        }

        private void about_button(object sender, EventArgs e)
        {
            string text = "Randomiser Windows" +
                "\nRandomiser is a program which choose a random word from your provided ones.\n" +
                "\nVersion: v1.0" +
                "\nSupported OS: Windows" +
                "\nSource Code: github.com/anonyindian/Randomiser" +
                "\n\nNote: You must separate all the choices with a white space.";
            MessageBox.Show(text: text, caption: "About Randomiser", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
        }

        private void srclinkclick(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://github.com/anonyindian/Randomiser";
            
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                Process.Start(new ProcessStartInfo("cmd", $"/c start {url}"));
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                Process.Start("xdg-open", url);
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                Process.Start("open", url);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void control_bar(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
