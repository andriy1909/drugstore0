using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Drugstore
{
    class Workers
    {
        int id;
        string pasport;
        string surname;
        string name;
        string lastname;
        string phone;
        string email;
        int posada;
        DateTime dateBirth;
        int stage;
        DateTime datePriyom;
        bool gender; //true-man | false-woman
        string login;
        string password;
        string connectString = @"Data Source=.\SQLEXPRESS; Initial Catalog = Drugstore; uid=sa; Integrated Security=SSPI;";

        public Workers()
        {

        }
        public Workers(string pasport, string surname, string name, string lastname, string phone, string email, int posada, DateTime dateBirth, int stage, DateTime datePriyom, bool gender)
        {
            this.pasport = pasport;
            this.surname = surname;
            this.name = name;
            this.lastname = lastname;
            this.phone = phone;
            this.email = email;
            this.posada = posada;
            this.dateBirth = dateBirth;
            this.stage = stage;
            this.datePriyom = datePriyom;
            this.gender = gender;
        }

        public void insertWorker()
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                SqlCommand command = new SqlCommand(
                    "INSERT INTO Workers VALUES(@valuePasport, @valueName, @valueSurname, @valueLastname, @valuePhone, @valueEmail, " +
                    "@valuePosada, @valueDateBirth, @valueStage, @valueDatePriyom, @valueGender, @valueLogin, @valuePassword)", connection);
                command.Parameters.AddWithValue("@valuePasport", pasport);
                command.Parameters.AddWithValue("@valueName", name);
                command.Parameters.AddWithValue("@valueSurname", surname);
                command.Parameters.AddWithValue("@valueLastname", lastname);
                command.Parameters.AddWithValue("@valuePhone", phone);
                command.Parameters.AddWithValue("@valueEmail", email);
                command.Parameters.AddWithValue("@valuePosada", posada.ToString());
                command.Parameters.AddWithValue("@valueDateBirth", dateBirth.Date.ToString());
                command.Parameters.AddWithValue("@valueStage", stage.ToString());
                command.Parameters.AddWithValue("@valueDatePriyom", datePriyom.Date.ToString());
                command.Parameters.AddWithValue("@valueGender", (gender) ? 1 : 0);
                command.Parameters.AddWithValue("@valueLogin", login);
                command.Parameters.AddWithValue("@valuePassword", password);

                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void updateWorker()
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                SqlCommand command = new SqlCommand(
                    "UPDATE Workers SET pasport=@valuePasport, name=@valueName, surname=@valueSurname, lastname=@valueLastname, phone=@valuePhone, email=@valueEmail, " +
                    " posada=@valuePosada, dateBirth=@valueDateBirth, stage=@valueStage, datePriyom=@valueDatePriyom, stat=@valueGender, login=@valueLogin, password=@valuePassword", connection);

                command.Parameters.AddWithValue("@valuePasport", pasport);
                command.Parameters.AddWithValue("@valueName", name);
                command.Parameters.AddWithValue("@valueSurname", surname);
                command.Parameters.AddWithValue("@valueLastname", lastname);
                command.Parameters.AddWithValue("@valuePhone", phone);
                command.Parameters.AddWithValue("@valueEmail", email);
                command.Parameters.AddWithValue("@valuePosada", posada.ToString());
                command.Parameters.AddWithValue("@valueDateBirth", dateBirth.Date.ToString());
                command.Parameters.AddWithValue("@valueStage", stage.ToString());
                command.Parameters.AddWithValue("@valueDatePriyom", datePriyom.Date.ToString());
                command.Parameters.AddWithValue("@valueGender", (gender) ? 1 : 0);
                command.Parameters.AddWithValue("@valueLogin", login);
                command.Parameters.AddWithValue("@valuePassword", password);

                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }
        public static void deleteId(int id)
        {
            string connectString = @"Data Source=.\SQLEXPRESS; Initial Catalog = Drugstore; uid=sa; Integrated Security=SSPI;";
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                SqlCommand command = new SqlCommand(
                    "DELETE FROM Workers " +
                    "WHERE id=" + id.ToString(), connection);

                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }
        public static DataSet getAllClients()
        {
            DataSet dataSet = new DataSet();
            string connectString = @"Data Source=.\SQLEXPRESS; Initial Catalog = Drugstore; uid=sa; Integrated Security=SSPI;";
            SqlConnection bd = new SqlConnection(connectString);
            bd.Open();
            SqlDataAdapter dataAdapter1 = new SqlDataAdapter("SELECT * FROM Workers", bd);
            dataAdapter1.Fill(dataSet);
            bd.Close();
            return dataSet;
        }
    }
}
