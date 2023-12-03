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

namespace Inventory_System
{
    public partial class frmInventory : Form
    {
        public frmInventory()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            frmLogin frmLogin = new frmLogin();
            frmLogin.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmItemAdd frmItemAdd = new frmItemAdd();
            frmItemAdd.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSupplierAdd frmSupplierAdd = new frmSupplierAdd();
            frmSupplierAdd.ShowDialog();
        }
        private void Inventory(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                try
                {
                    using (MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=''"))
                    {
                        connection.Open();

                        string query = "SELECT * FROM =inventory.products";
                        MySqlCommand command = new MySqlCommand(query, connection);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Assuming dataGridView1 is the name of your DataGridView control
                            dataGridView1.DataSource = dataTable;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void LoadData()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=''"))
                {
                    connection.Open();

                    string query = "SELECT * FROM inventory.products";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Assuming dataGridView1 is the name of your DataGridView control
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}
