using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirportProject
{
    class ViewControlLoader
    {

        DataArrays dataArrays = new DataArrays();


        public ViewControlLoader() {
            dataArrays.InitArrays();
        }

        public void SetArrivingFlights(ListView view) {
            foreach (flight f in dataArrays.GetFlightsOption("arrivals")) {
                view.Items.Add(new ListViewItem(f.GetArrayData()));
            }
        }

        public void SetDepartingFlights(ListView view)
        {
            foreach (flight f in dataArrays.GetFlightsOption("departures"))
            {
                view.Items.Add(new ListViewItem(f.GetArrayData()));
            }
        }

        public List<flight> GetAllFlights() {
            return dataArrays.getflights();
        }

        public string[] GetComboFlightData(int id) {
            foreach (flight f in dataArrays.getflights()) {
                if (f.GetIDFlight() == id) {
                    return f.GetArrayData();
                }
            }
            return null;
        }

        public flight GetFlightByID(int id) {

            foreach (flight f in dataArrays.getflights())
            {
                if (f.GetIDFlight() == id)
                {
                    return f;
                }
            }
            return null;

        }

        public void LoadComboBoxTerminal(ComboBox box) {
            foreach (terminal t in dataArrays.getterminals()) {
                box.Items.Add(t.GetTerminalColumn());
            }
        }

        public void LoadComboBoxStatus(ComboBox box)
        {
            foreach (status_flight t in dataArrays.getstatusflights())
            {
                box.Items.Add(t.GetStatusColumn());
            }
        }

        public void LoadComboBoxLateStatus(ComboBox box)
        {
            foreach (late_status t in dataArrays.getlatestatuses())
            {
                box.Items.Add(t.GetLateStatusColumn());
            }
        }

        public void LoadComboBoxEndStatus(ComboBox box)
        {
            foreach (end_status t in dataArrays.getendstatuses())
            {
                box.Items.Add(t.GetEndStatusColumn());
            }
        }

        public void LoadComboBoxID(ComboBox box) {

            foreach (flight t in dataArrays.getflights())
            {
                box.Items.Add(t.GetIDFlight());
            }

        }

        public void InsertFlight(flight f) {

            dataArrays.InsertFlight(f);
        }

        public void UpdateFlight(flight f) {

            dataArrays.UpdateFlight(f);

        }

        public void DeleteFlight(flight f) {

            dataArrays.DeleteFligh(f);

        }

    }
}
