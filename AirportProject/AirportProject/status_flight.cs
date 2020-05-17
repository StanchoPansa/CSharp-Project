using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportProject
{
    class status_flight
    {
        int id_status;
        string status_column;

        public status_flight(int id_status, string status_column)
        {
            this.id_status = id_status;
            this.status_column = status_column;
        }

        void SetIDStatus(int id_status)
        {
            this.id_status = id_status;
        }

        void SetStatusColumn(string status_column)
        {
            this.status_column = status_column;
        }

        public int GetIDStatus() {
            return id_status;
        }

        public string GetStatusColumn() {
            return status_column;
        }


    }
}
