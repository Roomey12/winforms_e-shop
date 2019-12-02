using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class Client
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Card { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        // parol?
    }

    /*class UnReg_Client
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
    }
    
    class Reg_Client : UnReg_Client
    {
        public string City { get; set; }
        public string Street { get; set; }
        public int Card { get; set; }
    }*/
}
