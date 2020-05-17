using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportProject
{
    class end_status
    {
        int id_end_status;
        string end_status_column;

        public end_status(int id_end_status, string end_status_column) {
            this.id_end_status = id_end_status;
            this.end_status_column = end_status_column;
        }

        void SetIDEndStatus(int id_end_status) {
            this.id_end_status = id_end_status;
        }

        void SetEndStatusColumn(string end_status_column) {
            this.end_status_column = end_status_column;
        }

        public int GetIDEndStatus() {
            return id_end_status;
        }

        public string GetEndStatusColumn() {
            return end_status_column;
        }

    }
}
