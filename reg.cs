using KeyAuth;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Loader
{
    public partial class reg : Form
    {
     public static api KeyAuthApp = new api(
    name: "",
    ownerid: "",
    secret: "",
    version: "1.0"
);
        public reg()
        {
            InitializeComponent();
        }
        

        private void LoginBtn_Click(object sender, EventArgs e)
        {
                 KeyAuthApp.register(username.Text, pass.Text, key.Text);
                 if (KeyAuthApp.response.success)
                 {
                MessageBox.Show("You're now logging into blahblahblah.\n\nMake sure to remember the following\n\n*Username\n*Password");
                    Main main = new Main();
                    main.Show();
                    this.Hide();
                 }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            var login = new Login();
            login.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void reg_Load(object sender, EventArgs e)
        {
            KeyAuthApp.init();

        }
    }
}
