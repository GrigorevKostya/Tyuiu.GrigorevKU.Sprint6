
namespace Tyuiu.GrigorevKU.Sprint6.Task4.V15
{
    partial class FormMain_GKU
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.groupBoxTask_GKU = new System.Windows.Forms.GroupBox();
            this.textBoxTask_GKU = new System.Windows.Forms.TextBox();
            this.groupBoxInput_GKU = new System.Windows.Forms.GroupBox();
            this.labelStopStep_GKU = new System.Windows.Forms.Label();
            this.labelStartStep_GKU = new System.Windows.Forms.Label();
            this.textBoxStopStep_GKU = new System.Windows.Forms.TextBox();
            this.textBoxStartStep_GKU = new System.Windows.Forms.TextBox();
            this.groupBoxOutPut_GKU = new System.Windows.Forms.GroupBox();
            this.textBoxOutPut_GKU = new System.Windows.Forms.TextBox();
            this.chartResult_GKU = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonDone_GKU = new System.Windows.Forms.Button();
            this.buttonSave_GKU = new System.Windows.Forms.Button();
            this.buttonInfo_GKU = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.groupBoxTask_GKU.SuspendLayout();
            this.groupBoxInput_GKU.SuspendLayout();
            this.groupBoxOutPut_GKU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_GKU)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_GKU
            // 
            this.groupBoxTask_GKU.Controls.Add(this.textBoxTask_GKU);
            this.groupBoxTask_GKU.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTask_GKU.Name = "groupBoxTask_GKU";
            this.groupBoxTask_GKU.Size = new System.Drawing.Size(531, 82);
            this.groupBoxTask_GKU.TabIndex = 0;
            this.groupBoxTask_GKU.TabStop = false;
            this.groupBoxTask_GKU.Text = "Условие";
            // 
            // textBoxTask_GKU
            // 
            this.textBoxTask_GKU.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTask_GKU.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_GKU.Location = new System.Drawing.Point(8, 18);
            this.textBoxTask_GKU.Multiline = true;
            this.textBoxTask_GKU.Name = "textBoxTask_GKU";
            this.textBoxTask_GKU.Size = new System.Drawing.Size(517, 57);
            this.textBoxTask_GKU.TabIndex = 0;
            this.textBoxTask_GKU.TabStop = false;
            this.textBoxTask_GKU.Text = "Протабулировать функцию на заданном промежутке от -5 до 5.\r\nРезультат вывести в t" +
    "extBox, построить график функции и сохранить в файл OutPutFileTask.txt по нажати" +
    "ю кнопки.";
            // 
            // groupBoxInput_GKU
            // 
            this.groupBoxInput_GKU.Controls.Add(this.labelStopStep_GKU);
            this.groupBoxInput_GKU.Controls.Add(this.labelStartStep_GKU);
            this.groupBoxInput_GKU.Controls.Add(this.textBoxStopStep_GKU);
            this.groupBoxInput_GKU.Controls.Add(this.textBoxStartStep_GKU);
            this.groupBoxInput_GKU.Location = new System.Drawing.Point(537, 0);
            this.groupBoxInput_GKU.Name = "groupBoxInput_GKU";
            this.groupBoxInput_GKU.Size = new System.Drawing.Size(348, 82);
            this.groupBoxInput_GKU.TabIndex = 1;
            this.groupBoxInput_GKU.TabStop = false;
            this.groupBoxInput_GKU.Text = "Ввод данных";
            // 
            // labelStopStep_GKU
            // 
            this.labelStopStep_GKU.AutoSize = true;
            this.labelStopStep_GKU.Location = new System.Drawing.Point(174, 26);
            this.labelStopStep_GKU.Name = "labelStopStep_GKU";
            this.labelStopStep_GKU.Size = new System.Drawing.Size(89, 17);
            this.labelStopStep_GKU.TabIndex = 3;
            this.labelStopStep_GKU.Text = "Конец шага:";
            // 
            // labelStartStep_GKU
            // 
            this.labelStartStep_GKU.AutoSize = true;
            this.labelStartStep_GKU.Location = new System.Drawing.Point(6, 26);
            this.labelStartStep_GKU.Name = "labelStartStep_GKU";
            this.labelStartStep_GKU.Size = new System.Drawing.Size(87, 17);
            this.labelStartStep_GKU.TabIndex = 2;
            this.labelStartStep_GKU.Text = "Старт шага:";
            // 
            // textBoxStopStep_GKU
            // 
            this.textBoxStopStep_GKU.Location = new System.Drawing.Point(177, 46);
            this.textBoxStopStep_GKU.Name = "textBoxStopStep_GKU";
            this.textBoxStopStep_GKU.Size = new System.Drawing.Size(165, 22);
            this.textBoxStopStep_GKU.TabIndex = 1;
            this.textBoxStopStep_GKU.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStopStep_GKU_KeyPress);
            // 
            // textBoxStartStep_GKU
            // 
            this.textBoxStartStep_GKU.Location = new System.Drawing.Point(6, 46);
            this.textBoxStartStep_GKU.Name = "textBoxStartStep_GKU";
            this.textBoxStartStep_GKU.Size = new System.Drawing.Size(165, 22);
            this.textBoxStartStep_GKU.TabIndex = 0;
            this.textBoxStartStep_GKU.TextChanged += new System.EventHandler(this.textBoxStartStep_GKU_TextChanged);
            this.textBoxStartStep_GKU.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStartStep_GKU_KeyPress);
            // 
            // groupBoxOutPut_GKU
            // 
            this.groupBoxOutPut_GKU.Controls.Add(this.textBoxOutPut_GKU);
            this.groupBoxOutPut_GKU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPut_GKU.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutPut_GKU.Name = "groupBoxOutPut_GKU";
            this.groupBoxOutPut_GKU.Size = new System.Drawing.Size(387, 514);
            this.groupBoxOutPut_GKU.TabIndex = 2;
            this.groupBoxOutPut_GKU.TabStop = false;
            this.groupBoxOutPut_GKU.Text = "Вывод:";
            this.groupBoxOutPut_GKU.Enter += new System.EventHandler(this.groupBoxOutPut_GKU_Enter);
            // 
            // textBoxOutPut_GKU
            // 
            this.textBoxOutPut_GKU.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxOutPut_GKU.Location = new System.Drawing.Point(3, 18);
            this.textBoxOutPut_GKU.Multiline = true;
            this.textBoxOutPut_GKU.Name = "textBoxOutPut_GKU";
            this.textBoxOutPut_GKU.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutPut_GKU.Size = new System.Drawing.Size(382, 493);
            this.textBoxOutPut_GKU.TabIndex = 0;
            // 
            // chartResult_GKU
            // 
            chartArea1.Name = "ChartArea1";
            this.chartResult_GKU.ChartAreas.Add(chartArea1);
            this.chartResult_GKU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartResult_GKU.Location = new System.Drawing.Point(0, 0);
            this.chartResult_GKU.Name = "chartResult_GKU";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Name = "Series1";
            this.chartResult_GKU.Series.Add(series1);
            this.chartResult_GKU.Size = new System.Drawing.Size(855, 514);
            this.chartResult_GKU.TabIndex = 3;
            this.chartResult_GKU.Text = "chart1";
            title1.Name = "Title_GKU";
            title1.Text = "График Функции";
            this.chartResult_GKU.Titles.Add(title1);
            this.chartResult_GKU.Click += new System.EventHandler(this.chartResult_GKU_Click);
            // 
            // buttonDone_GKU
            // 
            this.buttonDone_GKU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDone_GKU.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonDone_GKU.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDone_GKU.Location = new System.Drawing.Point(898, 9);
            this.buttonDone_GKU.Name = "buttonDone_GKU";
            this.buttonDone_GKU.Size = new System.Drawing.Size(109, 73);
            this.buttonDone_GKU.TabIndex = 4;
            this.buttonDone_GKU.Text = "Выполнить";
            this.buttonDone_GKU.UseVisualStyleBackColor = false;
            this.buttonDone_GKU.Click += new System.EventHandler(this.buttonDone_GKU_Click);
            // 
            // buttonSave_GKU
            // 
            this.buttonSave_GKU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave_GKU.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonSave_GKU.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave_GKU.Location = new System.Drawing.Point(1013, 10);
            this.buttonSave_GKU.Name = "buttonSave_GKU";
            this.buttonSave_GKU.Size = new System.Drawing.Size(103, 73);
            this.buttonSave_GKU.TabIndex = 5;
            this.buttonSave_GKU.Text = "Сохранить";
            this.buttonSave_GKU.UseVisualStyleBackColor = false;
            this.buttonSave_GKU.Click += new System.EventHandler(this.buttonSave_GKU_Click);
            // 
            // buttonInfo_GKU
            // 
            this.buttonInfo_GKU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo_GKU.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonInfo_GKU.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInfo_GKU.Location = new System.Drawing.Point(1122, 10);
            this.buttonInfo_GKU.Name = "buttonInfo_GKU";
            this.buttonInfo_GKU.Size = new System.Drawing.Size(108, 71);
            this.buttonInfo_GKU.TabIndex = 6;
            this.buttonInfo_GKU.Text = "Справка";
            this.buttonInfo_GKU.UseVisualStyleBackColor = false;
            this.buttonInfo_GKU.Click += new System.EventHandler(this.buttonInfo_GKU_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBoxOutPut_GKU);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 514);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBoxTask_GKU);
            this.panel2.Controls.Add(this.groupBoxInput_GKU);
            this.panel2.Controls.Add(this.buttonInfo_GKU);
            this.panel2.Controls.Add(this.buttonDone_GKU);
            this.panel2.Controls.Add(this.buttonSave_GKU);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1242, 100);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.chartResult_GKU);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(387, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(855, 514);
            this.panel3.TabIndex = 9;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(387, 100);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(10, 514);
            this.splitter1.TabIndex = 10;
            this.splitter1.TabStop = false;
            // 
            // FormMain_GKU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 614);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "FormMain_GKU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 |  Вариант 15 | Григорьев К.Ю.";
            this.groupBoxTask_GKU.ResumeLayout(false);
            this.groupBoxTask_GKU.PerformLayout();
            this.groupBoxInput_GKU.ResumeLayout(false);
            this.groupBoxInput_GKU.PerformLayout();
            this.groupBoxOutPut_GKU.ResumeLayout(false);
            this.groupBoxOutPut_GKU.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_GKU)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_GKU;
        private System.Windows.Forms.GroupBox groupBoxInput_GKU;
        private System.Windows.Forms.GroupBox groupBoxOutPut_GKU;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_GKU;
        private System.Windows.Forms.Button buttonDone_GKU;
        private System.Windows.Forms.Button buttonSave_GKU;
        private System.Windows.Forms.Button buttonInfo_GKU;
        private System.Windows.Forms.TextBox textBoxTask_GKU;
        private System.Windows.Forms.Label labelStopStep_GKU;
        private System.Windows.Forms.Label labelStartStep_GKU;
        private System.Windows.Forms.TextBox textBoxStopStep_GKU;
        private System.Windows.Forms.TextBox textBoxStartStep_GKU;
        private System.Windows.Forms.TextBox textBoxOutPut_GKU;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Splitter splitter1;
    }
}

