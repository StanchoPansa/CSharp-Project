using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirportProject
{
    public partial class Form1 : Form
    {
        private ViewControlLoader loader = new ViewControlLoader();

        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetActivePanel(userControl11);
        }

        public void SetActivePanel(UserControl control)
        {
            userControl11.Visible = false;
            userControl21.Visible = false;
            userControl31.Visible = false;
            userControl41.Visible = false;
            userControl51.Visible = false;

            control.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetActivePanel(userControl11); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SetActivePanel(userControl21);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SetActivePanel(userControl31);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SetActivePanel(userControl41);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SetActivePanel(userControl51);
        }
    }
}
