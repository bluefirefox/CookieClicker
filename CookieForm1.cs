using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookieClicker
{
    public partial class CookieForm1 : Form
    {
        private int cookieCurrency;
        private int numCookieWorkers;

        private int cookieWorkerCost = 15;

        public CookieForm1()
        {
            InitializeComponent();
            Start();

        }//end of CookieForm 1

        /*
         * Intiates variables
         */
        public void Start()
        {
            cookieCurrency = 0;
            numCookieWorkers = 0;
            label1.Text = "Cookies: 0";
            labelCookieWorker.Text = "Cookie Workers: 0";
            timer1.Interval = 5000;
            timer1.Start();
        }

        //Every click = to 1 currency
        private void PictureBoxCookie_Click(object sender, EventArgs e)
        {
            AddCookies(1);
            UpdateButtons();
        }

        private void buttonBuyCookieWorker_Click(object sender, EventArgs e)
        {
            
            numCookieWorkers += cookieCurrency / cookieWorkerCost;
            AddCookies(-1 * cookieWorkerCost * (cookieCurrency / 15));
            labelCookieWorker.Text = "Cookie Workers: " + numCookieWorkers;
            UpdateButtons();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            AddCookies( 2 * (numCookieWorkers));

            UpdateButtons();
        }

        private void UpdateButtons()
        {
            buttonBuyCookieWorker.Text = "Buy " + cookieCurrency / cookieWorkerCost;
        }

        private void AddCookies(int num)
        {
            cookieCurrency += num;
            label1.Text = "Cookies: " + cookieCurrency;
        }
    }//end of Class
}//end of namespace
