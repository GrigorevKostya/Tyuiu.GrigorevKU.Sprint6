using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.GrigorevKU.Sprint6.Task5.V23.Lib;
using System.IO;
namespace Tyuiu.GrigorevKU.Sprint6.Task5.V23
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\Users\dmitr\source\repos\Tyuiu.GrigorevKU.Sprint6\Tyuiu.GrigorevKU.Sprint6.Task5.V23\bin\Debug\InPutFileTask5V23.txt";
        private void buttonDone_GKU_Click(object sender, EventArgs e)
        {
            dataGridViewOutPut_GKU.ColumnCount = 2;
            dataGridViewOutPut_GKU.Columns[0].Width = 40;
            dataGridViewOutPut_GKU.Columns[1].Width = 60;

            this.chartGraph_GKU.ChartAreas[0].AxisX.Title = "Ось Х";
            this.chartGraph_GKU.ChartAreas[0].AxisY.Title = "Ось Y";
            this.chartGraph_GKU.Series[0].Points.Clear();

            double[] nums = new double[ds.len];
            nums = ds.LoadFromDataFile(path);
            for(int i =0; i < nums.Length; i++)
            {
                dataGridViewOutPut_GKU.Rows.Add(Convert.ToString(i), Convert.ToString(nums[i]));
                chartGraph_GKU.Series[0].Points.AddXY(i, nums[i]);
            }
        }

        private void buttonSaveFile_GKU_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"C:\Users\dmitr\source\repos\Tyuiu.GrigorevKU.Sprint6\Tyuiu.GrigorevKU.Sprint6.Task5.V23\bin\Debug\InPutFileTask5V23.txt";

                System.Diagnostics.Process txt = new System.Diagnostics.Process();
                txt.StartInfo.FileName = "notepad.exe";
                txt.StartInfo.Arguments = path;
                txt.Start();
            }
            catch
            {
                MessageBox.Show("Сбой при открытии файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_GKU_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ИИПб-23-2 Григорьев Константин Юрьевич", "Сообщение");
        }
    }
}
