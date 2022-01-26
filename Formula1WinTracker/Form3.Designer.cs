namespace Formula1WinTracker
{
	partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.database1DataSet = new Formula1WinTracker.Database1DataSet();
            this.f1RaceWinsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet1 = new Formula1WinTracker.Database1DataSet();
            this.f1RaceWinsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.f1RaceWinsTableAdapter = new Formula1WinTracker.Database1DataSetTableAdapters.F1RaceWinsTableAdapter();
            this.f1RaceWinsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxSearchYear = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxSearchNation = new System.Windows.Forms.ComboBox();
            this.comboBoxSearchGP = new System.Windows.Forms.ComboBox();
            this.comboBoxSearchTeam = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f1RaceWinsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f1RaceWinsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f1RaceWinsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AliceBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(675, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search Driver:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(125, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(542, 26);
            this.textBox1.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(21, 104);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(755, 334);
            this.listBox1.TabIndex = 8;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // f1RaceWinsBindingSource2
            // 
            this.f1RaceWinsBindingSource2.DataMember = "F1RaceWins";
            this.f1RaceWinsBindingSource2.DataSource = this.database1DataSet1;
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // f1RaceWinsBindingSource
            // 
            this.f1RaceWinsBindingSource.DataMember = "F1RaceWins";
            this.f1RaceWinsBindingSource.DataSource = this.database1DataSet;
            // 
            // f1RaceWinsTableAdapter
            // 
            this.f1RaceWinsTableAdapter.ClearBeforeFill = true;
            // 
            // f1RaceWinsBindingSource1
            // 
            this.f1RaceWinsBindingSource1.DataMember = "F1RaceWins";
            this.f1RaceWinsBindingSource1.DataSource = this.database1DataSet;
            // 
            // comboBoxSearchYear
            // 
            this.comboBoxSearchYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearchYear.FormattingEnabled = true;
            this.comboBoxSearchYear.Location = new System.Drawing.Point(139, 61);
            this.comboBoxSearchYear.Name = "comboBoxSearchYear";
            this.comboBoxSearchYear.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSearchYear.TabIndex = 3;
            this.comboBoxSearchYear.SelectedIndexChanged += new System.EventHandler(this.comboBoxSearchYear_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Quick Search:";
            // 
            // comboBoxSearchNation
            // 
            this.comboBoxSearchNation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearchNation.FormattingEnabled = true;
            this.comboBoxSearchNation.Location = new System.Drawing.Point(286, 61);
            this.comboBoxSearchNation.Name = "comboBoxSearchNation";
            this.comboBoxSearchNation.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSearchNation.TabIndex = 4;
            this.comboBoxSearchNation.SelectedIndexChanged += new System.EventHandler(this.comboBoxSearchNation_SelectedIndexChanged);
            // 
            // comboBoxSearchGP
            // 
            this.comboBoxSearchGP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearchGP.FormattingEnabled = true;
            this.comboBoxSearchGP.Location = new System.Drawing.Point(432, 63);
            this.comboBoxSearchGP.Name = "comboBoxSearchGP";
            this.comboBoxSearchGP.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSearchGP.TabIndex = 5;
            this.comboBoxSearchGP.SelectedIndexChanged += new System.EventHandler(this.comboBoxSearchGP_SelectedIndexChanged);
            // 
            // comboBoxSearchTeam
            // 
            this.comboBoxSearchTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearchTeam.FormattingEnabled = true;
            this.comboBoxSearchTeam.Location = new System.Drawing.Point(571, 64);
            this.comboBoxSearchTeam.Name = "comboBoxSearchTeam";
            this.comboBoxSearchTeam.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSearchTeam.TabIndex = 6;
            this.comboBoxSearchTeam.SelectedIndexChanged += new System.EventHandler(this.comboBoxSearchTeam_SelectedIndexChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxSearchTeam);
            this.Controls.Add(this.comboBoxSearchGP);
            this.Controls.Add(this.comboBoxSearchNation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxSearchYear);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "F1 - Search Database";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f1RaceWinsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f1RaceWinsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f1RaceWinsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.ListBox listBox1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource f1RaceWinsBindingSource;
        private Database1DataSetTableAdapters.F1RaceWinsTableAdapter f1RaceWinsTableAdapter;
        private System.Windows.Forms.BindingSource f1RaceWinsBindingSource1;
        private Database1DataSet database1DataSet1;
        private System.Windows.Forms.BindingSource f1RaceWinsBindingSource2;
        private System.Windows.Forms.ComboBox comboBoxSearchYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxSearchNation;
        private System.Windows.Forms.ComboBox comboBoxSearchGP;
        private System.Windows.Forms.ComboBox comboBoxSearchTeam;
    }
}