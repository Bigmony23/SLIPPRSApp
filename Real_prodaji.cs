using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLIPPRSApp
{
    public partial class Real_prodaji : Form
    {
        public Real_prodaji()
        {
            InitializeComponent();
        }

        private void real_ProdajiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.real_ProdajiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.slippers11DataSet);

        }

        private void Real_prodaji_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "slippers11DataSet.Real_Prodaji". При необходимости она может быть перемещена или удалена.
            this.real_ProdajiTableAdapter.Fill(this.slippers11DataSet.Real_Prodaji);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            real_ProdajiBindingSource.Filter = "Data_Prixoda='" + comboBox1.Text + "'";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            real_ProdajiBindingSource.Filter = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            real_ProdajiTableAdapter.Update(slippers11DataSet);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Строка подключения к базе данных
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\C#\\Slippers\\SLIPPRSApp\\Slippers11.mdf;Integrated Security=True";

            // Создание экземпляра подключения
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Создание экземпляра команды
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;

                    // Запрос на вставку данных в таблицу Real_prodaji
                    command.CommandText = @"INSERT INTO Real_prodaji (
                Id_Product,
                Sotrudnik,
                Sena_prodaji,
                Kolichestvo
            )
            SELECT
                r.Id_Product,
                r.Sotrudnik,
                r.Sena_prodaji,
                r.Kolichestvo - ISNULL(v.Kolichestvo, 0) AS Kolichestvo
            FROM
                [Prodaji] AS r
            LEFT JOIN (
                SELECT
                    Id_Product,
                    SUM(Kolichestvo) AS Kolichestvo
                FROM
                    Vozvrat
                GROUP BY
                    Id_Product
            ) AS v
            ON
                r.Id_Product = v.Id_Product;";

                    // Открытие подключения
                    connection.Open();

                    // Выполнение запроса
                    command.ExecuteNonQuery();

                    // Закрытие подключения
                    connection.Close();

                    // Вывод сообщения об успешном выполнении запроса
                    MessageBox.Show("Данные успешно добавлены в таблицу Real_prodaji.");
                }
            }
        }
    }
    }

