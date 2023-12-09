
namespace Tyuiu.GrigorevKU.Sprint6.Task6.V22
{
    partial class FormAbout_GKU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout_GKU));
            this.textBoxInfo_GKU = new System.Windows.Forms.TextBox();
            this.buttonOK_GKU = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxInfo_GKU
            // 
            this.textBoxInfo_GKU.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInfo_GKU.Location = new System.Drawing.Point(128, 2);
            this.textBoxInfo_GKU.Multiline = true;
            this.textBoxInfo_GKU.Name = "textBoxInfo_GKU";
            this.textBoxInfo_GKU.ReadOnly = true;
            this.textBoxInfo_GKU.Size = new System.Drawing.Size(372, 183);
            this.textBoxInfo_GKU.TabIndex = 0;
            this.textBoxInfo_GKU.TabStop = false;
            this.textBoxInfo_GKU.Text = resources.GetString("textBoxInfo_GKU.Text");
            // 
            // buttonOK_GKU
            // 
            this.buttonOK_GKU.Location = new System.Drawing.Point(374, 224);
            this.buttonOK_GKU.Name = "buttonOK_GKU";
            this.buttonOK_GKU.Size = new System.Drawing.Size(116, 30);
            this.buttonOK_GKU.TabIndex = 1;
            this.buttonOK_GKU.Text = "Ок";
            this.buttonOK_GKU.UseVisualStyleBackColor = true;
            this.buttonOK_GKU.Click += new System.EventHandler(this.buttonOK_GKU_Click);
            // 
            // FormAbout_GKU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 267);
            this.Controls.Add(this.buttonOK_GKU);
            this.Controls.Add(this.textBoxInfo_GKU);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout_GKU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInfo_GKU;
        private System.Windows.Forms.Button buttonOK_GKU;
    }
}