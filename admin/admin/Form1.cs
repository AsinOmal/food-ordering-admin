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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            welcomePanel.Visible = true;
            product_Management1.Visible = false;
            welcomePanel.BringToFront();
            order_management1.Visible = false;
        }

        private void btnProductManagement_Click(object sender, EventArgs e)
        {
            product_Management1.Visible = true;
            product_Management1.BringToFront();
        }

        private void btnorderManagement_Click(object sender, EventArgs e)
        {
            order_management1.Visible = true;
            order_management1.BringToFront();
        }
    }
}
