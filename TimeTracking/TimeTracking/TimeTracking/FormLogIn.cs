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
using System.Runtime.InteropServices;

namespace ProjectBD
{
    public partial class FormLogIn : Form
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

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void FormLogIn_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        SqlConnection conn = new SqlConnection(@"Data Source=ANDREIPC;Initial Catalog=ProiectBD;Integrated Security=True"); public FormLogIn()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
           
        }

        private void FormLogIn_Load(object sender, EventArgs e)
        {
            this.textBoxUsername.Enter += new EventHandler(textBox2_Enter);
            this.textBoxUsername.Leave += new EventHandler(textBox2_Leave);
            textBox2_SetText();
            this.textBoxPassword.Enter += new EventHandler(textBoxPassword_Enter);
            this.textBoxPassword.Leave += new EventHandler(textBoxPassword_Leave);
            textBoxPassword_SetText();

        }
        protected void textBox2_SetText()
        {
            this.textBoxUsername.Text = "User name";
            textBoxUsername.ForeColor = Color.Gray;
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBoxUsername.ForeColor == Color.Black)
                return;
            textBoxUsername.Text = "";
            textBoxUsername.ForeColor = Color.Black;
        }
        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBoxUsername.Text.Trim() == "")
                textBox2_SetText();
        }
        protected void textBoxPassword_SetText()
        {
            this.textBoxPassword.Text = "Parola";
            textBoxPassword.ForeColor = Color.Gray;
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxUsername.ForeColor == Color.Black)
                return;
            textBoxPassword.Text = "";
            textBoxPassword.ForeColor = Color.Black;
        }
        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxPassword.Text.Trim() == "")
                textBoxPassword_SetText();
        }

        public void buttonLogIn_Click_1(object sender, EventArgs e)
        {
            
                if (textBoxUsername.Text == "admin" && textBoxPassword.Text == "password")
                {
                    new FormEmployeeTable().Show();
                    this.Hide();

                }
                else if (textBoxUsername.Text == null && textBoxPassword.Text == null)
                {
                    MessageBox.Show(
                         "Nu ai introdus Username-ul si Parola",
                         "Warning!",
                         MessageBoxButtons.OK);
                    textBoxUsername.Clear();
                    textBoxPassword.Clear();
                    textBoxUsername.Focus();

                }
                else
                {
                    String username = textBoxUsername.Text;
                    String password = textBoxPassword.Text;

                    try
                    {
                        String querry = "SELECT * FROM TableEmployee WHERE username = '" + textBoxUsername.Text + "' AND password = '" + textBoxPassword.Text + "'";
                        SqlDataAdapter sda = new SqlDataAdapter(querry, conn);
                        DataTable dtable = new DataTable();
                        sda.Fill(dtable);
                        if (dtable.Rows.Count > 0)
                        {
                            username = textBoxUsername.Text;
                            password = textBoxPassword.Text;

                            FormEmployeeLogTime f1 = new FormEmployeeLogTime();
                            f1.UserName = username;
                            f1.Show();
                            this.Hide();
                            
                        }
                        else
                        {

                            MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textBoxUsername.Clear();
                            textBoxPassword.Clear();
                            textBoxUsername.Focus();
                        }
                   
                }
                    catch
                    {
                        MessageBox.Show("Error");
                    }
                    finally
                    {
                        conn.Close();
                    }




                }

            


        }

        private void label3_Click(object sender, EventArgs e)
        {
            textBoxUsername.Clear();
            textBoxPassword.Clear();
            textBoxUsername.Focus();
        }


        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonLogIn.PerformClick();


            }
        }

        public void label2_Click(object sender, EventArgs e)
        {
           
            this.Close();
            
        }
    }
}
