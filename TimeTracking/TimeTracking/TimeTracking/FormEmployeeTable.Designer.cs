
namespace ProjectBD
{
    partial class FormEmployeeTable
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableEmployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proiectBDDataSet3 = new ProjectBD.ProiectBDDataSet3();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewEmployee = new Guna.UI2.WinForms.Guna2DataGridView();
            this.buttonAddEmployeeAcc = new System.Windows.Forms.Button();
            this.buttonEditEmployee = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tableEmployeeTableAdapter = new ProjectBD.ProiectBDDataSet3TableAdapters.TableEmployeeTableAdapter();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.phoneDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tableEmployeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proiectBDDataSet3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // tableEmployeeBindingSource
            // 
            this.tableEmployeeBindingSource.DataMember = "TableEmployee";
            this.tableEmployeeBindingSource.DataSource = this.proiectBDDataSet3;
            // 
            // proiectBDDataSet3
            // 
            this.proiectBDDataSet3.DataSetName = "ProiectBDDataSet3";
            this.proiectBDDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dataGridViewEmployee);
            this.panel1.Location = new System.Drawing.Point(32, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(819, 360);
            this.panel1.TabIndex = 1;
            // 
            // dataGridViewEmployee
            // 
            this.dataGridViewEmployee.AllowUserToAddRows = false;
            this.dataGridViewEmployee.AllowUserToDeleteRows = false;
            this.dataGridViewEmployee.AllowUserToResizeColumns = false;
            this.dataGridViewEmployee.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridViewEmployee.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewEmployee.AutoGenerateColumns = false;
            this.dataGridViewEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEmployee.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewEmployee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewEmployee.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewEmployee.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEmployee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewEmployee.ColumnHeadersHeight = 21;
            this.dataGridViewEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.phoneDataGridViewTextBoxColumn1,
            this.addressDataGridViewTextBoxColumn1,
            this.Column1,
            this.Column2,
            this.username,
            this.password});
            this.dataGridViewEmployee.DataSource = this.tableEmployeeBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewEmployee.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewEmployee.EnableHeadersVisualStyles = false;
            this.dataGridViewEmployee.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewEmployee.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewEmployee.Name = "dataGridViewEmployee";
            this.dataGridViewEmployee.ReadOnly = true;
            this.dataGridViewEmployee.RowHeadersVisible = false;
            this.dataGridViewEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEmployee.Size = new System.Drawing.Size(816, 357);
            this.dataGridViewEmployee.TabIndex = 1;
            this.dataGridViewEmployee.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewEmployee.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridViewEmployee.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridViewEmployee.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridViewEmployee.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridViewEmployee.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewEmployee.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewEmployee.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridViewEmployee.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewEmployee.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridViewEmployee.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewEmployee.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewEmployee.ThemeStyle.HeaderStyle.Height = 21;
            this.dataGridViewEmployee.ThemeStyle.ReadOnly = true;
            this.dataGridViewEmployee.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewEmployee.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewEmployee.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridViewEmployee.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewEmployee.ThemeStyle.RowsStyle.Height = 22;
            this.dataGridViewEmployee.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewEmployee.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewEmployee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // buttonAddEmployeeAcc
            // 
            this.buttonAddEmployeeAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.buttonAddEmployeeAcc.FlatAppearance.BorderSize = 0;
            this.buttonAddEmployeeAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddEmployeeAcc.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddEmployeeAcc.ForeColor = System.Drawing.Color.White;
            this.buttonAddEmployeeAcc.Location = new System.Drawing.Point(32, 411);
            this.buttonAddEmployeeAcc.Name = "buttonAddEmployeeAcc";
            this.buttonAddEmployeeAcc.Size = new System.Drawing.Size(128, 33);
            this.buttonAddEmployeeAcc.TabIndex = 7;
            this.buttonAddEmployeeAcc.Text = "Angajat nou";
            this.buttonAddEmployeeAcc.UseVisualStyleBackColor = false;
            this.buttonAddEmployeeAcc.Click += new System.EventHandler(this.buttonLogIn_Click);
            // 
            // buttonEditEmployee
            // 
            this.buttonEditEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.buttonEditEmployee.FlatAppearance.BorderSize = 0;
            this.buttonEditEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditEmployee.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditEmployee.ForeColor = System.Drawing.Color.White;
            this.buttonEditEmployee.Location = new System.Drawing.Point(166, 411);
            this.buttonEditEmployee.Name = "buttonEditEmployee";
            this.buttonEditEmployee.Size = new System.Drawing.Size(146, 33);
            this.buttonEditEmployee.TabIndex = 8;
            this.buttonEditEmployee.Text = "Sterge Angajat";
            this.buttonEditEmployee.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.label2.Location = new System.Drawing.Point(838, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Exit";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tableEmployeeTableAdapter
            // 
            this.tableEmployeeTableAdapter.ClearBeforeFill = true;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(210)))), ((int)(((byte)(245)))));
            this.buttonRefresh.BackgroundImage = global::ProjectBD.Properties.Resources.refresh_icon_0;
            this.buttonRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(210)))), ((int)(((byte)(245)))));
            this.buttonRefresh.Location = new System.Drawing.Point(804, 401);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(47, 45);
            this.buttonRefresh.TabIndex = 10;
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn4.HeaderText = "ID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Surname";
            this.dataGridViewTextBoxColumn5.HeaderText = "Surname";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Last Name";
            this.dataGridViewTextBoxColumn9.HeaderText = "Last Name";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "LogTime";
            this.dataGridViewTextBoxColumn12.HeaderText = "LogTime";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Project";
            this.dataGridViewTextBoxColumn13.HeaderText = "Project";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "LogText";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridViewTextBoxColumn14.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn14.HeaderText = "LogText";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn14.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // phoneDataGridViewTextBoxColumn1
            // 
            this.phoneDataGridViewTextBoxColumn1.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn1.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn1.Name = "phoneDataGridViewTextBoxColumn1";
            this.phoneDataGridViewTextBoxColumn1.ReadOnly = true;
            this.phoneDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // addressDataGridViewTextBoxColumn1
            // 
            this.addressDataGridViewTextBoxColumn1.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn1.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn1.Name = "addressDataGridViewTextBoxColumn1";
            this.addressDataGridViewTextBoxColumn1.ReadOnly = true;
            this.addressDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column1
            // 
            this.Column1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Text = "Edit";
            this.Column1.ToolTipText = "Edit";
            this.Column1.UseColumnTextForButtonValue = true;
            // 
            // Column2
            // 
            this.Column2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column2.HeaderText = "";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.Text = "Delete";
            this.Column2.ToolTipText = "Delete";
            this.Column2.UseColumnTextForButtonValue = true;
            // 
            // username
            // 
            this.username.DataPropertyName = "username";
            this.username.HeaderText = "username";
            this.username.Name = "username";
            this.username.ReadOnly = true;
            this.username.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.username.Visible = false;
            // 
            // password
            // 
            this.password.DataPropertyName = "password";
            this.password.HeaderText = "password";
            this.password.Name = "password";
            this.password.ReadOnly = true;
            this.password.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.password.Visible = false;
            // 
            // FormEmployeeTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonEditEmployee);
            this.Controls.Add(this.buttonAddEmployeeAcc);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormEmployeeTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee TimeSheet";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableEmployeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proiectBDDataSet3)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn logTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn logTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonAddEmployeeAcc;
        private System.Windows.Forms.Button buttonEditEmployee;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Label label2;
        private ProiectBDDataSet3 proiectBDDataSet3;
        private System.Windows.Forms.BindingSource tableEmployeeBindingSource;
        private ProiectBDDataSet3TableAdapters.TableEmployeeTableAdapter tableEmployeeTableAdapter;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
    }
}

