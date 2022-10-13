
namespace ProjectBD
{
    partial class FormEmployeeLogTime
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.buttonLogAndTime = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonabc = new System.Windows.Forms.Button();
            this.buttonUnderline = new System.Windows.Forms.Button();
            this.buttonItalic = new System.Windows.Forms.Button();
            this.buttonBold = new System.Windows.Forms.Button();
            this.comboBoxSizee = new System.Windows.Forms.ComboBox();
            this.comboBoxFont = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tableProjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proiectBDDataSet4 = new ProjectBD.ProiectBDDataSet4();
            this.tableProjectsTableAdapter = new ProjectBD.ProiectBDDataSet4TableAdapters.TableProjectsTableAdapter();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.projectsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableProjectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proiectBDDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxTime
            // 
            this.textBoxTime.Location = new System.Drawing.Point(366, 326);
            this.textBoxTime.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(76, 20);
            this.textBoxTime.TabIndex = 1;
            // 
            // buttonLogAndTime
            // 
            this.buttonLogAndTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.buttonLogAndTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogAndTime.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogAndTime.ForeColor = System.Drawing.Color.White;
            this.buttonLogAndTime.Location = new System.Drawing.Point(483, 338);
            this.buttonLogAndTime.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLogAndTime.Name = "buttonLogAndTime";
            this.buttonLogAndTime.Size = new System.Drawing.Size(76, 37);
            this.buttonLogAndTime.TabIndex = 2;
            this.buttonLogAndTime.Text = "Log";
            this.buttonLogAndTime.UseVisualStyleBackColor = false;
            this.buttonLogAndTime.Click += new System.EventHandler(this.buttonLogAndTime_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(366, 36);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(513, 82);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.buttonabc);
            this.tabPage1.Controls.Add(this.buttonUnderline);
            this.tabPage1.Controls.Add(this.buttonItalic);
            this.tabPage1.Controls.Add(this.buttonBold);
            this.tabPage1.Controls.Add(this.comboBoxSizee);
            this.tabPage1.Controls.Add(this.comboBoxFont);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(505, 56);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::ProjectBD.Properties.Resources.Capture;
            this.button1.Location = new System.Drawing.Point(150, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 24);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // buttonabc
            // 
            this.buttonabc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonabc.Font = new System.Drawing.Font("Times New Roman", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonabc.Location = new System.Drawing.Point(105, 27);
            this.buttonabc.Name = "buttonabc";
            this.buttonabc.Size = new System.Drawing.Size(39, 24);
            this.buttonabc.TabIndex = 5;
            this.buttonabc.Text = "abc";
            this.buttonabc.UseVisualStyleBackColor = true;
            this.buttonabc.Click += new System.EventHandler(this.buttonabc_Click);
            // 
            // buttonUnderline
            // 
            this.buttonUnderline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUnderline.Font = new System.Drawing.Font("Times New Roman", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUnderline.Location = new System.Drawing.Point(71, 27);
            this.buttonUnderline.Name = "buttonUnderline";
            this.buttonUnderline.Size = new System.Drawing.Size(28, 24);
            this.buttonUnderline.TabIndex = 4;
            this.buttonUnderline.Text = "U";
            this.buttonUnderline.UseVisualStyleBackColor = true;
            this.buttonUnderline.Click += new System.EventHandler(this.buttonUnderline_Click);
            // 
            // buttonItalic
            // 
            this.buttonItalic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonItalic.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonItalic.Location = new System.Drawing.Point(37, 27);
            this.buttonItalic.Name = "buttonItalic";
            this.buttonItalic.Size = new System.Drawing.Size(28, 24);
            this.buttonItalic.TabIndex = 3;
            this.buttonItalic.Text = "I";
            this.buttonItalic.UseVisualStyleBackColor = true;
            this.buttonItalic.Click += new System.EventHandler(this.buttonItalic_Click);
            // 
            // buttonBold
            // 
            this.buttonBold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBold.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBold.Location = new System.Drawing.Point(3, 27);
            this.buttonBold.Name = "buttonBold";
            this.buttonBold.Size = new System.Drawing.Size(28, 24);
            this.buttonBold.TabIndex = 2;
            this.buttonBold.Text = "B";
            this.buttonBold.UseVisualStyleBackColor = true;
            this.buttonBold.Click += new System.EventHandler(this.buttonBold_Click);
            // 
            // comboBoxSizee
            // 
            this.comboBoxSizee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSizee.FormattingEnabled = true;
            this.comboBoxSizee.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "36",
            "48",
            "72"});
            this.comboBoxSizee.Location = new System.Drawing.Point(130, 3);
            this.comboBoxSizee.Name = "comboBoxSizee";
            this.comboBoxSizee.Size = new System.Drawing.Size(51, 21);
            this.comboBoxSizee.TabIndex = 1;
            this.comboBoxSizee.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBoxFont
            // 
            this.comboBoxFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFont.FormattingEnabled = true;
            this.comboBoxFont.Location = new System.Drawing.Point(3, 3);
            this.comboBoxFont.Name = "comboBoxFont";
            this.comboBoxFont.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFont.TabIndex = 0;
            this.comboBoxFont.SelectedIndexChanged += new System.EventHandler(this.comboBoxFont_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(505, 56);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "View";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.label5.Location = new System.Drawing.Point(842, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Exit";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(366, 124);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(513, 181);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = "";
            // 
            // tableProjectsBindingSource
            // 
            this.tableProjectsBindingSource.DataMember = "TableProjects";
            this.tableProjectsBindingSource.DataSource = this.proiectBDDataSet4;
            // 
            // proiectBDDataSet4
            // 
            this.proiectBDDataSet4.DataSetName = "ProiectBDDataSet4";
            this.proiectBDDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableProjectsTableAdapter
            // 
            this.tableProjectsTableAdapter.ClearBeforeFill = true;
            // 
            // guna2DataGridView1
            // 
            this.guna2DataGridView1.AllowUserToAddRows = false;
            this.guna2DataGridView1.AllowUserToDeleteRows = false;
            this.guna2DataGridView1.AllowUserToResizeColumns = false;
            this.guna2DataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView1.AutoGenerateColumns = false;
            this.guna2DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guna2DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.guna2DataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guna2DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeight = 21;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.projectsDataGridViewTextBoxColumn});
            this.guna2DataGridView1.DataSource = this.tableProjectsBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.EnableHeadersVisualStyles = false;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(59, 36);
            this.guna2DataGridView1.MultiSelect = false;
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.ReadOnly = true;
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guna2DataGridView1.Size = new System.Drawing.Size(301, 339);
            this.guna2DataGridView1.TabIndex = 16;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 21;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = true;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // projectsDataGridViewTextBoxColumn
            // 
            this.projectsDataGridViewTextBoxColumn.DataPropertyName = "Projects";
            this.projectsDataGridViewTextBoxColumn.HeaderText = "Projects";
            this.projectsDataGridViewTextBoxColumn.Name = "projectsDataGridViewTextBoxColumn";
            this.projectsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormEmployeeLogTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(886, 449);
            this.Controls.Add(this.guna2DataGridView1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonLogAndTime);
            this.Controls.Add(this.textBoxTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormEmployeeLogTime";
            this.Text = "LogTime";
            this.Load += new System.EventHandler(this.FormEmployeeLogTime_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormEmployeeLogTime_MouseDown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableProjectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proiectBDDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.Button buttonLogAndTime;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button buttonabc;
        private System.Windows.Forms.Button buttonUnderline;
        private System.Windows.Forms.Button buttonItalic;
        private System.Windows.Forms.Button buttonBold;
        private System.Windows.Forms.ComboBox comboBoxSizee;
        private System.Windows.Forms.ComboBox comboBoxFont;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private ProiectBDDataSet4 proiectBDDataSet4;
        private System.Windows.Forms.BindingSource tableProjectsBindingSource;
        private ProiectBDDataSet4TableAdapters.TableProjectsTableAdapter tableProjectsTableAdapter;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectsDataGridViewTextBoxColumn;
    }
}