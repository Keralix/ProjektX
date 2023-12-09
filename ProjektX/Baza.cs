using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektX
{
    public class Baza
    {
        string connectionString =
            @"Provider=Microsoft.ACE.OLEDB.12.0;" +
            @"Data Source=baza.accdb;" +
            @"User Id=;Password=;";
        OleDbConnection connection;
        public void Connect()
        {
            connection = new OleDbConnection(connectionString);
            connection.Open();
        }

        public OleDbDataReader Read(string commandStr)
        {
            OleDbCommand command = new OleDbCommand(commandStr, connection);
            OleDbDataReader reader = command.ExecuteReader();
            return reader;
        }

        public void Insert(string commandStr)
        {
            OleDbCommand command = new OleDbCommand(commandStr, connection);
            command.ExecuteNonQuery();
        }
        public void Dissconect()
        {
            
            connection.Close();
        }
    }
}
