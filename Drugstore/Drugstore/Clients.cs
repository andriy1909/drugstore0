using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

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

        public Clients()
        {

        }
        public Clients(int id, string surname, string name, string lastname, string email, bool checkEmail, DateTime dateBirth, DateTime dateRegistr, bool gender)
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
        public Clients(int id, string surname, string name, string lastname, string phone, DateTime dateBirth, DateTime dateRegistr, bool gender)
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
        public Clients(int id, string surname, string name, string lastname, string phone, string email, bool checkEmail, DateTime dateBirth, DateTime dateRegistr, bool gender)
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

        public void setClient(int id, string surname, string name, string lastname, string email, bool checkEmail, DateTime dateBirth, DateTime dateRegistr, bool gender)
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
        public void setClient(int id, string surname, string name, string lastname, string phone, DateTime dateBirth, DateTime dateRegistr, bool gender)
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
        public void setClient(int id, string surname, string name, string lastname, string phone, string email, bool checkEmail, DateTime dateBirth, DateTime dateRegistr, bool gender)
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

        public void getDataClient(int id)
        {

        }
    }
}
