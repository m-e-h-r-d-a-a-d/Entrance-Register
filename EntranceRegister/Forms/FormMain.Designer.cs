using EntranceRegister.Models;

namespace EntranceRegister.Forms;

partial class FormMain
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
        components = new System.ComponentModel.Container();
        var dataGridViewCellStyle1 = new DataGridViewCellStyle();
        var dataGridViewCellStyle2 = new DataGridViewCellStyle();
        splitContainer = new SplitContainer();
        tableLayoutPanel2 = new TableLayoutPanel();
        panel1 = new Panel();
        tableLayoutPanel3 = new TableLayoutPanel();
        tableLayoutPanel6 = new TableLayoutPanel();
        buttonTakePhoto = new Button();
        buttonRegisterAndPrint = new Button();
        pictureBoxCamera = new PictureBox();
        tableLayoutPanel4 = new TableLayoutPanel();
        panelCard = new Panel();
        comboBoxGender = new ComboBox();
        comboBoxHosts = new ComboBox();
        labelDate = new Label();
        labelTime = new Label();
        textBoxDate = new TextBox();
        textBoxStartTime = new TextBox();
        labelHost = new Label();
        labelName = new Label();
        textBoxName = new TextBox();
        pictureBoxFace = new PictureBox();
        pictureBoxDetectedFace = new PictureBox();
        tableLayoutPanel7 = new TableLayoutPanel();
        panel4 = new Panel();
        tableLayoutPanel5 = new TableLayoutPanel();
        panel5 = new Panel();
        labelDateTime = new Label();
        panel2 = new Panel();
        labelCardTitle = new Label();
        labelVisitorsCount = new Label();
        dataGridViewPresence = new DataGridView();
        idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        personDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        hostDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        startDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        StartDatePersian = new DataGridViewTextBoxColumn();
        Photo = new DataGridViewImageColumn();
        ColumnButtonReprint = new DataGridViewImageColumn();
        ColumnButtonExit = new DataGridViewImageColumn();
        ColumnDummy = new DataGridViewTextBoxColumn();
        registrarDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        bindingSourceTodayPresences = new BindingSource(components);
        timerDateTime = new System.Windows.Forms.Timer(components);
        tableLayoutPanel1 = new TableLayoutPanel();
        panel3 = new Panel();
        buttonExit = new Button();
        buttonSettings = new Button();
        buttonReport = new Button();
        buttonShutdown = new Button();
        buttonHelp = new Button();
        dataGridViewImageColumn1 = new DataGridViewImageColumn();
        dataGridViewImageColumn2 = new DataGridViewImageColumn();
        ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
        splitContainer.Panel1.SuspendLayout();
        splitContainer.Panel2.SuspendLayout();
        splitContainer.SuspendLayout();
        tableLayoutPanel2.SuspendLayout();
        panel1.SuspendLayout();
        tableLayoutPanel3.SuspendLayout();
        tableLayoutPanel6.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBoxCamera).BeginInit();
        tableLayoutPanel4.SuspendLayout();
        panelCard.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBoxFace).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBoxDetectedFace).BeginInit();
        tableLayoutPanel7.SuspendLayout();
        tableLayoutPanel5.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridViewPresence).BeginInit();
        ((System.ComponentModel.ISupportInitialize)bindingSourceTodayPresences).BeginInit();
        tableLayoutPanel1.SuspendLayout();
        panel3.SuspendLayout();
        SuspendLayout();
        // 
        // splitContainer
        // 
        splitContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        splitContainer.BackColor = Color.Black;
        splitContainer.Location = new Point(0, 111);
        splitContainer.Margin = new Padding(0);
        splitContainer.Name = "splitContainer";
        // 
        // splitContainer.Panel1
        // 
        splitContainer.Panel1.Controls.Add(tableLayoutPanel2);
        splitContainer.Panel1.RightToLeft = RightToLeft.Yes;
        // 
        // splitContainer.Panel2
        // 
        splitContainer.Panel2.Controls.Add(dataGridViewPresence);
        splitContainer.Panel2.RightToLeft = RightToLeft.Yes;
        splitContainer.Size = new Size(1280, 849);
        splitContainer.SplitterDistance = 573;
        splitContainer.SplitterWidth = 5;
        splitContainer.TabIndex = 0;
        // 
        // tableLayoutPanel2
        // 
        tableLayoutPanel2.BackColor = Color.WhiteSmoke;
        tableLayoutPanel2.ColumnCount = 1;
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel2.Controls.Add(panel1, 0, 0);
        tableLayoutPanel2.Controls.Add(tableLayoutPanel5, 0, 1);
        tableLayoutPanel2.Dock = DockStyle.Fill;
        tableLayoutPanel2.Location = new Point(0, 0);
        tableLayoutPanel2.Margin = new Padding(0);
        tableLayoutPanel2.Name = "tableLayoutPanel2";
        tableLayoutPanel2.RowCount = 2;
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 125F));
        tableLayoutPanel2.Size = new Size(573, 849);
        tableLayoutPanel2.TabIndex = 0;
        // 
        // panel1
        // 
        panel1.Controls.Add(tableLayoutPanel3);
        panel1.Dock = DockStyle.Fill;
        panel1.Location = new Point(0, 0);
        panel1.Margin = new Padding(0);
        panel1.Name = "panel1";
        panel1.Size = new Size(573, 724);
        panel1.TabIndex = 0;
        // 
        // tableLayoutPanel3
        // 
        tableLayoutPanel3.ColumnCount = 1;
        tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel3.Controls.Add(tableLayoutPanel6, 0, 2);
        tableLayoutPanel3.Controls.Add(pictureBoxCamera, 0, 0);
        tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 1);
        tableLayoutPanel3.Dock = DockStyle.Fill;
        tableLayoutPanel3.Location = new Point(0, 0);
        tableLayoutPanel3.Margin = new Padding(0);
        tableLayoutPanel3.Name = "tableLayoutPanel3";
        tableLayoutPanel3.RowCount = 3;
        tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 180F));
        tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 125F));
        tableLayoutPanel3.Size = new Size(573, 724);
        tableLayoutPanel3.TabIndex = 10;
        // 
        // tableLayoutPanel6
        // 
        tableLayoutPanel6.ColumnCount = 2;
        tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutPanel6.Controls.Add(buttonTakePhoto, 0, 0);
        tableLayoutPanel6.Controls.Add(buttonRegisterAndPrint, 1, 0);
        tableLayoutPanel6.Dock = DockStyle.Fill;
        tableLayoutPanel6.Location = new Point(0, 599);
        tableLayoutPanel6.Margin = new Padding(0);
        tableLayoutPanel6.Name = "tableLayoutPanel6";
        tableLayoutPanel6.RowCount = 1;
        tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanel6.Size = new Size(573, 125);
        tableLayoutPanel6.TabIndex = 1;
        // 
        // buttonTakePhoto
        // 
        buttonTakePhoto.Cursor = Cursors.Hand;
        buttonTakePhoto.Dock = DockStyle.Fill;
        buttonTakePhoto.FlatAppearance.BorderColor = Color.FromArgb(39, 43, 61);
        buttonTakePhoto.FlatAppearance.BorderSize = 0;
        buttonTakePhoto.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
        buttonTakePhoto.FlatStyle = FlatStyle.Flat;
        buttonTakePhoto.Font = new Font("Microsoft Sans Serif", 12F);
        buttonTakePhoto.ForeColor = Color.FromArgb(39, 43, 61);
        buttonTakePhoto.Image = Properties.Resources.Camera_01_128b;
        buttonTakePhoto.ImageAlign = ContentAlignment.MiddleRight;
        buttonTakePhoto.Location = new Point(314, 0);
        buttonTakePhoto.Margin = new Padding(27, 0, 27, 0);
        buttonTakePhoto.Name = "buttonTakePhoto";
        buttonTakePhoto.Size = new Size(232, 125);
        buttonTakePhoto.TabIndex = 0;
        buttonTakePhoto.Text = "عکسبرداری";
        buttonTakePhoto.TextAlign = ContentAlignment.MiddleLeft;
        buttonTakePhoto.TextImageRelation = TextImageRelation.ImageBeforeText;
        buttonTakePhoto.UseVisualStyleBackColor = false;
        buttonTakePhoto.Click += buttonTakePhoto_Click;
        // 
        // buttonRegisterAndPrint
        // 
        buttonRegisterAndPrint.BackColor = Color.WhiteSmoke;
        buttonRegisterAndPrint.Cursor = Cursors.Hand;
        buttonRegisterAndPrint.Dock = DockStyle.Fill;
        buttonRegisterAndPrint.FlatAppearance.BorderColor = Color.FromArgb(39, 43, 61);
        buttonRegisterAndPrint.FlatAppearance.BorderSize = 0;
        buttonRegisterAndPrint.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
        buttonRegisterAndPrint.FlatStyle = FlatStyle.Flat;
        buttonRegisterAndPrint.Font = new Font("Microsoft Sans Serif", 12F);
        buttonRegisterAndPrint.ForeColor = Color.FromArgb(39, 43, 61);
        buttonRegisterAndPrint.Image = Properties.Resources.Identity_Card_128b;
        buttonRegisterAndPrint.ImageAlign = ContentAlignment.MiddleRight;
        buttonRegisterAndPrint.Location = new Point(27, 0);
        buttonRegisterAndPrint.Margin = new Padding(27, 0, 27, 0);
        buttonRegisterAndPrint.Name = "buttonRegisterAndPrint";
        buttonRegisterAndPrint.Size = new Size(233, 125);
        buttonRegisterAndPrint.TabIndex = 1;
        buttonRegisterAndPrint.Text = "صدور کارت و چاپ";
        buttonRegisterAndPrint.TextAlign = ContentAlignment.MiddleLeft;
        buttonRegisterAndPrint.TextImageRelation = TextImageRelation.ImageBeforeText;
        buttonRegisterAndPrint.UseVisualStyleBackColor = false;
        buttonRegisterAndPrint.Click += buttonRegisterAndPrint_Click;
        // 
        // pictureBoxCamera
        // 
        pictureBoxCamera.BackColor = Color.Black;
        pictureBoxCamera.Dock = DockStyle.Fill;
        pictureBoxCamera.Location = new Point(0, 0);
        pictureBoxCamera.Margin = new Padding(0);
        pictureBoxCamera.Name = "pictureBoxCamera";
        pictureBoxCamera.Size = new Size(573, 419);
        pictureBoxCamera.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBoxCamera.TabIndex = 0;
        pictureBoxCamera.TabStop = false;
        // 
        // tableLayoutPanel4
        // 
        tableLayoutPanel4.BackColor = Color.WhiteSmoke;
        tableLayoutPanel4.ColumnCount = 4;
        tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 4F));
        tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
        tableLayoutPanel4.Controls.Add(panelCard, 3, 0);
        tableLayoutPanel4.Controls.Add(pictureBoxFace, 0, 0);
        tableLayoutPanel4.Controls.Add(pictureBoxDetectedFace, 1, 0);
        tableLayoutPanel4.Controls.Add(tableLayoutPanel7, 2, 0);
        tableLayoutPanel4.Dock = DockStyle.Fill;
        tableLayoutPanel4.Location = new Point(0, 434);
        tableLayoutPanel4.Margin = new Padding(0, 15, 0, 15);
        tableLayoutPanel4.Name = "tableLayoutPanel4";
        tableLayoutPanel4.RowCount = 1;
        tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutPanel4.Size = new Size(573, 150);
        tableLayoutPanel4.TabIndex = 2;
        // 
        // panelCard
        // 
        panelCard.BackColor = Color.WhiteSmoke;
        panelCard.Controls.Add(comboBoxGender);
        panelCard.Controls.Add(comboBoxHosts);
        panelCard.Controls.Add(labelDate);
        panelCard.Controls.Add(labelTime);
        panelCard.Controls.Add(textBoxDate);
        panelCard.Controls.Add(textBoxStartTime);
        panelCard.Controls.Add(labelHost);
        panelCard.Controls.Add(labelName);
        panelCard.Controls.Add(textBoxName);
        panelCard.Dock = DockStyle.Fill;
        panelCard.Location = new Point(0, 0);
        panelCard.Margin = new Padding(0);
        panelCard.Name = "panelCard";
        panelCard.Size = new Size(343, 150);
        panelCard.TabIndex = 8;
        // 
        // comboBoxGender
        // 
        comboBoxGender.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        comboBoxGender.BackColor = Color.WhiteSmoke;
        comboBoxGender.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxGender.FlatStyle = FlatStyle.Flat;
        comboBoxGender.Font = new Font("Microsoft Sans Serif", 9.75F);
        comboBoxGender.ForeColor = Color.Black;
        comboBoxGender.FormattingEnabled = true;
        comboBoxGender.Items.AddRange(new object[] { "آقای", "خانم" });
        comboBoxGender.Location = new Point(202, 26);
        comboBoxGender.Margin = new Padding(4, 5, 4, 5);
        comboBoxGender.Name = "comboBoxGender";
        comboBoxGender.Size = new Size(74, 28);
        comboBoxGender.TabIndex = 0;
        // 
        // comboBoxHosts
        // 
        comboBoxHosts.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        comboBoxHosts.BackColor = Color.WhiteSmoke;
        comboBoxHosts.FlatStyle = FlatStyle.Flat;
        comboBoxHosts.Font = new Font("Microsoft Sans Serif", 9.75F);
        comboBoxHosts.ForeColor = Color.Black;
        comboBoxHosts.FormattingEnabled = true;
        comboBoxHosts.Location = new Point(27, 71);
        comboBoxHosts.Margin = new Padding(4, 5, 4, 5);
        comboBoxHosts.Name = "comboBoxHosts";
        comboBoxHosts.Size = new Size(216, 28);
        comboBoxHosts.TabIndex = 2;
        // 
        // labelDate
        // 
        labelDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        labelDate.AutoSize = true;
        labelDate.Font = new Font("Microsoft Sans Serif", 9.75F);
        labelDate.Location = new Point(93, 114);
        labelDate.Margin = new Padding(4, 0, 4, 0);
        labelDate.Name = "labelDate";
        labelDate.Size = new Size(38, 20);
        labelDate.TabIndex = 3;
        labelDate.Text = "تاریخ";
        // 
        // labelTime
        // 
        labelTime.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        labelTime.AutoSize = true;
        labelTime.Font = new Font("Microsoft Sans Serif", 9.75F);
        labelTime.Location = new Point(249, 114);
        labelTime.Margin = new Padding(4, 0, 4, 0);
        labelTime.Name = "labelTime";
        labelTime.Size = new Size(70, 20);
        labelTime.TabIndex = 3;
        labelTime.Text = "زمان ورود";
        // 
        // textBoxDate
        // 
        textBoxDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        textBoxDate.BackColor = Color.WhiteSmoke;
        textBoxDate.BorderStyle = BorderStyle.None;
        textBoxDate.Location = new Point(-2, 114);
        textBoxDate.Margin = new Padding(4, 5, 4, 5);
        textBoxDate.Name = "textBoxDate";
        textBoxDate.ReadOnly = true;
        textBoxDate.Size = new Size(85, 20);
        textBoxDate.TabIndex = 2;
        textBoxDate.TabStop = false;
        // 
        // textBoxStartTime
        // 
        textBoxStartTime.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        textBoxStartTime.BackColor = Color.WhiteSmoke;
        textBoxStartTime.BorderStyle = BorderStyle.None;
        textBoxStartTime.Location = new Point(162, 114);
        textBoxStartTime.Margin = new Padding(4, 5, 4, 5);
        textBoxStartTime.Name = "textBoxStartTime";
        textBoxStartTime.ReadOnly = true;
        textBoxStartTime.Size = new Size(79, 20);
        textBoxStartTime.TabIndex = 2;
        textBoxStartTime.TabStop = false;
        // 
        // labelHost
        // 
        labelHost.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        labelHost.AutoSize = true;
        labelHost.Font = new Font("Microsoft Sans Serif", 9.75F);
        labelHost.Location = new Point(274, 74);
        labelHost.Margin = new Padding(4, 0, 4, 0);
        labelHost.Name = "labelHost";
        labelHost.Size = new Size(45, 20);
        labelHost.TabIndex = 3;
        labelHost.Text = "میزبان";
        // 
        // labelName
        // 
        labelName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        labelName.AutoSize = true;
        labelName.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 178);
        labelName.Location = new Point(296, 29);
        labelName.Margin = new Padding(4, 0, 4, 0);
        labelName.Name = "labelName";
        labelName.Size = new Size(23, 20);
        labelName.TabIndex = 3;
        labelName.Text = "نام";
        // 
        // textBoxName
        // 
        textBoxName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        textBoxName.BackColor = Color.WhiteSmoke;
        textBoxName.BorderStyle = BorderStyle.FixedSingle;
        textBoxName.Font = new Font("Microsoft Sans Serif", 9.75F);
        textBoxName.Location = new Point(27, 25);
        textBoxName.Margin = new Padding(4, 5, 4, 5);
        textBoxName.Name = "textBoxName";
        textBoxName.Size = new Size(167, 26);
        textBoxName.TabIndex = 1;
        // 
        // pictureBoxFace
        // 
        pictureBoxFace.BackColor = Color.WhiteSmoke;
        pictureBoxFace.Dock = DockStyle.Fill;
        pictureBoxFace.Location = new Point(467, 8);
        pictureBoxFace.Margin = new Padding(7, 8, 7, 8);
        pictureBoxFace.Name = "pictureBoxFace";
        pictureBoxFace.Size = new Size(99, 134);
        pictureBoxFace.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBoxFace.TabIndex = 0;
        pictureBoxFace.TabStop = false;
        pictureBoxFace.Click += pictureBoxFace_Click;
        // 
        // pictureBoxDetectedFace
        // 
        pictureBoxDetectedFace.BackColor = Color.WhiteSmoke;
        pictureBoxDetectedFace.Dock = DockStyle.Fill;
        pictureBoxDetectedFace.Location = new Point(354, 8);
        pictureBoxDetectedFace.Margin = new Padding(7, 8, 7, 8);
        pictureBoxDetectedFace.Name = "pictureBoxDetectedFace";
        pictureBoxDetectedFace.Size = new Size(99, 134);
        pictureBoxDetectedFace.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBoxDetectedFace.TabIndex = 0;
        pictureBoxDetectedFace.TabStop = false;
        // 
        // tableLayoutPanel7
        // 
        tableLayoutPanel7.ColumnCount = 1;
        tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel7.Controls.Add(panel4, 0, 1);
        tableLayoutPanel7.Dock = DockStyle.Fill;
        tableLayoutPanel7.Location = new Point(343, 0);
        tableLayoutPanel7.Margin = new Padding(0);
        tableLayoutPanel7.Name = "tableLayoutPanel7";
        tableLayoutPanel7.RowCount = 3;
        tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 208F));
        tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanel7.Size = new Size(4, 150);
        tableLayoutPanel7.TabIndex = 1;
        // 
        // panel4
        // 
        panel4.BackColor = Color.LightGray;
        panel4.Dock = DockStyle.Fill;
        panel4.Location = new Point(0, -29);
        panel4.Margin = new Padding(0);
        panel4.Name = "panel4";
        panel4.Size = new Size(4, 208);
        panel4.TabIndex = 0;
        // 
        // tableLayoutPanel5
        // 
        tableLayoutPanel5.BackColor = Color.WhiteSmoke;
        tableLayoutPanel5.ColumnCount = 3;
        tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 53F));
        tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutPanel5.Controls.Add(panel5, 2, 1);
        tableLayoutPanel5.Controls.Add(labelDateTime, 1, 2);
        tableLayoutPanel5.Controls.Add(panel2, 1, 1);
        tableLayoutPanel5.Controls.Add(labelCardTitle, 1, 0);
        tableLayoutPanel5.Controls.Add(labelVisitorsCount, 2, 2);
        tableLayoutPanel5.Dock = DockStyle.Fill;
        tableLayoutPanel5.Location = new Point(0, 724);
        tableLayoutPanel5.Margin = new Padding(0);
        tableLayoutPanel5.Name = "tableLayoutPanel5";
        tableLayoutPanel5.RightToLeft = RightToLeft.No;
        tableLayoutPanel5.RowCount = 3;
        tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 5F));
        tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanel5.Size = new Size(573, 125);
        tableLayoutPanel5.TabIndex = 7;
        // 
        // panel5
        // 
        panel5.BackColor = Color.FromArgb(39, 43, 61);
        panel5.Dock = DockStyle.Fill;
        panel5.Location = new Point(313, 60);
        panel5.Margin = new Padding(0);
        panel5.Name = "panel5";
        panel5.Size = new Size(260, 5);
        panel5.TabIndex = 11;
        // 
        // labelDateTime
        // 
        labelDateTime.BackColor = Color.Transparent;
        labelDateTime.Dock = DockStyle.Fill;
        labelDateTime.Font = new Font("Microsoft Sans Serif", 12F);
        labelDateTime.Location = new Point(57, 65);
        labelDateTime.Margin = new Padding(4, 0, 4, 0);
        labelDateTime.Name = "labelDateTime";
        labelDateTime.Size = new Size(252, 60);
        labelDateTime.TabIndex = 5;
        labelDateTime.Text = "ساعت و تاریخ";
        labelDateTime.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // panel2
        // 
        panel2.BackColor = Color.FromArgb(39, 43, 61);
        panel2.Dock = DockStyle.Fill;
        panel2.Location = new Point(53, 60);
        panel2.Margin = new Padding(0);
        panel2.Name = "panel2";
        panel2.Size = new Size(260, 5);
        panel2.TabIndex = 0;
        // 
        // labelCardTitle
        // 
        labelCardTitle.AutoSize = true;
        tableLayoutPanel5.SetColumnSpan(labelCardTitle, 2);
        labelCardTitle.Dock = DockStyle.Fill;
        labelCardTitle.Font = new Font("Microsoft Sans Serif", 12F);
        labelCardTitle.Location = new Point(57, 0);
        labelCardTitle.Margin = new Padding(4, 0, 4, 0);
        labelCardTitle.Name = "labelCardTitle";
        labelCardTitle.Size = new Size(512, 60);
        labelCardTitle.TabIndex = 1;
        labelCardTitle.Text = "کارت ورود میهمان";
        labelCardTitle.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // labelVisitorsCount
        // 
        labelVisitorsCount.BackColor = Color.Transparent;
        labelVisitorsCount.Dock = DockStyle.Fill;
        labelVisitorsCount.Font = new Font("Microsoft Sans Serif", 12F);
        labelVisitorsCount.Location = new Point(317, 65);
        labelVisitorsCount.Margin = new Padding(4, 0, 4, 0);
        labelVisitorsCount.Name = "labelVisitorsCount";
        labelVisitorsCount.Size = new Size(252, 60);
        labelVisitorsCount.TabIndex = 10;
        labelVisitorsCount.Text = "تعداد مراجعین";
        labelVisitorsCount.TextAlign = ContentAlignment.MiddleRight;
        // 
        // dataGridViewPresence
        // 
        dataGridViewPresence.AllowUserToAddRows = false;
        dataGridViewPresence.AllowUserToDeleteRows = false;
        dataGridViewPresence.AutoGenerateColumns = false;
        dataGridViewPresence.BackgroundColor = Color.WhiteSmoke;
        dataGridViewPresence.BorderStyle = BorderStyle.None;
        dataGridViewPresence.CellBorderStyle = DataGridViewCellBorderStyle.None;
        dataGridViewPresence.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
        dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle1.BackColor = Color.Gainsboro;
        dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 12F);
        dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
        dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
        dataGridViewPresence.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
        dataGridViewPresence.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewPresence.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, personDataGridViewTextBoxColumn, hostDataGridViewTextBoxColumn, startDateDataGridViewTextBoxColumn, StartDatePersian, Photo, ColumnButtonReprint, ColumnButtonExit, ColumnDummy, registrarDataGridViewTextBoxColumn });
        dataGridViewPresence.DataSource = bindingSourceTodayPresences;
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = SystemColors.Window;
        dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9.75F);
        dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
        dataGridViewCellStyle2.SelectionBackColor = Color.DimGray;
        dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
        dataGridViewPresence.DefaultCellStyle = dataGridViewCellStyle2;
        dataGridViewPresence.Dock = DockStyle.Fill;
        dataGridViewPresence.Location = new Point(0, 0);
        dataGridViewPresence.Margin = new Padding(0);
        dataGridViewPresence.Name = "dataGridViewPresence";
        dataGridViewPresence.ReadOnly = true;
        dataGridViewPresence.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
        dataGridViewPresence.RowHeadersVisible = false;
        dataGridViewPresence.RowHeadersWidth = 51;
        dataGridViewPresence.RowTemplate.Height = 50;
        dataGridViewPresence.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dataGridViewPresence.Size = new Size(702, 849);
        dataGridViewPresence.TabIndex = 0;
        dataGridViewPresence.TabStop = false;
        dataGridViewPresence.CellContentClick += dataGridViewPresence_CellContentClick;
        dataGridViewPresence.CellFormatting += dataGridViewPresence_CellFormatting;
        // 
        // idDataGridViewTextBoxColumn
        // 
        idDataGridViewTextBoxColumn.DataPropertyName = "Id";
        idDataGridViewTextBoxColumn.HeaderText = "شناسه";
        idDataGridViewTextBoxColumn.MinimumWidth = 6;
        idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
        idDataGridViewTextBoxColumn.ReadOnly = true;
        idDataGridViewTextBoxColumn.Visible = false;
        idDataGridViewTextBoxColumn.Width = 110;
        // 
        // personDataGridViewTextBoxColumn
        // 
        personDataGridViewTextBoxColumn.DataPropertyName = "Person";
        personDataGridViewTextBoxColumn.HeaderText = "نام";
        personDataGridViewTextBoxColumn.MinimumWidth = 6;
        personDataGridViewTextBoxColumn.Name = "personDataGridViewTextBoxColumn";
        personDataGridViewTextBoxColumn.ReadOnly = true;
        personDataGridViewTextBoxColumn.Width = 130;
        // 
        // hostDataGridViewTextBoxColumn
        // 
        hostDataGridViewTextBoxColumn.DataPropertyName = "Host";
        hostDataGridViewTextBoxColumn.HeaderText = "میزبان";
        hostDataGridViewTextBoxColumn.MinimumWidth = 6;
        hostDataGridViewTextBoxColumn.Name = "hostDataGridViewTextBoxColumn";
        hostDataGridViewTextBoxColumn.ReadOnly = true;
        hostDataGridViewTextBoxColumn.Width = 130;
        // 
        // startDateDataGridViewTextBoxColumn
        // 
        startDateDataGridViewTextBoxColumn.DataPropertyName = "StartTime";
        startDateDataGridViewTextBoxColumn.HeaderText = "زمان ورود";
        startDateDataGridViewTextBoxColumn.MinimumWidth = 6;
        startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
        startDateDataGridViewTextBoxColumn.ReadOnly = true;
        startDateDataGridViewTextBoxColumn.Width = 110;
        // 
        // StartDatePersian
        // 
        StartDatePersian.DataPropertyName = "StartDatePersian";
        StartDatePersian.HeaderText = "تاریخ";
        StartDatePersian.MinimumWidth = 6;
        StartDatePersian.Name = "StartDatePersian";
        StartDatePersian.ReadOnly = true;
        StartDatePersian.Width = 110;
        // 
        // Photo
        // 
        Photo.DataPropertyName = "Photo";
        Photo.HeaderText = "عکس";
        Photo.ImageLayout = DataGridViewImageCellLayout.Zoom;
        Photo.MinimumWidth = 6;
        Photo.Name = "Photo";
        Photo.ReadOnly = true;
        Photo.Width = 110;
        // 
        // ColumnButtonReprint
        // 
        ColumnButtonReprint.HeaderText = "چاپ مجدد";
        ColumnButtonReprint.Image = Properties.Resources.Identity_Card_128b;
        ColumnButtonReprint.MinimumWidth = 6;
        ColumnButtonReprint.Name = "ColumnButtonReprint";
        ColumnButtonReprint.ReadOnly = true;
        ColumnButtonReprint.Resizable = DataGridViewTriState.True;
        ColumnButtonReprint.Width = 110;
        // 
        // ColumnButtonExit
        // 
        ColumnButtonExit.HeaderText = "ثبت خروج";
        ColumnButtonExit.Image = Properties.Resources.Login_Door_Dark_128;
        ColumnButtonExit.MinimumWidth = 6;
        ColumnButtonExit.Name = "ColumnButtonExit";
        ColumnButtonExit.ReadOnly = true;
        ColumnButtonExit.Resizable = DataGridViewTriState.True;
        ColumnButtonExit.Width = 110;
        // 
        // ColumnDummy
        // 
        ColumnDummy.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        ColumnDummy.HeaderText = "";
        ColumnDummy.MinimumWidth = 6;
        ColumnDummy.Name = "ColumnDummy";
        ColumnDummy.ReadOnly = true;
        // 
        // registrarDataGridViewTextBoxColumn
        // 
        registrarDataGridViewTextBoxColumn.DataPropertyName = "Registrar";
        registrarDataGridViewTextBoxColumn.HeaderText = "ثبت کننده";
        registrarDataGridViewTextBoxColumn.MinimumWidth = 6;
        registrarDataGridViewTextBoxColumn.Name = "registrarDataGridViewTextBoxColumn";
        registrarDataGridViewTextBoxColumn.ReadOnly = true;
        registrarDataGridViewTextBoxColumn.Visible = false;
        registrarDataGridViewTextBoxColumn.Width = 110;
        // 
        // bindingSourceTodayPresences
        // 
        bindingSourceTodayPresences.DataSource = typeof(Presence);
        // 
        // timerDateTime
        // 
        timerDateTime.Interval = 60000;
        timerDateTime.Tick += timerDateTime_Tick;
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 1;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel1.Controls.Add(splitContainer, 0, 1);
        tableLayoutPanel1.Controls.Add(panel3, 0, 0);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Location = new Point(0, 0);
        tableLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 2;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 111F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutPanel1.Size = new Size(1280, 960);
        tableLayoutPanel1.TabIndex = 5;
        // 
        // panel3
        // 
        panel3.BackColor = Color.FromArgb(39, 43, 61);
        panel3.Controls.Add(buttonExit);
        panel3.Controls.Add(buttonSettings);
        panel3.Controls.Add(buttonReport);
        panel3.Controls.Add(buttonShutdown);
        panel3.Controls.Add(buttonHelp);
        panel3.Dock = DockStyle.Fill;
        panel3.ForeColor = Color.WhiteSmoke;
        panel3.Location = new Point(0, 0);
        panel3.Margin = new Padding(0);
        panel3.Name = "panel3";
        panel3.Size = new Size(1280, 111);
        panel3.TabIndex = 3;
        // 
        // buttonExit
        // 
        buttonExit.Cursor = Cursors.Hand;
        buttonExit.Dock = DockStyle.Left;
        buttonExit.FlatAppearance.BorderColor = Color.FromArgb(52, 73, 94);
        buttonExit.FlatAppearance.BorderSize = 0;
        buttonExit.FlatAppearance.CheckedBackColor = Color.Gainsboro;
        buttonExit.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
        buttonExit.FlatStyle = FlatStyle.Flat;
        buttonExit.Font = new Font("Microsoft Sans Serif", 12F);
        buttonExit.ForeColor = Color.WhiteSmoke;
        buttonExit.Image = Properties.Resources.Login_Door_1281;
        buttonExit.Location = new Point(336, 0);
        buttonExit.Margin = new Padding(0);
        buttonExit.Name = "buttonExit";
        buttonExit.Size = new Size(152, 111);
        buttonExit.TabIndex = 2;
        buttonExit.TabStop = false;
        buttonExit.Text = "خروج";
        buttonExit.TextImageRelation = TextImageRelation.ImageBeforeText;
        buttonExit.UseVisualStyleBackColor = true;
        buttonExit.Click += buttonLogout_Click;
        // 
        // buttonSettings
        // 
        buttonSettings.BackgroundImageLayout = ImageLayout.Zoom;
        buttonSettings.Cursor = Cursors.Hand;
        buttonSettings.Dock = DockStyle.Right;
        buttonSettings.FlatAppearance.BorderColor = Color.FromArgb(52, 73, 94);
        buttonSettings.FlatAppearance.BorderSize = 0;
        buttonSettings.FlatAppearance.CheckedBackColor = Color.Gainsboro;
        buttonSettings.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
        buttonSettings.FlatStyle = FlatStyle.Flat;
        buttonSettings.Font = new Font("Microsoft Sans Serif", 12F);
        buttonSettings.ForeColor = Color.WhiteSmoke;
        buttonSettings.Image = Properties.Resources.Tools_02_1281;
        buttonSettings.Location = new Point(901, 0);
        buttonSettings.Margin = new Padding(0);
        buttonSettings.Name = "buttonSettings";
        buttonSettings.Size = new Size(179, 111);
        buttonSettings.TabIndex = 1;
        buttonSettings.TabStop = false;
        buttonSettings.Text = "تنظیم‌ها";
        buttonSettings.TextImageRelation = TextImageRelation.ImageBeforeText;
        buttonSettings.UseVisualStyleBackColor = true;
        buttonSettings.Visible = false;
        // 
        // buttonReport
        // 
        buttonReport.Cursor = Cursors.Hand;
        buttonReport.Dock = DockStyle.Right;
        buttonReport.FlatAppearance.BorderColor = Color.FromArgb(39, 43, 61);
        buttonReport.FlatAppearance.BorderSize = 0;
        buttonReport.FlatAppearance.CheckedBackColor = Color.Gainsboro;
        buttonReport.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
        buttonReport.FlatStyle = FlatStyle.Flat;
        buttonReport.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 178);
        buttonReport.ForeColor = Color.WhiteSmoke;
        buttonReport.Image = Properties.Resources.Clipboard_1281;
        buttonReport.Location = new Point(1080, 0);
        buttonReport.Margin = new Padding(0);
        buttonReport.Name = "buttonReport";
        buttonReport.Size = new Size(200, 111);
        buttonReport.TabIndex = 0;
        buttonReport.TabStop = false;
        buttonReport.Text = "گزارش‌ها";
        buttonReport.TextImageRelation = TextImageRelation.ImageBeforeText;
        buttonReport.UseVisualStyleBackColor = true;
        buttonReport.Click += buttonReport_Click;
        // 
        // buttonShutdown
        // 
        buttonShutdown.Cursor = Cursors.Hand;
        buttonShutdown.Dock = DockStyle.Left;
        buttonShutdown.FlatAppearance.BorderColor = Color.FromArgb(52, 73, 94);
        buttonShutdown.FlatAppearance.BorderSize = 0;
        buttonShutdown.FlatAppearance.CheckedBackColor = Color.Gainsboro;
        buttonShutdown.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
        buttonShutdown.FlatStyle = FlatStyle.Flat;
        buttonShutdown.Font = new Font("Microsoft Sans Serif", 12F);
        buttonShutdown.ForeColor = Color.WhiteSmoke;
        buttonShutdown.Image = Properties.Resources.Media_Start_1281;
        buttonShutdown.Location = new Point(157, 0);
        buttonShutdown.Margin = new Padding(0);
        buttonShutdown.Name = "buttonShutdown";
        buttonShutdown.Size = new Size(179, 111);
        buttonShutdown.TabIndex = 1;
        buttonShutdown.TabStop = false;
        buttonShutdown.Text = "خاموش";
        buttonShutdown.TextImageRelation = TextImageRelation.ImageBeforeText;
        buttonShutdown.UseVisualStyleBackColor = true;
        buttonShutdown.Click += buttonShutdown_Click;
        // 
        // buttonHelp
        // 
        buttonHelp.Cursor = Cursors.Hand;
        buttonHelp.Dock = DockStyle.Left;
        buttonHelp.FlatAppearance.BorderColor = Color.FromArgb(52, 73, 94);
        buttonHelp.FlatAppearance.BorderSize = 0;
        buttonHelp.FlatAppearance.CheckedBackColor = Color.Gainsboro;
        buttonHelp.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
        buttonHelp.FlatStyle = FlatStyle.Flat;
        buttonHelp.Font = new Font("Microsoft Sans Serif", 12F);
        buttonHelp.ForeColor = Color.WhiteSmoke;
        buttonHelp.Image = Properties.Resources.Student_Read_02_128;
        buttonHelp.Location = new Point(0, 0);
        buttonHelp.Margin = new Padding(0);
        buttonHelp.Name = "buttonHelp";
        buttonHelp.Size = new Size(157, 111);
        buttonHelp.TabIndex = 2;
        buttonHelp.TabStop = false;
        buttonHelp.Text = "راهنما";
        buttonHelp.TextImageRelation = TextImageRelation.ImageBeforeText;
        buttonHelp.UseVisualStyleBackColor = true;
        buttonHelp.Click += buttonHelp_Click;
        // 
        // dataGridViewImageColumn1
        // 
        dataGridViewImageColumn1.HeaderText = "";
        dataGridViewImageColumn1.Image = Properties.Resources.Identity_Card_128b;
        dataGridViewImageColumn1.MinimumWidth = 6;
        dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
        dataGridViewImageColumn1.ReadOnly = true;
        dataGridViewImageColumn1.Resizable = DataGridViewTriState.True;
        dataGridViewImageColumn1.Width = 125;
        // 
        // dataGridViewImageColumn2
        // 
        dataGridViewImageColumn2.HeaderText = "";
        dataGridViewImageColumn2.Image = Properties.Resources.Login_Door_Dark_128;
        dataGridViewImageColumn2.MinimumWidth = 6;
        dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
        dataGridViewImageColumn2.ReadOnly = true;
        dataGridViewImageColumn2.Resizable = DataGridViewTriState.True;
        dataGridViewImageColumn2.Width = 125;
        // 
        // FormMain
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.WhiteSmoke;
        ClientSize = new Size(1280, 960);
        ControlBox = false;
        Controls.Add(tableLayoutPanel1);
        FormBorderStyle = FormBorderStyle.None;
        KeyPreview = true;
        Margin = new Padding(4, 5, 4, 5);
        Name = "FormMain";
        RightToLeft = RightToLeft.Yes;
        Text = "به فرما";
        WindowState = FormWindowState.Maximized;
        FormClosing += FormMain_FormClosing;
        Load += FormMain_Load;
        KeyDown += FormMain_KeyDown;
        splitContainer.Panel1.ResumeLayout(false);
        splitContainer.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
        splitContainer.ResumeLayout(false);
        tableLayoutPanel2.ResumeLayout(false);
        panel1.ResumeLayout(false);
        tableLayoutPanel3.ResumeLayout(false);
        tableLayoutPanel6.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pictureBoxCamera).EndInit();
        tableLayoutPanel4.ResumeLayout(false);
        panelCard.ResumeLayout(false);
        panelCard.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBoxFace).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBoxDetectedFace).EndInit();
        tableLayoutPanel7.ResumeLayout(false);
        tableLayoutPanel5.ResumeLayout(false);
        tableLayoutPanel5.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridViewPresence).EndInit();
        ((System.ComponentModel.ISupportInitialize)bindingSourceTodayPresences).EndInit();
        tableLayoutPanel1.ResumeLayout(false);
        panel3.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.SplitContainer splitContainer;
    private System.Windows.Forms.Timer timerDateTime;
    private System.Windows.Forms.DataGridView dataGridViewPresence;
    private System.Windows.Forms.BindingSource bindingSourceTodayPresences;
    private System.Windows.Forms.Button buttonShutdown;
    private System.Windows.Forms.Button buttonExit;
    private System.Windows.Forms.Button buttonSettings;
    private System.Windows.Forms.Button buttonHelp;
    private System.Windows.Forms.Button buttonReport;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel panelCard;
    private System.Windows.Forms.ComboBox comboBoxHosts;
    private System.Windows.Forms.Label labelDate;
    private System.Windows.Forms.Label labelTime;
    private System.Windows.Forms.TextBox textBoxDate;
    private System.Windows.Forms.TextBox textBoxStartTime;
    private System.Windows.Forms.Label labelHost;
    private System.Windows.Forms.Label labelName;
    private System.Windows.Forms.TextBox textBoxName;
    private System.Windows.Forms.Label labelCardTitle;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.Label labelDateTime;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
    private System.Windows.Forms.Button buttonTakePhoto;
    private System.Windows.Forms.Button buttonRegisterAndPrint;
    private System.Windows.Forms.PictureBox pictureBoxCamera;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
    private System.Windows.Forms.PictureBox pictureBoxFace;
    private System.Windows.Forms.PictureBox pictureBoxDetectedFace;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
    private System.Windows.Forms.Panel panel4;
    private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
    private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
    private System.Windows.Forms.ComboBox comboBoxGender;
    private System.Windows.Forms.Panel panel5;
    private System.Windows.Forms.Label labelVisitorsCount;
    private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn personDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn hostDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn StartDatePersian;
    private DataGridViewImageColumn Photo;
    private DataGridViewImageColumn ColumnButtonReprint;
    private DataGridViewImageColumn ColumnButtonExit;
    private DataGridViewTextBoxColumn ColumnDummy;
    private DataGridViewTextBoxColumn registrarDataGridViewTextBoxColumn;
}

