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
    public partial class modification : Form
    {
        public modification()
        {
            InitializeComponent();
        }

        private void Modify_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=DESKTOP-IPDREAN\\SQLEXPRESS2019;Initial Catalog =Flightservice;" + "Integrated Security=True";
                SqlConnection sqlconnection = new SqlConnection();
                SqlCommand selectCommand;

                sqlconnection.ConnectionString = connectionString;
                sqlconnection.Open();
                string selectStatement = "update [dbo].[passenger] set " +

                    "[firstname]='" + Firstname.Text +

                    "',[lastname]='" + Lastname.Text + 

                    "',[dateofbirth]='" + dateTimePicker1.Text +

                    "',[email]='" + email.Text +

                    "',[phonenumber]='" + mobileno.Text +

                    "',[gender]='" + gender1.Text+

                    "'where [passengerid]='" + this.passengerid.Text +"'; ";

                selectCommand = new SqlCommand(selectStatement, sqlconnection);
                selectCommand.ExecuteReader();
                sqlconnection.Close();
                MessageBox.Show("Update successefully", "DONE");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "connection failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Get_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-IPDREAN\\SQLEXPRESS2019;Initial Catalog =Flightservice;" + "Integrated Security=True";
            SqlConnection sqlconnection = new SqlConnection();
            SqlCommand selectCommand;
            SqlDataReader custReader;
            
            try
            {
                sqlconnection.ConnectionString = connectionString;
                sqlconnection.Open();
                string selectStatement = "SELECT * FROM passenger  where [passengerid]='" + this.passengerid.Text + "';";
                selectCommand = new SqlCommand(selectStatement, sqlconnection);
                custReader = selectCommand.ExecuteReader(CommandBehavior.CloseConnection);
                
                
                while (custReader.Read())
                {


                    Firstname.Text = custReader["firstname"].ToString();
                    Lastname.Text = custReader["lastname"].ToString();
                    gender1.Text = custReader["gender"].ToString();
                    
                    dateTimePicker1.Text = custReader["dateofbirth"].ToString();
                   
                    mobileno.Text = custReader["phonenumber"].ToString();
                    email.Text = custReader["email"].ToString();
                    
                    
                    
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "connection failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void passengerid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
