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
using Tyuiu.GrigorevKU.Sprint6.Task7.V15.Lib;
namespace Tyuiu.GrigorevKU.Sprint6.Task7.V15
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            openFileDialogTask_GKU.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_GKU.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        static int rows;
        static int columns;
        static string openFilePath;

        DataService ds = new DataService();

        public static int[,] LoadFromFileData(string filePath)
        {
            string FileData = File.ReadAllText(filePath);

            FileData = FileData.Replace('\n', '\r');
            string[] lines = FileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for(int r =0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for(int c =0; c< columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }
        private void buttonOpenFile_GKU_Click(object sender, EventArgs e)
        {
            openFileDialogTask_GKU.ShowDialog();
            openFilePath = openFileDialogTask_GKU.FileName;

            int[,] arrayValues = new int[rows, columns];

            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewInput_GKU.ColumnCount = columns;
            dataGridViewInput_GKU.RowCount = rows;
            dataGridViewOutPut_GKU.ColumnCount = columns;
            dataGridViewOutPut_GKU.RowCount = rows;

            for(int i =0; i < columns; i++)
            {
                dataGridViewInput_GKU.Columns[i].Width = 50;
                dataGridViewOutPut_GKU.Columns[i].Width = 50;
            }

            for(int r =0; r< rows; r++)
            {
                for(int c =0; c< columns; c++)
                {
                    dataGridViewInput_GKU.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = ds.GetMatrix(openFilePath);
            buttonDone_GKU.Enabled = true;
        }

        private void buttonSaveFile_GKU_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_GKU.FileName = "OutPutFileTask7v15.csv";
            saveFileDialogMatrix_GKU.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_GKU.ShowDialog();

            string path = saveFileDialogMatrix_GKU.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool FileExists = fileInfo.Exists;

            if (FileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutPut_GKU.RowCount;
            int columns = dataGridViewOutPut_GKU.ColumnCount;

            string str = "";

            for(int i =0; i< rows; i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOutPut_GKU.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOutPut_GKU.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonOpenFile_GKU_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_GKU.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_GKU_Click(object sender, EventArgs e)
        {
            int[,] arrayValues1 = new int[rows, columns];
            arrayValues1 = ds.GetMatrix(openFilePath);

            for(int r =0; r < rows; r++)
            {
                for(int c =0; c < columns; c++)
                {
                    dataGridViewOutPut_GKU.Rows[r].Cells[c].Value = arrayValues1[r, c];
                }
            }
            buttonSaveFile_GKU.Enabled = true;
        }

        private void buttonDone_GKU_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_GKU.ToolTipTitle = "Выполнить";
        }

        private void buttonDone_GKU_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void buttonSaveFile_GKU_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_GKU.ToolTipTitle = "Сохранить в файл";
        }

        private void buttonHelp_GKU_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_GKU.ToolTipTitle = "Справка";
        }

        private void buttonHelp_GKU_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
