
namespace Tyuiu.GrigorevKU.Sprint6.Task7.V15
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelButtons_GKU = new System.Windows.Forms.Panel();
            this.buttonHelp_GKU = new System.Windows.Forms.Button();
            this.buttonSaveFile_GKU = new System.Windows.Forms.Button();
            this.buttonDone_GKU = new System.Windows.Forms.Button();
            this.buttonOpenFile_GKU = new System.Windows.Forms.Button();
            this.panelTask_GKU = new System.Windows.Forms.Panel();
            this.groupBoxTask_GKU = new System.Windows.Forms.GroupBox();
            this.textBoxTask_GKU = new System.Windows.Forms.TextBox();
            this.panelInput_GKU = new System.Windows.Forms.Panel();
            this.groupBoxInput_GKU = new System.Windows.Forms.GroupBox();
            this.dataGridViewInput_GKU = new System.Windows.Forms.DataGridView();
            this.splitterInput_GKU = new System.Windows.Forms.Splitter();
            this.panelOutPut_GKU = new System.Windows.Forms.Panel();
            this.groupBoxOutPut_GKU = new System.Windows.Forms.GroupBox();
            this.dataGridViewOutPut_GKU = new System.Windows.Forms.DataGridView();
            this.openFileDialogTask_GKU = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogMatrix_GKU = new System.Windows.Forms.SaveFileDialog();
            this.toolTipButton_GKU = new System.Windows.Forms.ToolTip(this.components);
            this.panelButtons_GKU.SuspendLayout();
            this.panelTask_GKU.SuspendLayout();
            this.groupBoxTask_GKU.SuspendLayout();
            this.panelInput_GKU.SuspendLayout();
            this.groupBoxInput_GKU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInput_GKU)).BeginInit();
            this.panelOutPut_GKU.SuspendLayout();
            this.groupBoxOutPut_GKU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut_GKU)).BeginInit();
            this.SuspendLayout();
            // 
            // panelButtons_GKU
            // 
            this.panelButtons_GKU.Controls.Add(this.buttonHelp_GKU);
            this.panelButtons_GKU.Controls.Add(this.buttonSaveFile_GKU);
            this.panelButtons_GKU.Controls.Add(this.buttonDone_GKU);
            this.panelButtons_GKU.Controls.Add(this.buttonOpenFile_GKU);
            this.panelButtons_GKU.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons_GKU.Location = new System.Drawing.Point(0, 0);
            this.panelButtons_GKU.Name = "panelButtons_GKU";
            this.panelButtons_GKU.Size = new System.Drawing.Size(1125, 88);
            this.panelButtons_GKU.TabIndex = 0;
            // 
            // buttonHelp_GKU
            // 
            this.buttonHelp_GKU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_GKU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_GKU.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_GKU.Image")));
            this.buttonHelp_GKU.Location = new System.Drawing.Point(1001, 2);
            this.buttonHelp_GKU.Name = "buttonHelp_GKU";
            this.buttonHelp_GKU.Size = new System.Drawing.Size(121, 83);
            this.buttonHelp_GKU.TabIndex = 0;
            this.toolTipButton_GKU.SetToolTip(this.buttonHelp_GKU, "Подсказка");
            this.buttonHelp_GKU.UseVisualStyleBackColor = true;
            this.buttonHelp_GKU.Click += new System.EventHandler(this.buttonHelp_GKU_Click);
            this.buttonHelp_GKU.MouseEnter += new System.EventHandler(this.buttonHelp_GKU_MouseEnter);
            // 
            // buttonSaveFile_GKU
            // 
            this.buttonSaveFile_GKU.Enabled = false;
            this.buttonSaveFile_GKU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveFile_GKU.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveFile_GKU.Image")));
            this.buttonSaveFile_GKU.Location = new System.Drawing.Point(262, 5);
            this.buttonSaveFile_GKU.Name = "buttonSaveFile_GKU";
            this.buttonSaveFile_GKU.Size = new System.Drawing.Size(121, 83);
            this.buttonSaveFile_GKU.TabIndex = 0;
            this.toolTipButton_GKU.SetToolTip(this.buttonSaveFile_GKU, "Сохранить обработанные данные в файл в формате CSV");
            this.buttonSaveFile_GKU.UseVisualStyleBackColor = true;
            this.buttonSaveFile_GKU.Click += new System.EventHandler(this.buttonSaveFile_GKU_Click);
            this.buttonSaveFile_GKU.MouseEnter += new System.EventHandler(this.buttonSaveFile_GKU_MouseEnter);
            // 
            // buttonDone_GKU
            // 
            this.buttonDone_GKU.Enabled = false;
            this.buttonDone_GKU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone_GKU.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_GKU.Image")));
            this.buttonDone_GKU.Location = new System.Drawing.Point(135, 5);
            this.buttonDone_GKU.Name = "buttonDone_GKU";
            this.buttonDone_GKU.Size = new System.Drawing.Size(121, 83);
            this.buttonDone_GKU.TabIndex = 0;
            this.toolTipButton_GKU.SetToolTip(this.buttonDone_GKU, "Выполнить обработку данных");
            this.buttonDone_GKU.UseVisualStyleBackColor = true;
            this.buttonDone_GKU.Click += new System.EventHandler(this.buttonDone_GKU_Click);
            this.buttonDone_GKU.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_GKU_MouseDown);
            this.buttonDone_GKU.MouseEnter += new System.EventHandler(this.buttonDone_GKU_MouseEnter);
            // 
            // buttonOpenFile_GKU
            // 
            this.buttonOpenFile_GKU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenFile_GKU.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_GKU.Image")));
            this.buttonOpenFile_GKU.Location = new System.Drawing.Point(8, 5);
            this.buttonOpenFile_GKU.Name = "buttonOpenFile_GKU";
            this.buttonOpenFile_GKU.Size = new System.Drawing.Size(121, 83);
            this.buttonOpenFile_GKU.TabIndex = 0;
            this.toolTipButton_GKU.SetToolTip(this.buttonOpenFile_GKU, "Открыть файл для обработки данных в CSV");
            this.buttonOpenFile_GKU.UseVisualStyleBackColor = true;
            this.buttonOpenFile_GKU.Click += new System.EventHandler(this.buttonOpenFile_GKU_Click);
            this.buttonOpenFile_GKU.MouseEnter += new System.EventHandler(this.buttonOpenFile_GKU_MouseEnter);
            // 
            // panelTask_GKU
            // 
            this.panelTask_GKU.Controls.Add(this.groupBoxTask_GKU);
            this.panelTask_GKU.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTask_GKU.Location = new System.Drawing.Point(0, 88);
            this.panelTask_GKU.Name = "panelTask_GKU";
            this.panelTask_GKU.Size = new System.Drawing.Size(1125, 90);
            this.panelTask_GKU.TabIndex = 1;
            // 
            // groupBoxTask_GKU
            // 
            this.groupBoxTask_GKU.Controls.Add(this.textBoxTask_GKU);
            this.groupBoxTask_GKU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTask_GKU.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTask_GKU.Name = "groupBoxTask_GKU";
            this.groupBoxTask_GKU.Size = new System.Drawing.Size(1125, 90);
            this.groupBoxTask_GKU.TabIndex = 0;
            this.groupBoxTask_GKU.TabStop = false;
            this.groupBoxTask_GKU.Text = "Условие:";
            // 
            // textBoxTask_GKU
            // 
            this.textBoxTask_GKU.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTask_GKU.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_GKU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTask_GKU.Location = new System.Drawing.Point(3, 18);
            this.textBoxTask_GKU.Multiline = true;
            this.textBoxTask_GKU.Name = "textBoxTask_GKU";
            this.textBoxTask_GKU.Size = new System.Drawing.Size(1119, 69);
            this.textBoxTask_GKU.TabIndex = 0;
            this.textBoxTask_GKU.Text = resources.GetString("textBoxTask_GKU.Text");
            // 
            // panelInput_GKU
            // 
            this.panelInput_GKU.Controls.Add(this.groupBoxInput_GKU);
            this.panelInput_GKU.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInput_GKU.Location = new System.Drawing.Point(0, 178);
            this.panelInput_GKU.Name = "panelInput_GKU";
            this.panelInput_GKU.Size = new System.Drawing.Size(759, 401);
            this.panelInput_GKU.TabIndex = 2;
            // 
            // groupBoxInput_GKU
            // 
            this.groupBoxInput_GKU.Controls.Add(this.dataGridViewInput_GKU);
            this.groupBoxInput_GKU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInput_GKU.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInput_GKU.Name = "groupBoxInput_GKU";
            this.groupBoxInput_GKU.Size = new System.Drawing.Size(759, 401);
            this.groupBoxInput_GKU.TabIndex = 0;
            this.groupBoxInput_GKU.TabStop = false;
            this.groupBoxInput_GKU.Text = "Ввод:";
            // 
            // dataGridViewInput_GKU
            // 
            this.dataGridViewInput_GKU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInput_GKU.ColumnHeadersVisible = false;
            this.dataGridViewInput_GKU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewInput_GKU.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewInput_GKU.Name = "dataGridViewInput_GKU";
            this.dataGridViewInput_GKU.RowHeadersVisible = false;
            this.dataGridViewInput_GKU.RowHeadersWidth = 51;
            this.dataGridViewInput_GKU.RowTemplate.Height = 24;
            this.dataGridViewInput_GKU.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewInput_GKU.Size = new System.Drawing.Size(753, 380);
            this.dataGridViewInput_GKU.TabIndex = 0;
            // 
            // splitterInput_GKU
            // 
            this.splitterInput_GKU.Location = new System.Drawing.Point(759, 178);
            this.splitterInput_GKU.Name = "splitterInput_GKU";
            this.splitterInput_GKU.Size = new System.Drawing.Size(10, 401);
            this.splitterInput_GKU.TabIndex = 3;
            this.splitterInput_GKU.TabStop = false;
            // 
            // panelOutPut_GKU
            // 
            this.panelOutPut_GKU.Controls.Add(this.groupBoxOutPut_GKU);
            this.panelOutPut_GKU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOutPut_GKU.Location = new System.Drawing.Point(769, 178);
            this.panelOutPut_GKU.Name = "panelOutPut_GKU";
            this.panelOutPut_GKU.Size = new System.Drawing.Size(356, 401);
            this.panelOutPut_GKU.TabIndex = 4;
            // 
            // groupBoxOutPut_GKU
            // 
            this.groupBoxOutPut_GKU.Controls.Add(this.dataGridViewOutPut_GKU);
            this.groupBoxOutPut_GKU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPut_GKU.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutPut_GKU.Name = "groupBoxOutPut_GKU";
            this.groupBoxOutPut_GKU.Size = new System.Drawing.Size(356, 401);
            this.groupBoxOutPut_GKU.TabIndex = 0;
            this.groupBoxOutPut_GKU.TabStop = false;
            this.groupBoxOutPut_GKU.Text = "Вывод:";
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
            this.dataGridViewOutPut_GKU.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewOutPut_GKU.Size = new System.Drawing.Size(350, 380);
            this.dataGridViewOutPut_GKU.TabIndex = 0;
            // 
            // openFileDialogTask_GKU
            // 
            this.openFileDialogTask_GKU.FileName = "openFileDialog1";
            // 
            // toolTipButton_GKU
            // 
            this.toolTipButton_GKU.IsBalloon = true;
            this.toolTipButton_GKU.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipButton_GKU.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 579);
            this.Controls.Add(this.panelOutPut_GKU);
            this.Controls.Add(this.splitterInput_GKU);
            this.Controls.Add(this.panelInput_GKU);
            this.Controls.Add(this.panelTask_GKU);
            this.Controls.Add(this.panelButtons_GKU);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 7 |  Вариант 15 | Григорьев К.Ю.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelButtons_GKU.ResumeLayout(false);
            this.panelTask_GKU.ResumeLayout(false);
            this.groupBoxTask_GKU.ResumeLayout(false);
            this.groupBoxTask_GKU.PerformLayout();
            this.panelInput_GKU.ResumeLayout(false);
            this.groupBoxInput_GKU.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInput_GKU)).EndInit();
            this.panelOutPut_GKU.ResumeLayout(false);
            this.groupBoxOutPut_GKU.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut_GKU)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButtons_GKU;
        private System.Windows.Forms.Panel panelTask_GKU;
        private System.Windows.Forms.GroupBox groupBoxTask_GKU;
        private System.Windows.Forms.TextBox textBoxTask_GKU;
        private System.Windows.Forms.Panel panelInput_GKU;
        private System.Windows.Forms.GroupBox groupBoxInput_GKU;
        private System.Windows.Forms.Splitter splitterInput_GKU;
        private System.Windows.Forms.Panel panelOutPut_GKU;
        private System.Windows.Forms.GroupBox groupBoxOutPut_GKU;
        private System.Windows.Forms.DataGridView dataGridViewInput_GKU;
        private System.Windows.Forms.DataGridView dataGridViewOutPut_GKU;
        private System.Windows.Forms.Button buttonHelp_GKU;
        private System.Windows.Forms.Button buttonSaveFile_GKU;
        private System.Windows.Forms.Button buttonDone_GKU;
        private System.Windows.Forms.Button buttonOpenFile_GKU;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_GKU;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_GKU;
        private System.Windows.Forms.ToolTip toolTipButton_GKU;
    }
}

