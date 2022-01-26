using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formula1WinTracker
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		private void f1RaceWinsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.f1RaceWinsBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.database1DataSet);
		}

		private void Form2_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'database1DataSet.F1RaceWins' table. You can move, or remove it, as needed.
			this.f1RaceWinsTableAdapter.Fill(this.database1DataSet.F1RaceWins);

            //Set default values for textbox on load
            textBoxDriver.Text = "e.g. Lewis Hamilton";
            textBoxTeam.Text = "e.g. Mercedes";
            textBoxNation.Text = "e.g. British";
            textBoxGP.Text = "e.g. Australian Grand Prix";
            textBoxYear.Text = "e.g. 2018";
        }
    
        //Error Handling
        private void button1_Click(object sender, EventArgs e)
        {
            String AllowedChars = @"^[a-zA-Z_ ]*$";

            string connectionString = Formula1WinTracker.Properties.Settings.Default.Database1ConnectionString;
            SqlConnection connect = new SqlConnection(connectionString);

            if (String.IsNullOrEmpty(textBoxDriver.Text) || String.IsNullOrEmpty(textBoxTeam.Text) || 
                String.IsNullOrEmpty(textBoxNation.Text) || String.IsNullOrEmpty(textBoxGP.Text) || String.IsNullOrEmpty(textBoxYear.Text))
            {
                MessageBox.Show("Error: Input field missing, make sure you've filled all the boxes");
            }
            else if (!Regex.IsMatch(textBoxDriver.Text, AllowedChars) || !Regex.IsMatch(textBoxTeam.Text, AllowedChars) || !Regex.IsMatch(textBoxNation.Text, AllowedChars) || !Regex.IsMatch(textBoxGP.Text, AllowedChars))
            {
                MessageBox.Show("Error: Please remove all symbols and digits from; Driver, Team, Nationality and Grand Prix");
            }
            else if (!textBoxGP.Text.Contains("Grand Prix"))
            {
                MessageBox.Show("Error: Format incorrect,  Grand Prix must contain 'Grand Prix' in the input");
            }
            else if (!textBoxYear.Text.All(char.IsDigit))
            {
                MessageBox.Show("Error: Inputted data for 'Year' must be a digit, follow the provided examples");
            }
            else
            {
                //Insert data into database
                string inputText = "INSERT INTO F1RaceWins (Driver, Team, Nationality, [Grand Prix], Year) VALUES ('" + textBoxDriver.Text + "', '" + textBoxTeam.Text + "', '" +
                textBoxNation.Text + "', '" + textBoxGP.Text + "', " + textBoxYear.Text + ");";
                //MessageBox.Show(inputText);
                MessageBox.Show("Message: Successfully added to database");

                //Connect, execute command and close database
                SqlCommand insertCommand = new SqlCommand(inputText, connect);
                connect.Open();
                insertCommand.ExecuteNonQuery();
                connect.Close();

                //Set default values for textbox
                textBoxDriver.Text = "e.g. Lewis Hamilton";
                textBoxTeam.Text = "e.g. MERCEDES";
                textBoxNation.Text = "e.g. British";
                textBoxGP.Text = "e.g. Australlian Grand Prix";
                textBoxYear.Text = "e.g. 2018";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Clear textbox
            textBoxDriver.Clear();
            textBoxTeam.Clear();
            textBoxNation.Clear();
            textBoxGP.Clear();
            textBoxYear.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Help message
            MessageBox.Show("If having trouble please press clear and follow the examples provided. Read the error messages " +
                "carefully to ensure you are putting in the correct data.");
        }
    }
}
