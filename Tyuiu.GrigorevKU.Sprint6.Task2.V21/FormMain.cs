using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.GrigorevKU.Sprint6.Task2.V21.Lib;
namespace Tyuiu.GrigorevKU.Sprint6.Task2.V21
{
    public partial class FormMain_GKU : Form
    {
        public FormMain_GKU()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void labelStopStep_GKU_Click(object sender, EventArgs e)
        {

        }

        private void buttonDone_GKU_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_GKU.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_GKU.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction_GKU.ChartAreas[0].AxisX.Title = "Ось Х";
                this.chartFunction_GKU.ChartAreas[0].AxisY.Title = "Ось Y";
                chartFunction_GKU.Series[0].Points.Clear();
                for (int i = 0; i <= len -1; i++)
                {
                    this.dataGridViewFunction_GKU.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));

                    this.chartFunction_GKU.Series[0].Points.AddXY(startStep, valueArray[i]);

                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_GKU_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ИИПб-23-2 Григорьев Константин Юрьевич", "Сообщение");
        }

        private void buttonDone_GKU_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_GKU.BackColor = Color.Red;
        }

        private void buttonDone_GKU_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_GKU.BackColor = Color.Green;
        }

        private void buttonDone_GKU_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_GKU.BackColor = Color.Blue;
        }

        private void textBoxStartStep_GKU_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxStartStep_GKU_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void textBoxStopStep_GKU_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }
    }
}
