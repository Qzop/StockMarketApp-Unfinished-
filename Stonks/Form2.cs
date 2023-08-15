using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YahooFinanceApi;

namespace Stonks
{
    public partial class Recommended : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Recommended()
        {
            InitializeComponent();
            getRecommended();
        }

        private void getRecommended()
        {
            
        }
        private void exitbtn_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void homebtn_Click(object sender, EventArgs eventArgs)
        {
            this.Hide();
            Home home = new Home();
            home.StartPosition = FormStartPosition.Manual;
            home.Size = this.Size;
            home.Location = this.Location;
            home.ShowDialog();
            home.Show();

        }

        private void onHoverEnter_Exitbtn(object sender, EventArgs e)
        {
            newexitbtn.BackColor = Color.IndianRed;
        }

        private void onHoverExit_Exitbtn(object sender, EventArgs e)
        {
            newexitbtn.BackColor = SystemColors.ButtonFace;
        }

        private void onMinimize(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void moveApplication(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        public async Task<int> getData(string symbol, DateTime startDate, DateTime endDate)
        {
            try
            {
                var data = await Yahoo.GetHistoricalAsync(symbol, startDate, endDate);
                var tick = await Yahoo.Symbols(symbol).Fields(Field.LongName).QueryAsync();
                var ticker = tick[symbol];
                var companyName = ticker[Field.LongName];

                datalabel.Text = companyName + " " + data.ElementAt(0).DateTime.Month + "/" + data.ElementAt(0).DateTime.Day + "/" + data.ElementAt(0).DateTime.Year + " $" + Math.Round(data.ElementAt(0).Close, 2);
                datalabel.ForeColor = Color.Red;
                datalabel.Size = new Size(1000, 15);
                datalabel.Location = new Point(268, 149);
            }
            catch
            {
                datalabel.Text = "Unknown symbol: " + symbol;
                datalabel.ForeColor = Color.Red;
                datalabel.Size = new Size(300, 15);
                datalabel.Location = new Point(268, 149);
            }

            return 1;
        }
    }
}
