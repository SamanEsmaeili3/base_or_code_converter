namespace ASM_Project
{
    partial class Form1
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
            this.btn_baseChanger = new System.Windows.Forms.Button();
            this.btn_CodeChanger = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_baseChanger
            // 
            this.btn_baseChanger.Location = new System.Drawing.Point(444, 172);
            this.btn_baseChanger.Name = "btn_baseChanger";
            this.btn_baseChanger.Size = new System.Drawing.Size(152, 46);
            this.btn_baseChanger.TabIndex = 0;
            this.btn_baseChanger.Text = "Base changer";
            this.btn_baseChanger.UseVisualStyleBackColor = true;
            this.btn_baseChanger.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_CodeChanger
            // 
            this.btn_CodeChanger.Location = new System.Drawing.Point(229, 172);
            this.btn_CodeChanger.Name = "btn_CodeChanger";
            this.btn_CodeChanger.Size = new System.Drawing.Size(152, 46);
            this.btn_CodeChanger.TabIndex = 1;
            this.btn_CodeChanger.Text = "Code changer";
            this.btn_CodeChanger.UseVisualStyleBackColor = true;
            this.btn_CodeChanger.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_CodeChanger);
            this.Controls.Add(this.btn_baseChanger);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_baseChanger;
        private System.Windows.Forms.Button btn_CodeChanger;
    }
}

