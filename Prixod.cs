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
    public partial class Prixod : Form
    {
        public Prixod()
        {
            InitializeComponent();
        }

        private void prixodBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.prixodBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataset);

        }

        private void Prixod_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "slippers11DataSet.Prixod". При необходимости она может быть перемещена или удалена.
            this.prixodTableAdapter1.Fill(this.slippers11DataSet.Prixod);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataset.Prixod". При необходимости она может быть перемещена или удалена.
            this.prixodTableAdapter.Fill(this.dataset.Prixod);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            prixodBindingSource1.Filter = "Data_Prixoda='" + comboBox1.Text + "'";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            prixodBindingSource1.Filter = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            prixodTableAdapter1.Update(slippers11DataSet);
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
