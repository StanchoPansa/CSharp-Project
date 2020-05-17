using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirportProject
{
    public partial class UserControl2 : UserControl
    {

        private ViewControlLoader loader = new ViewControlLoader();

        public UserControl2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            listView1.Items.Clear();
            loader.SetArrivingFlights(listView1);

        }

        private void UserControl2_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            loader.SetArrivingFlights(listView1);
        }
    }
}
