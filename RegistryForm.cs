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

namespace Account
{
    public partial class RegistryForm : Form
    {
        public RegistryForm()
        {
            InitializeComponent();
        }
        private void serverIns_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Connect_Click(object sender, EventArgs e)
        {

            if (int.TryParse(portIns.Text, out DataHolder.port))
            {
                DataHolder.hostName = serverIns.Text;
                DataHolder.userName = userNameIns.Text;
                DataHolder.password = passwordIns.Text;
                DataHolder.dataBase = dataBaseIns.Text;

                DB db = new DB(DataHolder.hostName, DataHolder.port, DataHolder.userName, DataHolder.password, DataHolder.dataBase);
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command = new MySqlCommand("SELECT * FROM `product`", db.getConnection());
                adapter.SelectCommand = command;
                try
                {
                    adapter.Fill(table);
                    this.Hide();
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                }
                catch (MySqlException)
                {
                    MessageBox.Show("Не удалось подключиться к базе данных, проверьте вводимые данные.");
                }
            }
            else
            {
                MessageBox.Show("Номер порта был введён в неправильном формате");
            }

        }

        private void passwordIns_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
