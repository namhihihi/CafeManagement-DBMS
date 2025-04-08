using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CafeManagementDBMS
{
    public partial class InformationForm : Form
    {
        public InformationForm()
        {
            InitializeComponent();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            User user = new User();
            string username = txtUserName.Text.Trim();
            string password = txtPassword.Text.Trim();
            string fullName = txtHoTen.Text.Trim();
            string mail = txtEmail.Text.Trim();
            int age = Convert.ToInt32(txtTuoi.Text.Trim());
            string phone = txtSDT.Text.Trim();
            string address = txtDiaChi.Text.Trim();            

            if (user.insertUser(username, password, fullName, mail, age, phone, address))
                MessageBox.Show("User đăng ký thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Lỗi khi đăng ký user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
