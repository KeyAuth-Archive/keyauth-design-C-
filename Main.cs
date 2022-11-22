using System;
using System.Windows.Forms;

namespace KeyAuth
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }


        private void Main_Load(object sender, EventArgs e)
        {
            Login.KeyAuthApp.check();
          
            
          

            var onlineUsers = Login.KeyAuthApp.fetchOnline();
            onlineUsersBox.Items.Clear();
            foreach (var user in onlineUsers)
            {
                onlineUsersBox.Items.Add(user.credential);
            }
            onlineUsersBox.SelectedIndex = 0;
        }

        public static bool SubExist(string name, int len)
        {
            for (var i = 0; i < len; i++)
            {
                if (Login.KeyAuthApp.user_data.subscriptions[i].subscription == name)
                {
                    return true;
                }
            }
            return false;
        }

        public DateTime UnixTimeToDateTime(long unixtime)
        {
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Local);
            try
            {
                dtDateTime = dtDateTime.AddSeconds(unixtime).ToLocalTime();
            }
            catch
            {
                dtDateTime = DateTime.MaxValue;
            }
            return dtDateTime;
        }

        private void sendmsg_Click(object sender, EventArgs e)
        {
       
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
        }
    }
}
