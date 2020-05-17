using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportProject
{
    class terminal
    {
        int id_terminal;
        string terminal_column;

        public terminal(int id_terminal, string terminal_column) {
            this.id_terminal = id_terminal;
            this.terminal_column = terminal_column;
        }

        void SetIDTErminal(int id_terminal) {
            this.id_terminal = id_terminal;
        }

        void SetTerminalColumn(string terminal_column) {
            this.terminal_column = terminal_column;
        }

        public int GetIDTerminal() {
            return id_terminal;
        }

        public string GetTerminalColumn() {
            return terminal_column;
        }

    }
}
