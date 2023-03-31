using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CISESPORT.Info
{
    public class Player
    {
        public string SName { get; set; }
        public string LName { get; set; }
        public string Id { get; set; }
        public string Major { get; set; }
        public string Gname { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public int Age { get; set; }
        public Player(string name, string lastname, string id, string major, string gname, string mail, string phone, int age)
        {
            SName = name;
            LName = lastname;
            Id = id;
            Major = major;
            Gname = gname;
            Mail = mail;
            Phone = phone;
            Age = age;
        }
    }
}