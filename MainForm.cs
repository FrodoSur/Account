using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account
{
    public partial class MainForm : Form
    {
        
        bool connected = false;
        Recording[] rec;
        Product[] products;
        public MainForm()
        {
            InitializeComponent();
            DB db = new DB(DataHolder.hostName, DataHolder.port, DataHolder.userName, DataHolder.password, DataHolder.dataBase);
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `product`", db.getConnection());
            adapter.SelectCommand = command;
                adapter.Fill(table);
                if (table.Rows.Count > 1)
                {
                    products = new Product[table.Rows.Count];
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        var cells = table.Rows[i].ItemArray;
                        products[i] = new Product(cells[0], cells[1], cells[2]);
                    }
                }
                connected = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void findId_Click(object sender, EventArgs e)
        {
            if (!connected)
                Application.Exit();
            String idClient = idInsert.Text;
            int a;
            if (Int32.TryParse(idInsert.Text, out a))
            {
                DB db = new DB(DataHolder.hostName, DataHolder.port, DataHolder.userName, DataHolder.password, DataHolder.dataBase);
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command = new MySqlCommand("SELECT * FROM `records` WHERE `idCustomer` = @uC", db.getConnection());
                command.Parameters.Add("@uC", MySqlDbType.Int32).Value = a;
                adapter.SelectCommand = command;
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    rec = new Recording[table.Rows.Count];
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        var cells = table.Rows[i].ItemArray;
                        rec[i] = new Recording(cells[2], cells[3], cells[4], cells[5]);
                    }

                    MessageBox.Show("Записи загружены");
                    CalculateTheSummary();
                }
                else
                    MessageBox.Show("Записей о покупателе которого вы ищете не существует");
            }
            else
            {
                MessageBox.Show("Id покупателя был введён в неправильном формате");
            }
        }
        private void CalculateTheSummary()
        {
            String s="";
            int[] monthOverAll = new int[12];
            int[] monthOverAllAmount = new int[12];
            int[] productAmount = new int[products.Length];
            for (int i = 0; i < 12; i++)
            {
                monthOverAll[i] = 0;
                monthOverAllAmount[i] = 0;
            }
            for(int i = 0; i < productAmount.Length; i++)
            {
                productAmount[i] = 0;
            }
            bool cardUsed = false;
            foreach (Recording r in rec)
            {
                if (r.hasCard)
                    cardUsed = true;
                productAmount[r.idPurchase] += r.amount;
                foreach(Product p in products)
                {
                    if (r.idPurchase == p.id)
                    {
                        r.CountOverAllCost(p.cost);
                        break;
                    }
                }
                if (r.overallCost != null)
                {
                    monthOverAllAmount[r.datePurchase.Month-1]++;
                    monthOverAll[r.datePurchase.Month-1] += r.overallCost;
                }

            }
            int totalAmount = 0;
            s += "Id покупателя:" + idInsert.Text  + "\r\nСреднее количество потраченных денег по месяцам:";//+"\r\nОбщая потраченная сумма:" + totalAmount
            int maxPurchase = 0;
            int maxMonthId = -1;
            for (int i = 0; i < monthOverAll.Length; i++)
            {
                totalAmount += monthOverAll[i];
                if (monthOverAllAmount[i] != 0)
                {
                    if (monthOverAllAmount[i] > maxPurchase)
                    {
                        maxPurchase = monthOverAllAmount[i];
                        maxMonthId = i;
                    }
                    s += "\r\n Месяц №" + (i+1) + ":" + (monthOverAll[i] / monthOverAllAmount[i]) + ".";
                }
                else
                    s += "\r\n Месяц №" + (i+1) + ":0" + ".";
            }
            s += "\r\n Самый активный месяц:" + (maxMonthId+1) +"\r\n Общее число потраченных денег:"+totalAmount+ "\r\n Список всех покупок и количество их приобретений:";
            maxPurchase = 0;
            maxMonthId = 0;
            for(int i = 0; i < productAmount.Length; i++)
            {
                if (productAmount[i] > 0)
                {
                    if (productAmount[i] > maxPurchase)
                    {
                        maxPurchase = productAmount[i];
                        maxMonthId = i;
                    }
                    s += "\r\n Продукт №" + i + " был куплен " + productAmount[i] + " раз" + ".";
                }
            }
            s += "\r\n Наиболее покупаемый товар это " + products[maxMonthId-1].name+".";
            if (cardUsed)
                s += "\r\n Покупатель использует карту постоянного покупателя.";
            else
                s += "\r\n Покупатель не использует карту постоянного покупателя.";
            Records.Text = s;
        }
        private void addRecord_Click(object sender, EventArgs e)
        {
            if (!connected)
                Application.Exit();

            this.Hide();
            FillingInForm fillingForm = new FillingInForm();
            fillingForm.Show();
        }

        private void Records_Click(object sender, EventArgs e)
        {

        }

        private void idInsert_TextChanged(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistryForm registryForm = new RegistryForm();
            registryForm.Show();
        }
    }
}
