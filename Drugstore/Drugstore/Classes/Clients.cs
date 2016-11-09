using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Drugstore
{
    public class Clients
    {
        int id;
        string surname;
        string name;
        string lastname;
        string phone;
        string email;
        bool checkEmail;
        DateTime dateBirth;
        DateTime dateRegistr;
        bool gender; //true-man | false-woman
        string connectString = @"Data Source=.\SQLEXPRESS; Initial Catalog = Drugstore; uid=sa; Integrated Security=SSPI;";

        public Clients()
        {

        }
        public Clients(string surname, string name, string lastname,string phone, string email, bool checkEmail, DateTime dateBirth, DateTime dateRegistr, bool gender)
        {
            this.surname = surname;
            this.name = name;
            this.lastname = lastname;
            this.phone = phone;
            this.email = email;
            this.checkEmail = checkEmail;
            this.dateBirth = dateBirth;
            this.dateRegistr = dateRegistr;
            this.gender = gender;
        }
        /*public Clients(string surname, string name, string lastname, string phone, DateTime dateBirth, DateTime dateRegistr, bool gender)
        {
            this.id = id;
            this.surname = surname;
            this.name = name;
            this.lastname = lastname;
            this.phone = phone;
            this.email = "";
            this.checkEmail = false;
            this.dateBirth = dateBirth;
            this.dateRegistr = dateRegistr;
            this.gender = gender;
        }
        public Clients(string surname, string name, string lastname, string phone, string email, bool checkEmail, DateTime dateBirth, DateTime dateRegistr, bool gender)
        {
            this.id = id;
            this.surname = surname;
            this.name = name;
            this.lastname = lastname;
            this.phone = phone;
            this.email = email;
            this.checkEmail = checkEmail;
            this.dateBirth = dateBirth;
            this.dateRegistr = dateRegistr;
            this.gender = gender;
        }

        public void setClient(string surname, string name, string lastname, string email, bool checkEmail, DateTime dateBirth, DateTime dateRegistr, bool gender)
        {
            this.id = id;
            this.surname = surname;
            this.name = name;
            this.lastname = lastname;
            this.phone = "";
            this.email = email;
            this.checkEmail = checkEmail;
            this.dateBirth = dateBirth;
            this.dateRegistr = dateRegistr;
            this.gender = gender;
        }
        public void setClient(string surname, string name, string lastname, string phone, DateTime dateBirth, DateTime dateRegistr, bool gender)
        {
            this.id = id;
            this.surname = surname;
            this.name = name;
            this.lastname = lastname;
            this.phone = phone;
            this.email = "";
            this.checkEmail = false;
            this.dateBirth = dateBirth;
            this.dateRegistr = dateRegistr;
            this.gender = gender;
        }
        public void setClient(string surname, string name, string lastname, string phone, string email, bool checkEmail, DateTime dateBirth, DateTime dateRegistr, bool gender)
        {
            this.id = id;
            this.surname = surname;
            this.name = name;
            this.lastname = lastname;
            this.phone = phone;
            this.email = email;
            this.checkEmail = checkEmail;
            this.dateBirth = dateBirth;
            this.dateRegistr = dateRegistr;
            this.gender = gender;
        }
        */
        public int getId()
        {
            return id;
        }
        public string getSurname()
        {
            return surname;
        }
        public string getName()
        {
            return name;
        }
        public string getLastname()
        {
            return lastname;
        }
        public string getPhone()
        {
            return phone;
        }
        public string getEmail()
        {
            return email;
        }
        public bool getCheckEmail()
        {
            return checkEmail;
        }
        public DateTime getDateBirth()
        {
            return dateBirth;
        }
        public DateTime getDateRegistr()
        {
            return dateRegistr;
        }
        public bool getGender()
        {
            return gender;
        }

        public void getDataClient(int id)
        {

        }

        public void insertClient()
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                SqlCommand command = new SqlCommand(
                    "INSERT INTO Clients VALUES(@valueName, @valueSurname, @valueLastname, @valuePhone, @valueEmail, " +
                    "@valueCheckEmail, @valueDateBirth, @valueDateRegistr, @valueGender)", connection);
                command.Parameters.AddWithValue("@valueName", name);
                command.Parameters.AddWithValue("@valueSurname", surname);
                command.Parameters.AddWithValue("@valueLastname", lastname);
                command.Parameters.AddWithValue("@valuePhone", phone);
                command.Parameters.AddWithValue("@valueEmail", email);
                command.Parameters.AddWithValue("@valueCheckEmail", checkEmail);
                command.Parameters.AddWithValue("@valueDateBirth", dateBirth.Date.ToString());
                command.Parameters.AddWithValue("@valueDateRegistr", dateRegistr.Date.ToString());
                //command.Parameters.AddWithValue("@valueGender", (gender) ? 1 : 0);
                command.Parameters.AddWithValue("@valueGender", gender);

                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void updateClient(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                SqlCommand command = new SqlCommand(
                    "UPDATE Clients SET name=@valueName, surname=@valueSurname, lastname=@valueLastname, phone=@valuePhone, email=@valueEmail, " +
                    "rozsilka=@valueCheckEmail, dateBirth=@valueDateBirth, dateRegistr=@valueDateRegistr, stat=@valueGender "+
                    "WHERE id="+id.ToString(), connection);
                command.Parameters.AddWithValue("@valueName", name);
                command.Parameters.AddWithValue("@valueSurname", surname);
                command.Parameters.AddWithValue("@valueLastname", lastname);
                command.Parameters.AddWithValue("@valuePhone", phone);
                command.Parameters.AddWithValue("@valueEmail", email);
                command.Parameters.AddWithValue("@valueCheckEmail", (checkEmail) ? 1 : 0);
                command.Parameters.AddWithValue("@valueDateBirth", dateBirth.Date.ToString());
                command.Parameters.AddWithValue("@valueDateRegistr", dateRegistr.Date.ToString());
                command.Parameters.AddWithValue("@valueGender", (gender) ? 1 : 0);

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
                    "DELETE FROM Clients "+
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
            SqlDataAdapter dataAdapter1 = new SqlDataAdapter("SELECT * FROM Clients", bd);
            dataAdapter1.Fill(dataSet);
            bd.Close();
            return dataSet;
        }

        public void getClientId(int id)
        {
            string connectString = @"Data Source=.\SQLEXPRESS; Initial Catalog = Drugstore; uid=sa; Integrated Security=SSPI;";
            SqlConnection bd = new SqlConnection(connectString);
            bd.Open();
            SqlCommand command1 = new SqlCommand("SELECT * FROM Clients WHERE id=" + id.ToString(), bd);
            SqlDataReader dataReader1 = command1.ExecuteReader();

            this.id = id;
            //this.id = int.Parse(dataReader1["id"].ToString().Trim());
            surname = dataReader1["surname"].ToString().Trim();
            name = dataReader1["name"].ToString().Trim();
            lastname = dataReader1["lastname"].ToString().Trim();
            phone = dataReader1["phone"].ToString().Trim();
            email = dataReader1["email"].ToString().Trim();
            checkEmail = (bool)dataReader1["rozsilka"];
            dateBirth = (DateTime)dataReader1["dateBirth"];
            dateRegistr = (DateTime)dataReader1["dateRegistr"];
            gender = (bool)dataReader1["stat"];

            bd.Close();
        }
    }
}
