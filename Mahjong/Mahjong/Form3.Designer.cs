namespace Mahjong
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.button_resume = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_MainManu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_resume
            // 
            this.button_resume.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button_resume.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button_resume.Location = new System.Drawing.Point(538, 177);
            this.button_resume.Name = "button_resume";
            this.button_resume.Size = new System.Drawing.Size(218, 95);
            this.button_resume.TabIndex = 0;
            this.button_resume.Text = "Pokračovat";
            this.button_resume.UseVisualStyleBackColor = false;
            this.button_resume.Click += new System.EventHandler(this.button_resume_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_Close.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_Close.Location = new System.Drawing.Point(538, 393);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(218, 95);
            this.btn_Close.TabIndex = 1;
            this.btn_Close.Text = "Ukončit";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_MainManu
            // 
            this.btn_MainManu.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_MainManu.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_MainManu.Location = new System.Drawing.Point(538, 285);
            this.btn_MainManu.Name = "btn_MainManu";
            this.btn_MainManu.Size = new System.Drawing.Size(218, 95);
            this.btn_MainManu.TabIndex = 2;
            this.btn_MainManu.Text = "Hlavní nabídka";
            this.btn_MainManu.UseVisualStyleBackColor = false;
            this.btn_MainManu.Click += new System.EventHandler(this.btn_MainManu_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1200, 644);
            this.Controls.Add(this.btn_MainManu);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.button_resume);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_resume;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_MainManu;
    }
}