namespace WindowsFormsApp1
{
    partial class User_Dashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_Dashboard));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.GDGVUser = new Guna.UI.WinForms.GunaDataGridView();
            this.BtnPetsList = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaAdvenceButton2 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.PicPet = new System.Windows.Forms.PictureBox();
            this.PSMS = new Guna.UI.WinForms.GunaAdvenceButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.BtnLogout = new Guna.UI.WinForms.GunaAdvenceButton();
            this.BtnTransactions = new Guna.UI.WinForms.GunaAdvenceButton();
            this.BtnBilling = new Guna.UI.WinForms.GunaAdvenceButton();
            this.BtnSupplier = new Guna.UI.WinForms.GunaAdvenceButton();
            this.BtnUser = new Guna.UI.WinForms.GunaAdvenceButton();
            this.BtnCustomers = new Guna.UI.WinForms.GunaAdvenceButton();
            this.BtnPetFood = new Guna.UI.WinForms.GunaAdvenceButton();
            this.BtnPet = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnDashboard = new Guna.UI.WinForms.GunaAdvenceButton();
            this.PicLogo = new System.Windows.Forms.PictureBox();
            this.PETSHOP = new Guna.UI.WinForms.GunaAdvenceButton();
            this.BtnDelete = new Guna.UI.WinForms.GunaAdvenceButton();
            this.BtnReset = new Guna.UI.WinForms.GunaAdvenceButton();
            this.BtnUpdate = new Guna.UI.WinForms.GunaAdvenceButton();
            this.BtnSave = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaAdvenceButton15 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GDGVUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicPet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.PicPet);
            this.panel2.Controls.Add(this.PSMS);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(199, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(975, 85);
            this.panel2.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.BtnLogout);
            this.panel1.Controls.Add(this.BtnTransactions);
            this.panel1.Controls.Add(this.BtnBilling);
            this.panel1.Controls.Add(this.BtnSupplier);
            this.panel1.Controls.Add(this.BtnUser);
            this.panel1.Controls.Add(this.BtnCustomers);
            this.panel1.Controls.Add(this.BtnPetFood);
            this.panel1.Controls.Add(this.BtnPet);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.PicLogo);
            this.panel1.Controls.Add(this.PETSHOP);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 750);
            this.panel1.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BtnDelete);
            this.panel3.Controls.Add(this.BtnReset);
            this.panel3.Controls.Add(this.BtnUpdate);
            this.panel3.Controls.Add(this.BtnSave);
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Controls.Add(this.textBox3);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.comboBox2);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.TextUserName);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(205, 132);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(957, 242);
            this.panel3.TabIndex = 21;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(268, 59);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(220, 28);
            this.dateTimePicker1.TabIndex = 28;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(86)))));
            this.textBox3.Location = new System.Drawing.Point(489, 130);
            this.textBox3.MaxLength = 50;
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(353, 32);
            this.textBox3.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(484, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 23);
            this.label7.TabIndex = 26;
            this.label7.Text = "Password";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(86)))));
            this.textBox1.Location = new System.Drawing.Point(16, 130);
            this.textBox1.MaxLength = 50;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(411, 32);
            this.textBox1.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(6, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 23);
            this.label6.TabIndex = 24;
            this.label6.Text = " Full Address";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Courier New", 12F);
            this.comboBox2.ForeColor = System.Drawing.Color.Gray;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.ItemHeight = 22;
            this.comboBox2.Items.AddRange(new object[] {
            "Male ",
            "Female"});
            this.comboBox2.Location = new System.Drawing.Point(529, 58);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(165, 30);
            this.comboBox2.TabIndex = 23;
            this.comboBox2.Text = "Select ";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(86)))));
            this.textBox2.Location = new System.Drawing.Point(742, 57);
            this.textBox2.MaxLength = 50;
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(154, 32);
            this.textBox2.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(743, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Phone No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(525, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Gender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(274, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "User DOB";
            // 
            // TextUserName
            // 
            this.TextUserName.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(86)))));
            this.TextUserName.Location = new System.Drawing.Point(21, 57);
            this.TextUserName.MaxLength = 50;
            this.TextUserName.Multiline = true;
            this.TextUserName.Name = "TextUserName";
            this.TextUserName.Size = new System.Drawing.Size(216, 32);
            this.TextUserName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(21, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "User Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(581, 731);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Powered By Momna Wahla";
            // 
            // GDGVUser
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.GDGVUser.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GDGVUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GDGVUser.BackgroundColor = System.Drawing.Color.White;
            this.GDGVUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GDGVUser.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GDGVUser.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GDGVUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GDGVUser.ColumnHeadersHeight = 25;
            this.GDGVUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GDGVUser.DefaultCellStyle = dataGridViewCellStyle3;
            this.GDGVUser.EnableHeadersVisualStyles = false;
            this.GDGVUser.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.GDGVUser.Location = new System.Drawing.Point(214, 409);
            this.GDGVUser.Name = "GDGVUser";
            this.GDGVUser.ReadOnly = true;
            this.GDGVUser.RowHeadersVisible = false;
            this.GDGVUser.RowHeadersWidth = 51;
            this.GDGVUser.RowTemplate.Height = 24;
            this.GDGVUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GDGVUser.Size = new System.Drawing.Size(948, 319);
            this.GDGVUser.TabIndex = 25;
            this.GDGVUser.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.GDGVUser.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.GDGVUser.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.GDGVUser.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.GDGVUser.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.GDGVUser.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.GDGVUser.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.GDGVUser.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.GDGVUser.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.GDGVUser.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GDGVUser.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.GDGVUser.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.GDGVUser.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.GDGVUser.ThemeStyle.HeaderStyle.Height = 25;
            this.GDGVUser.ThemeStyle.ReadOnly = true;
            this.GDGVUser.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.GDGVUser.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GDGVUser.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.GDGVUser.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.GDGVUser.ThemeStyle.RowsStyle.Height = 24;
            this.GDGVUser.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GDGVUser.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // BtnPetsList
            // 
            this.BtnPetsList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnPetsList.AnimationHoverSpeed = 0.07F;
            this.BtnPetsList.AnimationSpeed = 0.03F;
            this.BtnPetsList.BackColor = System.Drawing.Color.Transparent;
            this.BtnPetsList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnPetsList.BaseColor = System.Drawing.Color.Gold;
            this.BtnPetsList.BorderColor = System.Drawing.Color.Black;
            this.BtnPetsList.CheckedBaseColor = System.Drawing.Color.Gray;
            this.BtnPetsList.CheckedBorderColor = System.Drawing.Color.Black;
            this.BtnPetsList.CheckedForeColor = System.Drawing.Color.White;
            this.BtnPetsList.CheckedImage = ((System.Drawing.Image)(resources.GetObject("BtnPetsList.CheckedImage")));
            this.BtnPetsList.CheckedLineColor = System.Drawing.Color.DimGray;
            this.BtnPetsList.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnPetsList.FocusedColor = System.Drawing.Color.Empty;
            this.BtnPetsList.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPetsList.ForeColor = System.Drawing.Color.DimGray;
            this.BtnPetsList.Image = null;
            this.BtnPetsList.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnPetsList.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.BtnPetsList.Location = new System.Drawing.Point(564, 379);
            this.BtnPetsList.Name = "BtnPetsList";
            this.BtnPetsList.OnHoverBaseColor = System.Drawing.Color.Gold;
            this.BtnPetsList.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnPetsList.OnHoverForeColor = System.Drawing.Color.DimGray;
            this.BtnPetsList.OnHoverImage = null;
            this.BtnPetsList.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.BtnPetsList.OnPressedColor = System.Drawing.Color.Black;
            this.BtnPetsList.Radius = 10;
            this.BtnPetsList.Size = new System.Drawing.Size(209, 23);
            this.BtnPetsList.TabIndex = 26;
            this.BtnPetsList.Text = "Users List";
            this.BtnPetsList.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaAdvenceButton2
            // 
            this.gunaAdvenceButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaAdvenceButton2.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton2.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton2.BackColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gunaAdvenceButton2.BaseColor = System.Drawing.Color.Gold;
            this.gunaAdvenceButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton2.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton2.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton2.CheckedImage")));
            this.gunaAdvenceButton2.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton2.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaAdvenceButton2.ForeColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton2.Image = null;
            this.gunaAdvenceButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton2.Location = new System.Drawing.Point(530, 91);
            this.gunaAdvenceButton2.Name = "gunaAdvenceButton2";
            this.gunaAdvenceButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.gunaAdvenceButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.gunaAdvenceButton2.OnHoverImage = null;
            this.gunaAdvenceButton2.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.Radius = 10;
            this.gunaAdvenceButton2.Size = new System.Drawing.Size(337, 32);
            this.gunaAdvenceButton2.TabIndex = 22;
            this.gunaAdvenceButton2.Text = "Manage Users";
            this.gunaAdvenceButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PicPet
            // 
            this.PicPet.BackColor = System.Drawing.Color.Transparent;
            this.PicPet.Image = global::WindowsFormsApp1.Properties.Resources.ChatGPT_Image_Jun_9__2025__03_19_44_AM1;
            this.PicPet.Location = new System.Drawing.Point(18, -1);
            this.PicPet.Name = "PicPet";
            this.PicPet.Size = new System.Drawing.Size(169, 120);
            this.PicPet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicPet.TabIndex = 39;
            this.PicPet.TabStop = false;
            // 
            // PSMS
            // 
            this.PSMS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PSMS.AnimationHoverSpeed = 0.07F;
            this.PSMS.AnimationSpeed = 0.03F;
            this.PSMS.BackColor = System.Drawing.Color.Transparent;
            this.PSMS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PSMS.BaseColor = System.Drawing.Color.Gold;
            this.PSMS.BorderColor = System.Drawing.Color.Black;
            this.PSMS.CheckedBaseColor = System.Drawing.Color.Gray;
            this.PSMS.CheckedBorderColor = System.Drawing.Color.Black;
            this.PSMS.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.PSMS.CheckedImage = ((System.Drawing.Image)(resources.GetObject("PSMS.CheckedImage")));
            this.PSMS.CheckedLineColor = System.Drawing.Color.DimGray;
            this.PSMS.DialogResult = System.Windows.Forms.DialogResult.None;
            this.PSMS.FocusedColor = System.Drawing.Color.Empty;
            this.PSMS.Font = new System.Drawing.Font("Courier New", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PSMS.ForeColor = System.Drawing.Color.DimGray;
            this.PSMS.Image = null;
            this.PSMS.ImageSize = new System.Drawing.Size(20, 20);
            this.PSMS.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.PSMS.Location = new System.Drawing.Point(193, 20);
            this.PSMS.Name = "PSMS";
            this.PSMS.OnHoverBaseColor = System.Drawing.Color.Gold;
            this.PSMS.OnHoverBorderColor = System.Drawing.Color.Black;
            this.PSMS.OnHoverForeColor = System.Drawing.Color.DimGray;
            this.PSMS.OnHoverImage = null;
            this.PSMS.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.PSMS.OnPressedColor = System.Drawing.Color.Black;
            this.PSMS.Radius = 10;
            this.PSMS.Size = new System.Drawing.Size(572, 42);
            this.PSMS.TabIndex = 7;
            this.PSMS.Text = "Pet Shop Management System";
            this.PSMS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox3.Image = global::WindowsFormsApp1.Properties.Resources._232cf3cfc0a4672e9441a6595e306408_removebg_preview;
            this.pictureBox3.Location = new System.Drawing.Point(929, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(44, 83);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // BtnLogout
            // 
            this.BtnLogout.AnimationHoverSpeed = 0.07F;
            this.BtnLogout.AnimationSpeed = 0.03F;
            this.BtnLogout.BackColor = System.Drawing.Color.Transparent;
            this.BtnLogout.BaseColor = System.Drawing.Color.LightGoldenrodYellow;
            this.BtnLogout.BorderColor = System.Drawing.Color.Black;
            this.BtnLogout.CheckedBaseColor = System.Drawing.Color.Gray;
            this.BtnLogout.CheckedBorderColor = System.Drawing.Color.Black;
            this.BtnLogout.CheckedForeColor = System.Drawing.Color.White;
            this.BtnLogout.CheckedImage = ((System.Drawing.Image)(resources.GetObject("BtnLogout.CheckedImage")));
            this.BtnLogout.CheckedLineColor = System.Drawing.Color.DimGray;
            this.BtnLogout.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnLogout.FocusedColor = System.Drawing.Color.Empty;
            this.BtnLogout.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogout.ForeColor = System.Drawing.Color.DimGray;
            this.BtnLogout.Image = ((System.Drawing.Image)(resources.GetObject("BtnLogout.Image")));
            this.BtnLogout.ImageSize = new System.Drawing.Size(30, 30);
            this.BtnLogout.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.BtnLogout.Location = new System.Drawing.Point(15, 696);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.OnHoverBaseColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnLogout.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnLogout.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnLogout.OnHoverImage = null;
            this.BtnLogout.OnHoverLineColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnLogout.OnPressedColor = System.Drawing.Color.Black;
            this.BtnLogout.Radius = 13;
            this.BtnLogout.Size = new System.Drawing.Size(166, 42);
            this.BtnLogout.TabIndex = 51;
            this.BtnLogout.Text = "Logout";
            this.BtnLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnTransactions
            // 
            this.BtnTransactions.AnimationHoverSpeed = 0.07F;
            this.BtnTransactions.AnimationSpeed = 0.03F;
            this.BtnTransactions.BackColor = System.Drawing.Color.Transparent;
            this.BtnTransactions.BaseColor = System.Drawing.Color.LightGoldenrodYellow;
            this.BtnTransactions.BorderColor = System.Drawing.Color.Black;
            this.BtnTransactions.CheckedBaseColor = System.Drawing.Color.Gray;
            this.BtnTransactions.CheckedBorderColor = System.Drawing.Color.Black;
            this.BtnTransactions.CheckedForeColor = System.Drawing.Color.White;
            this.BtnTransactions.CheckedImage = ((System.Drawing.Image)(resources.GetObject("BtnTransactions.CheckedImage")));
            this.BtnTransactions.CheckedLineColor = System.Drawing.Color.DimGray;
            this.BtnTransactions.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnTransactions.FocusedColor = System.Drawing.Color.Empty;
            this.BtnTransactions.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTransactions.ForeColor = System.Drawing.Color.DimGray;
            this.BtnTransactions.Image = ((System.Drawing.Image)(resources.GetObject("BtnTransactions.Image")));
            this.BtnTransactions.ImageSize = new System.Drawing.Size(25, 25);
            this.BtnTransactions.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.BtnTransactions.Location = new System.Drawing.Point(12, 606);
            this.BtnTransactions.Name = "BtnTransactions";
            this.BtnTransactions.OnHoverBaseColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnTransactions.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnTransactions.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnTransactions.OnHoverImage = null;
            this.BtnTransactions.OnHoverLineColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnTransactions.OnPressedColor = System.Drawing.Color.Black;
            this.BtnTransactions.Radius = 25;
            this.BtnTransactions.Size = new System.Drawing.Size(169, 52);
            this.BtnTransactions.TabIndex = 50;
            this.BtnTransactions.Text = " Transactions";
            this.BtnTransactions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnBilling
            // 
            this.BtnBilling.AnimationHoverSpeed = 0.07F;
            this.BtnBilling.AnimationSpeed = 0.03F;
            this.BtnBilling.BackColor = System.Drawing.Color.Transparent;
            this.BtnBilling.BaseColor = System.Drawing.Color.LightGoldenrodYellow;
            this.BtnBilling.BorderColor = System.Drawing.Color.Black;
            this.BtnBilling.CheckedBaseColor = System.Drawing.Color.Gray;
            this.BtnBilling.CheckedBorderColor = System.Drawing.Color.Black;
            this.BtnBilling.CheckedForeColor = System.Drawing.Color.White;
            this.BtnBilling.CheckedImage = ((System.Drawing.Image)(resources.GetObject("BtnBilling.CheckedImage")));
            this.BtnBilling.CheckedLineColor = System.Drawing.Color.DimGray;
            this.BtnBilling.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnBilling.FocusedColor = System.Drawing.Color.Empty;
            this.BtnBilling.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBilling.ForeColor = System.Drawing.Color.DimGray;
            this.BtnBilling.Image = ((System.Drawing.Image)(resources.GetObject("BtnBilling.Image")));
            this.BtnBilling.ImageSize = new System.Drawing.Size(35, 35);
            this.BtnBilling.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.BtnBilling.Location = new System.Drawing.Point(12, 548);
            this.BtnBilling.Name = "BtnBilling";
            this.BtnBilling.OnHoverBaseColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnBilling.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnBilling.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnBilling.OnHoverImage = null;
            this.BtnBilling.OnHoverLineColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnBilling.OnPressedColor = System.Drawing.Color.Black;
            this.BtnBilling.Radius = 25;
            this.BtnBilling.Size = new System.Drawing.Size(169, 52);
            this.BtnBilling.TabIndex = 49;
            this.BtnBilling.Text = "Billing";
            this.BtnBilling.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnSupplier
            // 
            this.BtnSupplier.AnimationHoverSpeed = 0.07F;
            this.BtnSupplier.AnimationSpeed = 0.03F;
            this.BtnSupplier.BackColor = System.Drawing.Color.Transparent;
            this.BtnSupplier.BaseColor = System.Drawing.Color.LightGoldenrodYellow;
            this.BtnSupplier.BorderColor = System.Drawing.Color.Black;
            this.BtnSupplier.CheckedBaseColor = System.Drawing.Color.Gray;
            this.BtnSupplier.CheckedBorderColor = System.Drawing.Color.Black;
            this.BtnSupplier.CheckedForeColor = System.Drawing.Color.White;
            this.BtnSupplier.CheckedImage = ((System.Drawing.Image)(resources.GetObject("BtnSupplier.CheckedImage")));
            this.BtnSupplier.CheckedLineColor = System.Drawing.Color.DimGray;
            this.BtnSupplier.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnSupplier.FocusedColor = System.Drawing.Color.Empty;
            this.BtnSupplier.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSupplier.ForeColor = System.Drawing.Color.DimGray;
            this.BtnSupplier.Image = ((System.Drawing.Image)(resources.GetObject("BtnSupplier.Image")));
            this.BtnSupplier.ImageSize = new System.Drawing.Size(40, 40);
            this.BtnSupplier.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.BtnSupplier.Location = new System.Drawing.Point(12, 490);
            this.BtnSupplier.Name = "BtnSupplier";
            this.BtnSupplier.OnHoverBaseColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnSupplier.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnSupplier.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnSupplier.OnHoverImage = null;
            this.BtnSupplier.OnHoverLineColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnSupplier.OnPressedColor = System.Drawing.Color.Black;
            this.BtnSupplier.Radius = 25;
            this.BtnSupplier.Size = new System.Drawing.Size(169, 52);
            this.BtnSupplier.TabIndex = 48;
            this.BtnSupplier.Text = " Supplier";
            this.BtnSupplier.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnUser
            // 
            this.BtnUser.AnimationHoverSpeed = 0.07F;
            this.BtnUser.AnimationSpeed = 0.03F;
            this.BtnUser.BackColor = System.Drawing.Color.Transparent;
            this.BtnUser.BaseColor = System.Drawing.Color.LightGoldenrodYellow;
            this.BtnUser.BorderColor = System.Drawing.Color.Black;
            this.BtnUser.CheckedBaseColor = System.Drawing.Color.Gray;
            this.BtnUser.CheckedBorderColor = System.Drawing.Color.Black;
            this.BtnUser.CheckedForeColor = System.Drawing.Color.White;
            this.BtnUser.CheckedImage = ((System.Drawing.Image)(resources.GetObject("BtnUser.CheckedImage")));
            this.BtnUser.CheckedLineColor = System.Drawing.Color.DimGray;
            this.BtnUser.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnUser.FocusedColor = System.Drawing.Color.Empty;
            this.BtnUser.Font = new System.Drawing.Font("Courier New", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUser.ForeColor = System.Drawing.Color.DimGray;
            this.BtnUser.Image = ((System.Drawing.Image)(resources.GetObject("BtnUser.Image")));
            this.BtnUser.ImageSize = new System.Drawing.Size(40, 40);
            this.BtnUser.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.BtnUser.Location = new System.Drawing.Point(12, 432);
            this.BtnUser.Name = "BtnUser";
            this.BtnUser.OnHoverBaseColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnUser.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnUser.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnUser.OnHoverImage = null;
            this.BtnUser.OnHoverLineColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnUser.OnPressedColor = System.Drawing.Color.Black;
            this.BtnUser.Radius = 25;
            this.BtnUser.Size = new System.Drawing.Size(169, 52);
            this.BtnUser.TabIndex = 47;
            this.BtnUser.Text = "User";
            this.BtnUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnCustomers
            // 
            this.BtnCustomers.AnimationHoverSpeed = 0.07F;
            this.BtnCustomers.AnimationSpeed = 0.03F;
            this.BtnCustomers.BackColor = System.Drawing.Color.Transparent;
            this.BtnCustomers.BaseColor = System.Drawing.Color.LightGoldenrodYellow;
            this.BtnCustomers.BorderColor = System.Drawing.Color.Black;
            this.BtnCustomers.CheckedBaseColor = System.Drawing.Color.Gray;
            this.BtnCustomers.CheckedBorderColor = System.Drawing.Color.Black;
            this.BtnCustomers.CheckedForeColor = System.Drawing.Color.White;
            this.BtnCustomers.CheckedImage = ((System.Drawing.Image)(resources.GetObject("BtnCustomers.CheckedImage")));
            this.BtnCustomers.CheckedLineColor = System.Drawing.Color.DimGray;
            this.BtnCustomers.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnCustomers.FocusedColor = System.Drawing.Color.Empty;
            this.BtnCustomers.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCustomers.ForeColor = System.Drawing.Color.DimGray;
            this.BtnCustomers.Image = ((System.Drawing.Image)(resources.GetObject("BtnCustomers.Image")));
            this.BtnCustomers.ImageSize = new System.Drawing.Size(35, 35);
            this.BtnCustomers.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.BtnCustomers.Location = new System.Drawing.Point(12, 374);
            this.BtnCustomers.Name = "BtnCustomers";
            this.BtnCustomers.OnHoverBaseColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnCustomers.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnCustomers.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnCustomers.OnHoverImage = null;
            this.BtnCustomers.OnHoverLineColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnCustomers.OnPressedColor = System.Drawing.Color.Black;
            this.BtnCustomers.Radius = 25;
            this.BtnCustomers.Size = new System.Drawing.Size(169, 52);
            this.BtnCustomers.TabIndex = 46;
            this.BtnCustomers.Text = "  Customer";
            this.BtnCustomers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnPetFood
            // 
            this.BtnPetFood.AnimationHoverSpeed = 0.07F;
            this.BtnPetFood.AnimationSpeed = 0.03F;
            this.BtnPetFood.BackColor = System.Drawing.Color.Transparent;
            this.BtnPetFood.BaseColor = System.Drawing.Color.LightGoldenrodYellow;
            this.BtnPetFood.BorderColor = System.Drawing.Color.Black;
            this.BtnPetFood.CheckedBaseColor = System.Drawing.Color.Gray;
            this.BtnPetFood.CheckedBorderColor = System.Drawing.Color.Black;
            this.BtnPetFood.CheckedForeColor = System.Drawing.Color.White;
            this.BtnPetFood.CheckedImage = ((System.Drawing.Image)(resources.GetObject("BtnPetFood.CheckedImage")));
            this.BtnPetFood.CheckedLineColor = System.Drawing.Color.DimGray;
            this.BtnPetFood.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnPetFood.FocusedColor = System.Drawing.Color.Empty;
            this.BtnPetFood.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPetFood.ForeColor = System.Drawing.Color.DimGray;
            this.BtnPetFood.Image = ((System.Drawing.Image)(resources.GetObject("BtnPetFood.Image")));
            this.BtnPetFood.ImageSize = new System.Drawing.Size(40, 40);
            this.BtnPetFood.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.BtnPetFood.Location = new System.Drawing.Point(12, 316);
            this.BtnPetFood.Name = "BtnPetFood";
            this.BtnPetFood.OnHoverBaseColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnPetFood.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnPetFood.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnPetFood.OnHoverImage = null;
            this.BtnPetFood.OnHoverLineColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnPetFood.OnPressedColor = System.Drawing.Color.Black;
            this.BtnPetFood.Radius = 25;
            this.BtnPetFood.Size = new System.Drawing.Size(169, 52);
            this.BtnPetFood.TabIndex = 45;
            this.BtnPetFood.Text = " Pet Food";
            this.BtnPetFood.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnPet
            // 
            this.BtnPet.AnimationHoverSpeed = 0.07F;
            this.BtnPet.AnimationSpeed = 0.03F;
            this.BtnPet.BackColor = System.Drawing.Color.Transparent;
            this.BtnPet.BaseColor = System.Drawing.Color.LightGoldenrodYellow;
            this.BtnPet.BorderColor = System.Drawing.Color.Black;
            this.BtnPet.CheckedBaseColor = System.Drawing.Color.Gray;
            this.BtnPet.CheckedBorderColor = System.Drawing.Color.Black;
            this.BtnPet.CheckedForeColor = System.Drawing.Color.White;
            this.BtnPet.CheckedImage = ((System.Drawing.Image)(resources.GetObject("BtnPet.CheckedImage")));
            this.BtnPet.CheckedLineColor = System.Drawing.Color.DimGray;
            this.BtnPet.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnPet.FocusedColor = System.Drawing.Color.Empty;
            this.BtnPet.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPet.ForeColor = System.Drawing.Color.DimGray;
            this.BtnPet.Image = ((System.Drawing.Image)(resources.GetObject("BtnPet.Image")));
            this.BtnPet.ImageSize = new System.Drawing.Size(35, 35);
            this.BtnPet.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.BtnPet.Location = new System.Drawing.Point(12, 258);
            this.BtnPet.Name = "BtnPet";
            this.BtnPet.OnHoverBaseColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnPet.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnPet.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnPet.OnHoverImage = null;
            this.BtnPet.OnHoverLineColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnPet.OnPressedColor = System.Drawing.Color.Black;
            this.BtnPet.Radius = 25;
            this.BtnPet.Size = new System.Drawing.Size(169, 52);
            this.BtnPet.TabIndex = 44;
            this.BtnPet.Text = "Pet";
            this.BtnPet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnDashboard
            // 
            this.btnDashboard.AnimationHoverSpeed = 0.07F;
            this.btnDashboard.AnimationSpeed = 0.03F;
            this.btnDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btnDashboard.BaseColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnDashboard.BorderColor = System.Drawing.Color.Black;
            this.btnDashboard.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnDashboard.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnDashboard.CheckedForeColor = System.Drawing.Color.White;
            this.btnDashboard.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnDashboard.CheckedImage")));
            this.btnDashboard.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnDashboard.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDashboard.FocusedColor = System.Drawing.Color.Empty;
            this.btnDashboard.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.DimGray;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageSize = new System.Drawing.Size(29, 29);
            this.btnDashboard.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnDashboard.Location = new System.Drawing.Point(12, 197);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.OnHoverBaseColor = System.Drawing.Color.DarkGoldenrod;
            this.btnDashboard.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDashboard.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDashboard.OnHoverImage = null;
            this.btnDashboard.OnHoverLineColor = System.Drawing.Color.DarkGoldenrod;
            this.btnDashboard.OnPressedColor = System.Drawing.Color.Black;
            this.btnDashboard.Radius = 25;
            this.btnDashboard.Size = new System.Drawing.Size(169, 55);
            this.btnDashboard.TabIndex = 43;
            this.btnDashboard.Text = "  Dashboard";
            this.btnDashboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PicLogo
            // 
            this.PicLogo.BackColor = System.Drawing.Color.Transparent;
            this.PicLogo.Image = global::WindowsFormsApp1.Properties.Resources.ChatGPT_Image_Jun_8__2025__04_28_14_PM2;
            this.PicLogo.Location = new System.Drawing.Point(0, 40);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(206, 146);
            this.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicLogo.TabIndex = 38;
            this.PicLogo.TabStop = false;
            // 
            // PETSHOP
            // 
            this.PETSHOP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PETSHOP.AnimationHoverSpeed = 0.07F;
            this.PETSHOP.AnimationSpeed = 0.03F;
            this.PETSHOP.BackColor = System.Drawing.Color.Transparent;
            this.PETSHOP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PETSHOP.BaseColor = System.Drawing.Color.Transparent;
            this.PETSHOP.BorderColor = System.Drawing.Color.Black;
            this.PETSHOP.CheckedBaseColor = System.Drawing.Color.Gray;
            this.PETSHOP.CheckedBorderColor = System.Drawing.Color.Black;
            this.PETSHOP.CheckedForeColor = System.Drawing.Color.White;
            this.PETSHOP.CheckedImage = ((System.Drawing.Image)(resources.GetObject("PETSHOP.CheckedImage")));
            this.PETSHOP.CheckedLineColor = System.Drawing.Color.DimGray;
            this.PETSHOP.DialogResult = System.Windows.Forms.DialogResult.None;
            this.PETSHOP.FocusedColor = System.Drawing.Color.Empty;
            this.PETSHOP.Font = new System.Drawing.Font("Courier New", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PETSHOP.ForeColor = System.Drawing.Color.DimGray;
            this.PETSHOP.Image = null;
            this.PETSHOP.ImageSize = new System.Drawing.Size(20, 20);
            this.PETSHOP.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.PETSHOP.Location = new System.Drawing.Point(8, 8);
            this.PETSHOP.Name = "PETSHOP";
            this.PETSHOP.OnHoverBaseColor = System.Drawing.Color.Gold;
            this.PETSHOP.OnHoverBorderColor = System.Drawing.Color.Black;
            this.PETSHOP.OnHoverForeColor = System.Drawing.Color.DimGray;
            this.PETSHOP.OnHoverImage = null;
            this.PETSHOP.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.PETSHOP.OnPressedColor = System.Drawing.Color.Black;
            this.PETSHOP.Radius = 10;
            this.PETSHOP.Size = new System.Drawing.Size(177, 26);
            this.PETSHOP.TabIndex = 35;
            this.PETSHOP.Text = "Pet Shop";
            this.PETSHOP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnDelete
            // 
            this.BtnDelete.AnimationHoverSpeed = 0.07F;
            this.BtnDelete.AnimationSpeed = 0.03F;
            this.BtnDelete.BackColor = System.Drawing.Color.Transparent;
            this.BtnDelete.BaseColor = System.Drawing.Color.Gold;
            this.BtnDelete.BorderColor = System.Drawing.Color.Black;
            this.BtnDelete.CheckedBaseColor = System.Drawing.Color.Gray;
            this.BtnDelete.CheckedBorderColor = System.Drawing.Color.Black;
            this.BtnDelete.CheckedForeColor = System.Drawing.Color.White;
            this.BtnDelete.CheckedImage = ((System.Drawing.Image)(resources.GetObject("BtnDelete.CheckedImage")));
            this.BtnDelete.CheckedLineColor = System.Drawing.Color.DimGray;
            this.BtnDelete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnDelete.FocusedColor = System.Drawing.Color.Empty;
            this.BtnDelete.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.ForeColor = System.Drawing.Color.DimGray;
            this.BtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("BtnDelete.Image")));
            this.BtnDelete.ImageSize = new System.Drawing.Size(35, 35);
            this.BtnDelete.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.BtnDelete.Location = new System.Drawing.Point(670, 175);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.OnHoverBaseColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnDelete.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnDelete.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnDelete.OnHoverImage = null;
            this.BtnDelete.OnHoverLineColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnDelete.OnPressedColor = System.Drawing.Color.Black;
            this.BtnDelete.Radius = 13;
            this.BtnDelete.Size = new System.Drawing.Size(177, 46);
            this.BtnDelete.TabIndex = 32;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnReset
            // 
            this.BtnReset.AnimationHoverSpeed = 0.07F;
            this.BtnReset.AnimationSpeed = 0.03F;
            this.BtnReset.BackColor = System.Drawing.Color.Transparent;
            this.BtnReset.BaseColor = System.Drawing.Color.Gold;
            this.BtnReset.BorderColor = System.Drawing.Color.Black;
            this.BtnReset.CheckedBaseColor = System.Drawing.Color.Gray;
            this.BtnReset.CheckedBorderColor = System.Drawing.Color.Black;
            this.BtnReset.CheckedForeColor = System.Drawing.Color.White;
            this.BtnReset.CheckedImage = ((System.Drawing.Image)(resources.GetObject("BtnReset.CheckedImage")));
            this.BtnReset.CheckedLineColor = System.Drawing.Color.DimGray;
            this.BtnReset.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnReset.FocusedColor = System.Drawing.Color.Empty;
            this.BtnReset.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReset.ForeColor = System.Drawing.Color.DimGray;
            this.BtnReset.Image = ((System.Drawing.Image)(resources.GetObject("BtnReset.Image")));
            this.BtnReset.ImageSize = new System.Drawing.Size(30, 30);
            this.BtnReset.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.BtnReset.Location = new System.Drawing.Point(453, 175);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.OnHoverBaseColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnReset.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnReset.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnReset.OnHoverImage = null;
            this.BtnReset.OnHoverLineColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnReset.OnPressedColor = System.Drawing.Color.Black;
            this.BtnReset.Radius = 13;
            this.BtnReset.Size = new System.Drawing.Size(177, 46);
            this.BtnReset.TabIndex = 31;
            this.BtnReset.Text = "Reset";
            this.BtnReset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.AnimationHoverSpeed = 0.07F;
            this.BtnUpdate.AnimationSpeed = 0.03F;
            this.BtnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.BtnUpdate.BaseColor = System.Drawing.Color.Gold;
            this.BtnUpdate.BorderColor = System.Drawing.Color.Black;
            this.BtnUpdate.CheckedBaseColor = System.Drawing.Color.Gray;
            this.BtnUpdate.CheckedBorderColor = System.Drawing.Color.Black;
            this.BtnUpdate.CheckedForeColor = System.Drawing.Color.White;
            this.BtnUpdate.CheckedImage = ((System.Drawing.Image)(resources.GetObject("BtnUpdate.CheckedImage")));
            this.BtnUpdate.CheckedLineColor = System.Drawing.Color.DimGray;
            this.BtnUpdate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnUpdate.FocusedColor = System.Drawing.Color.Empty;
            this.BtnUpdate.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.ForeColor = System.Drawing.Color.DimGray;
            this.BtnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("BtnUpdate.Image")));
            this.BtnUpdate.ImageSize = new System.Drawing.Size(35, 35);
            this.BtnUpdate.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.BtnUpdate.Location = new System.Drawing.Point(239, 175);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.OnHoverBaseColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnUpdate.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnUpdate.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnUpdate.OnHoverImage = null;
            this.BtnUpdate.OnHoverLineColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnUpdate.OnPressedColor = System.Drawing.Color.Black;
            this.BtnUpdate.Radius = 13;
            this.BtnUpdate.Size = new System.Drawing.Size(177, 46);
            this.BtnUpdate.TabIndex = 30;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnSave
            // 
            this.BtnSave.AnimationHoverSpeed = 0.07F;
            this.BtnSave.AnimationSpeed = 0.03F;
            this.BtnSave.BackColor = System.Drawing.Color.Transparent;
            this.BtnSave.BaseColor = System.Drawing.Color.Gold;
            this.BtnSave.BorderColor = System.Drawing.Color.Black;
            this.BtnSave.CheckedBaseColor = System.Drawing.Color.Gray;
            this.BtnSave.CheckedBorderColor = System.Drawing.Color.Black;
            this.BtnSave.CheckedForeColor = System.Drawing.Color.White;
            this.BtnSave.CheckedImage = ((System.Drawing.Image)(resources.GetObject("BtnSave.CheckedImage")));
            this.BtnSave.CheckedLineColor = System.Drawing.Color.DimGray;
            this.BtnSave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnSave.FocusedColor = System.Drawing.Color.Empty;
            this.BtnSave.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.ForeColor = System.Drawing.Color.DimGray;
            this.BtnSave.Image = ((System.Drawing.Image)(resources.GetObject("BtnSave.Image")));
            this.BtnSave.ImageSize = new System.Drawing.Size(35, 35);
            this.BtnSave.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.BtnSave.Location = new System.Drawing.Point(24, 175);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.OnHoverBaseColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnSave.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnSave.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnSave.OnHoverImage = null;
            this.BtnSave.OnHoverLineColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnSave.OnPressedColor = System.Drawing.Color.Black;
            this.BtnSave.Radius = 13;
            this.BtnSave.Size = new System.Drawing.Size(177, 46);
            this.BtnSave.TabIndex = 29;
            this.BtnSave.Text = "Save";
            this.BtnSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaAdvenceButton15
            // 
            this.gunaAdvenceButton15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaAdvenceButton15.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton15.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton15.BackColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gunaAdvenceButton15.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.gunaAdvenceButton15.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton15.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton15.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton15.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton15.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton15.CheckedImage")));
            this.gunaAdvenceButton15.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton15.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton15.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton15.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaAdvenceButton15.ForeColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton15.Image = null;
            this.gunaAdvenceButton15.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton15.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton15.Location = new System.Drawing.Point(584, 342);
            this.gunaAdvenceButton15.Name = "gunaAdvenceButton15";
            this.gunaAdvenceButton15.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.gunaAdvenceButton15.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton15.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.gunaAdvenceButton15.OnHoverImage = null;
            this.gunaAdvenceButton15.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton15.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton15.Radius = 10;
            this.gunaAdvenceButton15.Size = new System.Drawing.Size(209, 23);
            this.gunaAdvenceButton15.TabIndex = 24;
            this.gunaAdvenceButton15.Text = "Users List";
            this.gunaAdvenceButton15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // User_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(1174, 750);
            this.Controls.Add(this.BtnPetsList);
            this.Controls.Add(this.GDGVUser);
            this.Controls.Add(this.gunaAdvenceButton2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.gunaAdvenceButton15);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "User_Dashboard";
            this.Text = "User_Dashboard";
            this.Load += new System.EventHandler(this.User_Dashboard_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GDGVUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicPet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox3;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextUserName;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton15;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private Guna.UI.WinForms.GunaDataGridView GDGVUser;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private Guna.UI.WinForms.GunaAdvenceButton BtnDelete;
        private Guna.UI.WinForms.GunaAdvenceButton BtnReset;
        private Guna.UI.WinForms.GunaAdvenceButton BtnUpdate;
        private Guna.UI.WinForms.GunaAdvenceButton BtnSave;
        private Guna.UI.WinForms.GunaAdvenceButton PSMS;
        private Guna.UI.WinForms.GunaAdvenceButton PETSHOP;
        private System.Windows.Forms.PictureBox PicLogo;
        private Guna.UI.WinForms.GunaAdvenceButton BtnTransactions;
        private Guna.UI.WinForms.GunaAdvenceButton BtnBilling;
        private Guna.UI.WinForms.GunaAdvenceButton BtnSupplier;
        private Guna.UI.WinForms.GunaAdvenceButton BtnUser;
        private Guna.UI.WinForms.GunaAdvenceButton BtnCustomers;
        private Guna.UI.WinForms.GunaAdvenceButton BtnPetFood;
        private Guna.UI.WinForms.GunaAdvenceButton BtnPet;
        private Guna.UI.WinForms.GunaAdvenceButton btnDashboard;
        private Guna.UI.WinForms.GunaAdvenceButton BtnLogout;
        private Guna.UI.WinForms.GunaAdvenceButton BtnPetsList;
        private System.Windows.Forms.PictureBox PicPet;
    }
}