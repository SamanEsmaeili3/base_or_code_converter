namespace ASM_Project
{
    partial class BaseChanger_Form
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
            this.lbl_Binary = new System.Windows.Forms.Label();
            this.lbl_Octal = new System.Windows.Forms.Label();
            this.lbl_decimal = new System.Windows.Forms.Label();
            this.Hexadecimal = new System.Windows.Forms.Label();
            this.textBox_binary = new System.Windows.Forms.TextBox();
            this.textBox_octal = new System.Windows.Forms.TextBox();
            this.textBox_decimal = new System.Windows.Forms.TextBox();
            this.textBox_hexadecimal = new System.Windows.Forms.TextBox();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Binary
            // 
            this.lbl_Binary.AutoSize = true;
            this.lbl_Binary.Location = new System.Drawing.Point(92, 83);
            this.lbl_Binary.Name = "lbl_Binary";
            this.lbl_Binary.Size = new System.Drawing.Size(51, 16);
            this.lbl_Binary.TabIndex = 0;
            this.lbl_Binary.Text = "Binary :";
            // 
            // lbl_Octal
            // 
            this.lbl_Octal.AutoSize = true;
            this.lbl_Octal.Location = new System.Drawing.Point(92, 152);
            this.lbl_Octal.Name = "lbl_Octal";
            this.lbl_Octal.Size = new System.Drawing.Size(44, 16);
            this.lbl_Octal.TabIndex = 1;
            this.lbl_Octal.Text = "Octal :";
            // 
            // lbl_decimal
            // 
            this.lbl_decimal.AutoSize = true;
            this.lbl_decimal.Location = new System.Drawing.Point(92, 224);
            this.lbl_decimal.Name = "lbl_decimal";
            this.lbl_decimal.Size = new System.Drawing.Size(63, 16);
            this.lbl_decimal.TabIndex = 2;
            this.lbl_decimal.Text = "Decimal :";
            // 
            // Hexadecimal
            // 
            this.Hexadecimal.AutoSize = true;
            this.Hexadecimal.Location = new System.Drawing.Point(92, 288);
            this.Hexadecimal.Name = "Hexadecimal";
            this.Hexadecimal.Size = new System.Drawing.Size(93, 16);
            this.Hexadecimal.TabIndex = 3;
            this.Hexadecimal.Text = "Hexadecimal :";
            // 
            // textBox_binary
            // 
            this.textBox_binary.Location = new System.Drawing.Point(215, 83);
            this.textBox_binary.Name = "textBox_binary";
            this.textBox_binary.Size = new System.Drawing.Size(292, 22);
            this.textBox_binary.TabIndex = 4;
            // 
            // textBox_octal
            // 
            this.textBox_octal.Location = new System.Drawing.Point(215, 152);
            this.textBox_octal.Name = "textBox_octal";
            this.textBox_octal.Size = new System.Drawing.Size(292, 22);
            this.textBox_octal.TabIndex = 5;
            // 
            // textBox_decimal
            // 
            this.textBox_decimal.Location = new System.Drawing.Point(215, 221);
            this.textBox_decimal.Name = "textBox_decimal";
            this.textBox_decimal.Size = new System.Drawing.Size(292, 22);
            this.textBox_decimal.TabIndex = 6;
            // 
            // textBox_hexadecimal
            // 
            this.textBox_hexadecimal.Location = new System.Drawing.Point(215, 288);
            this.textBox_hexadecimal.Name = "textBox_hexadecimal";
            this.textBox_hexadecimal.Size = new System.Drawing.Size(292, 22);
            this.textBox_hexadecimal.TabIndex = 7;
            // 
            // btn_calculate
            // 
            this.btn_calculate.Location = new System.Drawing.Point(215, 351);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(112, 23);
            this.btn_calculate.TabIndex = 8;
            this.btn_calculate.Text = "Calculate";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(395, 351);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(112, 23);
            this.btn_Clear.TabIndex = 9;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // BaseChanger_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.textBox_hexadecimal);
            this.Controls.Add(this.textBox_decimal);
            this.Controls.Add(this.textBox_octal);
            this.Controls.Add(this.textBox_binary);
            this.Controls.Add(this.Hexadecimal);
            this.Controls.Add(this.lbl_decimal);
            this.Controls.Add(this.lbl_Octal);
            this.Controls.Add(this.lbl_Binary);
            this.Name = "BaseChanger_Form";
            this.Text = "Base Changer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Binary;
        private System.Windows.Forms.Label lbl_Octal;
        private System.Windows.Forms.Label lbl_decimal;
        private System.Windows.Forms.Label Hexadecimal;
        private System.Windows.Forms.TextBox textBox_binary;
        private System.Windows.Forms.TextBox textBox_octal;
        private System.Windows.Forms.TextBox textBox_decimal;
        private System.Windows.Forms.TextBox textBox_hexadecimal;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.Button btn_Clear;
    }
}