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
            button1.Visible = false;

            string sql = @"SELECT [name] FROM sys.Tables";
            SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["HwAdo_4.Properties.Settings.SalesConnectionString"].ConnectionString);
            Conn.Open();
            SqlDataAdapter DA = new SqlDataAdapter();
            SqlCommand comm = new SqlCommand(sql, Conn);
            SqlDataReader dr = comm.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr.GetString(0));
            }
            Conn.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Visible = true;
            LoadTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadTable();
        }

        private void LoadTable()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            var sd = comboBox1.AccessibilityObject.Value;

            SqlConnection myConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["HwAdo_4.Properties.Settings.SalesConnectionString"].ConnectionString);

            myConnection.Open();

            string query = $"SELECT * FROM [{sd}]";

            SqlCommand command = new SqlCommand(query, myConnection);

            SqlDataReader reader = command.ExecuteReader();

            for (var j = 0; j < reader.FieldCount; j++)
            {
                dataGridView1.Columns.Add(reader.GetName(j), reader.GetName(j));
            }

            while (reader.Read())
            {
                List<string> data = new List<string>();
                for (var i = 0; i < reader.FieldCount; i++)
                {
                    data.Add(reader[i].ToString());
                }
                dataGridView1.Rows.Add(data.ToArray());
            }
            reader.Close();

            myConnection.Close();
        }
    }
}
