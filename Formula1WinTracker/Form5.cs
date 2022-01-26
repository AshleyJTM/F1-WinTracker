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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void f1RaceWinsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.f1RaceWinsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.F1RaceWins' table. You can move, or remove it, as needed.
            this.f1RaceWinsTableAdapter.Fill(this.database1DataSet.F1RaceWins);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text.Length > 0 && textBoxID.Text.All(char.IsDigit))
            {
                string connectionString = Formula1WinTracker.Properties.Settings.Default.Database1ConnectionString;
                SqlConnection connect = new SqlConnection(connectionString);

                string deleteString = "DELETE FROM F1RaceWins WHERE Id =" + "'" + textBoxID.Text + "';";

                SqlCommand deleteCommand = new SqlCommand(deleteString, connect);
                connect.Open();
                deleteCommand.ExecuteNonQuery();
                connect.Close();

                MessageBox.Show("Message: Entry " + textBoxID.Text + " has been deleted");

                //this.f1RaceWinsDataGridView.RefreshEdit();
            }
            else
            {
                MessageBox.Show("Error: Input field missing, make sure you've filled all the boxes and only use digits");
            }
            textBoxID.Clear();
        }

    }
}
