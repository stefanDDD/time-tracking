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
    public partial class FormAddEmployee : Form
    {
        Timer t = new Timer();

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
        public FormAddEmployee()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void FormAddEmployee_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {

        }

        private void FormAddEmployee_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void ShowError(string Text)
        {

            labelError.Text = Text;
            panelError.Visible = true;
            timerError.Start();

        }
        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            labelError.Visible = true;
            panelError.Visible = true;

            if (string.IsNullOrEmpty(textBoxName.Text))
            {

                ShowError("Eroare! Campul [Nume] este necesar");
            }
            else if (string.IsNullOrEmpty(textBoxSurname.Text))
            {
                ShowError("Eroare! Campul [Prenume] este necesar");
            }
            else if (string.IsNullOrEmpty(textBoxUsername.Text))
            {
                ShowError("Eroare! Campul [Username] este necesar");
            }
            else if (string.IsNullOrEmpty(textBoxPassword.Text))
            {
                ShowError("Eroare! Campul [Password] este necesar");
            }
            else if (string.IsNullOrEmpty(textBoxPhone.Text))
            {
                ShowError("Eroare! Campul [Telefon] este necesar");
            }
            else if (string.IsNullOrEmpty(textBoxAddress.Text))
            {
                ShowError("Eroare! Campul [Adresa] este necesar");
            }
            else
            {
                ShowError("Completare reusita");


                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-VUPD668\MSSQLSERVER02;Initial Catalog=ProiectBD;Integrated Security=True"); SqlDataAdapter adapter;
                //Data Source=ANDREIPC;Initial Catalog=ProiectBD;Integrated Security=True
                conn.Open();
                SqlCommand sc = new SqlCommand("INSERT into TableEmployee(Surname, [Last Name], username, password,Phone,Address) VALUES('" + textBoxName.Text + "','" + textBoxSurname.Text + "','" + textBoxUsername.Text + "','" + textBoxPassword.Text + "','" + textBoxPhone.Text + "','" + textBoxAddress.Text + "')", conn);
                int i = sc.ExecuteNonQuery();
                if (i != 0)
                {
                    MessageBox.Show("Angajat adaugat");
                }
                else
                {
                    MessageBox.Show("Eroare!");
                }
                conn.Close();
                this.Close();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            textBoxName.Clear();
            textBoxSurname.Clear();
            textBoxUsername.Clear();
            textBoxPassword.Clear();
            textBoxName.Focus();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timerError_Tick(object sender, EventArgs e)
        {
            timerError.Stop();
            panelError.Visible = false;
        }
    }
}
