
namespace Tyuiu.GrigorevKU.Sprint6.Task3.V2
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
            this.groupBoxTask_GKU = new System.Windows.Forms.GroupBox();
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
            this.dataGridViewOutput_GKU = new System.Windows.Forms.DataGridView();
            this.dataGridViewTask_GKU = new System.Windows.Forms.DataGridView();
            this.textBoxTask_GKU = new System.Windows.Forms.TextBox();
            this.buttonDone_GKU = new System.Windows.Forms.Button();
            this.buttonInfo_GKU = new System.Windows.Forms.Button();
            this.labelResult_GKU = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxTask_GKU.SuspendLayout();
            this.groupBoxResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput_GKU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTask_GKU)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_GKU
            // 
            this.groupBoxTask_GKU.Controls.Add(this.textBoxTask_GKU);
            this.groupBoxTask_GKU.Controls.Add(this.dataGridViewTask_GKU);
            this.groupBoxTask_GKU.Location = new System.Drawing.Point(6, 6);
            this.groupBoxTask_GKU.Name = "groupBoxTask_GKU";
            this.groupBoxTask_GKU.Size = new System.Drawing.Size(452, 359);
            this.groupBoxTask_GKU.TabIndex = 0;
            this.groupBoxTask_GKU.TabStop = false;
            this.groupBoxTask_GKU.Text = "Условие";
            // 
            // groupBoxResult
            // 
            this.groupBoxResult.Controls.Add(this.labelResult_GKU);
            this.groupBoxResult.Controls.Add(this.dataGridViewOutput_GKU);
            this.groupBoxResult.Location = new System.Drawing.Point(464, 6);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Size = new System.Drawing.Size(462, 267);
            this.groupBoxResult.TabIndex = 1;
            this.groupBoxResult.TabStop = false;
            this.groupBoxResult.Text = "Вывод данных";
            // 
            // dataGridViewOutput_GKU
            // 
            this.dataGridViewOutput_GKU.AllowUserToAddRows = false;
            this.dataGridViewOutput_GKU.AllowUserToDeleteRows = false;
            this.dataGridViewOutput_GKU.AllowUserToResizeColumns = false;
            this.dataGridViewOutput_GKU.AllowUserToResizeRows = false;
            this.dataGridViewOutput_GKU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutput_GKU.ColumnHeadersVisible = false;
            this.dataGridViewOutput_GKU.Location = new System.Drawing.Point(6, 46);
            this.dataGridViewOutput_GKU.Name = "dataGridViewOutput_GKU";
            this.dataGridViewOutput_GKU.RowHeadersVisible = false;
            this.dataGridViewOutput_GKU.RowHeadersWidth = 51;
            this.dataGridViewOutput_GKU.RowTemplate.Height = 24;
            this.dataGridViewOutput_GKU.Size = new System.Drawing.Size(239, 215);
            this.dataGridViewOutput_GKU.TabIndex = 0;
            // 
            // dataGridViewTask_GKU
            // 
            this.dataGridViewTask_GKU.AllowUserToAddRows = false;
            this.dataGridViewTask_GKU.AllowUserToDeleteRows = false;
            this.dataGridViewTask_GKU.AllowUserToResizeColumns = false;
            this.dataGridViewTask_GKU.AllowUserToResizeRows = false;
            this.dataGridViewTask_GKU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTask_GKU.ColumnHeadersVisible = false;
            this.dataGridViewTask_GKU.Location = new System.Drawing.Point(214, 46);
            this.dataGridViewTask_GKU.Name = "dataGridViewTask_GKU";
            this.dataGridViewTask_GKU.RowHeadersVisible = false;
            this.dataGridViewTask_GKU.RowHeadersWidth = 51;
            this.dataGridViewTask_GKU.RowTemplate.Height = 24;
            this.dataGridViewTask_GKU.Size = new System.Drawing.Size(230, 214);
            this.dataGridViewTask_GKU.TabIndex = 0;
            // 
            // textBoxTask_GKU
            // 
            this.textBoxTask_GKU.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTask_GKU.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_GKU.Location = new System.Drawing.Point(6, 46);
            this.textBoxTask_GKU.Multiline = true;
            this.textBoxTask_GKU.Name = "textBoxTask_GKU";
            this.textBoxTask_GKU.Size = new System.Drawing.Size(200, 131);
            this.textBoxTask_GKU.TabIndex = 1;
            this.textBoxTask_GKU.Text = "Дана матрица 5 на 5. Заменить четные элементы первой строки на нули.";
            // 
            // buttonDone_GKU
            // 
            this.buttonDone_GKU.Location = new System.Drawing.Point(738, 329);
            this.buttonDone_GKU.Name = "buttonDone_GKU";
            this.buttonDone_GKU.Size = new System.Drawing.Size(173, 36);
            this.buttonDone_GKU.TabIndex = 2;
            this.buttonDone_GKU.Text = "Выполнить";
            this.buttonDone_GKU.UseVisualStyleBackColor = true;
            this.buttonDone_GKU.Click += new System.EventHandler(this.buttonDone_GKU_Click);
            // 
            // buttonInfo_GKU
            // 
            this.buttonInfo_GKU.Location = new System.Drawing.Point(681, 329);
            this.buttonInfo_GKU.Name = "buttonInfo_GKU";
            this.buttonInfo_GKU.Size = new System.Drawing.Size(40, 36);
            this.buttonInfo_GKU.TabIndex = 3;
            this.buttonInfo_GKU.Text = "?";
            this.buttonInfo_GKU.UseVisualStyleBackColor = true;
            this.buttonInfo_GKU.Click += new System.EventHandler(this.buttonInfo_GKU_Click);
            // 
            // labelResult_GKU
            // 
            this.labelResult_GKU.AutoSize = true;
            this.labelResult_GKU.Location = new System.Drawing.Point(10, 20);
            this.labelResult_GKU.Name = "labelResult_GKU";
            this.labelResult_GKU.Size = new System.Drawing.Size(80, 17);
            this.labelResult_GKU.TabIndex = 1;
            this.labelResult_GKU.Text = "Результат:";
            // 
            // FormMain_GKU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 377);
            this.Controls.Add(this.buttonInfo_GKU);
            this.Controls.Add(this.buttonDone_GKU);
            this.Controls.Add(this.groupBoxResult);
            this.Controls.Add(this.groupBoxTask_GKU);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain_GKU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 |  Вариант 2 | Григорьев К.Ю.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTask_GKU.ResumeLayout(false);
            this.groupBoxTask_GKU.PerformLayout();
            this.groupBoxResult.ResumeLayout(false);
            this.groupBoxResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput_GKU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTask_GKU)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_GKU;
        private System.Windows.Forms.TextBox textBoxTask_GKU;
        private System.Windows.Forms.DataGridView dataGridViewTask_GKU;
        private System.Windows.Forms.GroupBox groupBoxResult;
        private System.Windows.Forms.Label labelResult_GKU;
        private System.Windows.Forms.DataGridView dataGridViewOutput_GKU;
        private System.Windows.Forms.Button buttonDone_GKU;
        private System.Windows.Forms.Button buttonInfo_GKU;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

