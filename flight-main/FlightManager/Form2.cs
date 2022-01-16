using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightManager
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (true) //проверка дали данните съвпадат
            //{
                this.Hide();
                var form2 = new HomeView();
                form2.Closed += (s, args) => this.Close();
                form2.Show();
            //}
        }
    }
}
