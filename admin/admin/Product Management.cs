using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace admin
{
    public partial class Product_Management : UserControl
    {
        private byte[] imageData;
        MySqlConnection conn;
        public Product_Management()
        {
            InitializeComponent();
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png, *.gif, *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureboxitem.Image = new Bitmap(openFileDialog.FileName);

                }
                if (pictureboxitem.Image == null)
                {
                    MessageBox.Show("Please select image", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                using (MemoryStream ms = new MemoryStream())
                {
                    pictureboxitem.Image.Save(ms, pictureboxitem.Image.RawFormat);
                    imageData = ms.ToArray();
                }
            }
            catch (System.NullReferenceException ex)
            {
                MessageBox.Show("Please select image", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            if (txtPName.Text != "" && txtPrice.Text != "" && cmbCatType.SelectedIndex != -1 && pictureboxitem.Image != null)
            {

                string connectionString = "server=localhost;user=root;database=munchbar_db;port=3306";
                conn = new MySqlConnection(connectionString);
                conn.Open();

                string sql_cmd = "INSERT INTO item (itemname,unitprice,category,image) VALUES (@name,@price,@category,@image)";
                MySqlCommand cmd = new MySqlCommand(sql_cmd, conn);
                cmd.Parameters.AddWithValue("@name", txtPName.Text);
                cmd.Parameters.AddWithValue("@price", txtPrice.Text);
                cmd.Parameters.AddWithValue("@category", cmbCatType.Text);
                cmd.Parameters.AddWithValue("@image", imageData);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Item added successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();

                
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // If it's not a digit or a control character, ignore the input
                e.Handled = true;
            }
        }

        private void Product_Management_Load(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user=root;database=munchbar_db;port=3306";
            conn = new MySqlConnection(connectionString);
            conn.Open();

            string sql = "SELECT itemname FROM item";
            MySqlCommand cmd = new MySqlCommand( sql, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                // Assuming one column in the table
                comboItems.Items.Add(row[0].ToString());
            }
            conn.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(comboItems.SelectedIndex != -1)
            {
                string connectionString = "server=localhost;user=root;database=munchbar_db;port=3306";
                conn = new MySqlConnection(connectionString);
                conn.Open();

                string sql = "DELETE FROM item WHERE itemname = @name";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", comboItems.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show(comboItems.Text+"deleted successful!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

                comboItems.Items.Clear();
                string sql2 = "SELECT itemname FROM item";
                MySqlCommand cmd2 = new MySqlCommand(sql2, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd2);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    // Assuming one column in the table
                    comboItems.Items.Add(row[0].ToString());
                }


                conn.Close();
            }
            else
            {
                MessageBox.Show("Please select product name first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefreash_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user=root;database=munchbar_db;port=3306";
            conn = new MySqlConnection(connectionString);
            conn.Open();

            comboItems.Items.Clear();
            string sql2 = "SELECT itemname FROM item";
            MySqlCommand cmd2 = new MySqlCommand(sql2, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd2);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                // Assuming one column in the table
                comboItems.Items.Add(row[0].ToString());
            }


            conn.Close();
        }
    }
}
