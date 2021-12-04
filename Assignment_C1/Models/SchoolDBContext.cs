﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace Assignment_C1.Models
{
    public class SchoolDBContext
    {
        private static string User { get { return "root"; } }
        private static string Password { get { return ""; } }
        private static string Database { get { return "schooldb"; } }
        private static string Server { get { return "localhost"; } }
        private static string Port { get { return "3306"; } }

        protected static string ConnectionString
        {
            get
            {
                return "server = " + Server
                    + "; user = " + User
                    + ";database = " + Database
                    + "; port = " + Port
                    + "; password = " + Password;
            }
        }


        public MySqlConnection AccessDatabase()
        {
            return new MySqlConnection(ConnectionString);
        }


    }

}