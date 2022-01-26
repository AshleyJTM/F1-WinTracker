namespace Formula1WinTracker
{
	partial class Form4
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.f1RaceWinsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new Formula1WinTracker.Database1DataSet();
            this.f1RaceWinsTableAdapter = new Formula1WinTracker.Database1DataSetTableAdapters.F1RaceWinsTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f1RaceWinsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.f1RaceWinsBindingSource;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(74, 44);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "TotalWins";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(651, 317);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // f1RaceWinsBindingSource
            // 
            this.f1RaceWinsBindingSource.DataMember = "F1RaceWins";
            this.f1RaceWinsBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // f1RaceWinsTableAdapter
            // 
            this.f1RaceWinsTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AliceBlue;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(210, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "Wins by Drivers";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.AliceBlue;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(330, 384);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 41);
            this.button2.TabIndex = 4;
            this.button2.Text = "Wins by Teams";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.AliceBlue;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(450, 384);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 41);
            this.button3.TabIndex = 5;
            this.button3.Text = "Wins by Nationality";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "F1 - Graphical Data";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f1RaceWinsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
		private Database1DataSet database1DataSet;
		private System.Windows.Forms.BindingSource f1RaceWinsBindingSource;
		private Database1DataSetTableAdapters.F1RaceWinsTableAdapter f1RaceWinsTableAdapter;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}