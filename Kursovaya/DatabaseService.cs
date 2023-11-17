using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using Kursovaya.classes;

namespace Kursovaya
{
    public class DatabaseService
    {
        private string connectionString;
        private SQLiteConnection connection;
        public DatabaseService()
        {
            connectionString = "Data Source=iziLogistik.db;Version=3;";
        }
        public List<Journal> GetJournals()
        {
            List<Journal> journal = new List<Journal>();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM journal";

                SQLiteCommand command = new SQLiteCommand(query, connection);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        journal.Add(new Journal
                        {
                            ID_Zayavki = Convert.ToInt32(reader["ID_Zayavki"]),
                            Owner = Convert.ToString(reader["Owner"]),
                            Status = Convert.ToString(reader["Status"]),
                            Adress = Convert.ToString(reader["Adress"]),
                            Name_Gruz = Convert.ToString(reader["Name_Gruz"]),
                            Weight = Convert.ToString(reader["Weight"]),
                            Truck = Convert.ToInt32(reader["Truck"]),
                            Date_Otgruzki = Convert.ToString(reader["Date_Otgruzki"])
                        });
                    }
                }
            }
            return journal;    
        }
        public List<Trucks> GetTruck()
        {
            List<Trucks> trucks = new List<Trucks>();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Trucks";

                SQLiteCommand command = new SQLiteCommand(query, connection);

                SQLiteDataReader sQLiteDataReader = command.ExecuteReader();
                using (SQLiteDataReader reader = sQLiteDataReader)
                {
                    while (reader.Read())
                    {
                        trucks.Add(new Trucks
                        {
                            ID_Truck = Convert.ToInt32(reader["ID_Truck"]),
                            Number = Convert.ToString(reader["Number"]),
                            FIO = Convert.ToString(reader["FIO"]),
                            Status = Convert.ToInt32(reader["Status"]),
                            Car = Convert.ToString(reader["Car"])
                        });
                    }
                }
            }
            return trucks;
        }
        public List<StatusTrucks> GetStatusTrucks()
        {
            List<StatusTrucks> statusTrucks = new List<StatusTrucks>();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM StatusTrucks";

                SQLiteCommand command = new SQLiteCommand(query, connection);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        statusTrucks.Add(new StatusTrucks
                        {
                            ID = Convert.ToInt32(reader["ID"]),
                            Status2 = Convert.ToString(reader["Status2"])
                        });
                    }
                }
                return statusTrucks;
            }
        }
        /*public List<StatusZayavki> GetStatusZayavkis() 
        {
            List<StatusZayavki> statusZayavki = new List<StatusZayavki>();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM StatusZayavki";

                SQLiteCommand command = new SQLiteCommand(query, connection);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        statusZayavki.Add(new StatusZayavki
                        {
                            ID = Convert.ToInt32(reader["ID"]),
                            Status1 = Convert.ToString(reader["Status1"])
                        });
                    }
                }
                return statusZayavki;
            }
        }*/

        public bool AddJournal(Journal journal)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO journal (owner, status, adress, name_gruz, weight, truck, date_otgruzki) VALUES (@owner, @status, @adress, @name_gruz, @weight, @truck, @date_otgruzki)";

                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@owner", journal.Owner);
                command.Parameters.AddWithValue("@status", journal.Status);
                command.Parameters.AddWithValue("@adress", journal.Adress);
                command.Parameters.AddWithValue("@name_gruz", journal.Name_Gruz);
                command.Parameters.AddWithValue("@weight", journal.Weight);
                command.Parameters.AddWithValue("@truck", journal.Truck);
                command.Parameters.AddWithValue("@date_otgruzki", journal.Date_Otgruzki);

                int result = command.ExecuteNonQuery();
                return result > 0;
            }
        }

        public bool AddTrucks(Trucks trucks)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO trucks (number, fio, status, car) VALUES (@number, @fio, @status, @car)";

                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@number", trucks.Number);
                command.Parameters.AddWithValue("@fio", trucks.FIO);
                command.Parameters.AddWithValue("@status", trucks.Status);
                command.Parameters.AddWithValue("@car", trucks.Car);

                int result = command.ExecuteNonQuery();
                return result > 0;
            }
        }
       /* public bool AddStatusTruckss(StatusTrucks statusTrucks)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO statusTrucks (status2) VALUES (@status2)";

                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@status2", statusTrucks.Status2);

                int result = command.ExecuteNonQuery();
                return result > 0;
            }
        }
        public bool AddStatusZayavki(StatusZayavki statusZayavki)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO statusZayavki (status2) VALUES (@status1)";

                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@status1", statusZayavki.Status1);

                int result = command.ExecuteNonQuery();
                return result > 0;
            }
        }*/
    }
}
