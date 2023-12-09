
namespace Tyuiu.GrigorevKU.Sprint6.Task0.V2
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
            this.buttonExecute_GKU = new System.Windows.Forms.Button();
            this.groupBoxProblem_GKU = new System.Windows.Forms.GroupBox();
            this.pictureBoxFormula_GKU = new System.Windows.Forms.PictureBox();
            this.textBoxTask_GKU = new System.Windows.Forms.TextBox();
            this.groupBoxOutPut_GKU = new System.Windows.Forms.GroupBox();
            this.labelResult_GKU = new System.Windows.Forms.Label();
            this.textBoxResult_GKU = new System.Windows.Forms.TextBox();
            this.groupBoxInput_GKU = new System.Windows.Forms.GroupBox();
            this.labelVarX_GKU = new System.Windows.Forms.Label();
            this.textBoxVarX_GKU = new System.Windows.Forms.TextBox();
            this.buttonHelp_GKU = new System.Windows.Forms.Button();
            this.groupBoxProblem_GKU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_GKU)).BeginInit();
            this.groupBoxOutPut_GKU.SuspendLayout();
            this.groupBoxInput_GKU.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonExecute_GKU
            // 
            this.buttonExecute_GKU.Location = new System.Drawing.Point(624, 390);
            this.buttonExecute_GKU.Name = "buttonExecute_GKU";
            this.buttonExecute_GKU.Size = new System.Drawing.Size(164, 48);
            this.buttonExecute_GKU.TabIndex = 0;
            this.buttonExecute_GKU.Text = "Выполнить";
            this.buttonExecute_GKU.UseVisualStyleBackColor = true;
            this.buttonExecute_GKU.Click += new System.EventHandler(this.buttonExecute_GKU_Click);
            // 
            // groupBoxProblem_GKU
            // 
            this.groupBoxProblem_GKU.Controls.Add(this.pictureBoxFormula_GKU);
            this.groupBoxProblem_GKU.Controls.Add(this.textBoxTask_GKU);
            this.groupBoxProblem_GKU.Location = new System.Drawing.Point(12, 12);
            this.groupBoxProblem_GKU.Name = "groupBoxProblem_GKU";
            this.groupBoxProblem_GKU.Size = new System.Drawing.Size(776, 239);
            this.groupBoxProblem_GKU.TabIndex = 1;
            this.groupBoxProblem_GKU.TabStop = false;
            this.groupBoxProblem_GKU.Text = "Условие";
            // 
            // pictureBoxFormula_GKU
            // 
            this.pictureBoxFormula_GKU.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_GKU.Image")));
            this.pictureBoxFormula_GKU.Location = new System.Drawing.Point(551, 21);
            this.pictureBoxFormula_GKU.Name = "pictureBoxFormula_GKU";
            this.pictureBoxFormula_GKU.Size = new System.Drawing.Size(219, 82);
            this.pictureBoxFormula_GKU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFormula_GKU.TabIndex = 1;
            this.pictureBoxFormula_GKU.TabStop = false;
            // 
            // textBoxTask_GKU
            // 
            this.textBoxTask_GKU.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_GKU.Location = new System.Drawing.Point(6, 21);
            this.textBoxTask_GKU.Multiline = true;
            this.textBoxTask_GKU.Name = "textBoxTask_GKU";
            this.textBoxTask_GKU.ReadOnly = true;
            this.textBoxTask_GKU.ShortcutsEnabled = false;
            this.textBoxTask_GKU.Size = new System.Drawing.Size(539, 212);
            this.textBoxTask_GKU.TabIndex = 0;
            this.textBoxTask_GKU.Text = "Вычислить значение по формуле";
            // 
            // groupBoxOutPut_GKU
            // 
            this.groupBoxOutPut_GKU.Controls.Add(this.labelResult_GKU);
            this.groupBoxOutPut_GKU.Controls.Add(this.textBoxResult_GKU);
            this.groupBoxOutPut_GKU.Location = new System.Drawing.Point(588, 265);
            this.groupBoxOutPut_GKU.Name = "groupBoxOutPut_GKU";
            this.groupBoxOutPut_GKU.Size = new System.Drawing.Size(200, 119);
            this.groupBoxOutPut_GKU.TabIndex = 2;
            this.groupBoxOutPut_GKU.TabStop = false;
            this.groupBoxOutPut_GKU.Text = "Вывод данных";
            // 
            // labelResult_GKU
            // 
            this.labelResult_GKU.AutoSize = true;
            this.labelResult_GKU.Location = new System.Drawing.Point(14, 47);
            this.labelResult_GKU.Name = "labelResult_GKU";
            this.labelResult_GKU.Size = new System.Drawing.Size(80, 17);
            this.labelResult_GKU.TabIndex = 1;
            this.labelResult_GKU.Text = "Результат:";
            // 
            // textBoxResult_GKU
            // 
            this.textBoxResult_GKU.Location = new System.Drawing.Point(17, 67);
            this.textBoxResult_GKU.Name = "textBoxResult_GKU";
            this.textBoxResult_GKU.ReadOnly = true;
            this.textBoxResult_GKU.Size = new System.Drawing.Size(100, 22);
            this.textBoxResult_GKU.TabIndex = 0;
            this.textBoxResult_GKU.TextChanged += new System.EventHandler(this.textBoxResult_GKU_TextChanged);
            // 
            // groupBoxInput_GKU
            // 
            this.groupBoxInput_GKU.Controls.Add(this.labelVarX_GKU);
            this.groupBoxInput_GKU.Controls.Add(this.textBoxVarX_GKU);
            this.groupBoxInput_GKU.Location = new System.Drawing.Point(12, 265);
            this.groupBoxInput_GKU.Name = "groupBoxInput_GKU";
            this.groupBoxInput_GKU.Size = new System.Drawing.Size(570, 119);
            this.groupBoxInput_GKU.TabIndex = 3;
            this.groupBoxInput_GKU.TabStop = false;
            this.groupBoxInput_GKU.Text = "Ввод данных";
            // 
            // labelVarX_GKU
            // 
            this.labelVarX_GKU.AutoSize = true;
            this.labelVarX_GKU.Location = new System.Drawing.Point(19, 47);
            this.labelVarX_GKU.Name = "labelVarX_GKU";
            this.labelVarX_GKU.Size = new System.Drawing.Size(108, 17);
            this.labelVarX_GKU.TabIndex = 1;
            this.labelVarX_GKU.Text = "Переменная X:";
            // 
            // textBoxVarX_GKU
            // 
            this.textBoxVarX_GKU.Location = new System.Drawing.Point(22, 67);
            this.textBoxVarX_GKU.Name = "textBoxVarX_GKU";
            this.textBoxVarX_GKU.Size = new System.Drawing.Size(105, 22);
            this.textBoxVarX_GKU.TabIndex = 0;
            this.textBoxVarX_GKU.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVarX_GKU_KeyPress);
            // 
            // buttonHelp_GKU
            // 
            this.buttonHelp_GKU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_GKU.Location = new System.Drawing.Point(563, 390);
            this.buttonHelp_GKU.Name = "buttonHelp_GKU";
            this.buttonHelp_GKU.Size = new System.Drawing.Size(55, 48);
            this.buttonHelp_GKU.TabIndex = 4;
            this.buttonHelp_GKU.Text = "?";
            this.buttonHelp_GKU.UseVisualStyleBackColor = true;
            this.buttonHelp_GKU.Click += new System.EventHandler(this.buttonHelp_GKU_Click);
            // 
            // FormMain_GKU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonHelp_GKU);
            this.Controls.Add(this.groupBoxInput_GKU);
            this.Controls.Add(this.groupBoxOutPut_GKU);
            this.Controls.Add(this.groupBoxProblem_GKU);
            this.Controls.Add(this.buttonExecute_GKU);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain_GKU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 2 | Григорьев К.Ю.";
            this.groupBoxProblem_GKU.ResumeLayout(false);
            this.groupBoxProblem_GKU.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_GKU)).EndInit();
            this.groupBoxOutPut_GKU.ResumeLayout(false);
            this.groupBoxOutPut_GKU.PerformLayout();
            this.groupBoxInput_GKU.ResumeLayout(false);
            this.groupBoxInput_GKU.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonExecute_GKU;
        private System.Windows.Forms.GroupBox groupBoxProblem_GKU;
        private System.Windows.Forms.GroupBox groupBoxOutPut_GKU;
        private System.Windows.Forms.GroupBox groupBoxInput_GKU;
        private System.Windows.Forms.TextBox textBoxVarX_GKU;
        private System.Windows.Forms.TextBox textBoxResult_GKU;
        private System.Windows.Forms.Label labelVarX_GKU;
        private System.Windows.Forms.Label labelResult_GKU;
        private System.Windows.Forms.PictureBox pictureBoxFormula_GKU;
        private System.Windows.Forms.Button buttonHelp_GKU;
        private System.Windows.Forms.TextBox textBoxTask_GKU;
    }
}

