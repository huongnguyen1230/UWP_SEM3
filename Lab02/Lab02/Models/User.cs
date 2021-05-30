using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02.Models
{
    class User
    {
        private string name;
        private string email;
        private string content;


        public User(string name, string email, string content)
        {
            Name = name;
            Email = email;
            Content = content;
        }
        public string Name
        {
            get => name;
            set => name = value;
        }
        public string Email
        {
            get => email;
            set => email = value;
        }
        public string Content
        {
            get => content;
            set => content = value;
        }

    }
}
