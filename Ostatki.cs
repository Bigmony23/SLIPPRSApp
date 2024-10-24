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
    public partial class Ostatki : Form
    {
        public Ostatki()
        {
            InitializeComponent();
        }

        private void ostatki_tovaraBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ostatki_tovaraBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataset);

        }

        private void Ostatki_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "slippers11DataSet.Ostatki". При необходимости она может быть перемещена или удалена.
            this.ostatkiTableAdapter.Fill(this.slippers11DataSet.Ostatki);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataset.Ostatki_tovara". При необходимости она может быть перемещена или удалена.
            this.ostatki_tovaraTableAdapter.Fill(this.dataset.Ostatki_tovara);

        }

        private void button3_Click(object sender, EventArgs e)
        {
         ostatkiBindingSource.Filter = "Datanum='" + comboBox1.Text + "'";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ostatkiBindingSource.Filter = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ostatkiTableAdapter.Update(this.slippers11DataSet);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
