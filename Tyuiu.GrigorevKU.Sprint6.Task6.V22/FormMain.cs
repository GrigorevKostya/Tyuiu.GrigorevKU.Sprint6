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
using Tyuiu.GrigorevKU.Sprint6.Task6.V22.Lib;
namespace Tyuiu.GrigorevKU.Sprint6.Task6.V22
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string openFilePath;
        private void buttonOpenFile_GKU_Click(object sender, EventArgs e)
        {
            openFileDialogTask_GKU.ShowDialog();
            openFilePath = openFileDialogTask_GKU.FileName;
            textBoxInPut_GKU.Text = File.ReadAllText(openFilePath);
            groupBoxOutPut_GKU.Text = groupBoxOutPut_GKU.Text + " " + openFileDialogTask_GKU.FileName;
            buttonDone_GKU.Enabled = true;
        }

        private void toolTipTask_GKU_Popup(object sender, PopupEventArgs e)
        {

        }

        private void buttonDone_GKU_Click(object sender, EventArgs e)
        {
            textBoxOutPut_GKU.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonHelp_GKU_Click(object sender, EventArgs e)
        {
            FormAbout_GKU formAbout = new FormAbout_GKU();
            formAbout.ShowDialog();
        }
    }
}
