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
    public partial class UserControl3 : UserControl
    {
        private ViewControlLoader loader = new ViewControlLoader();

        public UserControl3()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            listView1.Items.Clear();
            loader.SetDepartingFlights(listView1);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UserControl3_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            loader.SetDepartingFlights(listView1);
        }
    }
}
