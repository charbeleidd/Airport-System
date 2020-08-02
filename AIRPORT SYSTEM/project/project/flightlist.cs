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
    public partial class flightlist : Form
    {
        public flightlist()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-IPDREAN\\SQLEXPRESS2019;Initial Catalog =Flightservice;" + "Integrated Security=True";
            SqlConnection sqlconnection = new SqlConnection();
            SqlCommand selectCommand;
            SqlDataReader custReader;
            DataTable table = new DataTable();
            try
            {
                sqlconnection.ConnectionString = connectionString;
                sqlconnection.Open();
                 string selectStatement = "select [ticketid],[firstname],[lastname],[name],[departcountry],[arrivecountry],[departtime],[price],[gate],[capacity] from [dbo].[ticket] " +

                    "inner join [dbo].[passenger] on [dbo].[ticket].[nameid]=[dbo].[passenger].[passengerid] " +

                    "inner join [dbo].[plane] on [dbo].[ticket].[planeid]=[dbo].[plane].[planeId]";
              
                selectCommand = new SqlCommand(selectStatement, sqlconnection);

                custReader = selectCommand.ExecuteReader(CommandBehavior.CloseConnection);

                table.Columns.Add("Ticket ID");
               
                table.Columns.Add("FIRST Name");
               table.Columns.Add("LAST Name");
                table.Columns.Add("Depart Country");
                table.Columns.Add("Arrive Country");
                table.Columns.Add("Depart Time");
                
                table.Columns.Add("Price");
                table.Columns.Add("Gate");
                table.Columns.Add("Plane name");
                table.Columns.Add("Plane capacity");
               
                while (custReader.Read())
                {
                    DataRow row = table.NewRow();
                    row["Ticket ID"] = custReader["ticketid"];
                    
                    row["FIRST Name"] = custReader["firstname"];
                    row["LAST Name"] = custReader["lastname"];
                    row["Depart Country"] = custReader["departcountry"];
                    row["Arrive Country"] = custReader["arrivecountry"];
                    row["Depart Time"] = custReader["departtime"];
                    row["Price"] = custReader["price"];
                    row["Gate"] = custReader["gate"];
                    row["Plane name"] = custReader["name"];
                    row["Plane capacity"] = custReader["capacity"];
                    
                    table.Rows.Add(row);
                }
                list.DataSource = table;
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "connection failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=DESKTOP-IPDREAN\\SQLEXPRESS2019;Initial Catalog =Flightservice;" + "Integrated Security=True";
                SqlConnection sqlconnection = new SqlConnection();
                SqlCommand selectCommand;

                sqlconnection.ConnectionString = connectionString;
                sqlconnection.Open();
                string selectStatement = "delete from [dbo].[ticket] where [ticketid]='" + this.ticketid.Text + "';";
                selectCommand = new SqlCommand(selectStatement, sqlconnection);
                selectCommand.ExecuteReader();
                sqlconnection.Close();
                MessageBox.Show("delete successefully", "DONE");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "connection failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Ticketid_TextChanged(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-IPDREAN\\SQLEXPRESS2019;Initial Catalog =Flightservice;" + "Integrated Security=True";
            SqlConnection sqlconnection = new SqlConnection();
            SqlCommand selectCommand;
            SqlDataReader custReader;

            try
            {
                sqlconnection.ConnectionString = connectionString;
                sqlconnection.Open();
                string selectStatement = "SELECT * FROM ticket  where [ticketid]='" + this.ticketid.Text + "';";
                selectCommand = new SqlCommand(selectStatement, sqlconnection);
                custReader = selectCommand.ExecuteReader(CommandBehavior.CloseConnection);


                while (custReader.Read())
                {


                    dateTimePicker9.Text = custReader["departtime"].ToString();
                    


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "connection failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=DESKTOP-IPDREAN\\SQLEXPRESS2019;Initial Catalog =Flightservice;" + "Integrated Security=True";
                SqlConnection sqlconnection = new SqlConnection();
                SqlCommand selectCommand;

                sqlconnection.ConnectionString = connectionString;
                sqlconnection.Open();
                string selectStatement = "update [dbo].[ticket] set [departtime]='" + dateTimePicker9.Text + "' where [ticketid]='" + this.ticketid.Text + "'; ";
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

