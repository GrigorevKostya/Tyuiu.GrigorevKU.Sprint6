using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.GrigorevKU.Sprint6.Task3.V2.Lib;
namespace Tyuiu.GrigorevKU.Sprint6.Task3.V2
{
    public partial class FormMain_GKU : Form
    {
        public FormMain_GKU()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        int[,] mtrx = new int[5, 5] { { -12, -4, -20, 5, -5 },
                                        { 2, 15, 1, -20, 7 },
                                        { 15, -15, 2, 11, 5 },
                                        { -19, -9, 16, 0, 1 }, 
                                        { 17, 16, 5, 12, -8 } };
        private void buttonDone_GKU_Click(object sender, EventArgs e)
        {
            int[,] res = ds.Calculate(mtrx);
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            dataGridViewOutput_GKU.RowCount = rows;
            dataGridViewOutput_GKU.ColumnCount = columns;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewOutput_GKU.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewOutput_GKU.Rows[i].Cells[j].Value = Convert.ToString(res[i, j]);
                }
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            dataGridViewTask_GKU.RowCount = rows;
            dataGridViewTask_GKU.ColumnCount = columns;

            for(int i =0; i < columns; i++)
            {
                dataGridViewTask_GKU.Columns[i].Width = 25;
            }

            for(int i =0; i < rows; i++)
            {
                for(int j =0; j < columns; j++)
                {
                    dataGridViewTask_GKU.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }

        private void buttonInfo_GKU_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ИИПб-23-2 Григорьев Константин Юрьевич", "Сообщение");
        }
    }
}
