using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.GrigorevKU.Sprint6.Task4.V15.Lib;
using Tyuiu.GrigorevKU.Sprint6.Task4.V15.Lib;

namespace Tyuiu.GrigorevKU.Sprint6.Task4.V15
{
    public partial class FormMain_GKU : Form
    {
        public FormMain_GKU()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
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

                textBoxOutPut_GKU.Text = "";

                this.chartResult_GKU.ChartAreas[0].AxisX.Title = "Ось Х";
                this.chartResult_GKU.ChartAreas[0].AxisY.Title = "Ось Y";

                chartResult_GKU.Series[0].Points.Clear();
                for(int i = 0; i <= len -1; i++)
                {
                    this.chartResult_GKU.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxOutPut_GKU.AppendText(valueArray[i] + Environment.NewLine);
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
            MessageBox.Show("Таск 4 выполнил студент группы ИИПб-23-2 Григорьев Константин Юрьевич", "Сообщение");
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

        private void chartResult_GKU_Click(object sender, EventArgs e)
        {

        }

        private void buttonSave_GKU_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4.txt";
                File.WriteAllText(path, textBoxOutPut_GKU.Text);

                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранен успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBoxOutPut_GKU_Enter(object sender, EventArgs e)
        {

        }
    }
}
