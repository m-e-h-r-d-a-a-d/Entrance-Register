namespace EntranceRegister.Forms;

partial class FormLogin
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.label1 = new System.Windows.Forms.Label();
        this.textBoxUsername = new System.Windows.Forms.TextBox();
        this.textBoxPassword = new System.Windows.Forms.TextBox();
        this.label2 = new System.Windows.Forms.Label();
        this.panel = new System.Windows.Forms.Panel();
        this.buttonOK = new System.Windows.Forms.Button();
        this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
        this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
        this.panel.SuspendLayout();
        this.tableLayoutPanel1.SuspendLayout();
        this.tableLayoutPanel2.SuspendLayout();
        this.SuspendLayout();
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Font = new System.Drawing.Font("B Yekan", 9.75F);
        this.label1.Location = new System.Drawing.Point(214, 10);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(58, 20);
        this.label1.TabIndex = 2;
        this.label1.Text = "نام کاربری";
        // 
        // textBoxUsername
        // 
        this.textBoxUsername.Location = new System.Drawing.Point(29, 10);
        this.textBoxUsername.Margin = new System.Windows.Forms.Padding(0);
        this.textBoxUsername.Name = "textBoxUsername";
        this.textBoxUsername.Size = new System.Drawing.Size(161, 20);
        this.textBoxUsername.TabIndex = 0;
        // 
        // textBoxPassword
        // 
        this.textBoxPassword.Location = new System.Drawing.Point(29, 45);
        this.textBoxPassword.Margin = new System.Windows.Forms.Padding(0);
        this.textBoxPassword.Name = "textBoxPassword";
        this.textBoxPassword.PasswordChar = '*';
        this.textBoxPassword.Size = new System.Drawing.Size(161, 20);
        this.textBoxPassword.TabIndex = 1;
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Font = new System.Drawing.Font("B Yekan", 9.75F);
        this.label2.Location = new System.Drawing.Point(221, 44);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(51, 20);
        this.label2.TabIndex = 4;
        this.label2.Text = "رمز عبور";
        // 
        // panel
        // 
        this.panel.Controls.Add(this.textBoxPassword);
        this.panel.Controls.Add(this.label2);
        this.panel.Controls.Add(this.buttonOK);
        this.panel.Controls.Add(this.textBoxUsername);
        this.panel.Controls.Add(this.label1);
        this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
        this.panel.Location = new System.Drawing.Point(123, 3);
        this.panel.Name = "panel";
        this.panel.Size = new System.Drawing.Size(294, 144);
        this.panel.TabIndex = 6;
        // 
        // buttonOK
        // 
        this.buttonOK.Cursor = System.Windows.Forms.Cursors.Hand;
        this.buttonOK.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(61)))));
        this.buttonOK.FlatAppearance.BorderSize = 0;
        this.buttonOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
        this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.buttonOK.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
        this.buttonOK.ForeColor = System.Drawing.Color.WhiteSmoke;
        // this.buttonOK.Image = global::BehFarma.UI.Properties.Resources.Key_Access_128;
        this.buttonOK.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
        this.buttonOK.Location = new System.Drawing.Point(29, 70);
        this.buttonOK.Margin = new System.Windows.Forms.Padding(0);
        this.buttonOK.Name = "buttonOK";
        this.buttonOK.Size = new System.Drawing.Size(161, 74);
        this.buttonOK.TabIndex = 2;
        this.buttonOK.Text = "ورود";
        this.buttonOK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        this.buttonOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
        this.buttonOK.UseVisualStyleBackColor = true;
        this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
        // 
        // tableLayoutPanel1
        // 
        this.tableLayoutPanel1.ColumnCount = 1;
        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
        this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
        this.tableLayoutPanel1.Name = "tableLayoutPanel1";
        this.tableLayoutPanel1.RowCount = 3;
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        this.tableLayoutPanel1.Size = new System.Drawing.Size(539, 336);
        this.tableLayoutPanel1.TabIndex = 7;
        // 
        // tableLayoutPanel2
        // 
        this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(61)))));
        this.tableLayoutPanel2.ColumnCount = 3;
        this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
        this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        this.tableLayoutPanel2.Controls.Add(this.panel, 1, 0);
        this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
        this.tableLayoutPanel2.ForeColor = System.Drawing.Color.WhiteSmoke;
        this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 93);
        this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
        this.tableLayoutPanel2.Name = "tableLayoutPanel2";
        this.tableLayoutPanel2.RowCount = 1;
        this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        this.tableLayoutPanel2.Size = new System.Drawing.Size(539, 150);
        this.tableLayoutPanel2.TabIndex = 7;
        // 
        // FormLogin
        // 
        this.AcceptButton = this.buttonOK;
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.Color.WhiteSmoke;
        this.ClientSize = new System.Drawing.Size(539, 336);
        this.ControlBox = false;
        this.Controls.Add(this.tableLayoutPanel1);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        this.Name = "FormLogin";
        this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
        this.Text = "ورود";
        this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
        this.panel.ResumeLayout(false);
        this.panel.PerformLayout();
        this.tableLayoutPanel1.ResumeLayout(false);
        this.tableLayoutPanel2.ResumeLayout(false);
        this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button buttonOK;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox textBoxUsername;
    private System.Windows.Forms.TextBox textBoxPassword;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Panel panel;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
}
