using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Account
{
    public partial class FillingInForm : Form
    {
        Product[] products;
        public FillingInForm()
        {
            InitializeComponent();
            DB db = new DB(DataHolder.hostName, DataHolder.port, DataHolder.userName, DataHolder.password, DataHolder.dataBase);
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `product`", db.getConnection());
            adapter.SelectCommand = command;
            try
            {
                adapter.Fill(table);

                products = new Product[table.Rows.Count];
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    var cells = table.Rows[i].ItemArray;
                    products[i] = new Product(cells[0], cells[1], cells[2]);
                }

            }
            catch (MySqlException)
            {
                MessageBox.Show("Не удалось подключиться к базе данных");
                Application.Exit();
            }
        }

        private void completeRecording_Click(object sender, EventArgs e)
        {
            DateTime purchaseDateVar = purchaseDate.Value;
            DB db = new DB(DataHolder.hostName, DataHolder.port, DataHolder.userName, DataHolder.password, DataHolder.dataBase);
            int a;
            if (!int.TryParse(idCustomer.Text, out a) || !int.TryParse(idPurchase.Text, out a) || !int.TryParse(amount.Text, out a))
            {
                MessageBox.Show("У одного из воодимых значений неправильный тип данных");
            }
            else
            if (int.Parse(idPurchase.Text) > products.Length + 1 || int.Parse(idPurchase.Text) < 1)
            {
                MessageBox.Show("Номер товара указан не верно, пожалуйста укажите номер от 1 до " + products.Length);
            }
            else if (int.Parse(amount.Text) < 1)
            {
                MessageBox.Show("Количество товаров должно быть больше 0");
            }
            else
            {
                MySqlCommand command = new MySqlCommand("INSERT INTO `records` (`idCustomer`, `purchaseDate`, `idPurchase`, `amount`, `hasCard`) VALUES (@idCust, @date, @idPurchase, @amount, @hasCard)", db.getConnection());
                command.Parameters.Add("@idCust", MySqlDbType.VarChar).Value = idCustomer.Text;
                command.Parameters.Add("@date", MySqlDbType.VarChar).Value = purchaseDate.Value.ToString("yyyy/MM/dd", CultureInfo.InvariantCulture);
                command.Parameters.Add("@idPurchase", MySqlDbType.VarChar).Value = idPurchase.Text;
                command.Parameters.Add("@amount", MySqlDbType.VarChar).Value = amount.Text;
                if (hasCard.Checked)
                    command.Parameters.Add("@hasCard", MySqlDbType.VarChar).Value = 1;
                else
                    command.Parameters.Add("@hasCard", MySqlDbType.VarChar).Value = 0;

                db.openConnection();
                if (command.ExecuteNonQuery() == 1)
                    MessageBox.Show("Запись была создана");
                else
                    MessageBox.Show("Запись была не создана");
                db.closeConnection();
            }
        }

        private void dateOfPurchase_TextChanged(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void amount_TextChanged(object sender, EventArgs e)
        {

        }

        private void idCustomer_TextChanged(object sender, EventArgs e)
        {

        }

        private void purchaseDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
