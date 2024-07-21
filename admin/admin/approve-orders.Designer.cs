namespace admin
{
    partial class approve_orders
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(approve_orders));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnConfirm = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnDeclined = new Guna.UI2.WinForms.Guna2GradientButton();
            this.itemTable = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lblOrderId = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.itemTable)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.Animated = true;
            this.btnConfirm.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirm.BorderRadius = 20;
            this.btnConfirm.CheckedState.Parent = this.btnConfirm;
            this.btnConfirm.CustomImages.Parent = this.btnConfirm;
            this.btnConfirm.FillColor = System.Drawing.Color.LawnGreen;
            this.btnConfirm.FillColor2 = System.Drawing.Color.DarkGreen;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnConfirm.ForeColor = System.Drawing.Color.Lime;
            this.btnConfirm.HoverState.FillColor = System.Drawing.Color.Green;
            this.btnConfirm.HoverState.Parent = this.btnConfirm;
            this.btnConfirm.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.Image")));
            this.btnConfirm.Location = new System.Drawing.Point(394, 19);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.ShadowDecoration.Parent = this.btnConfirm;
            this.btnConfirm.Size = new System.Drawing.Size(40, 40);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnDeclined
            // 
            this.btnDeclined.Animated = true;
            this.btnDeclined.BorderRadius = 20;
            this.btnDeclined.CheckedState.Parent = this.btnDeclined;
            this.btnDeclined.CustomImages.Parent = this.btnDeclined;
            this.btnDeclined.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeclined.FillColor2 = System.Drawing.Color.Red;
            this.btnDeclined.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeclined.ForeColor = System.Drawing.Color.White;
            this.btnDeclined.HoverState.Parent = this.btnDeclined;
            this.btnDeclined.Image = ((System.Drawing.Image)(resources.GetObject("btnDeclined.Image")));
            this.btnDeclined.Location = new System.Drawing.Point(440, 19);
            this.btnDeclined.Name = "btnDeclined";
            this.btnDeclined.ShadowDecoration.Parent = this.btnDeclined;
            this.btnDeclined.Size = new System.Drawing.Size(40, 40);
            this.btnDeclined.TabIndex = 3;
            this.btnDeclined.Click += new System.EventHandler(this.btnDeclined_Click);
            // 
            // itemTable
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(199)))), ((int)(((byte)(195)))));
            this.itemTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.itemTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.itemTable.BackgroundColor = System.Drawing.Color.White;
            this.itemTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.itemTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.itemTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.itemTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.itemTable.ColumnHeadersHeight = 21;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(217)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(129)))), ((int)(((byte)(121)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.itemTable.DefaultCellStyle = dataGridViewCellStyle6;
            this.itemTable.EnableHeadersVisualStyles = false;
            this.itemTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(189)))), ((int)(((byte)(184)))));
            this.itemTable.Location = new System.Drawing.Point(45, 7);
            this.itemTable.Name = "itemTable";
            this.itemTable.RowHeadersVisible = false;
            this.itemTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.itemTable.Size = new System.Drawing.Size(313, 108);
            this.itemTable.TabIndex = 4;
            this.itemTable.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Red;
            this.itemTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(199)))), ((int)(((byte)(195)))));
            this.itemTable.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.itemTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.itemTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.itemTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.itemTable.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.itemTable.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(189)))), ((int)(((byte)(184)))));
            this.itemTable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.itemTable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.itemTable.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.itemTable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.itemTable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.itemTable.ThemeStyle.HeaderStyle.Height = 21;
            this.itemTable.ThemeStyle.ReadOnly = false;
            this.itemTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(217)))), ((int)(((byte)(215)))));
            this.itemTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.itemTable.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.itemTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.itemTable.ThemeStyle.RowsStyle.Height = 22;
            this.itemTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(129)))), ((int)(((byte)(121)))));
            this.itemTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // lblOrderId
            // 
            this.lblOrderId.BackColor = System.Drawing.Color.Transparent;
            this.lblOrderId.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderId.Location = new System.Drawing.Point(7, 25);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Size = new System.Drawing.Size(15, 34);
            this.lblOrderId.TabIndex = 5;
            this.lblOrderId.Text = "1";
            // 
            // approve_orders
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblOrderId);
            this.Controls.Add(this.itemTable);
            this.Controls.Add(this.btnDeclined);
            this.Controls.Add(this.btnConfirm);
            this.Name = "approve_orders";
            this.Size = new System.Drawing.Size(509, 144);
            this.Load += new System.EventHandler(this.approve_orders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GradientButton btnConfirm;
        private Guna.UI2.WinForms.Guna2GradientButton btnDeclined;
        private Guna.UI2.WinForms.Guna2DataGridView itemTable;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblOrderId;
    }
}
