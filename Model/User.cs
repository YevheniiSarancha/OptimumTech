﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Optimum_Tech.Model.Interfaces;
using OptimumTech.Controls;

namespace Optimum_Tech.Model
{
    internal class User
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public Access Access { get; set; }
        public List<ProductControl> Favorites = new List<ProductControl>();
        public List<ProductControl> Selections = new List<ProductControl>();

        public User(string login, string password)
        {
            Login = login;
            Password = password;
        }
    }

    enum Access 
    {
        Admin, Guest, User
    }
}