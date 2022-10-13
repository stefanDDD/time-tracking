using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ProjectBD
{
    public partial class FormEmployeeTable : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );
        public FormEmployeeTable()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        SqlConnection conn = new SqlConnection(@"Data Source=ANDREIPC;Initial Catalog=ProiectBD;Integrated Security=True"); SqlDataAdapter adapter;
        DataTable dt;
        public void ShowData()
        {

           adapter = new SqlDataAdapter("SELECT * FROM tableEmployee", conn);
            dt = new DataTable();
            adapter.Fill(dt);
            dataGridViewEmployee.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'proiectBDDataSet3.TableEmployee' table. You can move, or remove it, as needed.
            this.tableEmployeeTableAdapter.Fill(this.proiectBDDataSet3.TableEmployee);
            // TODO: This line of code loads data into the 'proiectBDDataSet2.TableEmployee' table. You can move, or remove it, as needed.
           

        }

        private void dataGridViewEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            FormAddEmployee FormNew = new FormAddEmployee();
            FormNew.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



            if (e.ColumnIndex == 5)
            {
                SqlCommand cmd;
                cmd = new SqlCommand("Select LogText From tableEmployee", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                int rowIndex = e.RowIndex;
                FormDescription FormD = new FormDescription();
                FormD.textBoxDescription.Text = dataGridViewEmployee.Rows[rowIndex].Cells[5].Value.ToString();


                FormD.ShowDialog();

            }

            else if (e.ColumnIndex == 8)
            {
                int rowIndex = e.RowIndex;
                FormAddEmployee f2 = new FormAddEmployee();
                FormEmployeeTable f1 = new FormEmployeeTable();
                f2.textBoxName.Text = dataGridViewEmployee.Rows[rowIndex].Cells[1].Value.ToString();
                f2.textBoxSurname.Text = dataGridViewEmployee.Rows[rowIndex].Cells[2].Value.ToString();
                f2.textBoxUsername.Text = dataGridViewEmployee.Rows[rowIndex].Cells[10].Value.ToString();
                f2.textBoxPassword.Text = dataGridViewEmployee.Rows[rowIndex].Cells[11].Value.ToString();
                f2.textBoxPhone.Text = dataGridViewEmployee.Rows[rowIndex].Cells[6].Value.ToString();
                f2.textBoxAddress.Text = dataGridViewEmployee.Rows[rowIndex].Cells[7].Value.ToString();
                f2.ShowDialog();


                // f2.btnUpdate.Click += f2.btnUpdate_Click;


                SqlCommand cmd;
                cmd = new SqlCommand("UPDATE TableEmployee SET Surname='" + f2.textBoxName.Text + "',[Last Name]='" + f2.textBoxSurname.Text + "',username='" + f2.textBoxUsername.Text + "',password='" + f2.textBoxPassword.Text + "',Phone='" + f2.textBoxPhone.Text + "',Address='" + f2.textBoxAddress.Text + "' WHERE ID=" + dataGridViewEmployee.Rows[rowIndex].Cells[0].Value.ToString(), conn);
                conn.Open();

                cmd.ExecuteNonQuery();

                conn.Close();






            }
            else if (e.ColumnIndex == 9)
            {

                DialogResult dialogResult = MessageBox.Show("Doriti sa stergeti angajatul?", "Warning", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    //create sql connection


                    int rowIndex = e.RowIndex;
                    //sql to delete data
                    string sql = "DELETE FROM TableEmployee WHERE ID=" + dataGridViewEmployee.Rows[rowIndex].Cells[0].Value;
                    //create sql command
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    //open connection
                    conn.Open();
                    cmd.ExecuteNonQuery();

                    conn.Close();
                    dataGridViewEmployee.Rows.RemoveAt(rowIndex);

                }
                else if (dialogResult == DialogResult.No)
                {

                }


            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            ShowData();
            this.dataGridViewEmployee.Refresh();
            this.dataGridViewEmployee.Update();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
