using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Reflection.Metadata;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media.Media3D;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace CP2
{
    public static class DatabaseConfig
    {
        private const string Server = "localhost";
        private const string Database = "Escola";
        private const string User = "root";
        private const string Password = "fiap";
        private const int Port = 3306;

        private static readonly string ConnectionString =
            $"Server={Server};Port={Port};Database={Database};Uid={User};Pwd={Password};";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }
    }
}


