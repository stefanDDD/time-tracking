using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace ProjectBD
{
    public partial class FormEmployeeLogTime : Form
    {

        public string UserName { get; set; }
            
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
        public FormEmployeeLogTime()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        
        
        

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        SqlConnection conn = new SqlConnection(@"Data Source=ANDREIPC;Initial Catalog=ProiectBD;Integrated Security=True"); SqlDataAdapter adapter;
        DataTable dt;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void FormEmployeeLogTime_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        //FormLogIn f1 = new FormLogIn();
        
        private void FormEmployeeLogTime_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'proiectBDDataSet4.TableProjects' table. You can move, or remove it, as needed.
            this.tableProjectsTableAdapter.Fill(this.proiectBDDataSet4.TableProjects);
            foreach (FontFamily font in FontFamily.Families)
            {
                comboBoxFont.Items.Add(font.Name.ToString());
            }
        }
        private void buttonLogAndTime_Click(object sender, EventArgs e)
        {
            
            String selectedCell = guna2DataGridView1.CurrentCell.Value.ToString();
            Console.Write(selectedCell);
            string username = this.UserName;
            Console.WriteLine(username);
           
            Console.Write(selectedCell);
            conn.Open();
            SqlCommand sc = new SqlCommand("UPDATE TableEmployee SET LogTime = '"+ textBoxTime.Text + "', Project = '" + selectedCell + "', LogText = '" + richTextBox1.Text + "' WHERE username = '"+ username + "'" , conn);
            sc.ExecuteNonQuery();
            conn.Close();



        }

        private void button1_Click(object sender, EventArgs e)
        {
     
        }

        private void comboBoxFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            try { 
            richTextBox1.Font = new Font(comboBoxFont.Text, richTextBox1.Font.Size);
            }
            catch
            {

            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, float.Parse(comboBoxSizee.SelectedItem.ToString()));
            }
            catch
            {

            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void buttonBold_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, richTextBox1.Font.Size, FontStyle.Bold);
        }

        private void buttonItalic_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, richTextBox1.Font.Size, FontStyle.Italic);

        }

        private void buttonUnderline_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, richTextBox1.Font.Size, FontStyle.Underline);

        }

        private void buttonabc_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, richTextBox1.Font.Size, FontStyle.Strikeout);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult Color = colorDialog1.ShowDialog();
            if(Color == DialogResult.OK)
            {
                richTextBox1.ForeColor = colorDialog1.Color;
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogIn F1 = new FormLogIn();
            F1.Show();
        }

     

       
    }
}
