using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportProject
{
    class flight
    {
        int id_flight, s_id, end_s_id, late_s_id, terminal_id;
        string plane_name, company_name, time_time, date_date;
        string string_s, string_end_s, string_late_s, string_terminal;

        public flight(int id_flight, int s_id, int end_s_id, int late_s_id, int terminal_id,
            string plane_name, string company_name, string time_time, string date_date) {

            this.id_flight = id_flight;
            this.s_id = s_id;
            this.end_s_id = end_s_id;
            this.late_s_id = late_s_id;
            this.terminal_id = terminal_id;
            this.plane_name = plane_name;
            this.company_name = company_name;
            this.time_time = time_time;
            this.date_date = date_date;

        }

        public flight() { }


        public void SetIDFlight(int id_flight) {
            this.id_flight = id_flight;
        }

        public void SetSID(int s_id)
        {
            this.s_id = s_id;
        }

        public void SetEndSID(int end_s_id)
        {
            this.end_s_id = end_s_id;
        }

        public void SetLateSID(int late_s_id)
        {
            this.late_s_id = late_s_id;
        }

        public void SetTerminal(int terminal_id)
        {
            this.terminal_id = terminal_id;
        }

        public void SetPlaneName(string plane_name)
        {
            this.plane_name = plane_name;
        }

        public void SetCompanyName(string company_name)
        {
            this.company_name = company_name;
        }

        public void SetTime(string time_time)
        {
            this.time_time = time_time;
        }

        public void SetDate(string date_date)
        {
            this.date_date = date_date;
        }

        //----------------------------------------

        public void SetStringS(string string_s) {
            this.string_s = string_s;
        }

        public void SetStringEndS(string string_end_s) {
            this.string_end_s = string_end_s;
        }

        public void SetStringLateS(string string_late_s) {
            this.string_late_s = string_late_s;
        }

        public void SetStringTerminal(string string_terminal) {
            this.string_terminal = string_terminal;
        }

        public string GetStringStatus() {
            return string_s;
        }

        public string GetStringEndStatus()
        {
            return string_end_s;
        }

        public string GetStringLateStatus()
        {
            return string_late_s;
        }

        public string GetStringTerminal()
        {
            return string_terminal;
        }


        //----------------------------------------

        public int GetIDFlight() {
            return id_flight;
        }

        public int GetSID()
        {
            return s_id;
        }

        public int GetEndSID()
        {
            return end_s_id;
        }

        public int GetLateSID()
        {
            return late_s_id;
        }

        public int GetTerminal()
        {
            return terminal_id;
        }

        public string GetPlaneName()
        {
            return plane_name;
        }

        public string GetCompanyName()
        {
            return company_name;
        }

        public string GetTime()
        {
            return time_time;
        }

        public string GetDate()
        {
            return date_date;
        }

        public void SetDetails(flight f) {
            this.plane_name = f.GetPlaneName();
            this.company_name = f.GetCompanyName();
            this.s_id = f.GetSID();
            this.late_s_id = f.GetLateSID();
            this.end_s_id = f.GetLateSID();
            this.terminal_id = f.GetTerminal();
            this.time_time = f.GetTime();
            this.date_date = f.GetDate();
        }


        public string[] GetArrayData() {
            return new string[] { id_flight.ToString(), plane_name, company_name, string_s, string_end_s, string_late_s, string_terminal, time_time, date_date };
        }



    }
}
