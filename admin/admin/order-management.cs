using MySql.Data.MySqlClient;
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
    public partial class order_management : UserControl
    {
        public order_management()
        {
            InitializeComponent();
        }
        MySqlConnection conn;

        private void order_management_Load(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user=root;database=munchbar_db;port=3306";
            conn = new MySqlConnection(connectionString);
            conn.Open();

            LoadOrders(connectionString);

            conn.Close();
        }

        private void LoadOrders(string connectionString)
        {
            order_list.Controls.Clear(); // Clear the current orders

            string sql = "SELECT id FROM orders WHERE confirm_status = FALSE";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int id = reader.GetInt32("id");

                MySqlConnection inner_conn = new MySqlConnection(connectionString);
                inner_conn.Open();

                string sql_orders = "SELECT itemname, quantity FROM order_details WHERE id = @id";
                MySqlCommand cmd2 = new MySqlCommand(sql_orders, inner_conn);
                cmd2.Parameters.AddWithValue("@id", id);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd2);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                var w = new approve_orders()
                {
                    order_id = id,
                    orderTable = dataTable
                };
                order_list.Controls.Add(w);
                dataTable.Dispose();
                adapter.Dispose();
                inner_conn.Close();

                w.orderConfirmed += (ss, ee) =>
                {
                    var order = (approve_orders)ss;

                    DialogResult result = MessageBox.Show("Do you want to confirm this order?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        MySqlConnection confirmConn = new MySqlConnection(connectionString);
                        confirmConn.Open();
                        string confirm = "UPDATE orders SET confirm_status = TRUE WHERE id = @id";

                        MySqlCommand cmdConfirm = new MySqlCommand(confirm, confirmConn);
                        cmdConfirm.Parameters.AddWithValue("@id", order.order_id);
                        cmdConfirm.ExecuteNonQuery();
                        confirmConn.Close();

                        order.RemoveFromParent(); // Remove the control from the parent
                    }
                };

                w.orderDeclined += (ss, ee) =>
                {
                    var order = (approve_orders)ss;

                    DialogResult result = MessageBox.Show("Do you want to decline this order?", "Order Decline", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        MySqlConnection declineConn = new MySqlConnection(connectionString);
                        declineConn.Open();
                        string decline = "DELETE FROM orders WHERE id = @id";

                        MySqlCommand cmdDecline = new MySqlCommand(decline, declineConn);
                        cmdDecline.Parameters.AddWithValue("@id", order.order_id);
                        cmdDecline.ExecuteNonQuery();
                        declineConn.Close();

                        order.RemoveFromParent(); // Remove the control from the parent
                    }
                };
            }
            reader.Close();
        }

    }
}
