using SLIPPRSApp.DatasetTableAdapters;
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
    public partial class Tovar : Form
    {
        public Tovar()
        {
            InitializeComponent();
        }

        private void tovarsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tovarsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataset);

        }

        private void Tovar_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "slippers11DataSet.Tovars". При необходимости она может быть перемещена или удалена.
            this.tovarsTableAdapter1.Fill(this.slippers11DataSet.Tovars);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataset.Tovars". При необходимости она может быть перемещена или удалена.
            this.tovarsTableAdapter.Fill(this.dataset.Tovars);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            tovarsBindingSource1.Filter = "PRODUCT_NAME='" + comboBox1.Text + "'";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            tovarsBindingSource1.Filter = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tovarsTableAdapter1.Update(slippers11DataSet);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form ifrm = new Mesto_xraneniya();
            ifrm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form ifrm = new Model_Tovara();
            ifrm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

