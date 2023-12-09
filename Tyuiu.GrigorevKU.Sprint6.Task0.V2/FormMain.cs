using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.GrigorevKU.Sprint6.Task0.V2.Lib;

namespace Tyuiu.GrigorevKU.Sprint6.Task0.V2
{
    public partial class FormMain_GKU : Form
    {
        public FormMain_GKU()
        {
            InitializeComponent();
        }

        private void buttonExecute_GKU_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_GKU.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarX_GKU.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxVarX_GKU_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }

        }

        private void labelProblem_GKU_Click(object sender, EventArgs e)
        {

        }

        private void buttonHelp_GKU_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы ИИПб-23-2 Григорьев Константин Юрьевич", "Сообщение");
        }

        private void textBoxResult_GKU_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
