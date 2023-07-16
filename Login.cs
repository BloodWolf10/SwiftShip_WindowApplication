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

namespace SwiftShip_WindowApplication
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();

       
    }


       

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
        SqlConnection conn = new SqlConnection(@"Data Source=CODEBLACK\SQLEXPRESS;Initial Catalog=SwiftShip;Integrated Security=True");
        //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-82BV177\SQLEXPRESS;Initial Catalog=SwiftShip;Integrated Security=True");

        private void btnLogin_Click(object sender, EventArgs e)
        {
             Member mem = new Member();
            

            string User = txtBxUsername.Text;
            string password = txtBxPassword.Text;

            try
            {

                string query = "SELECT * FROM LoginInfo WHERE Username = '" + txtBxUsername.Text + "' AND UPassword = '" + txtBxPassword.Text+"'";
                SqlDataAdapter sda = new SqlDataAdapter(query,conn);
                DataTable dtable = new DataTable();

                sda.Fill(dtable);

                if (dtable.Rows.Count >0)
                {
                    User = txtBxUsername.Text;
                    password = txtBxPassword.Text;

                    this.Hide();
                    
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
    }
}
