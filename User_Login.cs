using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaruthiTextiles
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            
            if (txtUsername.Text == "")
            {
                lblResult.Text = "* Please enter Username";
            }
            else if (txtPassword.Text == "")
            {
                lblResult.Text = "* Please enter password";

            }
            else
            {
                try
                {
                    String sqlUrl = "Data Source=DESKTOP-TSSL51R\\SQLEXPRESS;Initial Catalog=MarutiTextiles;Integrated Security=True";
                    SqlConnection con = new SqlConnection(sqlUrl);
                    SqlCommand cmd = new SqlCommand("select * from dbo.User_Login where username = @username and password = @password", con);
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                    SqlDataAdapter sd = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sd.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                      //  MessageBox.Show("Successfully Logged In " +"\'"+ txtUsername.Text+"\'");

                        this.Hide();
                        Home home = new Home();
                        home.Show();
                    }
                    else
                    {
                        MessageBox.Show("username or password is invalid");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(""+ex);
                }
            }
           /* {
                if (txtUsername.Text == "admin" && txtPassword.Text == "admin123")
                {
                    lblResult.Text = "Successfully Logged In";
                }
                else
                {
                    lblResult.Text = "Invalid Username or Password";
                }
            }*/
           
        }
    }
}
