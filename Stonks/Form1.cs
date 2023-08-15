using System;
using System.Collections;
using YahooFinanceApi;
using System.Runtime.InteropServices;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Linq.Expressions;

namespace Stonks
{
    public partial class Home : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Home()
        {
            InitializeComponent();
        }

        // Event handler for search button click
        private async void searchbtn_Click(object sender, System.EventArgs e)
        {
            errmsg.Text = "";

            if (searchbox.Text.Length > 0)
            {
                var name = searchbox.Text;

                string url = "https://finance.yahoo.com/_finance_doubledown/api/resource/searchassist;searchTerm=" + name + "?device=console&returnMeta=true";
                HttpClient client = new HttpClient();
                string response = await client.GetStringAsync(url);

                string substr = response.Substring(150, 10);
                string[] symbol = substr.Split('"');

                int timespan = 1;
                DateTime endDate = DateTime.Today;
                DateTime startDate = DateTime.Today.AddMonths(-timespan);
                var awaiter = getData(symbol[0].ToUpper(), startDate, endDate);
            }
            else
            {
                errmsg.Text = "Please enter a company name.";
                errmsg.ForeColor = Color.Red;
                errmsg.Size = new Size(300, 15);
                errmsg.Location = new Point(295, 65);
            }
        }

        // Exits out of the application
        private void exitbtn_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void moveApplication(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
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

        private void reccommended_OnClick(object sender, EventArgs e)
        {
            this.Hide();
            Recommended form = new Recommended();
            form.StartPosition = FormStartPosition.Manual;
            form.Location = this.Location;
            form.Size = this.Size;
            form.ShowDialog();
            form.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public async Task<int> getData(string symbol, DateTime startDate, DateTime endDate)
        {
            try
            {
                var data = await Yahoo.GetHistoricalAsync(symbol, startDate, endDate);
                var tick = await Yahoo.Symbols(symbol).Fields(Field.LongName).QueryAsync();
                var ticker = tick[symbol];
                var companyName = ticker[Field.LongName];

                datalabel.Text = companyName + " " + data.ElementAt(19).DateTime.Month + "/" + data.ElementAt(22).DateTime.Day + "/" + data.ElementAt(22).DateTime.Year + " $" + Math.Round(data.ElementAt(22).Close, 2);
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