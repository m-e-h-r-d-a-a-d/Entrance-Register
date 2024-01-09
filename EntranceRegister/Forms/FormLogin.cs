using System.Security.Cryptography;
using System.Text;
using EntranceRegister.Models;

namespace EntranceRegister.Forms;

public partial class FormLogin : Form
{

    private readonly EntranceContext _dbContext;

    public FormLogin(EntranceContext dbContext)
    {
        InitializeComponent();
        _dbContext = dbContext;
    }

    private void buttonOK_Click(object sender, EventArgs e)
    {

        var md5 = MD5.Create();
        byte[] inputBytes = System.Text.Encoding.UTF8.GetBytes(textBoxPassword.Text);
        byte[] hash = md5.ComputeHash(inputBytes);

        // step 2, convert byte array to hex string
        var sb = new StringBuilder();
        foreach (byte b in hash)
        {
            sb.Append(b.ToString("X2"));
        }

        var user = _dbContext.Users.FirstOrDefault(u => u.Username == textBoxUsername.Text && u.Password == sb.ToString());
        if (user == null)
        {
            MessageBox.Show(@"کد کاربری یا رمز عبور اشتباه است", @"خطا در ورود", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        Globals.User = user;
        DialogResult = DialogResult.OK;
    }

    private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (e.CloseReason == CloseReason.UserClosing && DialogResult != DialogResult.OK)
        {
            e.Cancel = true;
        }
    }

    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);

        panel.Left = Width / 2 - panel.Width / 2;
        panel.Top = Height / 2 - panel.Height / 2;
    }
}
