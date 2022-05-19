using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestMySQL
{
    public partial class Form1 : Form
    {
        private MySqlConnection connection;
        private MySqlCommand command;
        private MySqlDataReader reader;
        private string connectionString = "server=localhost;user id=root;database=habilitations;SslMode=none";

        public Form1()
        {
            InitializeComponent();
            InitConnection();
            RecupProfils();
        }

        private void InitConnection()
        {
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
            }catch(MySqlException e)
            {
                Console.WriteLine(e.Message);
                Environment.Exit(0);
            }
        }

        private void RecupProfils()
        {
            string query = "select * from profil";
            command = new MySqlCommand(query, connection);
            command.Prepare();
            reader = command.ExecuteReader();
            lstProfil.Items.Clear();
            while (reader.Read())
            {
                lstProfil.Items.Add(reader["nom"]);
            }
            reader.Close();
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            if (!txtNom.Text.Equals(""))
            {
                // construction de la requête
                string query = "insert into profil (nom) values (@nom)";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@nom", txtNom.Text);
                //exécution de la requête
                command = new MySqlCommand(query, connection);
                foreach (KeyValuePair<string, object> parameter in parameters)
                {
                    command.Parameters.Add(new MySqlParameter(parameter.Key, parameter.Value));
                }
                command.Prepare();
                command.ExecuteNonQuery();
                // met à jour liste
                RecupProfils();
                txtNom.Text = "";
            }
        }

        private void btnSuppr_Click(object sender, EventArgs e)
        {
            if (lstProfil.SelectedIndex != -1)
            {
                // construction de la requête
                string query = "delete from profil where nom = @nom";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@nom", lstProfil.SelectedItem);
                //exécution de la requête
                command = new MySqlCommand(query, connection);
                foreach (KeyValuePair<string, object> parameter in parameters)
                {
                    command.Parameters.Add(new MySqlParameter(parameter.Key, parameter.Value));
                }
                command.Prepare();
                command.ExecuteNonQuery();
                // met à jour liste
                RecupProfils();
            }
        }
    }
}
