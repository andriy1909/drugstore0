using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Drugstore
{
    class Checks
    {
        int id;
        int cashierId;
        int clientId;
        DateTime dateTime;
        int itemId;
        int count;
        string connectString = @"Data Source=.\SQLEXPRESS; Initial Catalog = Drugstore; uid=sa; Integrated Security=SSPI;";

        public Checks()
        {

        }
        public void setCheck(int id, int cashier, int client, DateTime date, int item, int count)
        {
            setId(id);
            setCashierId(cashier);
            setClientId(clientId);
            setDateTime(date);
            setItemId(item);
            setCount(count);
        }

        public int getId()
        {
            return id;
        }
        public int getCashierId()
        {
            return cashierId;
        }
        public int getClientId()
        {
            return clientId;
        }
        public DateTime getDateTime()
        {
            return dateTime;
        }
        public int getItemId()
        {
            return itemId;
        }
        public int getCount()
        {
            return count;
        }

        public void setId(int id)
        {
            this.id = id;
        }
        public void setCashierId(int id)
        {
            cashierId = id;
        }
        public void setClientId(int id)
        {
            clientId = id;
        }
        public void setDateTime(DateTime date)
        {
            dateTime = date;
        }
        public void setItemId(int id)
        {
            itemId = id;
        }
        public void setCount(int value)
        {
            count = value;
        }

        public void getDataItem(int id)
        {
            SqlConnection bd = new SqlConnection(connectString);
            bd.Open();
            SqlCommand command1 = new SqlCommand("SELECT * FROM Check WHERE id=" + id.ToString(), bd);
            SqlDataReader dataReader1 = command1.ExecuteReader();
            while (dataReader1.Read())
            {
                setId(id);
                setCashierId((int)dataReader1["casir"]);
                setClientId((int)dataReader1["client"]);
                setDateTime((DateTime)dataReader1["date"]);
                setItemId((int)dataReader1["item"]);
                setCount((int)dataReader1["count"]);
            }
            bd.Close();
        }

        public void insertItem()
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                SqlCommand command = new SqlCommand(
                    "INSERT INTO Check VALUES(@valueId, @valueCasir, @valueClient, @valueDate, @valueItem, @valueCount)", connection);
                command.Parameters.AddWithValue("@valueId", getId());
                command.Parameters.AddWithValue("@valueCasir", getCashierId());
                command.Parameters.AddWithValue("@valueClient", getClientId());
                command.Parameters.AddWithValue("@valueDate", getDateTime());
                command.Parameters.AddWithValue("@valueItem", getItemId());
                command.Parameters.AddWithValue("@valueCount", getCount());

                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void updateItem(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                SqlCommand command = new SqlCommand(
                    "UPDATE Check SET id=@valueId, casir=@valueCasir, client=@valueClient, date=@valueDate, item=@valueItem, count=@valueCount WHERE id=" + id.ToString(), connection);
                command.Parameters.AddWithValue("@valueId", getId());
                command.Parameters.AddWithValue("@valueCasir", getCashierId());
                command.Parameters.AddWithValue("@valueClient", getClientId());
                command.Parameters.AddWithValue("@valueDate", getDateTime());
                command.Parameters.AddWithValue("@valueItem", getItemId());
                command.Parameters.AddWithValue("@valueCount", getCount());

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
                    "DELETE FROM Check " +
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
