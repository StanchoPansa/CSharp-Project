using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportProject
{
    class late_status
    {
        int id_late_status;
        string late_status_column;

        public late_status(int id_late_status, string late_status_column) {
            this.id_late_status = id_late_status;
            this.late_status_column = late_status_column;
        }

        void SetIDLateStatus(int id_late_status) {
            this.id_late_status = id_late_status;
        }

        void SetLateStatusColumn(string late_status_column) {
            this.late_status_column = late_status_column;
        }

        public int GetIDLateStatus() {
            return id_late_status;
        }

        public string GetLateStatusColumn() {
            return late_status_column;
        }
    }
}
