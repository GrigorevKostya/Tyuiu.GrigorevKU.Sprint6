
namespace Tyuiu.GrigorevKU.Sprint6.Task6.V22
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelButtons_GKU = new System.Windows.Forms.Panel();
            this.buttonHelp_GKU = new System.Windows.Forms.Button();
            this.buttonDone_GKU = new System.Windows.Forms.Button();
            this.buttonOpenFile_GKU = new System.Windows.Forms.Button();
            this.panelTask_GKU = new System.Windows.Forms.Panel();
            this.groupBoxTask_GKU = new System.Windows.Forms.GroupBox();
            this.textBoxTask_GKU = new System.Windows.Forms.TextBox();
            this.panelInput_GKU = new System.Windows.Forms.Panel();
            this.groupBoxInPut_GKU = new System.Windows.Forms.GroupBox();
            this.textBoxInPut_GKU = new System.Windows.Forms.TextBox();
            this.splitterOutPut_GKU = new System.Windows.Forms.Splitter();
            this.panelOutPut_GKU = new System.Windows.Forms.Panel();
            this.groupBoxOutPut_GKU = new System.Windows.Forms.GroupBox();
            this.textBoxOutPut_GKU = new System.Windows.Forms.TextBox();
            this.openFileDialogTask_GKU = new System.Windows.Forms.OpenFileDialog();
            this.toolTipTask_GKU = new System.Windows.Forms.ToolTip();
            this.panelButtons_GKU.SuspendLayout();
            this.panelTask_GKU.SuspendLayout();
            this.groupBoxTask_GKU.SuspendLayout();
            this.panelInput_GKU.SuspendLayout();
            this.groupBoxInPut_GKU.SuspendLayout();
            this.panelOutPut_GKU.SuspendLayout();
            this.groupBoxOutPut_GKU.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButtons_GKU
            // 
            this.panelButtons_GKU.Controls.Add(this.buttonHelp_GKU);
            this.panelButtons_GKU.Controls.Add(this.buttonDone_GKU);
            this.panelButtons_GKU.Controls.Add(this.buttonOpenFile_GKU);
            this.panelButtons_GKU.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons_GKU.Location = new System.Drawing.Point(0, 0);
            this.panelButtons_GKU.Name = "panelButtons_GKU";
            this.panelButtons_GKU.Size = new System.Drawing.Size(1037, 81);
            this.panelButtons_GKU.TabIndex = 0;
            // 
            // buttonHelp_GKU
            // 
            this.buttonHelp_GKU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_GKU.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_GKU.Image")));
            this.buttonHelp_GKU.Location = new System.Drawing.Point(936, 3);
            this.buttonHelp_GKU.Name = "buttonHelp_GKU";
            this.buttonHelp_GKU.Size = new System.Drawing.Size(89, 76);
            this.buttonHelp_GKU.TabIndex = 0;
            this.toolTipTask_GKU.SetToolTip(this.buttonHelp_GKU, "Сведения о программе");
            this.buttonHelp_GKU.UseVisualStyleBackColor = true;
            this.buttonHelp_GKU.Click += new System.EventHandler(this.buttonHelp_GKU_Click);
            // 
            // buttonDone_GKU
            // 
            this.buttonDone_GKU.Enabled = false;
            this.buttonDone_GKU.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_GKU.Image")));
            this.buttonDone_GKU.Location = new System.Drawing.Point(116, 3);
            this.buttonDone_GKU.Name = "buttonDone_GKU";
            this.buttonDone_GKU.Size = new System.Drawing.Size(102, 76);
            this.buttonDone_GKU.TabIndex = 0;
            this.toolTipTask_GKU.SetToolTip(this.buttonDone_GKU, "Выводит первое слово каждой строки\r\nв результирующую строку");
            this.buttonDone_GKU.UseVisualStyleBackColor = true;
            this.buttonDone_GKU.Click += new System.EventHandler(this.buttonDone_GKU_Click);
            // 
            // buttonOpenFile_GKU
            // 
            this.buttonOpenFile_GKU.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_GKU.Image")));
            this.buttonOpenFile_GKU.Location = new System.Drawing.Point(8, 3);
            this.buttonOpenFile_GKU.Name = "buttonOpenFile_GKU";
            this.buttonOpenFile_GKU.Size = new System.Drawing.Size(102, 76);
            this.buttonOpenFile_GKU.TabIndex = 0;
            this.toolTipTask_GKU.SetToolTip(this.buttonOpenFile_GKU, "Открыть файл\r\nВыберите нужный файл для обработки");
            this.buttonOpenFile_GKU.UseVisualStyleBackColor = true;
            this.buttonOpenFile_GKU.Click += new System.EventHandler(this.buttonOpenFile_GKU_Click);
            // 
            // panelTask_GKU
            // 
            this.panelTask_GKU.Controls.Add(this.groupBoxTask_GKU);
            this.panelTask_GKU.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTask_GKU.Location = new System.Drawing.Point(0, 81);
            this.panelTask_GKU.Name = "panelTask_GKU";
            this.panelTask_GKU.Size = new System.Drawing.Size(1037, 89);
            this.panelTask_GKU.TabIndex = 1;
            // 
            // groupBoxTask_GKU
            // 
            this.groupBoxTask_GKU.Controls.Add(this.textBoxTask_GKU);
            this.groupBoxTask_GKU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTask_GKU.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTask_GKU.Name = "groupBoxTask_GKU";
            this.groupBoxTask_GKU.Size = new System.Drawing.Size(1037, 89);
            this.groupBoxTask_GKU.TabIndex = 0;
            this.groupBoxTask_GKU.TabStop = false;
            this.groupBoxTask_GKU.Text = "Условие:";
            // 
            // textBoxTask_GKU
            // 
            this.textBoxTask_GKU.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTask_GKU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTask_GKU.Location = new System.Drawing.Point(3, 18);
            this.textBoxTask_GKU.Multiline = true;
            this.textBoxTask_GKU.Name = "textBoxTask_GKU";
            this.textBoxTask_GKU.ReadOnly = true;
            this.textBoxTask_GKU.Size = new System.Drawing.Size(1031, 68);
            this.textBoxTask_GKU.TabIndex = 0;
            this.textBoxTask_GKU.Text = resources.GetString("textBoxTask_GKU.Text");
            // 
            // panelInput_GKU
            // 
            this.panelInput_GKU.Controls.Add(this.groupBoxInPut_GKU);
            this.panelInput_GKU.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInput_GKU.Location = new System.Drawing.Point(0, 170);
            this.panelInput_GKU.Name = "panelInput_GKU";
            this.panelInput_GKU.Size = new System.Drawing.Size(520, 406);
            this.panelInput_GKU.TabIndex = 2;
            // 
            // groupBoxInPut_GKU
            // 
            this.groupBoxInPut_GKU.Controls.Add(this.textBoxInPut_GKU);
            this.groupBoxInPut_GKU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInPut_GKU.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInPut_GKU.Name = "groupBoxInPut_GKU";
            this.groupBoxInPut_GKU.Size = new System.Drawing.Size(520, 406);
            this.groupBoxInPut_GKU.TabIndex = 0;
            this.groupBoxInPut_GKU.TabStop = false;
            this.groupBoxInPut_GKU.Text = "Ввод:";
            // 
            // textBoxInPut_GKU
            // 
            this.textBoxInPut_GKU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxInPut_GKU.Location = new System.Drawing.Point(3, 18);
            this.textBoxInPut_GKU.Multiline = true;
            this.textBoxInPut_GKU.Name = "textBoxInPut_GKU";
            this.textBoxInPut_GKU.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInPut_GKU.Size = new System.Drawing.Size(514, 385);
            this.textBoxInPut_GKU.TabIndex = 0;
            // 
            // splitterOutPut_GKU
            // 
            this.splitterOutPut_GKU.Location = new System.Drawing.Point(520, 170);
            this.splitterOutPut_GKU.Name = "splitterOutPut_GKU";
            this.splitterOutPut_GKU.Size = new System.Drawing.Size(10, 406);
            this.splitterOutPut_GKU.TabIndex = 3;
            this.splitterOutPut_GKU.TabStop = false;
            // 
            // panelOutPut_GKU
            // 
            this.panelOutPut_GKU.Controls.Add(this.groupBoxOutPut_GKU);
            this.panelOutPut_GKU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOutPut_GKU.Location = new System.Drawing.Point(530, 170);
            this.panelOutPut_GKU.Name = "panelOutPut_GKU";
            this.panelOutPut_GKU.Size = new System.Drawing.Size(507, 406);
            this.panelOutPut_GKU.TabIndex = 4;
            // 
            // groupBoxOutPut_GKU
            // 
            this.groupBoxOutPut_GKU.Controls.Add(this.textBoxOutPut_GKU);
            this.groupBoxOutPut_GKU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPut_GKU.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutPut_GKU.Name = "groupBoxOutPut_GKU";
            this.groupBoxOutPut_GKU.Size = new System.Drawing.Size(507, 406);
            this.groupBoxOutPut_GKU.TabIndex = 0;
            this.groupBoxOutPut_GKU.TabStop = false;
            this.groupBoxOutPut_GKU.Text = "Вывод:";
            // 
            // textBoxOutPut_GKU
            // 
            this.textBoxOutPut_GKU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOutPut_GKU.Location = new System.Drawing.Point(3, 18);
            this.textBoxOutPut_GKU.Multiline = true;
            this.textBoxOutPut_GKU.Name = "textBoxOutPut_GKU";
            this.textBoxOutPut_GKU.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutPut_GKU.Size = new System.Drawing.Size(501, 385);
            this.textBoxOutPut_GKU.TabIndex = 0;
            // 
            // openFileDialogTask_GKU
            // 
            this.openFileDialogTask_GKU.FileName = "openFileDialogTask_GKU";
            // 
            // toolTipTask_GKU
            // 
            this.toolTipTask_GKU.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipTask_GKU.ToolTipTitle = "Подсказка";
            this.toolTipTask_GKU.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTipTask_GKU_Popup);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 576);
            this.Controls.Add(this.panelOutPut_GKU);
            this.Controls.Add(this.splitterOutPut_GKU);
            this.Controls.Add(this.panelInput_GKU);
            this.Controls.Add(this.panelTask_GKU);
            this.Controls.Add(this.panelButtons_GKU);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 |  Вариант 22 | Григорьев К.Ю.";
            this.panelButtons_GKU.ResumeLayout(false);
            this.panelTask_GKU.ResumeLayout(false);
            this.groupBoxTask_GKU.ResumeLayout(false);
            this.groupBoxTask_GKU.PerformLayout();
            this.panelInput_GKU.ResumeLayout(false);
            this.groupBoxInPut_GKU.ResumeLayout(false);
            this.groupBoxInPut_GKU.PerformLayout();
            this.panelOutPut_GKU.ResumeLayout(false);
            this.groupBoxOutPut_GKU.ResumeLayout(false);
            this.groupBoxOutPut_GKU.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButtons_GKU;
        private System.Windows.Forms.Panel panelTask_GKU;
        private System.Windows.Forms.GroupBox groupBoxTask_GKU;
        private System.Windows.Forms.TextBox textBoxTask_GKU;
        private System.Windows.Forms.Panel panelInput_GKU;
        private System.Windows.Forms.GroupBox groupBoxInPut_GKU;
        private System.Windows.Forms.Splitter splitterOutPut_GKU;
        private System.Windows.Forms.Panel panelOutPut_GKU;
        private System.Windows.Forms.GroupBox groupBoxOutPut_GKU;
        private System.Windows.Forms.Button buttonHelp_GKU;
        private System.Windows.Forms.Button buttonDone_GKU;
        private System.Windows.Forms.Button buttonOpenFile_GKU;
        private System.Windows.Forms.ToolTip toolTipTask_GKU;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_GKU;
        private System.Windows.Forms.TextBox textBoxInPut_GKU;
        private System.Windows.Forms.TextBox textBoxOutPut_GKU;
    }
}

