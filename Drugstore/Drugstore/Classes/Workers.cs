using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Drugstore
{
    class Workers : Person
    {
        string pasport;
        int posada;
        int stage;
        DateTime datePriyom;
        string login;
        string password;
        string connectString = @"Data Source=.\SQLEXPRESS; Initial Catalog = Drugstore; uid=sa; Integrated Security=SSPI;";

        public Workers()
        {

        }

        public void setWorker(string pasport, string surname, string name, string lastname, string phone, string email, int posada, DateTime dateBirth, int stage, DateTime datePriyom, bool gender)
        {
            this.pasport = pasport;
            setSurname(surname);
            setName(name);
            setLastname(lastname);
            setPhone(phone);
            setEmail(email);
            setPosada(posada);
            setDateBirth(dateBirth);
            setStage(stage);
            setDatePriyom(datePriyom);
            setGender(gender);
        }

        public string getPasport()
        {
            return pasport;
        }
        public int getPosada()
        {
            return posada;
        }
        public int getStage()
        {
            return stage;
        }
        public DateTime getDatePriyom()
        {
            return datePriyom;
        }
        public string getLogin()
        {
            return login;
        }
        public string getPassword()
        {
            return password;
        }

        public void setPasport(string pasport)
        {
            this.pasport = pasport;
        }
        public void setPosada(int posada)
        {
            this.posada = posada;
        }
        public void setStage(int stage)
        {
            this.stage = stage;
        }
        public void setDatePriyom(DateTime date)
        {
            datePriyom = date;
        }
        public void setLogin(string login)
        {
            this.login = login;
        }
        public void setPassword(string password)
        {
            this.password = password;
        }

        public void getDataWorker(int id)
        {
            SqlConnection bd = new SqlConnection(connectString);
            bd.Open();
            SqlCommand command1 = new SqlCommand("SELECT * FROM Workers WHERE id=" + id.ToString(), bd);
            SqlDataReader dataReader1 = command1.ExecuteReader();
            while (dataReader1.Read())
            {
                setId(id);
                setPasport(dataReader1["pasport"].ToString().Trim());
                setSurname(dataReader1["surname"].ToString().Trim());
                setName(dataReader1["name"].ToString().Trim());
                setLastname(dataReader1["lastname"].ToString().Trim());
                setPhone(dataReader1["phone"].ToString().Trim());
                setEmail(dataReader1["email"].ToString().Trim());
                setPosada((int)dataReader1["posada"]);
                setStage((int)dataReader1["stage"]);
                setDateBirth((DateTime)dataReader1["dateBirth"]);
                setDatePriyom((DateTime)dataReader1["datePriyom"]);
                setGender((bool)dataReader1["stat"]);
                setLogin(dataReader1["login"].ToString().Trim());
                setPassword(dataReader1["password"].ToString().Trim());
            }
            bd.Close();
        }

        public void insertWorker()
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                SqlCommand command = new SqlCommand(
                    "INSERT INTO Workers VALUES(@valuePasport, @valueName, @valueSurname, @valueLastname, @valuePhone, @valueEmail, " +
                    "@valuePosada, @valueDateBirth, @valueStage, @valueDatePriyom, @valueGender, @valueLogin, @valuePassword)", connection);
                command.Parameters.AddWithValue("@valuePasport", getPasport());
                command.Parameters.AddWithValue("@valueName", getName());
                command.Parameters.AddWithValue("@valueSurname", getSurname());
                command.Parameters.AddWithValue("@valueLastname", getLastname());
                command.Parameters.AddWithValue("@valuePhone", getPhone());
                command.Parameters.AddWithValue("@valueEmail", getEmail());
                command.Parameters.AddWithValue("@valuePosada", getPosada().ToString());
                command.Parameters.AddWithValue("@valueDateBirth", getDateBirth().Date.ToString());
                command.Parameters.AddWithValue("@valueStage", getStage().ToString());
                command.Parameters.AddWithValue("@valueDatePriyom", getDatePriyom().Date.ToString());
                command.Parameters.AddWithValue("@valueGender", getGender());
                command.Parameters.AddWithValue("@valueLogin", getLogin());
                command.Parameters.AddWithValue("@valuePassword", getPassword());

                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void updateWorker(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                SqlCommand command = new SqlCommand(
                    "UPDATE Workers SET pasport=@valuePasport, name=@valueName, surname=@valueSurname, lastname=@valueLastname, phone=@valuePhone, email=@valueEmail, " +
                    " posada=@valuePosada, dateBirth=@valueDateBirth, stage=@valueStage, datePriyom=@valueDatePriyom, stat=@valueGender, login=@valueLogin, password=@valuePassword"+
                    " WHERE id="+id.ToString(), connection);

                command.Parameters.AddWithValue("@valuePasport", getPasport());
                command.Parameters.AddWithValue("@valueName", getName());
                command.Parameters.AddWithValue("@valueSurname", getSurname());
                command.Parameters.AddWithValue("@valueLastname", getLastname());
                command.Parameters.AddWithValue("@valuePhone", getPhone());
                command.Parameters.AddWithValue("@valueEmail", getEmail());
                command.Parameters.AddWithValue("@valuePosada", getPosada().ToString());
                command.Parameters.AddWithValue("@valueDateBirth", getDateBirth().Date.ToString());
                command.Parameters.AddWithValue("@valueStage", getStage().ToString());
                command.Parameters.AddWithValue("@valueDatePriyom", getDatePriyom().Date.ToString());
                command.Parameters.AddWithValue("@valueGender", getGender());
                command.Parameters.AddWithValue("@valueLogin", getLogin());
                command.Parameters.AddWithValue("@valuePassword", getPassword());

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

        public static DataSet getAllWorkers()
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

        public string getNamePosada(int id)
        {
            string name="";
            SqlConnection bd = new SqlConnection(connectString);
            bd.Open();
            SqlCommand command1 = new SqlCommand("SELECT * FROM Posada WHERE id=@value", bd);
            command1.Parameters.AddWithValue("@value", id.ToString());
            SqlDataReader dataReader1 = command1.ExecuteReader();
            while (dataReader1.Read())
            {
                name = dataReader1["name"].ToString().Trim();               
            }
            bd.Close();
            return name;
        }

        public string getNamePosada()
        {
            string name = "";
            SqlConnection bd = new SqlConnection(connectString);
            bd.Open();
            SqlCommand command1 = new SqlCommand("SELECT * FROM Posada WHERE id=" + getId().ToString(), bd);
            SqlDataReader dataReader1 = command1.ExecuteReader();
            while (dataReader1.Read())
            {
                name = dataReader1["name"].ToString().Trim();
            }
            bd.Close();
            return name;
        }

        public int getPosadaId(string name)
        {
            int id = 0;
            SqlConnection bd = new SqlConnection(connectString);
            bd.Open();
            SqlCommand command1 = new SqlCommand("SELECT * FROM Posada WHERE name=@value", bd);
            command1.Parameters.AddWithValue("@value", name);
            SqlDataReader dataReader1 = command1.ExecuteReader();
            while (dataReader1.Read())
            {
                id = (int)dataReader1["id"];
            }
            bd.Close();
            return id;
        }

        public static List<string> getAllPosada()
        {
            string connectString = @"Data Source=.\SQLEXPRESS; Initial Catalog = Drugstore; uid=sa; Integrated Security=SSPI;";
            List<string> pos=new List<string>();
            SqlConnection bd = new SqlConnection(connectString);
            bd.Open();
            SqlCommand command1 = new SqlCommand("SELECT * FROM Posada", bd);
            SqlDataReader dataReader1 = command1.ExecuteReader();
            while (dataReader1.Read())
            {
                pos.Add(dataReader1["name"].ToString().Trim());
            }
            bd.Close();
            return pos;
        }
    }
}
