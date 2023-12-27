using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
// using BehFarma.Model;

namespace View
{
    public partial class FormLogin : Form
    {
        // public User User { private set; get; }

        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            // var entities = new BehFarmaEntities();

            var md5 = MD5.Create();
            var inputBytes = System.Text.Encoding.UTF8.GetBytes(textBoxPassword.Text);
            var hash = md5.ComputeHash(inputBytes);
 
            // step 2, convert byte array to hex string
            var sb = new StringBuilder();
            foreach (var b in hash)
                sb.Append(b.ToString("X2"));

            // var user = (from u in entities.Users where u.Username == textBoxUsername.Text select u).FirstOrDefault();
            // if (user != null && user.Password.ToLower() == sb.ToString().ToLower())
            {
                // User = user;
                DialogResult = DialogResult.OK;
            }
            // else
            {
                MessageBox.Show("کد کاربری یا رمز عبور اشتباه است", "خطا در ورود", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && DialogResult != DialogResult.OK)
                e.Cancel = true;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            panel.Left = Width/2 - panel.Width/2;
            panel.Top = Height/2 - panel.Height/2;
        }
    }
}
