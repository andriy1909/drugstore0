using System;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using Word = Microsoft.Office.Interop.Word;
using Exel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;

namespace Drugstore
{
    public class Clients : Person
    {
        string card;
        bool checkEmail;
        DateTime dateRegistr;
        string connectString;

        public Clients()
        {
            /*FileStream stream = new FileStream(Directory.GetCurrentDirectory() + "/Data/config.conf", FileMode.Open);
            StreamReader reader = new StreamReader(stream);
            string str = reader.ReadToEnd();
            stream.Close();*/
            connectString = @"Data Source=.\SQLEXPRESS; Initial Catalog = Drugstore; uid=sa; Integrated Security=SSPI;";
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

        public void printWord()
        {
            SqlConnection bd = new SqlConnection(connectString);
            bd.Open();
            SqlCommand command1 = new SqlCommand("SELECT * FROM Clients", bd);
            SqlDataReader dataReader1 = command1.ExecuteReader();
            
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Word Document File (*.docx)|*.docx|All files (*.*)|*.*";
            saveFileDialog1.ShowDialog();

            var wa = new Word.Application();
            Word.Document wd;
            Word.Paragraph wHeader;
            wa.Visible = false;
            wd = wa.Documents.Add();


            wHeader = wd.Content.Paragraphs.Add();
            wHeader.Range.Text += "Звіт";
            wHeader.Range.Font.Size = 16;
            wHeader.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            wHeader.Range.InsertParagraphAfter();



            Word.Paragraph wMainPar = wd.Content.Paragraphs.Add();
            wMainPar.Range.Font.Size = 14;
            int i = 1;
            while (dataReader1.Read())
            {
                setCard(dataReader1["card"].ToString().Trim());
                setSurname(dataReader1["surname"].ToString().Trim());
                setName(dataReader1["name"].ToString().Trim());
                setLastname(dataReader1["lastname"].ToString().Trim());
                setPhone(dataReader1["phone"].ToString().Trim());
               
                wMainPar.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                wMainPar.Range.Text += i.ToString() + ". " + getSurnameNL() + " - " + getPhone38() + " - card:" + getCard();
                wMainPar.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                i++;
            }

            wMainPar.Format.SpaceAfter = 24;
            wMainPar.Range.InsertParagraphAfter();

            wd.SaveAs(saveFileDialog1.FileName);
            wa.Quit();

            bd.Close();
        }

        public void printExcel()
        {
            SqlConnection bd = new SqlConnection(connectString);
            bd.Open();
            SqlCommand command1 = new SqlCommand("SELECT * FROM Clients", bd);
            SqlDataReader dataReader1 = command1.ExecuteReader();

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Exel Document File (*.xls)|*.xls";
            saveFileDialog1.ShowDialog();

            Exel.Application eApp = new Exel.Application();
            Exel._Workbook workbook = eApp.Workbooks.Add(Type.Missing);
            Exel._Worksheet worksheet = null;


            worksheet = workbook.ActiveSheet;
            worksheet.Name = "ExportedFromDatGrid";
            worksheet.Cells[1, 2] = "Звіт по персонажам.";

            worksheet.Cells[2, 1] = "№пп";

            worksheet.Cells[2, 2] = "ПІП";

            worksheet.Cells[2, 3] = "Телефон";

            worksheet.Cells[2, 4] = "Картка";

            int i = 1;
            while (dataReader1.Read())
            {
                setCard(dataReader1["card"].ToString().Trim());
                setSurname(dataReader1["surname"].ToString().Trim());
                setName(dataReader1["name"].ToString().Trim());
                setLastname(dataReader1["lastname"].ToString().Trim());
                setPhone(dataReader1["phone"].ToString().Trim());

                worksheet.Cells[i + 2, 1] = i;
                worksheet.Cells[i + 2, 2] = getSurnameNL();

                worksheet.Cells[i + 2, 3] = getPhone38();

                worksheet.Cells[i + 2, 4] = getCard();

                i++;
            }

            workbook.SaveAs(saveFileDialog1.FileName);
            eApp.Quit();
            workbook = null;
            eApp = null;

            bd.Close();
        }

        public void printReport()
        {

        }
    }
}
