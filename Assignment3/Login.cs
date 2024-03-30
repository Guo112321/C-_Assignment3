using static Assignment3.StudentDB;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Assignment3
{
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
        }

        public static bool IsAdminValid(string userName, string password)
        {
            return admins.Any(admin => admin.UserName == userName && admin.Password == password);
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (IsAdminValid(txtUserName.Text,txtPassword.Text))
            {
                ManagementSystem managementSystem = new ManagementSystem(new StudentDB.Admin(txtUserName.Text, txtPassword.Text));
                managementSystem.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("UserName or Password is not correct!");
            }
        }

        
    }
}
