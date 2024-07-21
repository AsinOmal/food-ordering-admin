namespace admin
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnProductManagement = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnorderManagement = new Guna.UI2.WinForms.Guna2GradientButton();
            this.welcomePanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.order_management1 = new admin.order_management();
            this.product_Management1 = new admin.Product_Management();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.welcomePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.btnProductManagement);
            this.guna2GradientPanel1.Controls.Add(this.guna2PictureBox1);
            this.guna2GradientPanel1.Controls.Add(this.btnorderManagement);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.Black;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.Maroon;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1044, 104);
            this.guna2GradientPanel1.TabIndex = 0;
            // 
            // btnProductManagement
            // 
            this.btnProductManagement.Animated = true;
            this.btnProductManagement.BackColor = System.Drawing.Color.Transparent;
            this.btnProductManagement.BorderRadius = 20;
            this.btnProductManagement.CheckedState.Parent = this.btnProductManagement;
            this.btnProductManagement.CustomImages.Parent = this.btnProductManagement;
            this.btnProductManagement.FillColor = System.Drawing.Color.DarkRed;
            this.btnProductManagement.FillColor2 = System.Drawing.Color.Black;
            this.btnProductManagement.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductManagement.ForeColor = System.Drawing.Color.White;
            this.btnProductManagement.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnProductManagement.HoverState.FillColor2 = System.Drawing.Color.Crimson;
            this.btnProductManagement.HoverState.Parent = this.btnProductManagement;
            this.btnProductManagement.Image = ((System.Drawing.Image)(resources.GetObject("btnProductManagement.Image")));
            this.btnProductManagement.Location = new System.Drawing.Point(779, 20);
            this.btnProductManagement.Name = "btnProductManagement";
            this.btnProductManagement.ShadowDecoration.Parent = this.btnProductManagement;
            this.btnProductManagement.Size = new System.Drawing.Size(254, 61);
            this.btnProductManagement.TabIndex = 1;
            this.btnProductManagement.Text = "Product Management";
            this.btnProductManagement.Click += new System.EventHandler(this.btnProductManagement_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.Location = new System.Drawing.Point(12, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(233, 77);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // btnorderManagement
            // 
            this.btnorderManagement.Animated = true;
            this.btnorderManagement.BackColor = System.Drawing.Color.Transparent;
            this.btnorderManagement.BorderRadius = 20;
            this.btnorderManagement.CheckedState.Parent = this.btnorderManagement;
            this.btnorderManagement.CustomImages.Parent = this.btnorderManagement;
            this.btnorderManagement.FillColor = System.Drawing.Color.Black;
            this.btnorderManagement.FillColor2 = System.Drawing.Color.DarkRed;
            this.btnorderManagement.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnorderManagement.ForeColor = System.Drawing.Color.White;
            this.btnorderManagement.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnorderManagement.HoverState.FillColor = System.Drawing.Color.Crimson;
            this.btnorderManagement.HoverState.Parent = this.btnorderManagement;
            this.btnorderManagement.Image = ((System.Drawing.Image)(resources.GetObject("btnorderManagement.Image")));
            this.btnorderManagement.Location = new System.Drawing.Point(512, 20);
            this.btnorderManagement.Name = "btnorderManagement";
            this.btnorderManagement.ShadowDecoration.Parent = this.btnorderManagement;
            this.btnorderManagement.Size = new System.Drawing.Size(254, 61);
            this.btnorderManagement.TabIndex = 0;
            this.btnorderManagement.Text = "Order Management";
            this.btnorderManagement.Click += new System.EventHandler(this.btnorderManagement_Click);
            // 
            // welcomePanel
            // 
            this.welcomePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("welcomePanel.BackgroundImage")));
            this.welcomePanel.Controls.Add(this.label1);
            this.welcomePanel.Controls.Add(this.product_Management1);
            this.welcomePanel.Controls.Add(this.order_management1);
            this.welcomePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.welcomePanel.Location = new System.Drawing.Point(0, 104);
            this.welcomePanel.Name = "welcomePanel";
            this.welcomePanel.ShadowDecoration.Parent = this.welcomePanel;
            this.welcomePanel.Size = new System.Drawing.Size(1044, 622);
            this.welcomePanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(471, 128);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome";
            // 
            // order_management1
            // 
            this.order_management1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.order_management1.Location = new System.Drawing.Point(0, 0);
            this.order_management1.Name = "order_management1";
            this.order_management1.Size = new System.Drawing.Size(1044, 622);
            this.order_management1.TabIndex = 3;
            // 
            // product_Management1
            // 
            this.product_Management1.BackColor = System.Drawing.Color.White;
            this.product_Management1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.product_Management1.Location = new System.Drawing.Point(0, 0);
            this.product_Management1.Margin = new System.Windows.Forms.Padding(4);
            this.product_Management1.Name = "product_Management1";
            this.product_Management1.Size = new System.Drawing.Size(1044, 622);
            this.product_Management1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1044, 723);
            this.Controls.Add(this.welcomePanel);
            this.Controls.Add(this.guna2GradientPanel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "MunchBar Cafe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.welcomePanel.ResumeLayout(false);
            this.welcomePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2GradientPanel welcomePanel;
        private Guna.UI2.WinForms.Guna2GradientButton btnorderManagement;
        private Guna.UI2.WinForms.Guna2GradientButton btnProductManagement;
        private System.Windows.Forms.Label label1;
        private order_management order_management1;
        private Product_Management product_Management1;
    }
}

