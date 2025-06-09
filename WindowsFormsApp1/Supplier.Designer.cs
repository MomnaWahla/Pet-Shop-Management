namespace WindowsFormsApp1
{
    partial class Supplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Supplier));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CombroCustomerGender = new System.Windows.Forms.ComboBox();
            this.LblSupplierGender = new System.Windows.Forms.Label();
            this.TxtCustomerAddress = new System.Windows.Forms.TextBox();
            this.LblSupllierAddress = new System.Windows.Forms.Label();
            this.TxtCustomerPhone = new System.Windows.Forms.TextBox();
            this.LblSupplierPhone = new System.Windows.Forms.Label();
            this.TextCustomerName = new System.Windows.Forms.TextBox();
            this.LblSupplierName = new System.Windows.Forms.Label();
            this.GDGVCustomers = new Guna.UI.WinForms.GunaDataGridView();
            this.BtnSupplierList = new Guna.UI.WinForms.GunaAdvenceButton();
            this.BtnManageSupplier = new Guna.UI.WinForms.GunaAdvenceButton();
            this.BtnDelete = new Guna.UI.WinForms.GunaAdvenceButton();
            this.BtnReset = new Guna.UI.WinForms.GunaAdvenceButton();
            this.BtnUpdate = new Guna.UI.WinForms.GunaAdvenceButton();
            this.BtnSave = new Guna.UI.WinForms.GunaAdvenceButton();
            this.PicPetFood = new System.Windows.Forms.PictureBox();
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
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GDGVCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicPetFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.PicPetFood);
            this.panel2.Controls.Add(this.PSMS);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(199, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(975, 85);
            this.panel2.TabIndex = 29;
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
            this.panel1.TabIndex = 28;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BtnDelete);
            this.panel3.Controls.Add(this.BtnReset);
            this.panel3.Controls.Add(this.BtnUpdate);
            this.panel3.Controls.Add(this.BtnSave);
            this.panel3.Controls.Add(this.CombroCustomerGender);
            this.panel3.Controls.Add(this.LblSupplierGender);
            this.panel3.Controls.Add(this.TxtCustomerAddress);
            this.panel3.Controls.Add(this.LblSupllierAddress);
            this.panel3.Controls.Add(this.TxtCustomerPhone);
            this.panel3.Controls.Add(this.LblSupplierPhone);
            this.panel3.Controls.Add(this.TextCustomerName);
            this.panel3.Controls.Add(this.LblSupplierName);
            this.panel3.Location = new System.Drawing.Point(212, 129);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(939, 168);
            this.panel3.TabIndex = 30;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // CombroCustomerGender
            // 
            this.CombroCustomerGender.Font = new System.Drawing.Font("Courier New", 12F);
            this.CombroCustomerGender.ForeColor = System.Drawing.Color.Gray;
            this.CombroCustomerGender.FormattingEnabled = true;
            this.CombroCustomerGender.ItemHeight = 22;
            this.CombroCustomerGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.CombroCustomerGender.Location = new System.Drawing.Point(239, 41);
            this.CombroCustomerGender.Name = "CombroCustomerGender";
            this.CombroCustomerGender.Size = new System.Drawing.Size(165, 30);
            this.CombroCustomerGender.TabIndex = 14;
            this.CombroCustomerGender.Text = "Select";
            // 
            // LblSupplierGender
            // 
            this.LblSupplierGender.AutoSize = true;
            this.LblSupplierGender.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSupplierGender.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblSupplierGender.Location = new System.Drawing.Point(237, 14);
            this.LblSupplierGender.Name = "LblSupplierGender";
            this.LblSupplierGender.Size = new System.Drawing.Size(82, 23);
            this.LblSupplierGender.TabIndex = 13;
            this.LblSupplierGender.Text = "Gender";
            // 
            // TxtCustomerAddress
            // 
            this.TxtCustomerAddress.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCustomerAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(86)))));
            this.TxtCustomerAddress.Location = new System.Drawing.Point(629, 40);
            this.TxtCustomerAddress.MaxLength = 50;
            this.TxtCustomerAddress.Multiline = true;
            this.TxtCustomerAddress.Name = "TxtCustomerAddress";
            this.TxtCustomerAddress.Size = new System.Drawing.Size(268, 32);
            this.TxtCustomerAddress.TabIndex = 10;
            // 
            // LblSupllierAddress
            // 
            this.LblSupllierAddress.AutoSize = true;
            this.LblSupllierAddress.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSupllierAddress.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblSupllierAddress.Location = new System.Drawing.Point(630, 15);
            this.LblSupllierAddress.Name = "LblSupllierAddress";
            this.LblSupllierAddress.Size = new System.Drawing.Size(94, 23);
            this.LblSupllierAddress.TabIndex = 9;
            this.LblSupllierAddress.Text = "Address";
            // 
            // TxtCustomerPhone
            // 
            this.TxtCustomerPhone.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCustomerPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(86)))));
            this.TxtCustomerPhone.Location = new System.Drawing.Point(425, 39);
            this.TxtCustomerPhone.MaxLength = 50;
            this.TxtCustomerPhone.Multiline = true;
            this.TxtCustomerPhone.Name = "TxtCustomerPhone";
            this.TxtCustomerPhone.Size = new System.Drawing.Size(180, 32);
            this.TxtCustomerPhone.TabIndex = 8;
            // 
            // LblSupplierPhone
            // 
            this.LblSupplierPhone.AutoSize = true;
            this.LblSupplierPhone.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSupplierPhone.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblSupplierPhone.Location = new System.Drawing.Point(426, 13);
            this.LblSupplierPhone.Name = "LblSupplierPhone";
            this.LblSupplierPhone.Size = new System.Drawing.Size(106, 23);
            this.LblSupplierPhone.TabIndex = 7;
            this.LblSupplierPhone.Text = "Phone No";
            // 
            // TextCustomerName
            // 
            this.TextCustomerName.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextCustomerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(86)))));
            this.TextCustomerName.Location = new System.Drawing.Point(4, 39);
            this.TextCustomerName.MaxLength = 50;
            this.TextCustomerName.Multiline = true;
            this.TextCustomerName.Name = "TextCustomerName";
            this.TextCustomerName.Size = new System.Drawing.Size(216, 32);
            this.TextCustomerName.TabIndex = 4;
            // 
            // LblSupplierName
            // 
            this.LblSupplierName.AutoSize = true;
            this.LblSupplierName.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSupplierName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblSupplierName.Location = new System.Drawing.Point(5, 13);
            this.LblSupplierName.Name = "LblSupplierName";
            this.LblSupplierName.Size = new System.Drawing.Size(166, 23);
            this.LblSupplierName.TabIndex = 3;
            this.LblSupplierName.Text = "Supplier Name";
            // 
            // GDGVCustomers
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.GDGVCustomers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GDGVCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GDGVCustomers.BackgroundColor = System.Drawing.Color.White;
            this.GDGVCustomers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GDGVCustomers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GDGVCustomers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GDGVCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GDGVCustomers.ColumnHeadersHeight = 25;
            this.GDGVCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GDGVCustomers.DefaultCellStyle = dataGridViewCellStyle3;
            this.GDGVCustomers.EnableHeadersVisualStyles = false;
            this.GDGVCustomers.GridColor = System.Drawing.Color.White;
            this.GDGVCustomers.Location = new System.Drawing.Point(218, 332);
            this.GDGVCustomers.Name = "GDGVCustomers";
            this.GDGVCustomers.ReadOnly = true;
            this.GDGVCustomers.RowHeadersVisible = false;
            this.GDGVCustomers.RowHeadersWidth = 51;
            this.GDGVCustomers.RowTemplate.Height = 24;
            this.GDGVCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GDGVCustomers.Size = new System.Drawing.Size(942, 397);
            this.GDGVCustomers.TabIndex = 33;
            this.GDGVCustomers.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.GDGVCustomers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.GDGVCustomers.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.GDGVCustomers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.GDGVCustomers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.GDGVCustomers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.GDGVCustomers.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.GDGVCustomers.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.GDGVCustomers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.GDGVCustomers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GDGVCustomers.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GDGVCustomers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.GDGVCustomers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.GDGVCustomers.ThemeStyle.HeaderStyle.Height = 25;
            this.GDGVCustomers.ThemeStyle.ReadOnly = true;
            this.GDGVCustomers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.GDGVCustomers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GDGVCustomers.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GDGVCustomers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Gray;
            this.GDGVCustomers.ThemeStyle.RowsStyle.Height = 24;
            this.GDGVCustomers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GDGVCustomers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // BtnSupplierList
            // 
            this.BtnSupplierList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnSupplierList.AnimationHoverSpeed = 0.07F;
            this.BtnSupplierList.AnimationSpeed = 0.03F;
            this.BtnSupplierList.BackColor = System.Drawing.Color.Transparent;
            this.BtnSupplierList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSupplierList.BaseColor = System.Drawing.Color.Gold;
            this.BtnSupplierList.BorderColor = System.Drawing.Color.Black;
            this.BtnSupplierList.CheckedBaseColor = System.Drawing.Color.Gray;
            this.BtnSupplierList.CheckedBorderColor = System.Drawing.Color.Black;
            this.BtnSupplierList.CheckedForeColor = System.Drawing.Color.White;
            this.BtnSupplierList.CheckedImage = ((System.Drawing.Image)(resources.GetObject("BtnSupplierList.CheckedImage")));
            this.BtnSupplierList.CheckedLineColor = System.Drawing.Color.DimGray;
            this.BtnSupplierList.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnSupplierList.FocusedColor = System.Drawing.Color.Empty;
            this.BtnSupplierList.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSupplierList.ForeColor = System.Drawing.Color.DimGray;
            this.BtnSupplierList.Image = null;
            this.BtnSupplierList.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnSupplierList.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.BtnSupplierList.Location = new System.Drawing.Point(573, 303);
            this.BtnSupplierList.Name = "BtnSupplierList";
            this.BtnSupplierList.OnHoverBaseColor = System.Drawing.Color.Gold;
            this.BtnSupplierList.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnSupplierList.OnHoverForeColor = System.Drawing.Color.DimGray;
            this.BtnSupplierList.OnHoverImage = null;
            this.BtnSupplierList.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.BtnSupplierList.OnPressedColor = System.Drawing.Color.Black;
            this.BtnSupplierList.Radius = 10;
            this.BtnSupplierList.Size = new System.Drawing.Size(209, 23);
            this.BtnSupplierList.TabIndex = 32;
            this.BtnSupplierList.Text = "Suppliers List";
            this.BtnSupplierList.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnManageSupplier
            // 
            this.BtnManageSupplier.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnManageSupplier.AnimationHoverSpeed = 0.07F;
            this.BtnManageSupplier.AnimationSpeed = 0.03F;
            this.BtnManageSupplier.BackColor = System.Drawing.Color.Transparent;
            this.BtnManageSupplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnManageSupplier.BaseColor = System.Drawing.Color.Gold;
            this.BtnManageSupplier.BorderColor = System.Drawing.Color.Black;
            this.BtnManageSupplier.CheckedBaseColor = System.Drawing.Color.Gray;
            this.BtnManageSupplier.CheckedBorderColor = System.Drawing.Color.Black;
            this.BtnManageSupplier.CheckedForeColor = System.Drawing.Color.White;
            this.BtnManageSupplier.CheckedImage = ((System.Drawing.Image)(resources.GetObject("BtnManageSupplier.CheckedImage")));
            this.BtnManageSupplier.CheckedLineColor = System.Drawing.Color.DimGray;
            this.BtnManageSupplier.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnManageSupplier.FocusedColor = System.Drawing.Color.Empty;
            this.BtnManageSupplier.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnManageSupplier.ForeColor = System.Drawing.Color.DimGray;
            this.BtnManageSupplier.Image = null;
            this.BtnManageSupplier.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnManageSupplier.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.BtnManageSupplier.Location = new System.Drawing.Point(492, 90);
            this.BtnManageSupplier.Name = "BtnManageSupplier";
            this.BtnManageSupplier.OnHoverBaseColor = System.Drawing.Color.Gold;
            this.BtnManageSupplier.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnManageSupplier.OnHoverForeColor = System.Drawing.Color.DimGray;
            this.BtnManageSupplier.OnHoverImage = null;
            this.BtnManageSupplier.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.BtnManageSupplier.OnPressedColor = System.Drawing.Color.Black;
            this.BtnManageSupplier.Radius = 10;
            this.BtnManageSupplier.Size = new System.Drawing.Size(337, 32);
            this.BtnManageSupplier.TabIndex = 31;
            this.BtnManageSupplier.Text = "Manage Supplier";
            this.BtnManageSupplier.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.BtnDelete.Location = new System.Drawing.Point(697, 97);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.OnHoverBaseColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnDelete.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnDelete.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnDelete.OnHoverImage = null;
            this.BtnDelete.OnHoverLineColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnDelete.OnPressedColor = System.Drawing.Color.Black;
            this.BtnDelete.Radius = 13;
            this.BtnDelete.Size = new System.Drawing.Size(177, 46);
            this.BtnDelete.TabIndex = 29;
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
            this.BtnReset.Location = new System.Drawing.Point(480, 97);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.OnHoverBaseColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnReset.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnReset.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnReset.OnHoverImage = null;
            this.BtnReset.OnHoverLineColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnReset.OnPressedColor = System.Drawing.Color.Black;
            this.BtnReset.Radius = 13;
            this.BtnReset.Size = new System.Drawing.Size(177, 46);
            this.BtnReset.TabIndex = 28;
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
            this.BtnUpdate.Location = new System.Drawing.Point(266, 97);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.OnHoverBaseColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnUpdate.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnUpdate.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnUpdate.OnHoverImage = null;
            this.BtnUpdate.OnHoverLineColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnUpdate.OnPressedColor = System.Drawing.Color.Black;
            this.BtnUpdate.Radius = 13;
            this.BtnUpdate.Size = new System.Drawing.Size(177, 46);
            this.BtnUpdate.TabIndex = 27;
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
            this.BtnSave.Location = new System.Drawing.Point(51, 97);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.OnHoverBaseColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnSave.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnSave.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnSave.OnHoverImage = null;
            this.BtnSave.OnHoverLineColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnSave.OnPressedColor = System.Drawing.Color.Black;
            this.BtnSave.Radius = 13;
            this.BtnSave.Size = new System.Drawing.Size(177, 46);
            this.BtnSave.TabIndex = 26;
            this.BtnSave.Text = "Save";
            this.BtnSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PicPetFood
            // 
            this.PicPetFood.BackColor = System.Drawing.Color.Transparent;
            this.PicPetFood.Image = global::WindowsFormsApp1.Properties.Resources.Worker_free_icons_designed_by_nawicon_removebg_preview;
            this.PicPetFood.Location = new System.Drawing.Point(63, 7);
            this.PicPetFood.Name = "PicPetFood";
            this.PicPetFood.Size = new System.Drawing.Size(93, 73);
            this.PicPetFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicPetFood.TabIndex = 41;
            this.PicPetFood.TabStop = false;
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
            this.PSMS.TabIndex = 9;
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
            this.BtnLogout.TabIndex = 59;
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
            this.BtnTransactions.TabIndex = 58;
            this.BtnTransactions.Text = "Transactions";
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
            this.BtnBilling.TabIndex = 57;
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
            this.BtnSupplier.Font = new System.Drawing.Font("Courier New", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.BtnSupplier.TabIndex = 56;
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
            this.BtnUser.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.BtnUser.TabIndex = 55;
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
            this.BtnCustomers.TabIndex = 54;
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
            this.BtnPetFood.TabIndex = 53;
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
            this.BtnPet.TabIndex = 52;
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
            this.btnDashboard.TabIndex = 51;
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
            this.PicLogo.TabIndex = 39;
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
            this.PETSHOP.TabIndex = 37;
            this.PETSHOP.Text = "Pet Shop";
            this.PETSHOP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(1174, 750);
            this.Controls.Add(this.GDGVCustomers);
            this.Controls.Add(this.BtnSupplierList);
            this.Controls.Add(this.BtnManageSupplier);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Supplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supplier";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GDGVCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicPetFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
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
        private Guna.UI.WinForms.GunaAdvenceButton BtnSupplierList;
        private Guna.UI.WinForms.GunaAdvenceButton BtnManageSupplier;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI.WinForms.GunaAdvenceButton BtnDelete;
        private Guna.UI.WinForms.GunaAdvenceButton BtnReset;
        private Guna.UI.WinForms.GunaAdvenceButton BtnUpdate;
        private Guna.UI.WinForms.GunaAdvenceButton BtnSave;
        private System.Windows.Forms.ComboBox CombroCustomerGender;
        private System.Windows.Forms.Label LblSupplierGender;
        private System.Windows.Forms.TextBox TxtCustomerAddress;
        private System.Windows.Forms.Label LblSupllierAddress;
        private System.Windows.Forms.TextBox TxtCustomerPhone;
        private System.Windows.Forms.Label LblSupplierPhone;
        private System.Windows.Forms.TextBox TextCustomerName;
        private System.Windows.Forms.Label LblSupplierName;
        private Guna.UI.WinForms.GunaDataGridView GDGVCustomers;
        private Guna.UI.WinForms.GunaAdvenceButton PSMS;
        private System.Windows.Forms.PictureBox PicPetFood;
    }
}