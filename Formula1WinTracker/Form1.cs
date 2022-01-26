using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formula1WinTracker
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			Form2 theForm = new Form2();
			theForm.ShowDialog();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Form3 theForm = new Form3();
			theForm.ShowDialog();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Form4 theForm = new Form4();
			theForm.ShowDialog();
		}

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by: Ashley Tanner-Mortell \nEmail: N0878275@my.ntu.ac.uk \nYear: 2021");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 theForm = new Form5();
            theForm.ShowDialog();
        }
    }
}
