using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLIPPRSApp
{
    public partial class Prodaji : Form
    {
        public Prodaji()
        {
            InitializeComponent();
        }

        private void prodaji1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.prodaji1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataset);

        }

        private void Prodaji_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "slippers11DataSet.Prodaji". При необходимости она может быть перемещена или удалена.
            this.prodajiTableAdapter.Fill(this.slippers11DataSet.Prodaji);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataset.Prodaji1". При необходимости она может быть перемещена или удалена.
            this.prodaji1TableAdapter.Fill(this.dataset.Prodaji1);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            prodajiBindingSource.Filter = "Data_Prixoda='" + comboBox1.Text + "'";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            prodajiBindingSource.Filter = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            prodajiTableAdapter.Update(slippers11DataSet);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
