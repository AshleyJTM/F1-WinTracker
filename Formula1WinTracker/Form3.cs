using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formula1WinTracker
{
	public partial class Form3 : Form
	{
		public Form3()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string connectionString = Formula1WinTracker.Properties.Settings.Default.Database1ConnectionString;
			SqlConnection connect = new SqlConnection(connectionString);

            //Search string from the text box
            string searchStringSQL;

            if (textBox1.Text == "All")
            {
                searchStringSQL = "SELECT * FROM F1RaceWins;";
            }
            else
            {
                searchStringSQL = "SELECT * FROM F1RaceWins WHERE Driver like '%" + textBox1.Text + "%'";
            }

            //Open database connection while running search
			connect.Open();
			SqlCommand databaseCommand = new SqlCommand(searchStringSQL, connect);

            //Collecting data
			DataTable table = new DataTable();
			SqlDataAdapter dta = new SqlDataAdapter(databaseCommand);
			dta.Fill(table);

            //Close database connection
			connect.Close();

            //Filling the listbox with search data
            int numberOfResults = table.Rows.Count;

            listBox1.Items.Clear();

            if (numberOfResults > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    string line = "";
                    line += "Driver: " + row["Driver"] + "  |  ";
                    line += " Team: " + row["Team"] + "  |  ";
                    line += " Nationality: " + row["Nationality"] + "  |  ";
                    line += " Grand Prix: " + row["Grand Prix"] + "  |  ";
                    line += " Year: " + row["Year"];
                    listBox1.Items.Add(line);
                }
            }
            else
            {
				MessageBox.Show("Error: No Results Found");
			}
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            string connectionString = Formula1WinTracker.Properties.Settings.Default.Database1ConnectionString;
            SqlConnection connect = new SqlConnection(connectionString);

            //Open database connection
            connect.Open();

            //POPULATE Year Combo Box
            string SQL;
            SQL = "SELECT DISTINCT Year FROM F1RaceWins ORDER BY Year";
            SqlCommand databaseCommand = new SqlCommand(SQL, connect);

            //Collecting data
            DataTable table = new DataTable();
            SqlDataAdapter dta = new SqlDataAdapter(databaseCommand);
            dta.Fill(table);

            //Filling the listbox with search data
            int numberOfResults = table.Rows.Count;

            //comboBoxSearchYear.Items.Add("Search Year");

            if (numberOfResults > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    comboBoxSearchYear.Items.Add(row["Year"]);
                }
            }

            //POPULATE Nationality Combo Box
            string SQL2;
            SQL2 = "SELECT DISTINCT Nationality FROM F1RaceWins ORDER BY Nationality";
            SqlCommand databaseCommand2 = new SqlCommand(SQL2, connect);

            //Collecting data
            DataTable table2 = new DataTable();
            SqlDataAdapter dta2 = new SqlDataAdapter(databaseCommand2);
            dta2.Fill(table2);

            //Filling the listbox with search data
            int numberOfResults2 = table2.Rows.Count;

            //comboBoxSearchYear.Items.Add("Search Year");

            if (numberOfResults2 > 0)
            {
                foreach (DataRow row in table2.Rows)
                {
                    comboBoxSearchNation.Items.Add(row["Nationality"]);
                }
            }

            //POPULATE Grand Prix Combo Box
            string SQL3;
            SQL3 = "SELECT DISTINCT [Grand Prix] FROM F1RaceWins ORDER BY [Grand Prix]";
            SqlCommand databaseCommand3 = new SqlCommand(SQL3, connect);

            //Collecting data
            DataTable table3 = new DataTable();
            SqlDataAdapter dta3 = new SqlDataAdapter(databaseCommand3);
            dta3.Fill(table3);

            //Filling the listbox with search data
            int numberOfResults3 = table3.Rows.Count;

            //comboBoxSearchYear.Items.Add("Search Year");

            if (numberOfResults3 > 0)
            {
                foreach (DataRow row in table3.Rows)
                {
                    comboBoxSearchGP.Items.Add(row["Grand Prix"]);
                }
            }

            //POPULATE Team Combo Box
            string SQL4;
            SQL4 = "SELECT DISTINCT Team FROM F1RaceWins ORDER BY Team";
            SqlCommand databaseCommand4 = new SqlCommand(SQL4, connect);

            //Collecting data
            DataTable table4 = new DataTable();
            SqlDataAdapter dta4 = new SqlDataAdapter(databaseCommand4);
            dta4.Fill(table4);

            //Filling the listbox with search data
            int numberOfResults4 = table4.Rows.Count;

            if (numberOfResults4 > 0)
            {
                foreach (DataRow row in table4.Rows)
                {
                    comboBoxSearchTeam.Items.Add(row["Team"]);
                }
            }

            //Default values for comboBoxTeam
            comboBoxSearchTeam.Items.Insert(0, "--Team--");
            comboBoxSearchTeam.SelectedIndex = 0;

            //Default values for comboBoxYear
            comboBoxSearchYear.Items.Insert(0, "--Year--");
            comboBoxSearchYear.SelectedIndex = 0;

            //Default values for comboBoxGP
            comboBoxSearchGP.Items.Insert(0, "--Grand Prix--");
            comboBoxSearchGP.SelectedIndex = 0;

            //Default values for comboBoxNation
            comboBoxSearchNation.Items.Insert(0, "--Nationality--");
            comboBoxSearchNation.SelectedIndex = 0;

            //Close database connection
            connect.Close();

        }

        private void comboBoxSearchYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ( comboBoxSearchYear.SelectedIndex == 0 )
            {
                return;
            }

            string connectionString = Formula1WinTracker.Properties.Settings.Default.Database1ConnectionString;
            SqlConnection connect = new SqlConnection(connectionString);

            //Search string from the text box
            string searchStringSQL;
            searchStringSQL = "SELECT * FROM F1RaceWins WHERE Year = '" + comboBoxSearchYear.Text + "'";
            
            //Open database connection while running search
            connect.Open();
            SqlCommand databaseCommand = new SqlCommand(searchStringSQL, connect);

            //Collecting data
            DataTable table = new DataTable();
            SqlDataAdapter dta = new SqlDataAdapter(databaseCommand);
            dta.Fill(table);

            //Close database connection
            connect.Close();

            //Filling the listbox with search data
            int numberOfResults = table.Rows.Count;

            //Clear listbox
            listBox1.Items.Clear();

            if (numberOfResults > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    string line = "";
                    line += "Driver: " + row["Driver"] + "  |  ";
                    line += " Team: " + row["Team"] + "  |  ";
                    line += " Nationality: " + row["Nationality"] + "  |  ";
                    line += " Grand Prix: " + row["Grand Prix"] + "  |  ";
                    line += " Year: " + row["Year"];
                    listBox1.Items.Add(line);
                }
            }
            else
            {
                MessageBox.Show("Error: No Results Found");
            }
        }

        private void comboBoxSearchNation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSearchNation.SelectedIndex == 0)
            {
                return;
            }

            string connectionString = Formula1WinTracker.Properties.Settings.Default.Database1ConnectionString;
            SqlConnection connect = new SqlConnection(connectionString);

            //Search string from the text box
            string searchStringSQL;
            searchStringSQL = "SELECT * FROM F1RaceWins WHERE Nationality = '" + comboBoxSearchNation.Text + "'";

            //Open database connection while running search
            connect.Open();
            SqlCommand databaseCommand = new SqlCommand(searchStringSQL, connect);

            //Collecting data
            DataTable table = new DataTable();
            SqlDataAdapter dta = new SqlDataAdapter(databaseCommand);
            dta.Fill(table);

            //Close database connection
            connect.Close();

            //Filling the listbox with search data
            int numberOfResults = table.Rows.Count;

            //Clear listbox
            listBox1.Items.Clear();

            if (numberOfResults > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    string line = "";
                    line += "Driver: " + row["Driver"] + "  |  ";
                    line += " Team: " + row["Team"] + "  |  ";
                    line += " Nationality: " + row["Nationality"] + "  |  ";
                    line += " Grand Prix: " + row["Grand Prix"] + "  |  ";
                    line += " Year: " + row["Year"];
                    listBox1.Items.Add(line);
                }
            }
            else
            {
                MessageBox.Show("Error: No Results Found");
            }
        }

        private void comboBoxSearchGP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSearchGP.SelectedIndex == 0)
            {
                return;
            }

            string connectionString = Formula1WinTracker.Properties.Settings.Default.Database1ConnectionString;
            SqlConnection connect = new SqlConnection(connectionString);

            //Search string from the text box
            string searchStringSQL;
            searchStringSQL = "SELECT * FROM F1RaceWins WHERE [Grand Prix] = '" + comboBoxSearchGP.Text + "'";

            //Open database connection while running search
            connect.Open();
            SqlCommand databaseCommand = new SqlCommand(searchStringSQL, connect);

            //Collecting data
            DataTable table = new DataTable();
            SqlDataAdapter dta = new SqlDataAdapter(databaseCommand);
            dta.Fill(table);

            //Close database connection
            connect.Close();

            //Filling the listbox with search data
            int numberOfResults = table.Rows.Count;

            //Clear listbox
            listBox1.Items.Clear();

            if (numberOfResults > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    string line = "";
                    line += "Driver: " + row["Driver"] + "  |  ";
                    line += " Team: " + row["Team"] + "  |  ";
                    line += " Nationality: " + row["Nationality"] + "  |  ";
                    line += " Grand Prix: " + row["Grand Prix"] + "  |  ";
                    line += " Year: " + row["Year"];
                    listBox1.Items.Add(line);
                }
            }
            else
            {
                MessageBox.Show("Error Message: No Results Found.");
            }
        }

        private void comboBoxSearchTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSearchTeam.SelectedIndex == 0)
            {
                return;
            }

            string connectionString = Formula1WinTracker.Properties.Settings.Default.Database1ConnectionString;
            SqlConnection connect = new SqlConnection(connectionString);

            //Search string from the text box
            string searchStringSQL;
            searchStringSQL = "SELECT * FROM F1RaceWins WHERE Team = '" + comboBoxSearchTeam.Text + "'";

            //Open database connection while running search
            connect.Open();
            SqlCommand databaseCommand = new SqlCommand(searchStringSQL, connect);

            //Collecting data
            DataTable table = new DataTable();
            SqlDataAdapter dta = new SqlDataAdapter(databaseCommand);
            dta.Fill(table);

            //Close database connection
            connect.Close();

            //Filling the listbox with search data
            int numberOfResults = table.Rows.Count;

            //Clear listbox
            listBox1.Items.Clear();

            if (numberOfResults > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    string line = "";
                    line += "Driver: " + row["Driver"] + "  |  ";
                    line += " Team: " + row["Team"] + "  |  ";
                    line += " Nationality: " + row["Nationality"] + "  |  ";
                    line += " Grand Prix: " + row["Grand Prix"] + "  |  ";
                    line += " Year: " + row["Year"];
                    listBox1.Items.Add(line);
                }
            }
            else
            {
                MessageBox.Show("Error Message: No Results Found.");
            }
        }
    }
 }
  
