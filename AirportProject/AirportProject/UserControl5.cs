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
    public partial class UserControl5 : UserControl
    {
        private ViewControlLoader loader = new ViewControlLoader();

        public UserControl5()
        {
            InitializeComponent();
        }

        private void UserControl5_Load(object sender, EventArgs e)
        {

            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            comboBox4.Items.Clear();
            comboBox5.Items.Clear();

            loader.LoadComboBoxStatus(comboBox1);
            loader.LoadComboBoxEndStatus(comboBox2);
            loader.LoadComboBoxLateStatus(comboBox3);
            loader.LoadComboBoxID(comboBox4);
            loader.LoadComboBoxTerminal(comboBox5);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.ToString() == "" || textBox2.Text.ToString() == "" || comboBox2.Text.ToString() == "" || comboBox1.Text.ToString() == "" || comboBox3.Text.ToString() == "" || comboBox5.Text.ToString() == "") {

                MessageBox.Show("Please fill all of the fields!");

            }
            else {

                flight f = new flight();

                f.SetPlaneName(textBox1.Text.ToString());
                f.SetCompanyName(textBox2.Text.ToString());
                f.SetStringS(comboBox1.Text.ToString());
                f.SetStringEndS(comboBox2.Text.ToString());
                f.SetStringLateS(comboBox3.Text.ToString());
                f.SetStringTerminal(comboBox5.Text.ToString());
                f.SetTime(textBox4.Text.ToString());
                f.SetDate(dateTimePicker1.Value.ToString("dd/MM/yyyy"));

                loader.InsertFlight(f);

            }


            

        }

        private void button3_Click(object sender, EventArgs e)
        {

            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            comboBox4.Items.Clear();
            comboBox5.Items.Clear();

            loader.LoadComboBoxStatus(comboBox1);
            loader.LoadComboBoxEndStatus(comboBox2);
            loader.LoadComboBoxLateStatus(comboBox3);
            loader.LoadComboBoxID(comboBox4);
            loader.LoadComboBoxTerminal(comboBox5);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (comboBox4.Text.ToString() == "") {

                MessageBox.Show("Please choose ID!");

            }
            else {

                flight f = new flight();

                f.SetIDFlight(Int32.Parse(comboBox4.Text.ToString()));

                loader.DeleteFlight(f);

            }

            

        }
    }
}
