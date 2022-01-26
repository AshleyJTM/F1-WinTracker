namespace Formula1WinTracker
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.database1DataSet = new Formula1WinTracker.Database1DataSet();
            this.f1RaceWinsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.f1RaceWinsTableAdapter = new Formula1WinTracker.Database1DataSetTableAdapters.F1RaceWinsTableAdapter();
            this.tableAdapterManager = new Formula1WinTracker.Database1DataSetTableAdapters.TableAdapterManager();
            this.f1RaceWinsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelID = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f1RaceWinsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f1RaceWinsDataGridView)).BeginInit();
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
            // f1RaceWinsDataGridView
            // 
            this.f1RaceWinsDataGridView.AutoGenerateColumns = false;
            this.f1RaceWinsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.f1RaceWinsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.f1RaceWinsDataGridView.DataSource = this.f1RaceWinsBindingSource;
            this.f1RaceWinsDataGridView.Location = new System.Drawing.Point(23, 102);
            this.f1RaceWinsDataGridView.Name = "f1RaceWinsDataGridView";
            this.f1RaceWinsDataGridView.Size = new System.Drawing.Size(409, 241);
            this.f1RaceWinsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Driver";
            this.dataGridViewTextBoxColumn2.HeaderText = "Driver";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Team";
            this.dataGridViewTextBoxColumn3.HeaderText = "Team";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Nationality";
            this.dataGridViewTextBoxColumn4.HeaderText = "Nationality";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Grand Prix";
            this.dataGridViewTextBoxColumn5.HeaderText = "Grand Prix";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Year";
            this.dataGridViewTextBoxColumn6.HeaderText = "Year";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Crimson;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(332, 42);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(89, 37);
            this.buttonDelete.TabIndex = 26;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.BackColor = System.Drawing.Color.Transparent;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(40, 46);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(35, 24);
            this.labelID.TabIndex = 21;
            this.labelID.Text = "ID:";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(81, 50);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(245, 20);
            this.textBoxID.TabIndex = 15;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(457, 355);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.f1RaceWinsDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "F1 - Delete Entries";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f1RaceWinsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f1RaceWinsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource f1RaceWinsBindingSource;
        private Database1DataSetTableAdapters.F1RaceWinsTableAdapter f1RaceWinsTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView f1RaceWinsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox textBoxID;
    }
}