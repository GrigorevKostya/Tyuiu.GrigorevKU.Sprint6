using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.GrigorevKU.Sprint6.Task1.V18.Lib;
namespace Tyuiu.GrigorevKU.Sprint6.Task1.V18
{
    public partial class FormMain_GKU : Form
    {
        public FormMain_GKU()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_GKU.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_GKU.Text);

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxResult_GKU.Text = "";
                textBoxResult_GKU.AppendText("+-----------+-----------+" + Environment.NewLine);
                textBoxResult_GKU.AppendText("|     X     |    f(x)   |" + Environment.NewLine);
                textBoxResult_GKU.AppendText("+-----------+-----------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,6:d}     |   {1, 6:f2}  |", startStep, valueArray[i]);
                    textBoxResult_GKU.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }
                textBoxResult_GKU.AppendText("+-----------+-----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void labelTask_GKU_Click(object sender, EventArgs e)
        {

        }

        private void labelResult_GKU_Click(object sender, EventArgs e)
        {

        }

        private void buttonInfo_GKU_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ИИПб-23-2 Григорьев Константин Юрьевич", "Сообщение", MessageBoxButtons.OK);
        }

        private void textBoxStartStep_GKU_TextChanged(object sender, EventArgs e)
        {
        
        }
    }
}
