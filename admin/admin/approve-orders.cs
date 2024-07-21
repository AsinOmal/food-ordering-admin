using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace admin
{
    public partial class approve_orders : UserControl
    {
        public int order_id { get; set; }
        public event EventHandler orderConfirmed = null;
        public event EventHandler orderDeclined = null;

        public DataTable orderTable { get; set; }
        public approve_orders()
        {
            InitializeComponent();
        }

        private void approve_orders_Load(object sender, EventArgs e)
        {
            lblOrderId.Text = order_id.ToString();
            itemTable.DataSource = orderTable;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            orderConfirmed?.Invoke(this, e);
        }

        private void btnDeclined_Click(object sender, EventArgs e)
        {
            orderDeclined?.Invoke(this, e);
        }
        public void RemoveFromParent()
        {
            if (this.Parent != null)
            {
                this.Parent.Controls.Remove(this);
            }
        }
    }
}
