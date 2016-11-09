using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drugstore
{
    public class User
    {
        public int id { get; set; }
        public string surname { get; set; }
        public string name { get; set; }
        public string lastname { get; set; }
        public string posada { get; set; }
        public int access { get; set; }

        public User()
        {
            posada = "";
            access = 4;
        }
        public User(int id,string surname, string name, string lastname,string posada)
        {
            this.id = id;
            this.surname = surname;
            this.name = name;
            this.lastname = lastname;
            this.posada = posada;
            if (posada == "Директор")
                access = 1;
            else
                if (posada == "Менеджер")
                access = 2;
            else
                if (posada == "Аптекар")
                access = 3;
            else
                access = 4;
        }
        public string getNameLastname()
        {
            return name + " " + surname;
        }
        public string getSurnameNL()
        {
            return surname + " " + name[0] + "." + lastname[0] + ".";
        }
        public string getUserName()
        {
            return surname + " " + name + " " + lastname;
        }
    }
}
