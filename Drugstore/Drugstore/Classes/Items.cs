using System.Data;
using System.Data.SqlClient;

namespace Drugstore
{
    class Items
    {
        int id;
        string name;
        string category;
        string text;
        int count;
        double price;
        double discont;
        string image;
        string position;
        string connectString = @"Data Source=.\SQLEXPRESS; Initial Catalog = Drugstore; uid=sa; Integrated Security=SSPI;";

        public Items()
        {

        }
        public void setItem(int id, string name, string category, string text, int count, double price, double discont, string image, string position)
        {
            this.id = id;
            this.name = name;
            this.category = category;
            this.text = text;
            this.count = count;
            this.price = price;
            this.discont = discont;
            this.image = image;
            this.position = position;
        }

        public int getId()
        {
            return id;
        }
        public string getName()
        {
            return name;
        }
        public string getCategory()
        {
            return category;
        }
        public string getText()
        {
            return text;
        }
        public int getCount()
        {
            return count;
        }
        public double getPrice()
        {
            return price;
        }
        public double getDiscont()
        {
            return discont;
        }
        public string getImage()
        {
            return image;
        }
        public string getPosition()
        {
            return position;
        }

        public void setId(int value)
        {
            id = value;
        }
        public void setName(string value)
        {
            name = value;
        }
        public void setCategory(string value)
        {
            category = value;
        }
        public void setText(string value)
        {
            text = value;
        }
        public void setCount(int value)
        {
            count = value;
        }
        public void setPrice(double value)
        {
            price = value;
        }
        public void setDiscont(double value)
        {
            discont = value;
        }
        public void setImage(string value)
        {
            image = value;
        }
        public void setPosition(string value)
        {
            position = value;
        }

        public void getDataItem(int id)
        {
            SqlConnection bd = new SqlConnection(connectString);
            bd.Open();
            SqlCommand command1 = new SqlCommand("SELECT * FROM Item WHERE id=" + id.ToString(), bd);
            SqlDataReader dataReader1 = command1.ExecuteReader();
            while (dataReader1.Read())
            {
                setId(id);
                setName(dataReader1["name"].ToString().Trim());
                setCategory(dataReader1["category"].ToString().Trim());
                setText(dataReader1["text"].ToString().Trim());
                setCount((int)dataReader1["count"]);
                setPrice((double)dataReader1["price"]);
                setDiscont((double)dataReader1["discont"]);
                setImage(dataReader1["image"].ToString().Trim());
                setPosition(dataReader1["position"].ToString().Trim());
            }
            bd.Close();
        }

        public void insertItem()
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                SqlCommand command = new SqlCommand(
                    "INSERT INTO Item VALUES(@valueName, @valueCategory, @valueText, @valueCount, " +
                    "@valuePrice, @valueDiscont, @valueImage, @valuePosition)", connection);
                command.Parameters.AddWithValue("@valueName", getName());
                command.Parameters.AddWithValue("@valueCategory", getCategory());
                command.Parameters.AddWithValue("@valueText", getText());
                command.Parameters.AddWithValue("@valueCount", getCount());
                command.Parameters.AddWithValue("@valuePrice", getPrice());
                command.Parameters.AddWithValue("@valueDiscont", getDiscont());
                command.Parameters.AddWithValue("@valueImage", getImage());
                command.Parameters.AddWithValue("@valuePosition", getPosition());

                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void updateItem(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                SqlCommand command = new SqlCommand(
                    "UPDATE Item SET name=@valueName, category=@valueCategory, text=@valueText, count=@valueCount, " +
                    "price=@valuePrice, discont=@valueDiscont, image=@valueImage, position=@valuePosition " +
                    "WHERE id=" + id.ToString(), connection);
                command.Parameters.AddWithValue("@valueName", getName());
                command.Parameters.AddWithValue("@valueCategory", getCategory());
                command.Parameters.AddWithValue("@valueText", getText());
                command.Parameters.AddWithValue("@valueCount", getCount());
                command.Parameters.AddWithValue("@valuePrice", getPrice());
                command.Parameters.AddWithValue("@valueDiscont", getDiscont());
                command.Parameters.AddWithValue("@valueImage", getImage());
                command.Parameters.AddWithValue("@valuePosition", getPosition());

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
                    "DELETE FROM Item " +
                    "WHERE id=" + id.ToString(), connection);

                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public static DataSet getAllItems()
        {
            DataSet dataSet = new DataSet();
            string connectString = @"Data Source=.\SQLEXPRESS; Initial Catalog = Drugstore; uid=sa; Integrated Security=SSPI;";
            SqlConnection bd = new SqlConnection(connectString);
            bd.Open();
            SqlDataAdapter dataAdapter1 = new SqlDataAdapter("SELECT * FROM Item", bd);
            dataAdapter1.Fill(dataSet);
            bd.Close();
            return dataSet;
        }
    }
}
