using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Drugstore
{
    public class Person
    {
        int id;
        string surname;
        string name;
        string lastname;
        string phone;
        string email;
        DateTime dateBirth;
        bool gender; //true-man | false-woman

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
        public DateTime getDateBirth()
        {
            return dateBirth;
        }
        public bool getGender()
        {
            return gender;
        }

        public string ToUpLower(string str)
        {
            return str.Remove(1).ToUpper() + str.Remove(0, 1).ToLower();
        }

        public void setId(int id)
        {
            this.id = id;
        }
        public void setSurname(string surname)
        {
            this.surname = ToUpLower(surname);
        }
        public void setName(string name)
        {
            this.name = ToUpLower(name);
        }
        public void setLastname(string lastname)
        {
            this.lastname = ToUpLower(lastname);
        }
        public void setPhone(string phone)
        {
            this.phone = phone;
        }
        public void setEmail(string email)
        {
            this.email = email;
        }
        public void setDateBirth(DateTime date)
        {
            dateBirth = date;
        }
        public void setGender(bool gender)
        {
            this.gender = gender;
        }
    }
}
