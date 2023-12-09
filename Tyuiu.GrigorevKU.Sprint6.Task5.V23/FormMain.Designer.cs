
namespace Tyuiu.GrigorevKU.Sprint6.Task5.V23
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelTask_GKU = new System.Windows.Forms.Panel();
            this.buttonInfo_GKU = new System.Windows.Forms.Button();
            this.buttonOpenFile_GKU = new System.Windows.Forms.Button();
            this.buttonDone_GKU = new System.Windows.Forms.Button();
            this.groupBoxTask_GKU = new System.Windows.Forms.GroupBox();
            this.textBoxTask_GKU = new System.Windows.Forms.TextBox();
            this.panelOutPut_GKU = new System.Windows.Forms.Panel();
            this.groupBoxOutPut_GKU = new System.Windows.Forms.GroupBox();
            this.dataGridViewOutPut_GKU = new System.Windows.Forms.DataGridView();
            this.splitterOutPut_GKU = new System.Windows.Forms.Splitter();
            this.panelGraph_GKU = new System.Windows.Forms.Panel();
            this.chartGraph_GKU = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelTask_GKU.SuspendLayout();
            this.groupBoxTask_GKU.SuspendLayout();
            this.panelOutPut_GKU.SuspendLayout();
            this.groupBoxOutPut_GKU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut_GKU)).BeginInit();
            this.panelGraph_GKU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraph_GKU)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTask_GKU
            // 
            this.panelTask_GKU.Controls.Add(this.buttonInfo_GKU);
            this.panelTask_GKU.Controls.Add(this.buttonOpenFile_GKU);
            this.panelTask_GKU.Controls.Add(this.buttonDone_GKU);
            this.panelTask_GKU.Controls.Add(this.groupBoxTask_GKU);
            this.panelTask_GKU.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTask_GKU.Location = new System.Drawing.Point(0, 0);
            this.panelTask_GKU.Name = "panelTask_GKU";
            this.panelTask_GKU.Size = new System.Drawing.Size(1096, 109);
            this.panelTask_GKU.TabIndex = 0;
            // 
            // buttonInfo_GKU
            // 
            this.buttonInfo_GKU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo_GKU.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonInfo_GKU.Location = new System.Drawing.Point(914, 18);
            this.buttonInfo_GKU.Name = "buttonInfo_GKU";
            this.buttonInfo_GKU.Size = new System.Drawing.Size(156, 74);
            this.buttonInfo_GKU.TabIndex = 1;
            this.buttonInfo_GKU.Text = "Справка";
            this.buttonInfo_GKU.UseVisualStyleBackColor = false;
            this.buttonInfo_GKU.Click += new System.EventHandler(this.buttonInfo_GKU_Click);
            // 
            // buttonOpenFile_GKU
            // 
            this.buttonOpenFile_GKU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenFile_GKU.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonOpenFile_GKU.Location = new System.Drawing.Point(752, 18);
            this.buttonOpenFile_GKU.Name = "buttonOpenFile_GKU";
            this.buttonOpenFile_GKU.Size = new System.Drawing.Size(156, 74);
            this.buttonOpenFile_GKU.TabIndex = 1;
            this.buttonOpenFile_GKU.Text = "Открыть файл";
            this.buttonOpenFile_GKU.UseVisualStyleBackColor = false;
            this.buttonOpenFile_GKU.Click += new System.EventHandler(this.buttonSaveFile_GKU_Click);
            // 
            // buttonDone_GKU
            // 
            this.buttonDone_GKU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDone_GKU.BackColor = System.Drawing.Color.Green;
            this.buttonDone_GKU.Location = new System.Drawing.Point(590, 18);
            this.buttonDone_GKU.Name = "buttonDone_GKU";
            this.buttonDone_GKU.Size = new System.Drawing.Size(156, 74);
            this.buttonDone_GKU.TabIndex = 1;
            this.buttonDone_GKU.Text = "Выполнить";
            this.buttonDone_GKU.UseVisualStyleBackColor = false;
            this.buttonDone_GKU.Click += new System.EventHandler(this.buttonDone_GKU_Click);
            // 
            // groupBoxTask_GKU
            // 
            this.groupBoxTask_GKU.Controls.Add(this.textBoxTask_GKU);
            this.groupBoxTask_GKU.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxTask_GKU.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTask_GKU.Name = "groupBoxTask_GKU";
            this.groupBoxTask_GKU.Size = new System.Drawing.Size(583, 109);
            this.groupBoxTask_GKU.TabIndex = 0;
            this.groupBoxTask_GKU.TabStop = false;
            this.groupBoxTask_GKU.Text = "Условие";
            // 
            // textBoxTask_GKU
            // 
            this.textBoxTask_GKU.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTask_GKU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTask_GKU.Location = new System.Drawing.Point(3, 18);
            this.textBoxTask_GKU.Multiline = true;
            this.textBoxTask_GKU.Name = "textBoxTask_GKU";
            this.textBoxTask_GKU.Size = new System.Drawing.Size(577, 88);
            this.textBoxTask_GKU.TabIndex = 0;
            this.textBoxTask_GKU.TabStop = false;
            this.textBoxTask_GKU.Text = "Прочитать данные из файла InPutFileTask5V23.txt. Вывести в dataGridView\r\nотрицате" +
    "льные значения и построить диаграмму по этим значениям.";
            // 
            // panelOutPut_GKU
            // 
            this.panelOutPut_GKU.Controls.Add(this.groupBoxOutPut_GKU);
            this.panelOutPut_GKU.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOutPut_GKU.Location = new System.Drawing.Point(0, 109);
            this.panelOutPut_GKU.Name = "panelOutPut_GKU";
            this.panelOutPut_GKU.Size = new System.Drawing.Size(347, 398);
            this.panelOutPut_GKU.TabIndex = 1;
            // 
            // groupBoxOutPut_GKU
            // 
            this.groupBoxOutPut_GKU.Controls.Add(this.dataGridViewOutPut_GKU);
            this.groupBoxOutPut_GKU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPut_GKU.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutPut_GKU.Name = "groupBoxOutPut_GKU";
            this.groupBoxOutPut_GKU.Size = new System.Drawing.Size(347, 398);
            this.groupBoxOutPut_GKU.TabIndex = 0;
            this.groupBoxOutPut_GKU.TabStop = false;
            this.groupBoxOutPut_GKU.Text = "Вывод данных:";
            // 
            // dataGridViewOutPut_GKU
            // 
            this.dataGridViewOutPut_GKU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutPut_GKU.ColumnHeadersVisible = false;
            this.dataGridViewOutPut_GKU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOutPut_GKU.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewOutPut_GKU.Name = "dataGridViewOutPut_GKU";
            this.dataGridViewOutPut_GKU.RowHeadersVisible = false;
            this.dataGridViewOutPut_GKU.RowHeadersWidth = 51;
            this.dataGridViewOutPut_GKU.RowTemplate.Height = 24;
            this.dataGridViewOutPut_GKU.Size = new System.Drawing.Size(341, 377);
            this.dataGridViewOutPut_GKU.TabIndex = 0;
            // 
            // splitterOutPut_GKU
            // 
            this.splitterOutPut_GKU.Location = new System.Drawing.Point(347, 109);
            this.splitterOutPut_GKU.Name = "splitterOutPut_GKU";
            this.splitterOutPut_GKU.Size = new System.Drawing.Size(8, 398);
            this.splitterOutPut_GKU.TabIndex = 2;
            this.splitterOutPut_GKU.TabStop = false;
            // 
            // panelGraph_GKU
            // 
            this.panelGraph_GKU.Controls.Add(this.chartGraph_GKU);
            this.panelGraph_GKU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGraph_GKU.Location = new System.Drawing.Point(355, 109);
            this.panelGraph_GKU.Name = "panelGraph_GKU";
            this.panelGraph_GKU.Size = new System.Drawing.Size(741, 398);
            this.panelGraph_GKU.TabIndex = 3;
            // 
            // chartGraph_GKU
            // 
            chartArea1.Name = "ChartArea1";
            this.chartGraph_GKU.ChartAreas.Add(chartArea1);
            this.chartGraph_GKU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartGraph_GKU.Location = new System.Drawing.Point(0, 0);
            this.chartGraph_GKU.Name = "chartGraph_GKU";
            this.chartGraph_GKU.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.chartGraph_GKU.Series.Add(series1);
            this.chartGraph_GKU.Size = new System.Drawing.Size(741, 398);
            this.chartGraph_GKU.TabIndex = 0;
            this.chartGraph_GKU.Text = "chart1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 507);
            this.Controls.Add(this.panelGraph_GKU);
            this.Controls.Add(this.splitterOutPut_GKU);
            this.Controls.Add(this.panelOutPut_GKU);
            this.Controls.Add(this.panelTask_GKU);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 |  Вариант 23 | Григорьев К.Ю.";
            this.panelTask_GKU.ResumeLayout(false);
            this.groupBoxTask_GKU.ResumeLayout(false);
            this.groupBoxTask_GKU.PerformLayout();
            this.panelOutPut_GKU.ResumeLayout(false);
            this.groupBoxOutPut_GKU.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut_GKU)).EndInit();
            this.panelGraph_GKU.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartGraph_GKU)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTask_GKU;
        private System.Windows.Forms.Panel panelOutPut_GKU;
        private System.Windows.Forms.GroupBox groupBoxOutPut_GKU;
        private System.Windows.Forms.DataGridView dataGridViewOutPut_GKU;
        private System.Windows.Forms.Splitter splitterOutPut_GKU;
        private System.Windows.Forms.Panel panelGraph_GKU;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGraph_GKU;
        private System.Windows.Forms.Button buttonInfo_GKU;
        private System.Windows.Forms.Button buttonOpenFile_GKU;
        private System.Windows.Forms.Button buttonDone_GKU;
        private System.Windows.Forms.GroupBox groupBoxTask_GKU;
        private System.Windows.Forms.TextBox textBoxTask_GKU;
    }
}

