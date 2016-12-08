using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Data.Entity.Core.Objects.DataClasses; //for sql functions

namespace OCD
{
    public partial class MainMenu : Form
    {
        int userID;

        public MainMenu()
        {
            InitializeComponent();
        }

        /*public class Register
        {
            public string userName { get; set; }
            public string userPass { get; set; }
            public string userPass2 { get; set; }
        }

        public class RegisterContext : DbContext
        {
            public DbSet<Register> Register { get; set; }
        }*/


        [EdmFunction("Entities.Store", "connectUser")]
        public static int connectUser(String loginName, String loginPass)
        {
           throw new NotSupportedException("Direct calls are not supported.");
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            using (var context = new Entities())
            {
                try
                {
                    SqlParameter userName = new SqlParameter("@login", loginName.Text);
                    SqlParameter userPass = new SqlParameter("@pass", loginPass.Text);
                    userID = context.Database.ExecuteSqlCommand("connectUser('" + loginName.Text + "' , '" + loginPass.Text + "')");
                    //userID = connectUser(loginName.Text, loginPass.Text);

                    lbErrorOrMessage.Text = "Login Successfully";
                    lbErrorOrMessage.BackColor = Color.Green;
                    lbErrorOrMessage.Visible = true;
                }
                catch
                {
                    lbErrorOrMessage.Text = "Could not login!";
                    lbErrorOrMessage.BackColor = Color.Red;
                    lbErrorOrMessage.Visible = true;
                }
            }          
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            gbSignIn.Visible = false;
            gbCreateAccount.Visible = true;
            this.AcceptButton = btnCreateAccount2;
        }

        private void btnCreateAccount2_Click(object sender, EventArgs e)
        {
            this.AcceptButton = btnSignIn;
            /*using (var db = new RegisterContext())
            {
                var register = new Register { userName = registerName.Text, userPass = registerPass.Text, userPass2 = registerPass2.Text };
                db.Register.Add(register);
                db.SaveChanges();
            }*/

            using (var context = new Entities())
            {

                //context.Database.SqlQuery<Entities>("CREATELORD", registerName.Text, registerPass.Text, registerPass2.Text);
                /*SqlParameter param1 = new SqlParameter("@login", registerName.Text);
                SqlParameter param2 = new SqlParameter("@pass", registerPass.Text);
                SqlParameter param3 = new SqlParameter("@pass2", registerPass2.Text);
                context.Database.ExecuteSqlCommand("createLord @login, @pass, @pass2");*/
                //if (context)
                try
                {
                    context.CREATELORD(registerName.Text, registerPass.Text, registerPass2.Text);
                    lbErrorOrMessage.Text = "Account Created Sucessfully";
                    lbErrorOrMessage.BackColor = Color.Green;
                    gbSignIn.Visible = true;
                    gbCreateAccount.Visible = false;
                    lbErrorOrMessage.Visible = true;
                    registerName.Text = "";
                    registerPass.Text = "";
                    registerPass2.Text = "";
                }
                catch
                {
                    lbErrorOrMessage.Text = "Login is already taken or Passwords doesn't match.";
                    lbErrorOrMessage.BackColor = Color.Red;
                    lbErrorOrMessage.Visible = true;
                    registerName.Text = "";
                    registerPass.Text = "";
                    registerPass2.Text = "";
                }
                
            }
        }
    }
}
