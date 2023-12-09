
namespace Tyuiu.GrigorevKU.Sprint6.Task1.V18
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_GKU));
            this.buttonDone_GKU = new System.Windows.Forms.Button();
            this.buttonInfo_GKU = new System.Windows.Forms.Button();
            this.groupBoxInput_GKU = new System.Windows.Forms.GroupBox();
            this.labelStopStep_GKU = new System.Windows.Forms.Label();
            this.labelStartStep_GKU = new System.Windows.Forms.Label();
            this.textBoxStopStep_GKU = new System.Windows.Forms.TextBox();
            this.textBoxStartStep_GKU = new System.Windows.Forms.TextBox();
            this.groupBoxTask_GKU = new System.Windows.Forms.GroupBox();
            this.pictureBoxTask_GKU = new System.Windows.Forms.PictureBox();
            this.textBoxTask_GKU = new System.Windows.Forms.TextBox();
            this.groupBoxResult_GKU = new System.Windows.Forms.GroupBox();
            this.labelResult_GKU = new System.Windows.Forms.Label();
            this.textBoxResult_GKU = new System.Windows.Forms.TextBox();
            this.groupBoxInput_GKU.SuspendLayout();
            this.groupBoxTask_GKU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTask_GKU)).BeginInit();
            this.groupBoxResult_GKU.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDone_GKU
            // 
            this.buttonDone_GKU.BackColor = System.Drawing.Color.Green;
            this.buttonDone_GKU.Location = new System.Drawing.Point(456, 360);
            this.buttonDone_GKU.Name = "buttonDone_GKU";
            this.buttonDone_GKU.Size = new System.Drawing.Size(138, 62);
            this.buttonDone_GKU.TabIndex = 0;
            this.buttonDone_GKU.Text = "Выполнить";
            this.buttonDone_GKU.UseMnemonic = false;
            this.buttonDone_GKU.UseVisualStyleBackColor = false;
            this.buttonDone_GKU.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonInfo_GKU
            // 
            this.buttonInfo_GKU.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonInfo_GKU.Location = new System.Drawing.Point(352, 360);
            this.buttonInfo_GKU.Name = "buttonInfo_GKU";
            this.buttonInfo_GKU.Size = new System.Drawing.Size(98, 62);
            this.buttonInfo_GKU.TabIndex = 1;
            this.buttonInfo_GKU.Text = "Справка";
            this.buttonInfo_GKU.UseVisualStyleBackColor = false;
            this.buttonInfo_GKU.Click += new System.EventHandler(this.buttonInfo_GKU_Click);
            // 
            // groupBoxInput_GKU
            // 
            this.groupBoxInput_GKU.Controls.Add(this.labelStopStep_GKU);
            this.groupBoxInput_GKU.Controls.Add(this.labelStartStep_GKU);
            this.groupBoxInput_GKU.Controls.Add(this.textBoxStopStep_GKU);
            this.groupBoxInput_GKU.Controls.Add(this.textBoxStartStep_GKU);
            this.groupBoxInput_GKU.Location = new System.Drawing.Point(12, 354);
            this.groupBoxInput_GKU.Name = "groupBoxInput_GKU";
            this.groupBoxInput_GKU.Size = new System.Drawing.Size(324, 68);
            this.groupBoxInput_GKU.TabIndex = 2;
            this.groupBoxInput_GKU.TabStop = false;
            this.groupBoxInput_GKU.Text = "Ввод данных";
            // 
            // labelStopStep_GKU
            // 
            this.labelStopStep_GKU.AutoSize = true;
            this.labelStopStep_GKU.Location = new System.Drawing.Point(166, 20);
            this.labelStopStep_GKU.Name = "labelStopStep_GKU";
            this.labelStopStep_GKU.Size = new System.Drawing.Size(89, 17);
            this.labelStopStep_GKU.TabIndex = 3;
            this.labelStopStep_GKU.Text = "Конец шага:";
            // 
            // labelStartStep_GKU
            // 
            this.labelStartStep_GKU.AutoSize = true;
            this.labelStartStep_GKU.Location = new System.Drawing.Point(6, 20);
            this.labelStartStep_GKU.Name = "labelStartStep_GKU";
            this.labelStartStep_GKU.Size = new System.Drawing.Size(87, 17);
            this.labelStartStep_GKU.TabIndex = 2;
            this.labelStartStep_GKU.Text = "Старт шага:";
            // 
            // textBoxStopStep_GKU
            // 
            this.textBoxStopStep_GKU.Location = new System.Drawing.Point(169, 40);
            this.textBoxStopStep_GKU.Name = "textBoxStopStep_GKU";
            this.textBoxStopStep_GKU.Size = new System.Drawing.Size(147, 22);
            this.textBoxStopStep_GKU.TabIndex = 1;
            // 
            // textBoxStartStep_GKU
            // 
            this.textBoxStartStep_GKU.Location = new System.Drawing.Point(6, 40);
            this.textBoxStartStep_GKU.Name = "textBoxStartStep_GKU";
            this.textBoxStartStep_GKU.Size = new System.Drawing.Size(144, 22);
            this.textBoxStartStep_GKU.TabIndex = 0;
            this.textBoxStartStep_GKU.TextChanged += new System.EventHandler(this.textBoxStartStep_GKU_TextChanged);
            // 
            // groupBoxTask_GKU
            // 
            this.groupBoxTask_GKU.Controls.Add(this.pictureBoxTask_GKU);
            this.groupBoxTask_GKU.Controls.Add(this.textBoxTask_GKU);
            this.groupBoxTask_GKU.Location = new System.Drawing.Point(14, 10);
            this.groupBoxTask_GKU.Name = "groupBoxTask_GKU";
            this.groupBoxTask_GKU.Size = new System.Drawing.Size(580, 344);
            this.groupBoxTask_GKU.TabIndex = 3;
            this.groupBoxTask_GKU.TabStop = false;
            this.groupBoxTask_GKU.Text = "Условие";
            // 
            // pictureBoxTask_GKU
            // 
            this.pictureBoxTask_GKU.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTask_GKU.Image")));
            this.pictureBoxTask_GKU.Location = new System.Drawing.Point(10, 72);
            this.pictureBoxTask_GKU.Name = "pictureBoxTask_GKU";
            this.pictureBoxTask_GKU.Size = new System.Drawing.Size(388, 49);
            this.pictureBoxTask_GKU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxTask_GKU.TabIndex = 1;
            this.pictureBoxTask_GKU.TabStop = false;
            // 
            // textBoxTask_GKU
            // 
            this.textBoxTask_GKU.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTask_GKU.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_GKU.Location = new System.Drawing.Point(10, 24);
            this.textBoxTask_GKU.Multiline = true;
            this.textBoxTask_GKU.Name = "textBoxTask_GKU";
            this.textBoxTask_GKU.Size = new System.Drawing.Size(378, 87);
            this.textBoxTask_GKU.TabIndex = 0;
            this.textBoxTask_GKU.Text = "Протабулировать функцию на заданном диапазоне. Результат вывести в  виде таблицы." +
    "";
            // 
            // groupBoxResult_GKU
            // 
            this.groupBoxResult_GKU.Controls.Add(this.labelResult_GKU);
            this.groupBoxResult_GKU.Controls.Add(this.textBoxResult_GKU);
            this.groupBoxResult_GKU.Location = new System.Drawing.Point(609, 18);
            this.groupBoxResult_GKU.Name = "groupBoxResult_GKU";
            this.groupBoxResult_GKU.Size = new System.Drawing.Size(322, 403);
            this.groupBoxResult_GKU.TabIndex = 4;
            this.groupBoxResult_GKU.TabStop = false;
            this.groupBoxResult_GKU.Text = "Вывод данных";
            // 
            // labelResult_GKU
            // 
            this.labelResult_GKU.AutoSize = true;
            this.labelResult_GKU.Location = new System.Drawing.Point(6, 20);
            this.labelResult_GKU.Name = "labelResult_GKU";
            this.labelResult_GKU.Size = new System.Drawing.Size(80, 17);
            this.labelResult_GKU.TabIndex = 1;
            this.labelResult_GKU.Text = "Результат:";
            this.labelResult_GKU.Click += new System.EventHandler(this.labelResult_GKU_Click);
            // 
            // textBoxResult_GKU
            // 
            this.textBoxResult_GKU.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxResult_GKU.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult_GKU.Location = new System.Drawing.Point(6, 40);
            this.textBoxResult_GKU.Multiline = true;
            this.textBoxResult_GKU.Name = "textBoxResult_GKU";
            this.textBoxResult_GKU.ReadOnly = true;
            this.textBoxResult_GKU.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_GKU.Size = new System.Drawing.Size(310, 357);
            this.textBoxResult_GKU.TabIndex = 0;
            // 
            // FormMain_GKU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 450);
            this.Controls.Add(this.groupBoxResult_GKU);
            this.Controls.Add(this.groupBoxTask_GKU);
            this.Controls.Add(this.groupBoxInput_GKU);
            this.Controls.Add(this.buttonInfo_GKU);
            this.Controls.Add(this.buttonDone_GKU);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain_GKU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 1 |  Вариант 18 | Григорьев К.Ю.";
            this.groupBoxInput_GKU.ResumeLayout(false);
            this.groupBoxInput_GKU.PerformLayout();
            this.groupBoxTask_GKU.ResumeLayout(false);
            this.groupBoxTask_GKU.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTask_GKU)).EndInit();
            this.groupBoxResult_GKU.ResumeLayout(false);
            this.groupBoxResult_GKU.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDone_GKU;
        private System.Windows.Forms.Button buttonInfo_GKU;
        private System.Windows.Forms.GroupBox groupBoxInput_GKU;
        private System.Windows.Forms.Label labelStopStep_GKU;
        private System.Windows.Forms.Label labelStartStep_GKU;
        private System.Windows.Forms.TextBox textBoxStopStep_GKU;
        private System.Windows.Forms.TextBox textBoxStartStep_GKU;
        private System.Windows.Forms.GroupBox groupBoxTask_GKU;
        private System.Windows.Forms.TextBox textBoxTask_GKU;
        private System.Windows.Forms.GroupBox groupBoxResult_GKU;
        private System.Windows.Forms.Label labelResult_GKU;
        private System.Windows.Forms.TextBox textBoxResult_GKU;
        private System.Windows.Forms.PictureBox pictureBoxTask_GKU;
    }
}

