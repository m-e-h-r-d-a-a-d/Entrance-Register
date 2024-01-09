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
        this.components = new System.ComponentModel.Container();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReport));
        this.splitContainer = new System.Windows.Forms.SplitContainer();
        this.panel2 = new System.Windows.Forms.Panel();
        this.comboBoxGates = new System.Windows.Forms.ComboBox();
        this.label2 = new System.Windows.Forms.Label();
        this.buttonSearch = new System.Windows.Forms.Button();
        this.label1 = new System.Windows.Forms.Label();
        this.labelHost = new System.Windows.Forms.Label();
        this.textBoxDateTo = new System.Windows.Forms.MaskedTextBox();
        this.textBoxName = new System.Windows.Forms.TextBox();
        this.comboBoxHosts = new System.Windows.Forms.ComboBox();
        this.labelName = new System.Windows.Forms.Label();
        this.labelDate = new System.Windows.Forms.Label();
        this.textBoxDateFrom = new System.Windows.Forms.MaskedTextBox();
        this.dataGridViewPresence = new System.Windows.Forms.DataGridView();
        this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.personDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.hostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.gateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.EndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.StartDatePersian = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.Photo = new System.Windows.Forms.DataGridViewImageColumn();
        this.registrarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.ColumnDummy = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.bindingSourcePresences = new System.Windows.Forms.BindingSource(this.components);
        this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
        this.panel1 = new System.Windows.Forms.Panel();
        this.buttonExport = new System.Windows.Forms.Button();
        this.buttonLogOut = new System.Windows.Forms.Button();
        this.buttonShutdown = new System.Windows.Forms.Button();
        this.buttonHelp = new System.Windows.Forms.Button();
        this.buttonExit = new System.Windows.Forms.Button();
        this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
        this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
        this.splitContainer.Panel1.SuspendLayout();
        this.splitContainer.Panel2.SuspendLayout();
        this.splitContainer.SuspendLayout();
        this.panel2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPresence)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePresences)).BeginInit();
        this.tableLayoutPanel1.SuspendLayout();
        this.panel1.SuspendLayout();
        this.SuspendLayout();
        // 
        // splitContainer
        // 
        this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
        | System.Windows.Forms.AnchorStyles.Left)
        | System.Windows.Forms.AnchorStyles.Right)));
        this.splitContainer.BackColor = System.Drawing.Color.WhiteSmoke;
        this.splitContainer.Location = new System.Drawing.Point(3, 75);
        this.splitContainer.Name = "splitContainer";
        // 
        // splitContainer.Panel1
        // 
        this.splitContainer.Panel1.Controls.Add(this.panel2);
        this.splitContainer.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
        // 
        // splitContainer.Panel2
        // 
        this.splitContainer.Panel2.Controls.Add(this.dataGridViewPresence);
        this.splitContainer.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
        this.splitContainer.Size = new System.Drawing.Size(794, 522);
        this.splitContainer.SplitterDistance = 268;
        this.splitContainer.TabIndex = 0;
        // 
        // panel2
        // 
        this.panel2.Controls.Add(this.comboBoxGates);
        this.panel2.Controls.Add(this.label2);
        this.panel2.Controls.Add(this.buttonSearch);
        this.panel2.Controls.Add(this.label1);
        this.panel2.Controls.Add(this.labelHost);
        this.panel2.Controls.Add(this.textBoxDateTo);
        this.panel2.Controls.Add(this.textBoxName);
        this.panel2.Controls.Add(this.comboBoxHosts);
        this.panel2.Controls.Add(this.labelName);
        this.panel2.Controls.Add(this.labelDate);
        this.panel2.Controls.Add(this.textBoxDateFrom);
        this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
        this.panel2.Location = new System.Drawing.Point(0, 0);
        this.panel2.Name = "panel2";
        this.panel2.Size = new System.Drawing.Size(268, 201);
        this.panel2.TabIndex = 15;
        // 
        // comboBoxGates
        // 
        this.comboBoxGates.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
        | System.Windows.Forms.AnchorStyles.Right)));
        this.comboBoxGates.BackColor = System.Drawing.Color.WhiteSmoke;
        this.comboBoxGates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.comboBoxGates.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
        this.comboBoxGates.FormattingEnabled = true;
        this.comboBoxGates.Location = new System.Drawing.Point(14, 38);
        this.comboBoxGates.Name = "comboBoxGates";
        this.comboBoxGates.Size = new System.Drawing.Size(183, 24);
        this.comboBoxGates.TabIndex = 18;
        this.comboBoxGates.SelectedIndexChanged += new System.EventHandler(this.comboBoxGates_SelectedIndexChanged);
        // 
        // label2
        // 
        this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.label2.AutoSize = true;
        this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
        this.label2.Location = new System.Drawing.Point(219, 43);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(38, 16);
        this.label2.TabIndex = 17;
        this.label2.Text = "درگاه";
        // 
        // buttonSearch
        // 
        this.buttonSearch.BackColor = System.Drawing.Color.WhiteSmoke;
        this.buttonSearch.Cursor = System.Windows.Forms.Cursors.Hand;
        this.buttonSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
        this.buttonSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(61)))));
        this.buttonSearch.FlatAppearance.BorderSize = 0;
        this.buttonSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
        this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
        this.buttonSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(61)))));
        this.buttonSearch.Image = Properties.Resources.Search_Find_128;
        this.buttonSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
        this.buttonSearch.Location = new System.Drawing.Point(0, 128);
        this.buttonSearch.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
        this.buttonSearch.Name = "buttonSearch";
        this.buttonSearch.Size = new System.Drawing.Size(268, 73);
        this.buttonSearch.TabIndex = 4;
        this.buttonSearch.Text = "جستجو";
        this.buttonSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        this.buttonSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
        this.buttonSearch.UseVisualStyleBackColor = false;
        this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
        // 
        // label1
        // 
        this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.label1.AutoSize = true;
        this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
        this.label1.Location = new System.Drawing.Point(103, 106);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(17, 16);
        this.label1.TabIndex = 14;
        this.label1.Text = "تا";
        // 
        // labelHost
        // 
        this.labelHost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.labelHost.AutoSize = true;
        this.labelHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
        this.labelHost.Location = new System.Drawing.Point(217, 74);
        this.labelHost.Name = "labelHost";
        this.labelHost.Size = new System.Drawing.Size(40, 16);
        this.labelHost.TabIndex = 10;
        this.labelHost.Text = "میزبان";
        // 
        // textBoxDateTo
        // 
        this.textBoxDateTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.textBoxDateTo.BackColor = System.Drawing.Color.WhiteSmoke;
        this.textBoxDateTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
        this.textBoxDateTo.Location = new System.Drawing.Point(13, 104);
        this.textBoxDateTo.Mask = "0000/00/00";
        this.textBoxDateTo.Name = "textBoxDateTo";
        this.textBoxDateTo.RightToLeft = System.Windows.Forms.RightToLeft.No;
        this.textBoxDateTo.Size = new System.Drawing.Size(84, 22);
        this.textBoxDateTo.TabIndex = 3;
        // 
        // textBoxName
        // 
        this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
        | System.Windows.Forms.AnchorStyles.Right)));
        this.textBoxName.BackColor = System.Drawing.Color.WhiteSmoke;
        this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
        this.textBoxName.Location = new System.Drawing.Point(14, 9);
        this.textBoxName.Name = "textBoxName";
        this.textBoxName.Size = new System.Drawing.Size(183, 22);
        this.textBoxName.TabIndex = 0;
        // 
        // comboBoxHosts
        // 
        this.comboBoxHosts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
        | System.Windows.Forms.AnchorStyles.Right)));
        this.comboBoxHosts.BackColor = System.Drawing.Color.WhiteSmoke;
        this.comboBoxHosts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.comboBoxHosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
        this.comboBoxHosts.FormattingEnabled = true;
        this.comboBoxHosts.Location = new System.Drawing.Point(14, 69);
        this.comboBoxHosts.Name = "comboBoxHosts";
        this.comboBoxHosts.Size = new System.Drawing.Size(183, 24);
        this.comboBoxHosts.TabIndex = 1;
        // 
        // labelName
        // 
        this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.labelName.AutoSize = true;
        this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
        this.labelName.Location = new System.Drawing.Point(235, 12);
        this.labelName.Name = "labelName";
        this.labelName.Size = new System.Drawing.Size(22, 16);
        this.labelName.TabIndex = 11;
        this.labelName.Text = "نام";
        // 
        // labelDate
        // 
        this.labelDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.labelDate.AutoSize = true;
        this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
        this.labelDate.Location = new System.Drawing.Point(209, 105);
        this.labelDate.Name = "labelDate";
        this.labelDate.Size = new System.Drawing.Size(48, 16);
        this.labelDate.TabIndex = 8;
        this.labelDate.Text = "تاریخ از";
        // 
        // textBoxDateFrom
        // 
        this.textBoxDateFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.textBoxDateFrom.BackColor = System.Drawing.Color.WhiteSmoke;
        this.textBoxDateFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
        this.textBoxDateFrom.Location = new System.Drawing.Point(125, 104);
        this.textBoxDateFrom.Mask = "0000/00/00";
        this.textBoxDateFrom.Name = "textBoxDateFrom";
        this.textBoxDateFrom.RightToLeft = System.Windows.Forms.RightToLeft.No;
        this.textBoxDateFrom.Size = new System.Drawing.Size(71, 22);
        this.textBoxDateFrom.TabIndex = 2;
        // 
        // dataGridViewPresence
        // 
        this.dataGridViewPresence.AllowUserToAddRows = false;
        this.dataGridViewPresence.AllowUserToDeleteRows = false;
        this.dataGridViewPresence.AutoGenerateColumns = false;
        this.dataGridViewPresence.BackgroundColor = System.Drawing.Color.WhiteSmoke;
        this.dataGridViewPresence.BorderStyle = System.Windows.Forms.BorderStyle.None;
        this.dataGridViewPresence.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
        this.dataGridViewPresence.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
        dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
        dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
        dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
        dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
        dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        this.dataGridViewPresence.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
        this.dataGridViewPresence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dataGridViewPresence.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.personDataGridViewTextBoxColumn,
            this.hostDataGridViewTextBoxColumn,
            this.gateDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.EndTime,
            this.StartDatePersian,
            this.Photo,
            this.registrarDataGridViewTextBoxColumn,
            this.ColumnDummy});
        this.dataGridViewPresence.DataSource = this.bindingSourcePresences;
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
        dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
        dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
        dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
        dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        this.dataGridViewPresence.DefaultCellStyle = dataGridViewCellStyle2;
        this.dataGridViewPresence.Dock = System.Windows.Forms.DockStyle.Fill;
        this.dataGridViewPresence.Location = new System.Drawing.Point(0, 0);
        this.dataGridViewPresence.Margin = new System.Windows.Forms.Padding(0);
        this.dataGridViewPresence.Name = "dataGridViewPresence";
        this.dataGridViewPresence.ReadOnly = true;
        this.dataGridViewPresence.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
        this.dataGridViewPresence.RowHeadersVisible = false;
        this.dataGridViewPresence.RowTemplate.Height = 50;
        this.dataGridViewPresence.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dataGridViewPresence.Size = new System.Drawing.Size(522, 522);
        this.dataGridViewPresence.TabIndex = 0;
        this.dataGridViewPresence.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewPresence_CellFormatting);
        // 
        // idDataGridViewTextBoxColumn
        // 
        this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
        this.idDataGridViewTextBoxColumn.HeaderText = "شناسه";
        this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
        this.idDataGridViewTextBoxColumn.ReadOnly = true;
        this.idDataGridViewTextBoxColumn.Visible = false;
        // 
        // personDataGridViewTextBoxColumn
        // 
        this.personDataGridViewTextBoxColumn.DataPropertyName = "Person";
        this.personDataGridViewTextBoxColumn.HeaderText = "نام";
        this.personDataGridViewTextBoxColumn.Name = "personDataGridViewTextBoxColumn";
        this.personDataGridViewTextBoxColumn.ReadOnly = true;
        this.personDataGridViewTextBoxColumn.Width = 150;
        // 
        // hostDataGridViewTextBoxColumn
        // 
        this.hostDataGridViewTextBoxColumn.DataPropertyName = "Host";
        this.hostDataGridViewTextBoxColumn.HeaderText = "میزبان";
        this.hostDataGridViewTextBoxColumn.Name = "hostDataGridViewTextBoxColumn";
        this.hostDataGridViewTextBoxColumn.ReadOnly = true;
        this.hostDataGridViewTextBoxColumn.Width = 150;
        // 
        // gateDataGridViewTextBoxColumn
        // 
        this.gateDataGridViewTextBoxColumn.DataPropertyName = "GateName";
        this.gateDataGridViewTextBoxColumn.HeaderText = "ورودی";
        this.gateDataGridViewTextBoxColumn.Name = "gateDataGridViewTextBoxColumn";
        this.gateDataGridViewTextBoxColumn.ReadOnly = true;
        // 
        // startDateDataGridViewTextBoxColumn
        // 
        this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartTime";
        this.startDateDataGridViewTextBoxColumn.HeaderText = "زمان ورود";
        this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
        this.startDateDataGridViewTextBoxColumn.ReadOnly = true;
        // 
        // EndTime
        // 
        this.EndTime.DataPropertyName = "EndTime";
        this.EndTime.HeaderText = "زمان خروج";
        this.EndTime.Name = "EndTime";
        this.EndTime.ReadOnly = true;
        // 
        // StartDatePersian
        // 
        this.StartDatePersian.DataPropertyName = "StartDatePersian";
        this.StartDatePersian.HeaderText = "تاریخ";
        this.StartDatePersian.Name = "StartDatePersian";
        this.StartDatePersian.ReadOnly = true;
        // 
        // Photo
        // 
        this.Photo.DataPropertyName = "Photo";
        this.Photo.HeaderText = "عکس";
        this.Photo.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
        this.Photo.Name = "Photo";
        this.Photo.ReadOnly = true;
        // 
        // registrarDataGridViewTextBoxColumn
        // 
        this.registrarDataGridViewTextBoxColumn.DataPropertyName = "RegistrarUsername";
        this.registrarDataGridViewTextBoxColumn.HeaderText = "ثبت کننده";
        this.registrarDataGridViewTextBoxColumn.Name = "registrarDataGridViewTextBoxColumn";
        this.registrarDataGridViewTextBoxColumn.ReadOnly = true;
        // 
        // ColumnDummy
        // 
        this.ColumnDummy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
        this.ColumnDummy.HeaderText = "";
        this.ColumnDummy.Name = "ColumnDummy";
        this.ColumnDummy.ReadOnly = true;
        // 
        // bindingSourcePresences
        // 
        this.bindingSourcePresences.DataSource = typeof(Presence);
        // 
        // tableLayoutPanel1
        // 
        this.tableLayoutPanel1.ColumnCount = 1;
        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
        this.tableLayoutPanel1.Controls.Add(this.splitContainer, 0, 1);
        this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
        this.tableLayoutPanel1.Name = "tableLayoutPanel1";
        this.tableLayoutPanel1.RowCount = 2;
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 600);
        this.tableLayoutPanel1.TabIndex = 5;
        // 
        // panel1
        // 
        this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(61)))));
        this.panel1.Controls.Add(this.buttonExport);
        this.panel1.Controls.Add(this.buttonLogOut);
        this.panel1.Controls.Add(this.buttonShutdown);
        this.panel1.Controls.Add(this.buttonHelp);
        this.panel1.Controls.Add(this.buttonExit);
        this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.panel1.Location = new System.Drawing.Point(0, 0);
        this.panel1.Margin = new System.Windows.Forms.Padding(0);
        this.panel1.Name = "panel1";
        this.panel1.Size = new System.Drawing.Size(800, 72);
        this.panel1.TabIndex = 0;
        // 
        // buttonExport
        // 
        this.buttonExport.Cursor = System.Windows.Forms.Cursors.Hand;
        this.buttonExport.Dock = System.Windows.Forms.DockStyle.Left;
        this.buttonExport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(61)))));
        this.buttonExport.FlatAppearance.BorderSize = 0;
        this.buttonExport.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gainsboro;
        this.buttonExport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
        this.buttonExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.buttonExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
        this.buttonExport.ForeColor = System.Drawing.Color.WhiteSmoke;
        this.buttonExport.Image = Properties.Resources.Excel_641;
        this.buttonExport.Location = new System.Drawing.Point(366, 0);
        this.buttonExport.Margin = new System.Windows.Forms.Padding(0);
        this.buttonExport.Name = "buttonExport";
        this.buttonExport.Size = new System.Drawing.Size(146, 72);
        this.buttonExport.TabIndex = 4;
        this.buttonExport.TabStop = false;
        this.buttonExport.Text = "اکسل";
        this.buttonExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
        this.buttonExport.UseVisualStyleBackColor = true;
        this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
        // 
        // buttonLogOut
        // 
        this.buttonLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
        this.buttonLogOut.Dock = System.Windows.Forms.DockStyle.Left;
        this.buttonLogOut.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
        this.buttonLogOut.FlatAppearance.BorderSize = 0;
        this.buttonLogOut.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gainsboro;
        this.buttonLogOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
        this.buttonLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.buttonLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
        this.buttonLogOut.ForeColor = System.Drawing.Color.WhiteSmoke;
        this.buttonLogOut.Image = Properties.Resources.Login_Door_1281;
        this.buttonLogOut.Location = new System.Drawing.Point(252, 0);
        this.buttonLogOut.Margin = new System.Windows.Forms.Padding(0);
        this.buttonLogOut.Name = "buttonLogOut";
        this.buttonLogOut.Size = new System.Drawing.Size(114, 72);
        this.buttonLogOut.TabIndex = 6;
        this.buttonLogOut.TabStop = false;
        this.buttonLogOut.Text = "خروج";
        this.buttonLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
        this.buttonLogOut.UseVisualStyleBackColor = true;
        this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click_1);
        // 
        // buttonShutdown
        // 
        this.buttonShutdown.Cursor = System.Windows.Forms.Cursors.Hand;
        this.buttonShutdown.Dock = System.Windows.Forms.DockStyle.Left;
        this.buttonShutdown.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
        this.buttonShutdown.FlatAppearance.BorderSize = 0;
        this.buttonShutdown.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gainsboro;
        this.buttonShutdown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
        this.buttonShutdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.buttonShutdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
        this.buttonShutdown.ForeColor = System.Drawing.Color.WhiteSmoke;
        this.buttonShutdown.Image = Properties.Resources.Media_Start_1281;
        this.buttonShutdown.Location = new System.Drawing.Point(118, 0);
        this.buttonShutdown.Margin = new System.Windows.Forms.Padding(0);
        this.buttonShutdown.Name = "buttonShutdown";
        this.buttonShutdown.Size = new System.Drawing.Size(134, 72);
        this.buttonShutdown.TabIndex = 5;
        this.buttonShutdown.TabStop = false;
        this.buttonShutdown.Text = "خاموش";
        this.buttonShutdown.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
        this.buttonShutdown.UseVisualStyleBackColor = true;
        this.buttonShutdown.Click += new System.EventHandler(this.buttonShutdown_Click);
        // 
        // buttonHelp
        // 
        this.buttonHelp.Cursor = System.Windows.Forms.Cursors.Hand;
        this.buttonHelp.Dock = System.Windows.Forms.DockStyle.Left;
        this.buttonHelp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
        this.buttonHelp.FlatAppearance.BorderSize = 0;
        this.buttonHelp.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gainsboro;
        this.buttonHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
        this.buttonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.buttonHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
        this.buttonHelp.ForeColor = System.Drawing.Color.WhiteSmoke;
        this.buttonHelp.Image = Properties.Resources.Student_Read_02_128;
        this.buttonHelp.Location = new System.Drawing.Point(0, 0);
        this.buttonHelp.Margin = new System.Windows.Forms.Padding(0);
        this.buttonHelp.Name = "buttonHelp";
        this.buttonHelp.Size = new System.Drawing.Size(118, 72);
        this.buttonHelp.TabIndex = 7;
        this.buttonHelp.TabStop = false;
        this.buttonHelp.Text = "راهنما";
        this.buttonHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
        this.buttonHelp.UseVisualStyleBackColor = true;
        this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
        // 
        // buttonExit
        // 
        this.buttonExit.AllowDrop = true;
        this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
        this.buttonExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
        this.buttonExit.FlatAppearance.BorderSize = 0;
        this.buttonExit.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gainsboro;
        this.buttonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
        this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
        this.buttonExit.ForeColor = System.Drawing.Color.WhiteSmoke;
        this.buttonExit.Image = Properties.Resources.Login_Arrow_128;
        this.buttonExit.Location = new System.Drawing.Point(665, 0);
        this.buttonExit.Margin = new System.Windows.Forms.Padding(0);
        this.buttonExit.Name = "buttonExit";
        this.buttonExit.Size = new System.Drawing.Size(135, 72);
        this.buttonExit.TabIndex = 3;
        this.buttonExit.TabStop = false;
        this.buttonExit.Text = "ثبت تردد";
        this.buttonExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
        this.buttonExit.UseVisualStyleBackColor = true;
        this.buttonExit.Click += new System.EventHandler(this.buttonLogout_Click);
        // 
        // saveFileDialog
        // 
        this.saveFileDialog.DefaultExt = "xml";
        this.saveFileDialog.Filter = "Excel|*.xlsx|All files|*.*";
        // 
        // dataGridViewTextBoxColumn1
        // 
        this.dataGridViewTextBoxColumn1.DataPropertyName = "Gate";
        this.dataGridViewTextBoxColumn1.HeaderText = "ورودی";
        this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
        // 
        // FormReport
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
        this.ClientSize = new System.Drawing.Size(800, 600);
        this.ControlBox = false;
        this.Controls.Add(this.tableLayoutPanel1);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        this.Name = "FormReport";
        this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
        this.Text = "به فرما";
        this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
        this.Load += new System.EventHandler(this.FormMain_Load);
        this.splitContainer.Panel1.ResumeLayout(false);
        this.splitContainer.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
        this.splitContainer.ResumeLayout(false);
        this.panel2.ResumeLayout(false);
        this.panel2.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPresence)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePresences)).EndInit();
        this.tableLayoutPanel1.ResumeLayout(false);
        this.panel1.ResumeLayout(false);
        this.ResumeLayout(false);

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
