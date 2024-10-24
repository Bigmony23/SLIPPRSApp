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
    public partial class Vozvrat : Form
    {
        public Vozvrat()
        {
            InitializeComponent();
        }

        private void vozvratBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vozvratBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.slippers11DataSet);

        }

        private void Vozvrat_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "slippers11DataSet.Vozvrat". При необходимости она может быть перемещена или удалена.
            this.vozvratTableAdapter.Fill(this.slippers11DataSet.Vozvrat);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            vozvratTableAdapter.Update(this.slippers11DataSet);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form ifrm = new Otchet_vozvrat();
            ifrm.FormBorderStyle = FormBorderStyle.FixedDialog; // Устанавливаем форму в режим диалогового окна
            ifrm.Show();
        }
    }
}
