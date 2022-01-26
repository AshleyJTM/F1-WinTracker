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
	public partial class Form4 : Form
	{
		public Form4()
		{
			InitializeComponent();
		}

		private void Form4_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'database1DataSet.F1RaceWins' table. You can move, or remove it, as needed.
			this.f1RaceWinsTableAdapter.Fill(this.database1DataSet.F1RaceWins);

            //Titles for charts
            chart1.Titles.Add("Wins by Drivers");
            chart1.ChartAreas[0].AxisX.Title = "Drivers";
            chart1.ChartAreas[0].AxisY.Title = "Wins";

            string connectionString = Formula1WinTracker.Properties.Settings.Default.Database1ConnectionString;
            SqlConnection connect = new SqlConnection(connectionString);

            //Connect to database
            connect.Open();

            //Count data and group for graph
            string SQL;
            SQL = "SELECT Driver, COUNT(1) AS Wins FROM F1RaceWins GROUP BY Driver";
            SqlCommand databaseCommand = new SqlCommand(SQL, connect);

            //Collecting data
            DataTable table = new DataTable();
            SqlDataAdapter dta = new SqlDataAdapter(databaseCommand);
            dta.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                chart1.Series["TotalWins"].Points.AddXY(row["Driver"], row["Wins"]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Clear chart1
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
                chart1.Titles.Clear();
            }

            //Titles for charts
            chart1.Titles.Add("Wins by Drivers");
            chart1.ChartAreas[0].AxisX.Title = "Drivers";
            chart1.ChartAreas[0].AxisY.Title = "Wins";

            string connectionString = Formula1WinTracker.Properties.Settings.Default.Database1ConnectionString;
            SqlConnection connect = new SqlConnection(connectionString);
            
            //Connect to database
            connect.Open();

            //Count data and group for graph
            string SQL;
            SQL = "SELECT Driver, COUNT(1) AS Wins FROM F1RaceWins GROUP BY Driver";
            SqlCommand databaseCommand = new SqlCommand(SQL, connect);

            //Collecting data
            DataTable table = new DataTable();
            SqlDataAdapter dta = new SqlDataAdapter(databaseCommand);
            dta.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                chart1.Series["TotalWins"].Points.AddXY(row["Driver"], row["Wins"]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Clear chart1
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
                chart1.Titles.Clear();
            }

            //Titles for charts
            chart1.Titles.Add("Wins by Teams");
            chart1.ChartAreas[0].AxisX.Title = "Teams";
            chart1.ChartAreas[0].AxisY.Title = "Wins";

            //Connect to database
            string connectionString = Formula1WinTracker.Properties.Settings.Default.Database1ConnectionString;
            SqlConnection connect = new SqlConnection(connectionString);
            connect.Open();

            //Count data and group for graph
            string SQL;
            SQL = "SELECT Team, COUNT(1) AS Wins FROM F1RaceWins GROUP BY Team";
            SqlCommand databaseCommand = new SqlCommand(SQL, connect);

            //Collecting data
            DataTable table = new DataTable();
            SqlDataAdapter dta = new SqlDataAdapter(databaseCommand);
            dta.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                chart1.Series["TotalWins"].Points.AddXY(row["Team"], row["Wins"]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Clear chart1
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
                chart1.Titles.Clear();
            }

            //Titles for charts
            chart1.Titles.Add("Wins by Nationality");
            chart1.ChartAreas[0].AxisX.Title = "Nationality";
            chart1.ChartAreas[0].AxisY.Title = "Wins";

            //Connect to database
            string connectionString = Formula1WinTracker.Properties.Settings.Default.Database1ConnectionString;
            SqlConnection connect = new SqlConnection(connectionString);
            connect.Open();

            //Count data and group for graph
            string SQL;
            SQL = "SELECT Nationality, COUNT(1) AS Wins FROM F1RaceWins GROUP BY Nationality";
            SqlCommand databaseCommand = new SqlCommand(SQL, connect);

            //Collecting data
            DataTable table = new DataTable();
            SqlDataAdapter dta = new SqlDataAdapter(databaseCommand);
            dta.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                chart1.Series["TotalWins"].Points.AddXY(row["Nationality"], row["Wins"]);
            }
        }
    }
}
