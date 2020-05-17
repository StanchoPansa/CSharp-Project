using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AirportProject
{
    class DataBaseWorker
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public DataBaseWorker()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            server = "localhost";
            database = "airport";
            uid = "root";
            password = "root";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        //open connection to database
        private bool OpenConnection()
        {

            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }

        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //Insert statement
        public void Insert(flight f)
        {

            string query = "INSERT INTO flight (plane_name, company_name, s_id, end_s_id, late_s_id, terminal_id, time_time, date_date) VALUES('" + f.GetPlaneName() + "','" + f.GetCompanyName() + "','" + f.GetSID() + "','" + f.GetEndSID() + "','" + f.GetLateSID() + "','" + f.GetTerminal() + "','" + f.GetTime() + "','" + f.GetDate() + "')";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }

        }

        //Update statement
        public void Update(flight f)
        {
            string query = "UPDATE flight SET plane_name = '"+f.GetPlaneName()+"', company_name = '"+f.GetCompanyName()+"', s_id = '"+f.GetSID()+"', end_s_id = '"+f.GetEndSID()+"', late_s_id = '"+f.GetLateSID()+"', terminal_id = '"+f.GetTerminal()+"', time_time = '"+f.GetTime()+"', date_date = '"+f.GetDate()+"' WHERE id_flight = '"+f.GetIDFlight()+"' ";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }

        }

        //Delete statement
        public void Delete(flight f)
        {

            string query = "DELETE FROM flight WHERE id_flight = '" + f.GetIDFlight() + "'";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }

        }

        //Select statement
        public void SelectFlight(List<flight> flights)
        {
            string query = "SELECT * FROM flight";

            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    flights.Add(new flight(dataReader.GetInt32("id_flight"), dataReader.GetInt32("s_id"), dataReader.GetInt32("end_s_id"), dataReader.GetInt32("late_s_id"), dataReader.GetInt32("terminal_id"),
                    dataReader.GetString("plane_name"), dataReader.GetString("company_name"), dataReader.GetString("time_time"), dataReader.GetString("date_date")));
                }

                dataReader.Close();

                this.CloseConnection();
            }


        }

        public void SelectStatus(List<status_flight> status_Flights)
        {

            string query = "SELECT * FROM status_flight";

            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    status_Flights.Add(new status_flight(dataReader.GetInt32("id_status"), dataReader.GetString("status_column")));
                }

                dataReader.Close();

                this.CloseConnection();
            }

        }

        public void SelectLateStatus(List<late_status> late_Statuses)
        {

            string query = "SELECT * FROM late_status";

            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    late_Statuses.Add(new late_status(dataReader.GetInt32("id_late_status"), dataReader.GetString("late_status_column")));
                }

                dataReader.Close();

                this.CloseConnection();
            }

        }




        public void SelectEndStatus(List<end_status> end_Statuses)
        {

            string query = "SELECT * FROM end_status";

            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    end_Statuses.Add(new end_status(dataReader.GetInt32("id_end_status"), dataReader.GetString("end_status_column")));
                }

                dataReader.Close();

                this.CloseConnection();
            }

        }


        public void SelectTerminal(List<terminal> terminals)
        {

            string query = "SELECT * FROM terminal";

            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    terminals.Add(new terminal(dataReader.GetInt32("id_terminal"), dataReader.GetString("terminal_column")));
                }

                dataReader.Close();

                this.CloseConnection();
            }

        }


    }
}


    


