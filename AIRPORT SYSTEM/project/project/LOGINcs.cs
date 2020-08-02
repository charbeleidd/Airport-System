using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace project
{
    public partial class LOGINcs : Form
    {
        public LOGINcs()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "") MessageBox.Show("please fill all fields");
            else
            {
                try
                {
                    string str_pass = "";


                    string connectionString = "Data Source=DESKTOP-IPDREAN\\SQLEXPRESS2019;Initial Catalog =Flightservice;" + "Integrated Security=True";
                    SqlConnection sqlconnection = new SqlConnection();
                    

                    sqlconnection.ConnectionString = connectionString;

                    sqlconnection.Open();

                    SqlCommand login = new SqlCommand("select [password] from [dbo].[login] " +

                        "where  [username]= '" + textBox1.Text + "'", sqlconnection);

                    SqlDataReader PASS_Reader = login.ExecuteReader();

               

                    while (PASS_Reader.Read())
                    {
                        str_pass = PASS_Reader[0].ToString();
                    }

                    if (str_pass.Equals(textBox2.Text))
                    {
                        sqlconnection.Close();
                        Form login_form = new Main();
                        login_form.Show(); 

                    }
                    else { MessageBox.Show("Invalid UserName or Password", "LOGIN"); }
                    textBox1.Clear();
                    textBox2.Clear();
                }
                catch (SqlException ex)
                {
                MessageBox.Show(ex.ToString()); 
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LOGINcs_Load(object sender, EventArgs e)
        {

        }
    }
}
