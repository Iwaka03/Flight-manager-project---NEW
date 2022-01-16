using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightManager
{
    public partial class HomeView : Form
    {
        public HomeView()
        {
            InitializeComponent();
        }

        private void BackToLoginBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form3 = new UserLogin();
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }

        private void BackToAdminLoginBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form4 = new Form2();
            form4.Closed += (s, args) => this.Close();
            form4.Show();
        }

        private void ContactsBtn_Click(object sender, EventArgs e)
        {
            //при натискане да се показват контактите, не съм го направил защото не знам какви контакти да сложа
        }

        private void BookNowBtn_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.skyscanner.net/");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.booking.com/index.bg.html?aid=376395;label=bookings-naam-wTAMuVFMLzQvu3zrKRSSDAS438019761960:pl:ta:p1:p22,563,000:ac:ap:neg:fi:tikwd-65526620:lp9040120:li:dec:dm:ppccp=UmFuZG9tSVYkc2RlIyh9Ya9nxjGDNbW5UggBp-p-5hQ;ws=&gclid=Cj0KCQiAoY-PBhCNARIsABcz773PAyRH-V7Xpx55aMRE4XNltz3Fv34jOF_hj1vwZM8OxAO8wDsu-mkaAoEFEALw_wcB");
        }
    }
}
