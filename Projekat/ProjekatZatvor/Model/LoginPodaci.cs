using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatZatvor.Model
{
    public class LoginPodaci
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LoginPodaciId { get; set; }
        private String username;
        private String password;

        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public LoginPodaci(String user, String pass){

            Username = user;
            Password = pass;
        }

        public LoginPodaci()
        {
        }
    }
}
