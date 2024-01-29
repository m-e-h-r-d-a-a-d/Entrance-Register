using EntranceRegister.Models;

namespace EntranceRegister.Forms;

partial class FormReport
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
        panel2 = new Panel();
        comboBoxGates = new ComboBox();
        label2 = new Label();
        buttonSearch = new Button();
        label1 = new Label();
        labelHost = new Label();
        textBoxDateTo = new MaskedTextBox();
        textBoxName = new TextBox();
        comboBoxHosts = new ComboBox();
        labelName = new Label();
        labelDate = new Label();
        textBoxDateFrom = new MaskedTextBox();
        dataGridViewPresence = new DataGridView();
        idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        personDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        hostDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        gateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        startDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        EndTime = new DataGridViewTextBoxColumn();
        StartDatePersian = new DataGridViewTextBoxColumn();
        Photo = new DataGridViewImageColumn();
        registrarDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        ColumnDummy = new DataGridViewTextBoxColumn();
        bindingSourcePresences = new BindingSource(components);
        tableLayoutPanel1 = new TableLayoutPanel();
        panel1 = new Panel();
        buttonExport = new Button();
        buttonLogOut = new Button();
        buttonShutdown = new Button();
        buttonHelp = new Button();
        buttonExit = new Button();
        saveFileDialog = new SaveFileDialog();
        dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
        ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
        splitContainer.Panel1.SuspendLayout();
        splitContainer.Panel2.SuspendLayout();
        splitContainer.SuspendLayout();
        panel2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridViewPresence).BeginInit();
        ((System.ComponentModel.ISupportInitialize)bindingSourcePresences).BeginInit();
        tableLayoutPanel1.SuspendLayout();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // splitContainer
        // 
        splitContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        splitContainer.BackColor = Color.WhiteSmoke;
        splitContainer.Location = new Point(4, 116);
        splitContainer.Margin = new Padding(4, 5, 4, 5);
        splitContainer.Name = "splitContainer";
        // 
        // splitContainer.Panel1
        // 
        splitContainer.Panel1.Controls.Add(panel2);
        splitContainer.Panel1.RightToLeft = RightToLeft.Yes;
        // 
        // splitContainer.Panel2
        // 
        splitContainer.Panel2.Controls.Add(dataGridViewPresence);
        splitContainer.Panel2.RightToLeft = RightToLeft.Yes;
        splitContainer.Size = new Size(1272, 839);
        splitContainer.SplitterDistance = 429;
        splitContainer.SplitterWidth = 5;
        splitContainer.TabIndex = 0;
        // 
        // panel2
        // 
        panel2.Controls.Add(comboBoxGates);
        panel2.Controls.Add(label2);
        panel2.Controls.Add(buttonSearch);
        panel2.Controls.Add(label1);
        panel2.Controls.Add(labelHost);
        panel2.Controls.Add(textBoxDateTo);
        panel2.Controls.Add(textBoxName);
        panel2.Controls.Add(comboBoxHosts);
        panel2.Controls.Add(labelName);
        panel2.Controls.Add(labelDate);
        panel2.Controls.Add(textBoxDateFrom);
        panel2.Dock = DockStyle.Top;
        panel2.Location = new Point(0, 0);
        panel2.Margin = new Padding(4, 5, 4, 5);
        panel2.Name = "panel2";
        panel2.Size = new Size(429, 309);
        panel2.TabIndex = 15;
        // 
        // comboBoxGates
        // 
        comboBoxGates.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        comboBoxGates.BackColor = Color.WhiteSmoke;
        comboBoxGates.FlatStyle = FlatStyle.Flat;
        comboBoxGates.Font = new Font("Microsoft Sans Serif", 9.75F);
        comboBoxGates.FormattingEnabled = true;
        comboBoxGates.Location = new Point(19, 58);
        comboBoxGates.Margin = new Padding(4, 5, 4, 5);
        comboBoxGates.Name = "comboBoxGates";
        comboBoxGates.Size = new Size(315, 28);
        comboBoxGates.TabIndex = 18;
        comboBoxGates.SelectedIndexChanged += comboBoxGates_SelectedIndexChanged;
        // 
        // label2
        // 
        label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        label2.AutoSize = true;
        label2.Font = new Font("Microsoft Sans Serif", 9.75F);
        label2.Location = new Point(364, 66);
        label2.Margin = new Padding(4, 0, 4, 0);
        label2.Name = "label2";
        label2.Size = new Size(39, 20);
        label2.TabIndex = 17;
        label2.Text = "درگاه";
        // 
        // buttonSearch
        // 
        buttonSearch.BackColor = Color.WhiteSmoke;
        buttonSearch.Cursor = Cursors.Hand;
        buttonSearch.Dock = DockStyle.Bottom;
        buttonSearch.FlatAppearance.BorderColor = Color.FromArgb(39, 43, 61);
        buttonSearch.FlatAppearance.BorderSize = 0;
        buttonSearch.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
        buttonSearch.FlatStyle = FlatStyle.Flat;
        buttonSearch.Font = new Font("Microsoft Sans Serif", 12F);
        buttonSearch.ForeColor = Color.FromArgb(39, 43, 61);
        buttonSearch.Image = Properties.Resources.Search_Find_128;
        buttonSearch.ImageAlign = ContentAlignment.MiddleRight;
        buttonSearch.Location = new Point(0, 197);
        buttonSearch.Margin = new Padding(27, 0, 27, 0);
        buttonSearch.Name = "buttonSearch";
        buttonSearch.Size = new Size(429, 112);
        buttonSearch.TabIndex = 4;
        buttonSearch.Text = "جستجو";
        buttonSearch.TextAlign = ContentAlignment.MiddleLeft;
        buttonSearch.TextImageRelation = TextImageRelation.ImageBeforeText;
        buttonSearch.UseVisualStyleBackColor = false;
        buttonSearch.Click += buttonSearch_Click;
        // 
        // label1
        // 
        label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        label1.AutoSize = true;
        label1.Font = new Font("Microsoft Sans Serif", 9.75F);
        label1.Location = new Point(209, 163);
        label1.Margin = new Padding(4, 0, 4, 0);
        label1.Name = "label1";
        label1.Size = new Size(17, 20);
        label1.TabIndex = 14;
        label1.Text = "تا";
        // 
        // labelHost
        // 
        labelHost.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        labelHost.AutoSize = true;
        labelHost.Font = new Font("Microsoft Sans Serif", 9.75F);
        labelHost.Location = new Point(361, 114);
        labelHost.Margin = new Padding(4, 0, 4, 0);
        labelHost.Name = "labelHost";
        labelHost.Size = new Size(45, 20);
        labelHost.TabIndex = 10;
        labelHost.Text = "میزبان";
        // 
        // textBoxDateTo
        // 
        textBoxDateTo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        textBoxDateTo.BackColor = Color.WhiteSmoke;
        textBoxDateTo.Font = new Font("Microsoft Sans Serif", 9.75F);
        textBoxDateTo.Location = new Point(89, 160);
        textBoxDateTo.Margin = new Padding(4, 5, 4, 5);
        textBoxDateTo.Mask = "0000/00/00";
        textBoxDateTo.Name = "textBoxDateTo";
        textBoxDateTo.RightToLeft = RightToLeft.No;
        textBoxDateTo.Size = new Size(111, 26);
        textBoxDateTo.TabIndex = 3;
        // 
        // textBoxName
        // 
        textBoxName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        textBoxName.BackColor = Color.WhiteSmoke;
        textBoxName.BorderStyle = BorderStyle.FixedSingle;
        textBoxName.Font = new Font("Microsoft Sans Serif", 9.75F);
        textBoxName.Location = new Point(19, 14);
        textBoxName.Margin = new Padding(4, 5, 4, 5);
        textBoxName.Name = "textBoxName";
        textBoxName.Size = new Size(315, 26);
        textBoxName.TabIndex = 0;
        // 
        // comboBoxHosts
        // 
        comboBoxHosts.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        comboBoxHosts.BackColor = Color.WhiteSmoke;
        comboBoxHosts.FlatStyle = FlatStyle.Flat;
        comboBoxHosts.Font = new Font("Microsoft Sans Serif", 9.75F);
        comboBoxHosts.FormattingEnabled = true;
        comboBoxHosts.Location = new Point(19, 106);
        comboBoxHosts.Margin = new Padding(4, 5, 4, 5);
        comboBoxHosts.Name = "comboBoxHosts";
        comboBoxHosts.Size = new Size(315, 28);
        comboBoxHosts.TabIndex = 1;
        // 
        // labelName
        // 
        labelName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        labelName.AutoSize = true;
        labelName.Font = new Font("Microsoft Sans Serif", 9.75F);
        labelName.Location = new Point(385, 18);
        labelName.Margin = new Padding(4, 0, 4, 0);
        labelName.Name = "labelName";
        labelName.Size = new Size(23, 20);
        labelName.TabIndex = 11;
        labelName.Text = "نام";
        // 
        // labelDate
        // 
        labelDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        labelDate.AutoSize = true;
        labelDate.Font = new Font("Microsoft Sans Serif", 9.75F);
        labelDate.Location = new Point(351, 162);
        labelDate.Margin = new Padding(4, 0, 4, 0);
        labelDate.Name = "labelDate";
        labelDate.Size = new Size(55, 20);
        labelDate.TabIndex = 8;
        labelDate.Text = "تاریخ از";
        // 
        // textBoxDateFrom
        // 
        textBoxDateFrom.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        textBoxDateFrom.BackColor = Color.WhiteSmoke;
        textBoxDateFrom.Font = new Font("Microsoft Sans Serif", 9.75F);
        textBoxDateFrom.Location = new Point(239, 160);
        textBoxDateFrom.Margin = new Padding(4, 5, 4, 5);
        textBoxDateFrom.Mask = "0000/00/00";
        textBoxDateFrom.Name = "textBoxDateFrom";
        textBoxDateFrom.RightToLeft = RightToLeft.No;
        textBoxDateFrom.Size = new Size(93, 26);
        textBoxDateFrom.TabIndex = 2;
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
        dataGridViewPresence.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, personDataGridViewTextBoxColumn, hostDataGridViewTextBoxColumn, gateDataGridViewTextBoxColumn, startDateDataGridViewTextBoxColumn, EndTime, StartDatePersian, Photo, registrarDataGridViewTextBoxColumn, ColumnDummy });
        dataGridViewPresence.DataSource = bindingSourcePresences;
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = SystemColors.Window;
        dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9.75F);
        dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
        dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
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
        dataGridViewPresence.Size = new Size(838, 839);
        dataGridViewPresence.TabIndex = 0;
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
        idDataGridViewTextBoxColumn.Width = 125;
        // 
        // personDataGridViewTextBoxColumn
        // 
        personDataGridViewTextBoxColumn.DataPropertyName = "Person";
        personDataGridViewTextBoxColumn.HeaderText = "نام";
        personDataGridViewTextBoxColumn.MinimumWidth = 6;
        personDataGridViewTextBoxColumn.Name = "personDataGridViewTextBoxColumn";
        personDataGridViewTextBoxColumn.ReadOnly = true;
        personDataGridViewTextBoxColumn.Width = 150;
        // 
        // hostDataGridViewTextBoxColumn
        // 
        hostDataGridViewTextBoxColumn.DataPropertyName = "Host";
        hostDataGridViewTextBoxColumn.HeaderText = "میزبان";
        hostDataGridViewTextBoxColumn.MinimumWidth = 6;
        hostDataGridViewTextBoxColumn.Name = "hostDataGridViewTextBoxColumn";
        hostDataGridViewTextBoxColumn.ReadOnly = true;
        hostDataGridViewTextBoxColumn.Width = 150;
        // 
        // gateDataGridViewTextBoxColumn
        // 
        gateDataGridViewTextBoxColumn.DataPropertyName = "GateName";
        gateDataGridViewTextBoxColumn.HeaderText = "ورودی";
        gateDataGridViewTextBoxColumn.MinimumWidth = 6;
        gateDataGridViewTextBoxColumn.Name = "gateDataGridViewTextBoxColumn";
        gateDataGridViewTextBoxColumn.ReadOnly = true;
        gateDataGridViewTextBoxColumn.Width = 125;
        // 
        // startDateDataGridViewTextBoxColumn
        // 
        startDateDataGridViewTextBoxColumn.DataPropertyName = "StartTime";
        startDateDataGridViewTextBoxColumn.HeaderText = "زمان ورود";
        startDateDataGridViewTextBoxColumn.MinimumWidth = 6;
        startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
        startDateDataGridViewTextBoxColumn.ReadOnly = true;
        startDateDataGridViewTextBoxColumn.Width = 125;
        // 
        // EndTime
        // 
        EndTime.DataPropertyName = "EndTime";
        EndTime.HeaderText = "زمان خروج";
        EndTime.MinimumWidth = 6;
        EndTime.Name = "EndTime";
        EndTime.ReadOnly = true;
        EndTime.Width = 125;
        // 
        // StartDatePersian
        // 
        StartDatePersian.DataPropertyName = "StartDatePersian";
        StartDatePersian.HeaderText = "تاریخ";
        StartDatePersian.MinimumWidth = 6;
        StartDatePersian.Name = "StartDatePersian";
        StartDatePersian.ReadOnly = true;
        StartDatePersian.Width = 125;
        // 
        // Photo
        // 
        Photo.DataPropertyName = "Photo";
        Photo.HeaderText = "عکس";
        Photo.ImageLayout = DataGridViewImageCellLayout.Zoom;
        Photo.MinimumWidth = 6;
        Photo.Name = "Photo";
        Photo.ReadOnly = true;
        Photo.Width = 125;
        // 
        // registrarDataGridViewTextBoxColumn
        // 
        registrarDataGridViewTextBoxColumn.DataPropertyName = "RegistrarUsername";
        registrarDataGridViewTextBoxColumn.HeaderText = "ثبت کننده";
        registrarDataGridViewTextBoxColumn.MinimumWidth = 6;
        registrarDataGridViewTextBoxColumn.Name = "registrarDataGridViewTextBoxColumn";
        registrarDataGridViewTextBoxColumn.ReadOnly = true;
        registrarDataGridViewTextBoxColumn.Width = 125;
        // 
        // ColumnDummy
        // 
        ColumnDummy.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        ColumnDummy.HeaderText = "";
        ColumnDummy.MinimumWidth = 6;
        ColumnDummy.Name = "ColumnDummy";
        ColumnDummy.ReadOnly = true;
        // 
        // bindingSourcePresences
        // 
        bindingSourcePresences.DataSource = typeof(Presence);
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 1;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel1.Controls.Add(panel1, 0, 0);
        tableLayoutPanel1.Controls.Add(splitContainer, 0, 1);
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
        // panel1
        // 
        panel1.BackColor = Color.FromArgb(39, 43, 61);
        panel1.Controls.Add(buttonExport);
        panel1.Controls.Add(buttonLogOut);
        panel1.Controls.Add(buttonShutdown);
        panel1.Controls.Add(buttonHelp);
        panel1.Controls.Add(buttonExit);
        panel1.Dock = DockStyle.Fill;
        panel1.Location = new Point(0, 0);
        panel1.Margin = new Padding(0);
        panel1.Name = "panel1";
        panel1.Size = new Size(1280, 111);
        panel1.TabIndex = 0;
        // 
        // buttonExport
        // 
        buttonExport.Cursor = Cursors.Hand;
        buttonExport.Dock = DockStyle.Left;
        buttonExport.FlatAppearance.BorderColor = Color.FromArgb(39, 43, 61);
        buttonExport.FlatAppearance.BorderSize = 0;
        buttonExport.FlatAppearance.CheckedBackColor = Color.Gainsboro;
        buttonExport.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
        buttonExport.FlatStyle = FlatStyle.Flat;
        buttonExport.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 178);
        buttonExport.ForeColor = Color.WhiteSmoke;
        buttonExport.Image = Properties.Resources.Excel_641;
        buttonExport.Location = new Point(488, 0);
        buttonExport.Margin = new Padding(0);
        buttonExport.Name = "buttonExport";
        buttonExport.Size = new Size(195, 111);
        buttonExport.TabIndex = 4;
        buttonExport.TabStop = false;
        buttonExport.Text = "اکسل";
        buttonExport.TextImageRelation = TextImageRelation.ImageBeforeText;
        buttonExport.UseVisualStyleBackColor = true;
        buttonExport.Click += buttonExport_Click;
        // 
        // buttonLogOut
        // 
        buttonLogOut.Cursor = Cursors.Hand;
        buttonLogOut.Dock = DockStyle.Left;
        buttonLogOut.FlatAppearance.BorderColor = Color.FromArgb(52, 73, 94);
        buttonLogOut.FlatAppearance.BorderSize = 0;
        buttonLogOut.FlatAppearance.CheckedBackColor = Color.Gainsboro;
        buttonLogOut.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
        buttonLogOut.FlatStyle = FlatStyle.Flat;
        buttonLogOut.Font = new Font("Microsoft Sans Serif", 12F);
        buttonLogOut.ForeColor = Color.WhiteSmoke;
        buttonLogOut.Image = Properties.Resources.Login_Door_1281;
        buttonLogOut.Location = new Point(336, 0);
        buttonLogOut.Margin = new Padding(0);
        buttonLogOut.Name = "buttonLogOut";
        buttonLogOut.Size = new Size(152, 111);
        buttonLogOut.TabIndex = 6;
        buttonLogOut.TabStop = false;
        buttonLogOut.Text = "خروج";
        buttonLogOut.TextImageRelation = TextImageRelation.ImageBeforeText;
        buttonLogOut.UseVisualStyleBackColor = true;
        buttonLogOut.Click += buttonLogOut_Click_1;
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
        buttonShutdown.TabIndex = 5;
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
        buttonHelp.TabIndex = 7;
        buttonHelp.TabStop = false;
        buttonHelp.Text = "راهنما";
        buttonHelp.TextImageRelation = TextImageRelation.ImageBeforeText;
        buttonHelp.UseVisualStyleBackColor = true;
        buttonHelp.Click += buttonHelp_Click;
        // 
        // buttonExit
        // 
        buttonExit.AllowDrop = true;
        buttonExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        buttonExit.Cursor = Cursors.Hand;
        buttonExit.FlatAppearance.BorderColor = Color.FromArgb(52, 73, 94);
        buttonExit.FlatAppearance.BorderSize = 0;
        buttonExit.FlatAppearance.CheckedBackColor = Color.Gainsboro;
        buttonExit.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
        buttonExit.FlatStyle = FlatStyle.Flat;
        buttonExit.Font = new Font("Microsoft Sans Serif", 12F);
        buttonExit.ForeColor = Color.WhiteSmoke;
        buttonExit.Image = Properties.Resources.Login_Arrow_128;
        buttonExit.Location = new Point(1100, 0);
        buttonExit.Margin = new Padding(0);
        buttonExit.Name = "buttonExit";
        buttonExit.Size = new Size(180, 111);
        buttonExit.TabIndex = 3;
        buttonExit.TabStop = false;
        buttonExit.Text = "ثبت تردد";
        buttonExit.TextImageRelation = TextImageRelation.ImageBeforeText;
        buttonExit.UseVisualStyleBackColor = true;
        buttonExit.Click += buttonLogout_Click;
        // 
        // saveFileDialog
        // 
        saveFileDialog.DefaultExt = "xml";
        saveFileDialog.Filter = "Excel|*.xlsx|All files|*.*";
        // 
        // dataGridViewTextBoxColumn1
        // 
        dataGridViewTextBoxColumn1.DataPropertyName = "Gate";
        dataGridViewTextBoxColumn1.HeaderText = "ورودی";
        dataGridViewTextBoxColumn1.MinimumWidth = 6;
        dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
        dataGridViewTextBoxColumn1.Width = 125;
        // 
        // FormReport
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(255, 224, 192);
        ClientSize = new Size(1280, 960);
        ControlBox = false;
        Controls.Add(tableLayoutPanel1);
        FormBorderStyle = FormBorderStyle.None;
        Margin = new Padding(4, 5, 4, 5);
        Name = "FormReport";
        RightToLeft = RightToLeft.Yes;
        Text = "به فرما";
        WindowState = FormWindowState.Maximized;
        FormClosing += FormMain_FormClosing;
        Load += FormMain_Load;
        splitContainer.Panel1.ResumeLayout(false);
        splitContainer.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
        splitContainer.ResumeLayout(false);
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridViewPresence).EndInit();
        ((System.ComponentModel.ISupportInitialize)bindingSourcePresences).EndInit();
        tableLayoutPanel1.ResumeLayout(false);
        panel1.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.SplitContainer splitContainer;
    private System.Windows.Forms.DataGridView dataGridViewPresence;
    private System.Windows.Forms.BindingSource bindingSourcePresences;
    private System.Windows.Forms.ComboBox comboBoxHosts;
    private System.Windows.Forms.Label labelDate;
    private System.Windows.Forms.MaskedTextBox textBoxDateFrom;
    private System.Windows.Forms.Label labelHost;
    private System.Windows.Forms.Label labelName;
    private System.Windows.Forms.TextBox textBoxName;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.MaskedTextBox textBoxDateTo;
    private TableLayoutPanel tableLayoutPanel1;
    private Panel panel1;
    private Button buttonExit;
    private Button buttonSearch;
    private Panel panel2;
    private Button buttonExport;
    private SaveFileDialog saveFileDialog;
    private Button buttonLogOut;
    private Button buttonShutdown;
    private Button buttonHelp;
    private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn personDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn hostDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn gateDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn EndTime;
    private DataGridViewTextBoxColumn StartDatePersian;
    private DataGridViewImageColumn Photo;
    private DataGridViewTextBoxColumn registrarDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn ColumnDummy;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private ComboBox comboBoxGates;
    private Label label2;
}
