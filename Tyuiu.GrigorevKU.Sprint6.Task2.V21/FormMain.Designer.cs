
namespace Tyuiu.GrigorevKU.Sprint6.Task2.V21
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxTask_GKU = new System.Windows.Forms.GroupBox();
            this.textBoxTask_GKU = new System.Windows.Forms.TextBox();
            this.groupBoxInput_GKU = new System.Windows.Forms.GroupBox();
            this.labelStopStep_GKU = new System.Windows.Forms.Label();
            this.labelStartStep_GKU = new System.Windows.Forms.Label();
            this.textBoxStopStep_GKU = new System.Windows.Forms.TextBox();
            this.textBoxStartStep_GKU = new System.Windows.Forms.TextBox();
            this.groupBoxResult_GKU = new System.Windows.Forms.GroupBox();
            this.chartFunction_GKU = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelResult_GKU = new System.Windows.Forms.Label();
            this.dataGridViewFunction_GKU = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDone_GKU = new System.Windows.Forms.Button();
            this.buttonInfo_GKU = new System.Windows.Forms.Button();
            this.groupBoxTask_GKU.SuspendLayout();
            this.groupBoxInput_GKU.SuspendLayout();
            this.groupBoxResult_GKU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_GKU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_GKU)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_GKU
            // 
            this.groupBoxTask_GKU.Controls.Add(this.textBoxTask_GKU);
            this.groupBoxTask_GKU.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_GKU.Name = "groupBoxTask_GKU";
            this.groupBoxTask_GKU.Size = new System.Drawing.Size(564, 326);
            this.groupBoxTask_GKU.TabIndex = 0;
            this.groupBoxTask_GKU.TabStop = false;
            this.groupBoxTask_GKU.Text = "Условие";
            // 
            // textBoxTask_GKU
            // 
            this.textBoxTask_GKU.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTask_GKU.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_GKU.Location = new System.Drawing.Point(13, 19);
            this.textBoxTask_GKU.Multiline = true;
            this.textBoxTask_GKU.Name = "textBoxTask_GKU";
            this.textBoxTask_GKU.Size = new System.Drawing.Size(406, 306);
            this.textBoxTask_GKU.TabIndex = 0;
            this.textBoxTask_GKU.TabStop = false;
            this.textBoxTask_GKU.Text = "Протабулировать функцию на заданном диапазоне. Результат вывести в DataGridView и" +
    " построить график функции.";
            // 
            // groupBoxInput_GKU
            // 
            this.groupBoxInput_GKU.Controls.Add(this.labelStopStep_GKU);
            this.groupBoxInput_GKU.Controls.Add(this.labelStartStep_GKU);
            this.groupBoxInput_GKU.Controls.Add(this.textBoxStopStep_GKU);
            this.groupBoxInput_GKU.Controls.Add(this.textBoxStartStep_GKU);
            this.groupBoxInput_GKU.Location = new System.Drawing.Point(12, 344);
            this.groupBoxInput_GKU.Name = "groupBoxInput_GKU";
            this.groupBoxInput_GKU.Size = new System.Drawing.Size(329, 96);
            this.groupBoxInput_GKU.TabIndex = 1;
            this.groupBoxInput_GKU.TabStop = false;
            this.groupBoxInput_GKU.Text = "Ввод данных";
            // 
            // labelStopStep_GKU
            // 
            this.labelStopStep_GKU.AutoSize = true;
            this.labelStopStep_GKU.Location = new System.Drawing.Point(163, 33);
            this.labelStopStep_GKU.Name = "labelStopStep_GKU";
            this.labelStopStep_GKU.Size = new System.Drawing.Size(89, 17);
            this.labelStopStep_GKU.TabIndex = 3;
            this.labelStopStep_GKU.Text = "Конец шага:";
            this.labelStopStep_GKU.Click += new System.EventHandler(this.labelStopStep_GKU_Click);
            // 
            // labelStartStep_GKU
            // 
            this.labelStartStep_GKU.AutoSize = true;
            this.labelStartStep_GKU.Location = new System.Drawing.Point(11, 33);
            this.labelStartStep_GKU.Name = "labelStartStep_GKU";
            this.labelStartStep_GKU.Size = new System.Drawing.Size(87, 17);
            this.labelStartStep_GKU.TabIndex = 2;
            this.labelStartStep_GKU.Text = "Старт шага:";
            // 
            // textBoxStopStep_GKU
            // 
            this.textBoxStopStep_GKU.Location = new System.Drawing.Point(166, 53);
            this.textBoxStopStep_GKU.Name = "textBoxStopStep_GKU";
            this.textBoxStopStep_GKU.Size = new System.Drawing.Size(144, 22);
            this.textBoxStopStep_GKU.TabIndex = 1;
            this.textBoxStopStep_GKU.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStopStep_GKU_KeyPress);
            // 
            // textBoxStartStep_GKU
            // 
            this.textBoxStartStep_GKU.Location = new System.Drawing.Point(14, 53);
            this.textBoxStartStep_GKU.Name = "textBoxStartStep_GKU";
            this.textBoxStartStep_GKU.Size = new System.Drawing.Size(146, 22);
            this.textBoxStartStep_GKU.TabIndex = 0;
            this.textBoxStartStep_GKU.TextChanged += new System.EventHandler(this.textBoxStartStep_GKU_TextChanged);
            this.textBoxStartStep_GKU.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStartStep_GKU_KeyPress);
            // 
            // groupBoxResult_GKU
            // 
            this.groupBoxResult_GKU.Controls.Add(this.chartFunction_GKU);
            this.groupBoxResult_GKU.Controls.Add(this.labelResult_GKU);
            this.groupBoxResult_GKU.Controls.Add(this.dataGridViewFunction_GKU);
            this.groupBoxResult_GKU.Location = new System.Drawing.Point(582, 12);
            this.groupBoxResult_GKU.Name = "groupBoxResult_GKU";
            this.groupBoxResult_GKU.Size = new System.Drawing.Size(606, 428);
            this.groupBoxResult_GKU.TabIndex = 2;
            this.groupBoxResult_GKU.TabStop = false;
            this.groupBoxResult_GKU.Text = "Вывод данных";
            // 
            // chartFunction_GKU
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_GKU.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunction_GKU.Legends.Add(legend1);
            this.chartFunction_GKU.Location = new System.Drawing.Point(211, 37);
            this.chartFunction_GKU.Name = "chartFunction_GKU";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_GKU.Series.Add(series1);
            this.chartFunction_GKU.Size = new System.Drawing.Size(389, 370);
            this.chartFunction_GKU.TabIndex = 2;
            this.chartFunction_GKU.Text = "chart1";
            // 
            // labelResult_GKU
            // 
            this.labelResult_GKU.AutoSize = true;
            this.labelResult_GKU.Location = new System.Drawing.Point(10, 19);
            this.labelResult_GKU.Name = "labelResult_GKU";
            this.labelResult_GKU.Size = new System.Drawing.Size(80, 17);
            this.labelResult_GKU.TabIndex = 1;
            this.labelResult_GKU.Text = "Результат:";
            // 
            // dataGridViewFunction_GKU
            // 
            this.dataGridViewFunction_GKU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction_GKU.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
            this.dataGridViewFunction_GKU.Location = new System.Drawing.Point(13, 37);
            this.dataGridViewFunction_GKU.Name = "dataGridViewFunction_GKU";
            this.dataGridViewFunction_GKU.RowHeadersVisible = false;
            this.dataGridViewFunction_GKU.RowHeadersWidth = 51;
            this.dataGridViewFunction_GKU.RowTemplate.Height = 24;
            this.dataGridViewFunction_GKU.Size = new System.Drawing.Size(191, 370);
            this.dataGridViewFunction_GKU.TabIndex = 0;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.MinimumWidth = 6;
            this.X.Name = "X";
            this.X.Width = 50;
            // 
            // Y
            // 
            this.Y.HeaderText = "F(X)";
            this.Y.MinimumWidth = 6;
            this.Y.Name = "Y";
            this.Y.Width = 50;
            // 
            // buttonDone_GKU
            // 
            this.buttonDone_GKU.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonDone_GKU.Location = new System.Drawing.Point(455, 346);
            this.buttonDone_GKU.Name = "buttonDone_GKU";
            this.buttonDone_GKU.Size = new System.Drawing.Size(121, 95);
            this.buttonDone_GKU.TabIndex = 3;
            this.buttonDone_GKU.Text = "Выполнить";
            this.buttonDone_GKU.UseVisualStyleBackColor = false;
            this.buttonDone_GKU.Click += new System.EventHandler(this.buttonDone_GKU_Click);
            this.buttonDone_GKU.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_GKU_MouseDown);
            this.buttonDone_GKU.MouseEnter += new System.EventHandler(this.buttonDone_GKU_MouseEnter);
            this.buttonDone_GKU.MouseLeave += new System.EventHandler(this.buttonDone_GKU_MouseLeave);
            // 
            // buttonInfo_GKU
            // 
            this.buttonInfo_GKU.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonInfo_GKU.Location = new System.Drawing.Point(347, 346);
            this.buttonInfo_GKU.Name = "buttonInfo_GKU";
            this.buttonInfo_GKU.Size = new System.Drawing.Size(102, 94);
            this.buttonInfo_GKU.TabIndex = 4;
            this.buttonInfo_GKU.Text = "Справка";
            this.buttonInfo_GKU.UseVisualStyleBackColor = false;
            this.buttonInfo_GKU.Click += new System.EventHandler(this.buttonInfo_GKU_Click);
            // 
            // FormMain_GKU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 450);
            this.Controls.Add(this.buttonInfo_GKU);
            this.Controls.Add(this.buttonDone_GKU);
            this.Controls.Add(this.groupBoxResult_GKU);
            this.Controls.Add(this.groupBoxInput_GKU);
            this.Controls.Add(this.groupBoxTask_GKU);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain_GKU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 |  Вариант 21 | Григорьев К.Ю.";
            this.groupBoxTask_GKU.ResumeLayout(false);
            this.groupBoxTask_GKU.PerformLayout();
            this.groupBoxInput_GKU.ResumeLayout(false);
            this.groupBoxInput_GKU.PerformLayout();
            this.groupBoxResult_GKU.ResumeLayout(false);
            this.groupBoxResult_GKU.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_GKU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_GKU)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_GKU;
        private System.Windows.Forms.GroupBox groupBoxInput_GKU;
        private System.Windows.Forms.GroupBox groupBoxResult_GKU;
        private System.Windows.Forms.Button buttonDone_GKU;
        private System.Windows.Forms.Button buttonInfo_GKU;
        private System.Windows.Forms.Label labelStopStep_GKU;
        private System.Windows.Forms.Label labelStartStep_GKU;
        private System.Windows.Forms.TextBox textBoxStopStep_GKU;
        private System.Windows.Forms.TextBox textBoxStartStep_GKU;
        private System.Windows.Forms.TextBox textBoxTask_GKU;
        private System.Windows.Forms.DataGridView dataGridViewFunction_GKU;
        private System.Windows.Forms.Label labelResult_GKU;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_GKU;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
    }
}

