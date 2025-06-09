namespace WindowsFormsApp1
{
    partial class Splash
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
            Guna.UI.WinForms.GunaCircleProgressBar gunaCircleProgressBar1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.LblPoweredByMomnaWahla = new System.Windows.Forms.Label();
            this.LblLoading = new System.Windows.Forms.Label();
            this.BtnPetShopManageSystem = new Guna.UI.WinForms.GunaAdvenceButton();
            gunaCircleProgressBar1 = new Guna.UI.WinForms.GunaCircleProgressBar();
            this.SuspendLayout();
            // 
            // gunaCircleProgressBar1
            // 
            gunaCircleProgressBar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            gunaCircleProgressBar1.AnimationSpeed = 0.6F;
            gunaCircleProgressBar1.BaseColor = System.Drawing.Color.Transparent;
            gunaCircleProgressBar1.IdleColor = System.Drawing.Color.Transparent;
            gunaCircleProgressBar1.IdleOffset = 20;
            gunaCircleProgressBar1.IdleThickness = 14;
            gunaCircleProgressBar1.Image = global::WindowsFormsApp1.Properties.Resources.ChatGPT_Image_Jun_8__2025__04_28_14_PM1;
            gunaCircleProgressBar1.ImageSize = new System.Drawing.Size(300, 300);
            gunaCircleProgressBar1.Location = new System.Drawing.Point(230, 91);
            gunaCircleProgressBar1.Name = "gunaCircleProgressBar1";
            gunaCircleProgressBar1.ProgressMaxColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            gunaCircleProgressBar1.ProgressMinColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            gunaCircleProgressBar1.ProgressOffset = 20;
            gunaCircleProgressBar1.Size = new System.Drawing.Size(268, 266);
            gunaCircleProgressBar1.TabIndex = 1;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 15;
            this.gunaElipse1.TargetControl = this;
            // 
            // LblPoweredByMomnaWahla
            // 
            this.LblPoweredByMomnaWahla.AutoSize = true;
            this.LblPoweredByMomnaWahla.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPoweredByMomnaWahla.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.LblPoweredByMomnaWahla.Location = new System.Drawing.Point(205, 407);
            this.LblPoweredByMomnaWahla.Name = "LblPoweredByMomnaWahla";
            this.LblPoweredByMomnaWahla.Size = new System.Drawing.Size(379, 34);
            this.LblPoweredByMomnaWahla.TabIndex = 2;
            this.LblPoweredByMomnaWahla.Text = "Powered By Momna Wahla";
            this.LblPoweredByMomnaWahla.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // LblLoading
            // 
            this.LblLoading.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LblLoading.AutoSize = true;
            this.LblLoading.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLoading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.LblLoading.Location = new System.Drawing.Point(181, 380);
            this.LblLoading.Name = "LblLoading";
            this.LblLoading.Size = new System.Drawing.Size(410, 27);
            this.LblLoading.TabIndex = 3;
            this.LblLoading.Text = "Application Loading......Please Wait!";
            this.LblLoading.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // BtnPetShopManageSystem
            // 
            this.BtnPetShopManageSystem.AnimationHoverSpeed = 0.07F;
            this.BtnPetShopManageSystem.AnimationSpeed = 0.03F;
            this.BtnPetShopManageSystem.BackColor = System.Drawing.Color.Transparent;
            this.BtnPetShopManageSystem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnPetShopManageSystem.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.BtnPetShopManageSystem.BorderColor = System.Drawing.Color.Black;
            this.BtnPetShopManageSystem.CheckedBaseColor = System.Drawing.Color.Gray;
            this.BtnPetShopManageSystem.CheckedBorderColor = System.Drawing.Color.Black;
            this.BtnPetShopManageSystem.CheckedForeColor = System.Drawing.Color.White;
            this.BtnPetShopManageSystem.CheckedImage = ((System.Drawing.Image)(resources.GetObject("BtnPetShopManageSystem.CheckedImage")));
            this.BtnPetShopManageSystem.CheckedLineColor = System.Drawing.Color.DimGray;
            this.BtnPetShopManageSystem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnPetShopManageSystem.FocusedColor = System.Drawing.Color.Empty;
            this.BtnPetShopManageSystem.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPetShopManageSystem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.BtnPetShopManageSystem.Image = null;
            this.BtnPetShopManageSystem.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnPetShopManageSystem.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.BtnPetShopManageSystem.Location = new System.Drawing.Point(89, 21);
            this.BtnPetShopManageSystem.Name = "BtnPetShopManageSystem";
            this.BtnPetShopManageSystem.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.BtnPetShopManageSystem.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnPetShopManageSystem.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.BtnPetShopManageSystem.OnHoverImage = null;
            this.BtnPetShopManageSystem.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.BtnPetShopManageSystem.OnPressedColor = System.Drawing.Color.Black;
            this.BtnPetShopManageSystem.Radius = 10;
            this.BtnPetShopManageSystem.Size = new System.Drawing.Size(572, 42);
            this.BtnPetShopManageSystem.TabIndex = 0;
            this.BtnPetShopManageSystem.Text = "Pet Shop Management System";
            this.BtnPetShopManageSystem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Controls.Add(this.LblLoading);
            this.Controls.Add(this.LblPoweredByMomnaWahla);
            this.Controls.Add(gunaCircleProgressBar1);
            this.Controls.Add(this.BtnPetShopManageSystem);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pet Shop Management System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.Label LblPoweredByMomnaWahla;
        private System.Windows.Forms.Label LblLoading;
        private Guna.UI.WinForms.GunaAdvenceButton BtnPetShopManageSystem;
    }
}

