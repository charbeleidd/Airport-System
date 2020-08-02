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
    public partial class nameverification : Form
    {
        public nameverification()
        {
            InitializeComponent();
            
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Add_Click(object sender, EventArgs e)
        {

            string connectionString = "Data Source=DESKTOP-IPDREAN\\SQLEXPRESS2019;Initial Catalog =Flightservice;" + "Integrated Security=True";
            SqlConnection sqlconnection = new SqlConnection();
            SqlCommand selectCommand;
            SqlDataReader R;
            
            try
            {   if(firstname3.Text=="" || lastname3.Text == "") { MessageBox.Show("enter a name ."); }
            // name existance verificaton 
                int name_verification = 0;

                sqlconnection.ConnectionString = connectionString;

                sqlconnection.Open();

                string selectStatement = "select [firstname],[lastname] From [dbo].[passenger] ";

                selectCommand = new SqlCommand(selectStatement, sqlconnection);


                R = selectCommand.ExecuteReader();
         
                while (R.Read())
                {
                    if(firstname3.Text==R[0].ToString()&&lastname3.Text==R[1].ToString())
                    {   //it's a flag to indicate if name exists or not
                        name_verification = 1;
                    }

                 
                }
                if(name_verification==1)
                {
                    MessageBox.Show("ALREADY REGISTERED!!");
                }
                else

                {
                    MessageBox.Show("ADD A NAME.");
                    Form name= new Passengers();
                    name.Show();
                  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "connection failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    private void Modify_Click(object sender, EventArgs e)
        {
            Form nameverification = new modification();
            DialogResult selectedbutton = nameverification.ShowDialog();
        }

        private void Showall_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-IPDREAN\\SQLEXPRESS2019;Initial Catalog =Flightservice;" + "Integrated Security=True";

            SqlConnection sqlconnection = new SqlConnection();

            SqlCommand selectCommand;

            SqlDataReader PASSENGER_Reader;

            DataTable ADD_TABLE = new DataTable();
            try
            {
                sqlconnection.ConnectionString = connectionString;
                sqlconnection.Open();
                string selectStatement = "SELECT * FROM passenger";

                selectCommand = new SqlCommand(selectStatement, sqlconnection);

                PASSENGER_Reader = selectCommand.ExecuteReader(CommandBehavior.CloseConnection);

               ADD_TABLE.Columns.Add("ID");

                ADD_TABLE.Columns.Add("FIRST Name");

                ADD_TABLE.Columns.Add("LAST Name");

                ADD_TABLE.Columns.Add("Age");

                ADD_TABLE.Columns.Add("Phone number");

                ADD_TABLE.Columns.Add("Gender");

                ADD_TABLE.Columns.Add("E-mail");
                
                while (PASSENGER_Reader.Read())
                {
                    DataRow NEW_ROW = ADD_TABLE.NewRow();

                    NEW_ROW["ID"] = PASSENGER_Reader["passengerid"];
                    NEW_ROW["FIRST Name"] = PASSENGER_Reader["firstname"];
                    NEW_ROW["LAST Name"] = PASSENGER_Reader["lastname"];
                    NEW_ROW["Age"] = PASSENGER_Reader["dateofbirth"];
                    NEW_ROW["Phone number"] = PASSENGER_Reader["phonenumber"];
                    NEW_ROW["Gender"] = PASSENGER_Reader["gender"];
                   NEW_ROW["E-mail"] = PASSENGER_Reader["email"];
                   
                    ADD_TABLE.Rows.Add(NEW_ROW);
                }


                allpass.DataSource = ADD_TABLE;
               


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
                string selectStatement = "delete from [dbo].[passenger] where [passengerid]='" + this.passengerid.Text + "';";
                selectCommand = new SqlCommand(selectStatement, sqlconnection);
                selectCommand.ExecuteNonQuery();
                sqlconnection.Close();
                MessageBox.Show("delete successefully", "DONE");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "connection failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Nameverification_Load(object sender, EventArgs e)
        {

        }

        private void allpass_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
