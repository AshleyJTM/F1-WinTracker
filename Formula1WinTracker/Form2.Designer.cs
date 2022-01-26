namespace Formula1WinTracker
{
	partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.database1DataSet = new Formula1WinTracker.Database1DataSet();
            this.f1RaceWinsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.f1RaceWinsTableAdapter = new Formula1WinTracker.Database1DataSetTableAdapters.F1RaceWinsTableAdapter();
            this.tableAdapterManager = new Formula1WinTracker.Database1DataSetTableAdapters.TableAdapterManager();
            this.textBoxDriver = new System.Windows.Forms.TextBox();
            this.textBoxTeam = new System.Windows.Forms.TextBox();
            this.textBoxNation = new System.Windows.Forms.TextBox();
            this.textBoxGP = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f1RaceWinsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.F1RaceWinsTableAdapter = this.f1RaceWinsTableAdapter;
            this.tableAdapterManager.UpdateOrder = Formula1WinTracker.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // textBoxDriver
            // 
            this.textBoxDriver.Location = new System.Drawing.Point(94, 47);
            this.textBoxDriver.Name = "textBoxDriver";
            this.textBoxDriver.Size = new System.Drawing.Size(227, 20);
            this.textBoxDriver.TabIndex = 2;
            // 
            // textBoxTeam
            // 
            this.textBoxTeam.Location = new System.Drawing.Point(94, 73);
            this.textBoxTeam.Name = "textBoxTeam";
            this.textBoxTeam.Size = new System.Drawing.Size(227, 20);
            this.textBoxTeam.TabIndex = 3;
            // 
            // textBoxNation
            // 
            this.textBoxNation.Location = new System.Drawing.Point(94, 99);
            this.textBoxNation.Name = "textBoxNation";
            this.textBoxNation.Size = new System.Drawing.Size(227, 20);
            this.textBoxNation.TabIndex = 4;
            // 
            // textBoxGP
            // 
            this.textBoxGP.Location = new System.Drawing.Point(94, 125);
            this.textBoxGP.Name = "textBoxGP";
            this.textBoxGP.Size = new System.Drawing.Size(227, 20);
            this.textBoxGP.TabIndex = 5;
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(94, 151);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(227, 20);
            this.textBoxYear.TabIndex = 6;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(94, 193);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(83, 46);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Driver:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Team:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nationality:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Grand Prix:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Year:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(183, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 46);
            this.button1.TabIndex = 14;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.AliceBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(298, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 26);
            this.button2.TabIndex = 15;
            this.button2.Text = "Help";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(356, 251);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.textBoxGP);
            this.Controls.Add(this.textBoxNation);
            this.Controls.Add(this.textBoxTeam);
            this.Controls.Add(this.textBoxDriver);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "F1 - Add Entries";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f1RaceWinsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Database1DataSet database1DataSet;
		private System.Windows.Forms.BindingSource f1RaceWinsBindingSource;
		private Database1DataSetTableAdapters.F1RaceWinsTableAdapter f1RaceWinsTableAdapter;
		private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox textBoxDriver;
        private System.Windows.Forms.TextBox textBoxTeam;
        private System.Windows.Forms.TextBox textBoxNation;
        private System.Windows.Forms.TextBox textBoxGP;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}