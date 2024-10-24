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
    public partial class Mesto_xraneniya : Form
    {
        public Mesto_xraneniya()
        {
            InitializeComponent();
        }

        private void mesto_xraneniyaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mesto_xraneniyaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataset);

        }

        private void Mesto_xraneniya_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "slippers11DataSet.Mesto_xraneniya". При необходимости она может быть перемещена или удалена.
            this.mesto_xraneniyaTableAdapter1.Fill(this.slippers11DataSet.Mesto_xraneniya);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataset.Mesto_xraneniya". При необходимости она может быть перемещена или удалена.
            this.mesto_xraneniyaTableAdapter.Fill(this.dataset.Mesto_xraneniya);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mesto_xraneniyaTableAdapter1.Update(slippers11DataSet);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mesto_xraneniyaBindingSource1.Filter = "Id_Product='" + comboBox1.Text + "'";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mesto_xraneniyaBindingSource1.Filter = "";
        }
    }
}
