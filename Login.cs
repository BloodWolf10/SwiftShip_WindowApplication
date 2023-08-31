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
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;

namespace SwiftShip_WindowApplication
{
    public partial class FormLogin : Form
    {
        public static string userlog;
        public FormLogin()
        {
            InitializeComponent();

       
    }
        public static string role;
        DBAccess bAccess = new DBAccess();
        SqlConnection connection = new SqlConnection(DBAccess.strConnString);




        class Member:LoggedPerson
        {
            LoggedPerson loged = new LoggedPerson();

            public string Useridentity;
           public Member()
                {
                loged.LoggedName= Useridentity;
            }

        }

       

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       // SqlConnection conn = new SqlConnection(@"Data Source=CODEBLACK\SQLEXPRESS;Initial Catalog=SwiftShip;Integrated Security=True");
        //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-82BV177\SQLEXPRESS;Initial Catalog=SwiftShip;Integrated Security=True");

        private void btnLogin_Click(object sender, EventArgs e)
        {
             Member mem = new Member();


           
            string User = txtBxUsername.Text;
            string password = txtBxPassword.Text;

            try
            {

                string query = "SELECT * FROM LoginInfo WHERE Username = '" + txtBxUsername.Text + "' AND UPassword = '" + txtBxPassword.Text+"'";
                SqlDataAdapter sda = new SqlDataAdapter(query,connection);
                DataTable dtable = new DataTable();

                sda.Fill(dtable);

                if (dtable.Rows.Count >0)
                {
                    userlog = txtBxUsername.Text.Trim();
                    User = txtBxUsername.Text;
                    password = txtBxPassword.Text;
                    role = dtable.Rows[0]["UserRole"].ToString();

                    this.Hide();
                    connection.Close();
                    Dashboard dash = new Dashboard();
                    dash.ShowDialog();
                    mem.Useridentity = User;
                    this.Close();
                }

                else if (txtBxUsername.Text == "" || txtBxPassword.Text == "")
                    {
                    MessageBox.Show(" Invalid parameters entered", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


                else
                {
                    MessageBox.Show(" Incorrect Password or Username entered", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBxUsername.Clear();
                    txtBxPassword.Clear();
                }
            }

            catch (Exception) {
                MessageBox.Show("Error Occured While Attepting to Login", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBxUsername.Clear();
                txtBxPassword.Clear();
            }

           

          
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void lblShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (lblShowPassword.Checked)
            {
                // When the checkbox is checked, show the password by changing the PasswordChar property.
                txtBxPassword.PasswordChar = '\0'; // Setting it to '\0' will make the password visible.
            }
            else
            {
                // When the checkbox is unchecked, mask the password again.
                txtBxPassword.PasswordChar = '*'; // Set it back to the original masking character.
            }
        }

        private void lblHello_Click(object sender, EventArgs e)
        {

        }
    }
}
