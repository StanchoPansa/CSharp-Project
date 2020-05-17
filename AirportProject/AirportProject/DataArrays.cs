using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportProject
{
    class DataArrays
    {
        List<flight> Flights = new List<flight>();
        List<status_flight> Status_Flights = new List<status_flight>();
        List<late_status> Late_Statuses = new List<late_status>();
        List<end_status> End_Statuses = new List<end_status>();
        List<terminal> Terminals = new List<terminal>();
        DataBaseWorker worker = new DataBaseWorker();

        public void InitArrays() {

            worker.SelectFlight(Flights);
            worker.SelectStatus(Status_Flights);
            worker.SelectLateStatus(Late_Statuses);
            worker.SelectEndStatus(End_Statuses);
            worker.SelectTerminal(Terminals);

        }

        public List<flight> getflights() {

            Flights.Clear();
            worker.SelectFlight(Flights);

            foreach (flight f in Flights) {
                SetStringColumns(f);
            }

            return Flights;
        }

        public List<flight> GetFlightsOption(string s) {
            List<flight> result = new List<flight>();

            switch (s) {

                case "arrivals": {

                        foreach (flight f in getflights()) {
                            if (f.GetStringStatus() == "Arriving") {
                                result.Add(f);
                            }
                        }

                        break;
                    }

                case "departures":
                    {
                        foreach (flight f in getflights())
                        {
                            if (f.GetStringStatus() == "Departing")
                            {
                                result.Add(f);
                            }
                        }

                        break;


                    }

            }

            return result;
        }

        public List<status_flight> getstatusflights() {
            return Status_Flights;
        }

        public List<late_status> getlatestatuses() {
            return Late_Statuses;
        }

        public List<end_status> getendstatuses() {
            return End_Statuses;
        }

        public List<terminal> getterminals() {
            return Terminals;
        }


        public void InsertFlight(flight f) {

            UpdateFlightID(f);
            worker.Insert(f);
            Flights.Clear();
            worker.SelectFlight(Flights);
        }

        public void UpdateFlight(flight f)
        {

            UpdateFlightID(f);

            worker.Update(f);
            /*foreach( flight fl in Flights){
                if (fl.GetIDFlight() == f.GetIDFlight()) {
                    fl.SetDetails(f);
                }
            }*/

            Flights.Clear();
            worker.SelectFlight(Flights);
        }


        private void UpdateFlightID(flight f) {

            f.SetSID(GetIDWithStatus(f.GetStringStatus()));
            f.SetEndSID(GetIDWithEndStatus(f.GetStringEndStatus()));
            f.SetLateSID(GetIDWithLateStatus(f.GetStringLateStatus()));
            f.SetTerminal(GetIDWithTerminal(f.GetStringTerminal()));

        }


        private int GetIDWithStatus(string s) {
            foreach (status_flight sf in Status_Flights) {
                if (sf.GetStatusColumn() == s) {
                    return sf.GetIDStatus();
                }
            }
            return 0;
        }

        private int GetIDWithEndStatus(string s)
        {
            foreach (end_status sf in End_Statuses)
            {
                if (sf.GetEndStatusColumn() == s)
                {
                    return sf.GetIDEndStatus();
                }
            }
            return 0;
        }

        private int GetIDWithLateStatus(string s)
        {
            foreach (late_status sf in Late_Statuses)
            {
                if (sf.GetLateStatusColumn() == s)
                {
                    return sf.GetIDLateStatus();
                }
            }
            return 0;
        }

        private int GetIDWithTerminal(string s)
        {
            foreach (terminal sf in Terminals)
            {
                if (sf.GetTerminalColumn() == s)
                {
                    return sf.GetIDTerminal();
                }
            }
            return 0;
        }



        public void DeleteFligh(flight f) {

            worker.Delete(f);

            flight removed = new flight(); 

            foreach (flight fl in Flights) {

                if (fl.GetIDFlight() == f.GetIDFlight()) {

                    removed = fl;

                }

            }

            Flights.Remove(removed);

        }

   //--------------------------------------------------------------------------


        public string GetStatusValue(int id) {
            foreach (status_flight s in Status_Flights) {
                if (s.GetIDStatus() == id) {
                    return s.GetStatusColumn();
                }
            }
            return null;
        }

        public string GetEndStatusValue(int id) {
            foreach (end_status s in End_Statuses) {
                if (s.GetIDEndStatus() == id) {
                    return s.GetEndStatusColumn();
                }
            }
            return null;
        }

        public string GetLateStatusValue(int id) {
            foreach (late_status s in Late_Statuses) {
                if (s.GetIDLateStatus() == id) {
                    return s.GetLateStatusColumn();
                }
            }
            return null;
        }

        public string GetTerminalValue(int id) {
            foreach (terminal s in Terminals) {
                if (s.GetIDTerminal() == id) {
                    return s.GetTerminalColumn();
                }
            }
            return null;
        }


        //--------------------------------------------------------------------------------


        public void SetStringColumns(flight f) {
            f.SetStringS(GetStatusValue(f.GetSID()));
            f.SetStringEndS(GetEndStatusValue(f.GetEndSID()));
            f.SetStringLateS(GetLateStatusValue(f.GetLateSID()));
            f.SetStringTerminal(GetTerminalValue(f.GetTerminal()));
        }




    }
}
