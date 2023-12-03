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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Inventory_System
{
    public partial class frmLogin : Form
    {
        MySqlConnection connection =
            new MySqlConnection
            ("datasource=localhost;port=3306;username=root;password=''");
        MySqlCommand command;
        MySqlDataReader mdr;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Please enter both Username and Password", "No Value", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string connectionString = ("datasource=localhost;port=3306;username=root;password=''");

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        // Use parameterized query to prevent SQL injection
                        string selectQuery = "SELECT * FROM inventory.login WHERE Username = @userName AND PASSWORD = @PASSWORD";
                        MySqlCommand command = new MySqlCommand(selectQuery, connection);
                        command.Parameters.AddWithValue("@userName", txtUsername.Text);
                        command.Parameters.AddWithValue("@PASSWORD", txtPassword.Text);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                MessageBox.Show("Admin Login Successful!");
                                // Code for connecting to the 'AdminAccount' database here
                                this.Hide();
                                frmInventory frmInventory = new frmInventory();
                                frmInventory.ShowDialog();
                            }
                            else
                            {
                                // Close the first DataReader before executing the second query
                                reader.Close();

                                // Check user accounts
                                string selectUserQuery = "SELECT * FROM inventory.login WHERE userName = @userName AND Password = @Password";
                                MySqlCommand userCommand = new MySqlCommand(selectUserQuery, connection);
                                userCommand.Parameters.AddWithValue("@userName", txtUsername.Text);
                                userCommand.Parameters.AddWithValue("@PASSWORD", txtPassword.Text);

                                using (MySqlDataReader userReader = userCommand.ExecuteReader())
                                {
                                    if (userReader.Read())
                                    {
                                        MessageBox.Show("User Login Successful!");
                                        this.Hide();
                                        frmInventory frmInventory = new frmInventory();
                                        frmInventory.ShowDialog();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Incorrect Login Information! Try again.");
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            System.Windows.Forms.Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }

    }
}
                    
            
                
            