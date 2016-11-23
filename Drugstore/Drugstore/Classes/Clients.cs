using System;
using System.Data.SqlClient;
using System.Data;

namespace Drugstore
{
    public class Clients : Person
    {
        string card;
        bool checkEmail;
        DateTime dateRegistr;
        string connectString = @"Data Source=.\SQLEXPRESS; Initial Catalog = Drugstore; uid=sa; Integrated Security=SSPI;";

        public Clients()
        {

        }
        public void setClient(string card, string surname, string name, string lastname,string phone, string email, bool checkEmail, DateTime dateBirth, DateTime dateRegistr, bool gender)
        {
            setCard(card);
            setSurname(surname);
            setName(name);
            setLastname(lastname);
            setPhone(phone);
            setEmail(email);
            setCheckEmail(checkEmail);
            setDateBirth(dateBirth);
            setDateRegistr(dateRegistr);
            setGender(gender);
        }

        public string getCard()
        {
            return card;
        }

        public bool getCheckEmail()
        {
            return checkEmail;
        }
        
        public DateTime getDateRegistr()
        {
            return dateRegistr;
        }        

        public void setCard(string card)
        {
            this.card = card;
        }
        public void setCheckEmail(bool check)
        {
            checkEmail = check;
        }
        public void setDateRegistr(DateTime date)
        {
            dateRegistr = date;
        }

        public void getDataClient(int id)
        {
            SqlConnection bd = new SqlConnection(connectString);
            bd.Open();
            SqlCommand command1 = new SqlCommand("SELECT * FROM Clients WHERE id=" + id.ToString(), bd);
            SqlDataReader dataReader1 = command1.ExecuteReader();
            while (dataReader1.Read())
            {
                setId(id);
                setCard(dataReader1["card"].ToString().Trim());
                setSurname(dataReader1["surname"].ToString().Trim());
                setName(dataReader1["name"].ToString().Trim());
                setLastname(dataReader1["lastname"].ToString().Trim());
                setPhone(dataReader1["phone"].ToString().Trim());
                setEmail(dataReader1["email"].ToString().Trim());
                setCheckEmail((bool)dataReader1["rozsilka"]);
                setDateBirth((DateTime)dataReader1["dateBirth"]);
                setDateRegistr((DateTime)dataReader1["dateRegistr"]);
                setGender((bool)dataReader1["gender"]);
            }
            bd.Close();
        }

        public void insertClient()
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                SqlCommand command = new SqlCommand(
                    "INSERT INTO Clients VALUES(@valueCard, @valueSurname, @valuename, @valueLastname, @valuePhone, @valueEmail, " +
                    "@valueCheckEmail, @valueDateBirth, @valueDateRegistr, @valueGender)", connection);
                command.Parameters.AddWithValue("@valueCard", getCard());
                command.Parameters.AddWithValue("@valueSurname", getSurname());
                command.Parameters.AddWithValue("@valueName", getName());
                command.Parameters.AddWithValue("@valueLastname", getLastname());
                command.Parameters.AddWithValue("@valuePhone", getPhone());
                command.Parameters.AddWithValue("@valueEmail", getEmail());
                command.Parameters.AddWithValue("@valueCheckEmail", getCheckEmail());
                command.Parameters.AddWithValue("@valueDateBirth", getDateBirth().Date.ToString());
                command.Parameters.AddWithValue("@valueDateRegistr", getDateRegistr().Date.ToString());
                command.Parameters.AddWithValue("@valueGender", getGender());

                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void updateClient(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                SqlCommand command = new SqlCommand(
                    "UPDATE Clients SET card=@valueCard, name=@valueName, surname=@valueSurname, lastname=@valueLastname, phone=@valuePhone, email=@valueEmail, " +
                    "rozsilka=@valueCheckEmail, dateBirth=@valueDateBirth, dateRegistr=@valueDateRegistr, gender=@valueGender "+
                    "WHERE id="+id.ToString(), connection);
                command.Parameters.AddWithValue("@valueCard", getCard());
                command.Parameters.AddWithValue("@valueSurname", getSurname());
                command.Parameters.AddWithValue("@valueName", getName());
                command.Parameters.AddWithValue("@valueLastname", getLastname());
                command.Parameters.AddWithValue("@valuePhone", getPhone());
                command.Parameters.AddWithValue("@valueEmail", getEmail());
                command.Parameters.AddWithValue("@valueCheckEmail", getCheckEmail());
                command.Parameters.AddWithValue("@valueDateBirth", getDateBirth().Date.ToString());
                command.Parameters.AddWithValue("@valueDateRegistr", getDateRegistr().Date.ToString());
                command.Parameters.AddWithValue("@valueGender", getGender());

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
    }
}
