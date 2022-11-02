using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReturnValuesFromUserControl
{
    public partial class UserControllogin : UserControl
    {
        public UserControllogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            var username = textboxUsername.Text.Trim();
            var password = textboxPassword.Text.Trim(); 
            if(username.Equals("abc ") && password.Equals("def"))
            {
                MessageBox.Show("Success");
            } 
            else
            {
                MessageBox.Show("Failed");
            }
        }
    }
}
