using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HwAdo_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonRefresh.Visible = false;

            string sql = @"SELECT [name] FROM sys.Tables";
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["HwAdo_4.Properties.Settings.SalesConnectionString"].ConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                comboBoxTables.Items.Add(dataReader.GetString(0));
            }
            dataReader.Close();
            connection.Close();
        }

        private void comboBoxTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonRefresh.Visible = true;
            LoadTable();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadTable();
        }

        private void LoadTable()
        {
            dataGridViewRows.Rows.Clear();
            dataGridViewRows.Columns.Clear();

            var tableName = comboBoxTables.AccessibilityObject.Value;

            SqlConnection myConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["HwAdo_4.Properties.Settings.SalesConnectionString"].ConnectionString);

            myConnection.Open();

            string query = $"SELECT * FROM [{tableName}]";

            SqlCommand command = new SqlCommand(query, myConnection);

            SqlDataReader reader = command.ExecuteReader();

            for (var j = 0; j < reader.FieldCount; j++)
            {
                dataGridViewRows.Columns.Add(reader.GetName(j), reader.GetName(j));
            }

            while (reader.Read())
            {
                List<string> data = new List<string>();
                for (var i = 0; i < reader.FieldCount; i++)
                {
                    data.Add(reader[i].ToString());
                }
                dataGridViewRows.Rows.Add(data.ToArray());
            }
            reader.Close();

            myConnection.Close();
        }
    }
}
