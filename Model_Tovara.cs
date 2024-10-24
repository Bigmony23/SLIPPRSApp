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
    public partial class Model_Tovara : Form
    {
        public Model_Tovara()
        {
            InitializeComponent();
        }

        private void model_tovaraBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.model_tovaraBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataset);

        }

        private void Model_Tovara_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "slippers11DataSet.Vid_tovara". При необходимости она может быть перемещена или удалена.
            this.vid_tovaraTableAdapter.Fill(this.slippers11DataSet.Vid_tovara);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataset.Model_tovara". При необходимости она может быть перемещена или удалена.
            this.model_tovaraTableAdapter.Fill(this.dataset.Model_tovara);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            vid_tovaraBindingSource.Filter = "Id_Product='" + comboBox1.Text + "'";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            vid_tovaraBindingSource.Filter = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vid_tovaraTableAdapter.Update(slippers11DataSet);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
