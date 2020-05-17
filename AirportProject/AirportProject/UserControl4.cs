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
    public partial class UserControl4 : UserControl
    {
        private ViewControlLoader loader = new ViewControlLoader();
        private flight choosenFlight;

        public UserControl4()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            choosenFlight = loader.GetFlightByID(Int32.Parse(comboBox1.Text.ToString()));
            textBox2.Text = String.Join(", ", choosenFlight.GetArrayData());
        }

        private void button7_Click(object sender, EventArgs e)
        {

            comboBox1.Items.Clear();
            comboBox2.Items.Clear();

            loader.LoadComboBoxTerminal(comboBox2);

            foreach (flight f in loader.GetAllFlights())
            {
                comboBox1.Items.Add(f.GetIDFlight());
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.ToString() == "" || comboBox2.Text.ToString() == "" || comboBox1.Text.ToString() == "") {

                MessageBox.Show("Please fill all of the field!");

            }
            else {

                if (GetStatus() == null || GetEndStatus() == null || GetLateStatus() == null) {

                    MessageBox.Show("Please choose every option!");

                }
                else { 

                choosenFlight.SetStringS(GetStatus());
                choosenFlight.SetStringEndS(GetEndStatus());
                choosenFlight.SetStringLateS(GetLateStatus());

                choosenFlight.SetStringTerminal(comboBox2.Text.ToString());

                choosenFlight.SetTime(textBox1.Text.ToString());

                choosenFlight.SetDate(dateTimePicker1.Value.ToString("dd/MM/yyyy"));

                loader.UpdateFlight(choosenFlight);


                }

            }

         

        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>

        private string GetStatus() {
            if (radioButton1.Checked == true) {
                return "Arriving";
            }
            if (radioButton2.Checked == true) {
                return "Departing";
            }

            return null;
        }

        private string GetEndStatus() {
            if (radioButton3.Checked == true)
            {
                return "Landed";
            }
            if (radioButton4.Checked == true)
            {
                return "Not Landed";
            }
            return null;
        }

        private string GetLateStatus()
        {
            if (radioButton5.Checked == true)
            {
                return "On Time";
            }
            if (radioButton6.Checked == true)
            {
                return "Late";
            }
            return null;
        }

        private void UserControl4_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();

            loader.LoadComboBoxTerminal(comboBox2);

            foreach (flight f in loader.GetAllFlights())
            {
                comboBox1.Items.Add(f.GetIDFlight());
            }
        }
    }
}
