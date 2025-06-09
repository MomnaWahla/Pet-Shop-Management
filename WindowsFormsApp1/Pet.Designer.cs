namespace WindowsFormsApp1
{
    partial class Pet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pet));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnTransactions = new Guna.UI.WinForms.GunaAdvenceButton();
            this.BtnBilling = new Guna.UI.WinForms.GunaAdvenceButton();
            this.BtnSupplier = new Guna.UI.WinForms.GunaAdvenceButton();
            this.BtnUser = new Guna.UI.WinForms.GunaAdvenceButton();
            this.PETSHOP = new Guna.UI.WinForms.GunaAdvenceButton();
            this.PicLogo = new System.Windows.Forms.PictureBox();
            this.BtnCustomers = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaAdvenceButton16 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.BtnPetFood = new Guna.UI.WinForms.GunaAdvenceButton();
            this.BtnPet = new Guna.UI.WinForms.GunaAdvenceButton();
            this.BtnLogout = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnDashboard = new Guna.UI.WinForms.GunaAdvenceButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PicPet = new System.Windows.Forms.PictureBox();
            this.BtnClose = new System.Windows.Forms.PictureBox();
            this.PSMS = new Guna.UI.WinForms.GunaAdvenceButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnDelete = new Guna.UI.WinForms.GunaAdvenceButton();
            this.BtnReset = new Guna.UI.WinForms.GunaAdvenceButton();
            this.BtnUpdate = new Guna.UI.WinForms.GunaAdvenceButton();
            this.txtPetPrice = new System.Windows.Forms.TextBox();
            this.LblPetQuantity = new System.Windows.Forms.Label();
            this.BtnSave = new Guna.UI.WinForms.GunaAdvenceButton();
            this.TxtPetQuantity = new System.Windows.Forms.TextBox();
            this.CBPetGender = new System.Windows.Forms.ComboBox();
            this.LblPetPrice = new System.Windows.Forms.Label();
            this.ComboPetGender = new System.Windows.Forms.Label();
            this.CBPetCategory = new System.Windows.Forms.ComboBox();
            this.ComboPetCategory = new System.Windows.Forms.Label();
            this.TextPetName = new System.Windows.Forms.TextBox();
            this.lblPetName = new System.Windows.Forms.Label();
            this.Madeby = new System.Windows.Forms.Label();
            this.GDGPet = new Guna.UI.WinForms.GunaDataGridView();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.BtnPetsList = new Guna.UI.WinForms.GunaAdvenceButton();
            this.BtnManagePet = new Guna.UI.WinForms.GunaAdvenceButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicPet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GDGPet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.BtnTransactions);
            this.panel1.Controls.Add(this.BtnBilling);
            this.panel1.Controls.Add(this.BtnSupplier);
            this.panel1.Controls.Add(this.BtnUser);
            this.panel1.Controls.Add(this.PETSHOP);
            this.panel1.Controls.Add(this.PicLogo);
            this.panel1.Controls.Add(this.BtnCustomers);
            this.panel1.Controls.Add(this.gunaAdvenceButton16);
            this.panel1.Controls.Add(this.BtnPetFood);
            this.panel1.Controls.Add(this.BtnPet);
            this.panel1.Controls.Add(this.BtnLogout);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 750);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.BtnTransactions.TabIndex = 42;
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
            this.BtnBilling.TabIndex = 41;
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
            this.BtnSupplier.TabIndex = 40;
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
            this.BtnUser.TabIndex = 39;
            this.BtnUser.Text = "User";
            this.BtnUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.PETSHOP.TabIndex = 28;
            this.PETSHOP.Text = "Pet Shop";
            this.PETSHOP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PETSHOP.Click += new System.EventHandler(this.PETSHOP_Click);
            // 
            // PicLogo
            // 
            this.PicLogo.BackColor = System.Drawing.Color.Transparent;
            this.PicLogo.Image = global::WindowsFormsApp1.Properties.Resources.ChatGPT_Image_Jun_8__2025__04_28_14_PM2;
            this.PicLogo.Location = new System.Drawing.Point(0, 40);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(206, 146);
            this.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicLogo.TabIndex = 37;
            this.PicLogo.TabStop = false;
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
            this.BtnCustomers.TabIndex = 38;
            this.BtnCustomers.Text = "  Customer";
            this.BtnCustomers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaAdvenceButton16
            // 
            this.gunaAdvenceButton16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaAdvenceButton16.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton16.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton16.BackColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gunaAdvenceButton16.BaseColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton16.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton16.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton16.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton16.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton16.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton16.CheckedImage")));
            this.gunaAdvenceButton16.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton16.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton16.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton16.Font = new System.Drawing.Font("Courier New", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaAdvenceButton16.ForeColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton16.Image = null;
            this.gunaAdvenceButton16.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton16.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton16.Location = new System.Drawing.Point(1, -30);
            this.gunaAdvenceButton16.Name = "gunaAdvenceButton16";
            this.gunaAdvenceButton16.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.gunaAdvenceButton16.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton16.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.gunaAdvenceButton16.OnHoverImage = null;
            this.gunaAdvenceButton16.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton16.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton16.Radius = 10;
            this.gunaAdvenceButton16.Size = new System.Drawing.Size(177, 26);
            this.gunaAdvenceButton16.TabIndex = 13;
            this.gunaAdvenceButton16.Text = "Pet Shop";
            this.gunaAdvenceButton16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaAdvenceButton16.Click += new System.EventHandler(this.gunaAdvenceButton16_Click);
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
            this.BtnPetFood.TabIndex = 30;
            this.BtnPetFood.Text = " Pet Food";
            this.BtnPetFood.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnPetFood.Click += new System.EventHandler(this.gunaAdvenceButton9_Click);
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
            this.BtnPet.Font = new System.Drawing.Font("Courier New", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.BtnPet.TabIndex = 24;
            this.BtnPet.Text = "Pet";
            this.BtnPet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnPet.Click += new System.EventHandler(this.gunaAdvenceButton14_Click);
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
            this.BtnLogout.TabIndex = 29;
            this.BtnLogout.Text = "Logout";
            this.BtnLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnLogout.Click += new System.EventHandler(this.gunaAdvenceButton13_Click);
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
            this.btnDashboard.TabIndex = 23;
            this.btnDashboard.Text = "  Dashboard";
            this.btnDashboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDashboard.Click += new System.EventHandler(this.gunaAdvenceButton4_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.PicPet);
            this.panel2.Controls.Add(this.BtnClose);
            this.panel2.Controls.Add(this.PSMS);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(199, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(975, 85);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // PicPet
            // 
            this.PicPet.BackColor = System.Drawing.Color.Transparent;
            this.PicPet.Image = global::WindowsFormsApp1.Properties.Resources.ChatGPT_Image_Jun_9__2025__05_24_41_AM;
            this.PicPet.Location = new System.Drawing.Point(9, -17);
            this.PicPet.Name = "PicPet";
            this.PicPet.Size = new System.Drawing.Size(169, 120);
            this.PicPet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicPet.TabIndex = 38;
            this.PicPet.TabStop = false;
            // 
            // BtnClose
            // 
            this.BtnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnClose.Image = global::WindowsFormsApp1.Properties.Resources._232cf3cfc0a4672e9441a6595e306408_removebg_preview;
            this.BtnClose.Location = new System.Drawing.Point(929, 0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(44, 83);
            this.BtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnClose.TabIndex = 6;
            this.BtnClose.TabStop = false;
            this.BtnClose.Click += new System.EventHandler(this.pictureBox3_Click);
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
            this.PSMS.TabIndex = 5;
            this.PSMS.Text = "Pet Shop Management System";
            this.PSMS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PSMS.Click += new System.EventHandler(this.gunaAdvenceButton1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BtnDelete);
            this.panel3.Controls.Add(this.BtnReset);
            this.panel3.Controls.Add(this.BtnUpdate);
            this.panel3.Controls.Add(this.txtPetPrice);
            this.panel3.Controls.Add(this.LblPetQuantity);
            this.panel3.Controls.Add(this.BtnSave);
            this.panel3.Controls.Add(this.TxtPetQuantity);
            this.panel3.Controls.Add(this.CBPetGender);
            this.panel3.Controls.Add(this.LblPetPrice);
            this.panel3.Controls.Add(this.ComboPetGender);
            this.panel3.Controls.Add(this.CBPetCategory);
            this.panel3.Controls.Add(this.ComboPetCategory);
            this.panel3.Controls.Add(this.TextPetName);
            this.panel3.Controls.Add(this.lblPetName);
            this.panel3.Location = new System.Drawing.Point(209, 128);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(939, 168);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
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
            this.BtnDelete.Location = new System.Drawing.Point(692, 91);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.OnHoverBaseColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnDelete.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnDelete.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnDelete.OnHoverImage = null;
            this.BtnDelete.OnHoverLineColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnDelete.OnPressedColor = System.Drawing.Color.Black;
            this.BtnDelete.Radius = 13;
            this.BtnDelete.Size = new System.Drawing.Size(177, 46);
            this.BtnDelete.TabIndex = 21;
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
            this.BtnReset.Location = new System.Drawing.Point(475, 91);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.OnHoverBaseColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnReset.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnReset.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnReset.OnHoverImage = null;
            this.BtnReset.OnHoverLineColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnReset.OnPressedColor = System.Drawing.Color.Black;
            this.BtnReset.Radius = 13;
            this.BtnReset.Size = new System.Drawing.Size(177, 46);
            this.BtnReset.TabIndex = 20;
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
            this.BtnUpdate.Location = new System.Drawing.Point(261, 91);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.OnHoverBaseColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnUpdate.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnUpdate.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnUpdate.OnHoverImage = null;
            this.BtnUpdate.OnHoverLineColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnUpdate.OnPressedColor = System.Drawing.Color.Black;
            this.BtnUpdate.Radius = 13;
            this.BtnUpdate.Size = new System.Drawing.Size(177, 46);
            this.BtnUpdate.TabIndex = 19;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPetPrice
            // 
            this.txtPetPrice.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPetPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(86)))));
            this.txtPetPrice.Location = new System.Drawing.Point(788, 44);
            this.txtPetPrice.MaxLength = 50;
            this.txtPetPrice.Multiline = true;
            this.txtPetPrice.Name = "txtPetPrice";
            this.txtPetPrice.Size = new System.Drawing.Size(140, 32);
            this.txtPetPrice.TabIndex = 10;
            this.txtPetPrice.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // LblPetQuantity
            // 
            this.LblPetQuantity.AutoSize = true;
            this.LblPetQuantity.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPetQuantity.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblPetQuantity.Location = new System.Drawing.Point(621, 18);
            this.LblPetQuantity.Name = "LblPetQuantity";
            this.LblPetQuantity.Size = new System.Drawing.Size(106, 23);
            this.LblPetQuantity.TabIndex = 7;
            this.LblPetQuantity.Text = "Quantity";
            this.LblPetQuantity.Click += new System.EventHandler(this.label3_Click);
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
            this.BtnSave.Location = new System.Drawing.Point(46, 91);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.OnHoverBaseColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnSave.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnSave.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnSave.OnHoverImage = null;
            this.BtnSave.OnHoverLineColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnSave.OnPressedColor = System.Drawing.Color.Black;
            this.BtnSave.Radius = 13;
            this.BtnSave.Size = new System.Drawing.Size(177, 46);
            this.BtnSave.TabIndex = 18;
            this.BtnSave.Text = "Save";
            this.BtnSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnSave.Click += new System.EventHandler(this.gunaAdvenceButton3_Click);
            // 
            // TxtPetQuantity
            // 
            this.TxtPetQuantity.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPetQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(86)))));
            this.TxtPetQuantity.Location = new System.Drawing.Point(620, 44);
            this.TxtPetQuantity.MaxLength = 50;
            this.TxtPetQuantity.Multiline = true;
            this.TxtPetQuantity.Name = "TxtPetQuantity";
            this.TxtPetQuantity.Size = new System.Drawing.Size(143, 32);
            this.TxtPetQuantity.TabIndex = 8;
            this.TxtPetQuantity.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CBPetGender
            // 
            this.CBPetGender.Font = new System.Drawing.Font("Courier New", 12F);
            this.CBPetGender.ForeColor = System.Drawing.Color.Gray;
            this.CBPetGender.FormattingEnabled = true;
            this.CBPetGender.ItemHeight = 22;
            this.CBPetGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.CBPetGender.Location = new System.Drawing.Point(434, 42);
            this.CBPetGender.Name = "CBPetGender";
            this.CBPetGender.Size = new System.Drawing.Size(165, 30);
            this.CBPetGender.TabIndex = 14;
            this.CBPetGender.Text = "Select";
            this.CBPetGender.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // LblPetPrice
            // 
            this.LblPetPrice.AutoSize = true;
            this.LblPetPrice.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPetPrice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblPetPrice.Location = new System.Drawing.Point(789, 18);
            this.LblPetPrice.Name = "LblPetPrice";
            this.LblPetPrice.Size = new System.Drawing.Size(70, 23);
            this.LblPetPrice.TabIndex = 9;
            this.LblPetPrice.Text = "Price";
            this.LblPetPrice.Click += new System.EventHandler(this.label4_Click);
            // 
            // ComboPetGender
            // 
            this.ComboPetGender.AutoSize = true;
            this.ComboPetGender.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboPetGender.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ComboPetGender.Location = new System.Drawing.Point(432, 14);
            this.ComboPetGender.Name = "ComboPetGender";
            this.ComboPetGender.Size = new System.Drawing.Size(82, 23);
            this.ComboPetGender.TabIndex = 13;
            this.ComboPetGender.Text = "Gender";
            this.ComboPetGender.Click += new System.EventHandler(this.label6_Click);
            // 
            // CBPetCategory
            // 
            this.CBPetCategory.Font = new System.Drawing.Font("Courier New", 12F);
            this.CBPetCategory.ForeColor = System.Drawing.Color.Gray;
            this.CBPetCategory.FormattingEnabled = true;
            this.CBPetCategory.ItemHeight = 22;
            this.CBPetCategory.Items.AddRange(new object[] {
            "Dog",
            "Cat",
            "Bird",
            "Fish"});
            this.CBPetCategory.Location = new System.Drawing.Point(241, 42);
            this.CBPetCategory.Name = "CBPetCategory";
            this.CBPetCategory.Size = new System.Drawing.Size(165, 30);
            this.CBPetCategory.TabIndex = 6;
            this.CBPetCategory.Text = "Select ";
            this.CBPetCategory.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ComboPetCategory
            // 
            this.ComboPetCategory.AutoSize = true;
            this.ComboPetCategory.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboPetCategory.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ComboPetCategory.Location = new System.Drawing.Point(239, 14);
            this.ComboPetCategory.Name = "ComboPetCategory";
            this.ComboPetCategory.Size = new System.Drawing.Size(106, 23);
            this.ComboPetCategory.TabIndex = 5;
            this.ComboPetCategory.Text = "Category";
            this.ComboPetCategory.Click += new System.EventHandler(this.label2_Click);
            // 
            // TextPetName
            // 
            this.TextPetName.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextPetName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(86)))));
            this.TextPetName.Location = new System.Drawing.Point(4, 40);
            this.TextPetName.MaxLength = 50;
            this.TextPetName.Multiline = true;
            this.TextPetName.Name = "TextPetName";
            this.TextPetName.Size = new System.Drawing.Size(216, 32);
            this.TextPetName.TabIndex = 4;
            this.TextPetName.TextChanged += new System.EventHandler(this.TextUserName_TextChanged);
            // 
            // lblPetName
            // 
            this.lblPetName.AutoSize = true;
            this.lblPetName.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPetName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPetName.Location = new System.Drawing.Point(5, 14);
            this.lblPetName.Name = "lblPetName";
            this.lblPetName.Size = new System.Drawing.Size(106, 23);
            this.lblPetName.TabIndex = 3;
            this.lblPetName.Text = "Pet Name";
            this.lblPetName.Click += new System.EventHandler(this.label1_Click);
            // 
            // Madeby
            // 
            this.Madeby.AutoSize = true;
            this.Madeby.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Madeby.ForeColor = System.Drawing.Color.DimGray;
            this.Madeby.Location = new System.Drawing.Point(581, 731);
            this.Madeby.Name = "Madeby";
            this.Madeby.Size = new System.Drawing.Size(183, 16);
            this.Madeby.TabIndex = 11;
            this.Madeby.Text = "Powered By Momna Wahla";
            this.Madeby.Click += new System.EventHandler(this.label5_Click);
            // 
            // GDGPet
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.GDGPet.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GDGPet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GDGPet.BackgroundColor = System.Drawing.Color.White;
            this.GDGPet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GDGPet.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GDGPet.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GDGPet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GDGPet.ColumnHeadersHeight = 25;
            this.GDGPet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GDGPet.DefaultCellStyle = dataGridViewCellStyle3;
            this.GDGPet.EnableHeadersVisualStyles = false;
            this.GDGPet.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.GDGPet.Location = new System.Drawing.Point(209, 331);
            this.GDGPet.Name = "GDGPet";
            this.GDGPet.RowHeadersVisible = false;
            this.GDGPet.RowHeadersWidth = 51;
            this.GDGPet.RowTemplate.Height = 24;
            this.GDGPet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GDGPet.Size = new System.Drawing.Size(939, 397);
            this.GDGPet.TabIndex = 27;
            this.GDGPet.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.GDGPet.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.GDGPet.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.GDGPet.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.GDGPet.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.GDGPet.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.GDGPet.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.GDGPet.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.GDGPet.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.GDGPet.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GDGPet.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GDGPet.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.GDGPet.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.GDGPet.ThemeStyle.HeaderStyle.Height = 25;
            this.GDGPet.ThemeStyle.ReadOnly = false;
            this.GDGPet.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.GDGPet.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GDGPet.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GDGPet.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Azure;
            this.GDGPet.ThemeStyle.RowsStyle.Height = 24;
            this.GDGPet.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GDGPet.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.GDGPet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.User_gunaDataGridView1_CellContentClick);
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 15;
            this.gunaElipse1.TargetControl = this;
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
            this.BtnPetsList.Location = new System.Drawing.Point(564, 302);
            this.BtnPetsList.Name = "BtnPetsList";
            this.BtnPetsList.OnHoverBaseColor = System.Drawing.Color.Gold;
            this.BtnPetsList.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnPetsList.OnHoverForeColor = System.Drawing.Color.DimGray;
            this.BtnPetsList.OnHoverImage = null;
            this.BtnPetsList.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.BtnPetsList.OnPressedColor = System.Drawing.Color.Black;
            this.BtnPetsList.Radius = 10;
            this.BtnPetsList.Size = new System.Drawing.Size(209, 23);
            this.BtnPetsList.TabIndex = 12;
            this.BtnPetsList.Text = "Pets List";
            this.BtnPetsList.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnPetsList.Click += new System.EventHandler(this.gunaAdvenceButton15_Click);
            // 
            // BtnManagePet
            // 
            this.BtnManagePet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnManagePet.AnimationHoverSpeed = 0.07F;
            this.BtnManagePet.AnimationSpeed = 0.03F;
            this.BtnManagePet.BackColor = System.Drawing.Color.Transparent;
            this.BtnManagePet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnManagePet.BaseColor = System.Drawing.Color.Gold;
            this.BtnManagePet.BorderColor = System.Drawing.Color.Black;
            this.BtnManagePet.CheckedBaseColor = System.Drawing.Color.Gray;
            this.BtnManagePet.CheckedBorderColor = System.Drawing.Color.Black;
            this.BtnManagePet.CheckedForeColor = System.Drawing.Color.White;
            this.BtnManagePet.CheckedImage = ((System.Drawing.Image)(resources.GetObject("BtnManagePet.CheckedImage")));
            this.BtnManagePet.CheckedLineColor = System.Drawing.Color.DimGray;
            this.BtnManagePet.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnManagePet.FocusedColor = System.Drawing.Color.Empty;
            this.BtnManagePet.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnManagePet.ForeColor = System.Drawing.Color.DimGray;
            this.BtnManagePet.Image = null;
            this.BtnManagePet.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnManagePet.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.BtnManagePet.Location = new System.Drawing.Point(492, 90);
            this.BtnManagePet.Name = "BtnManagePet";
            this.BtnManagePet.OnHoverBaseColor = System.Drawing.Color.Gold;
            this.BtnManagePet.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnManagePet.OnHoverForeColor = System.Drawing.Color.DimGray;
            this.BtnManagePet.OnHoverImage = null;
            this.BtnManagePet.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.BtnManagePet.OnPressedColor = System.Drawing.Color.Black;
            this.BtnManagePet.Radius = 10;
            this.BtnManagePet.Size = new System.Drawing.Size(337, 32);
            this.BtnManagePet.TabIndex = 6;
            this.BtnManagePet.Text = "Manage Pet";
            this.BtnManagePet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnManagePet.Click += new System.EventHandler(this.gunaAdvenceButton2_Click);
            // 
            // Pet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(1174, 750);
            this.Controls.Add(this.GDGPet);
            this.Controls.Add(this.BtnPetsList);
            this.Controls.Add(this.Madeby);
            this.Controls.Add(this.BtnManagePet);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Azure;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pet";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicPet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GDGPet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaAdvenceButton PSMS;
        private System.Windows.Forms.PictureBox BtnClose;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI.WinForms.GunaAdvenceButton BtnManagePet;
        private System.Windows.Forms.TextBox TextPetName;
        private System.Windows.Forms.Label lblPetName;
        private System.Windows.Forms.ComboBox CBPetCategory;
        private System.Windows.Forms.Label ComboPetCategory;
        private System.Windows.Forms.ComboBox CBPetGender;
        private System.Windows.Forms.Label ComboPetGender;
        private System.Windows.Forms.TextBox txtPetPrice;
        private System.Windows.Forms.Label LblPetPrice;
        private System.Windows.Forms.TextBox TxtPetQuantity;
        private System.Windows.Forms.Label LblPetQuantity;
        private Guna.UI.WinForms.GunaAdvenceButton BtnSave;
        private Guna.UI.WinForms.GunaAdvenceButton btnDashboard;
        private Guna.UI.WinForms.GunaAdvenceButton BtnPetFood;
        private Guna.UI.WinForms.GunaAdvenceButton BtnPet;
        private Guna.UI.WinForms.GunaAdvenceButton BtnLogout;
        private System.Windows.Forms.Label Madeby;
        private Guna.UI.WinForms.GunaAdvenceButton BtnPetsList;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton16;
        private Guna.UI.WinForms.GunaDataGridView GDGPet;
        private System.Windows.Forms.PictureBox PicLogo;
        private System.Windows.Forms.PictureBox PicPet;
        private Guna.UI.WinForms.GunaAdvenceButton BtnDelete;
        private Guna.UI.WinForms.GunaAdvenceButton BtnReset;
        private Guna.UI.WinForms.GunaAdvenceButton BtnUpdate;
        private Guna.UI.WinForms.GunaAdvenceButton PETSHOP;
        private Guna.UI.WinForms.GunaAdvenceButton BtnUser;
        private Guna.UI.WinForms.GunaAdvenceButton BtnCustomers;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaAdvenceButton BtnTransactions;
        private Guna.UI.WinForms.GunaAdvenceButton BtnBilling;
        private Guna.UI.WinForms.GunaAdvenceButton BtnSupplier;
    }
}