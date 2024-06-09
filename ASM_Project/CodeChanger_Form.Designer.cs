namespace ASM_Project
{
    partial class CodeChanger_Form
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
            this.lbl_Excess3 = new System.Windows.Forms.Label();
            this.lbl_2421 = new System.Windows.Forms.Label();
            this.lbl_Decimal = new System.Windows.Forms.Label();
            this.lbl_BCD = new System.Windows.Forms.Label();
            this.txtBox_excess3 = new System.Windows.Forms.TextBox();
            this.txtBox_2421 = new System.Windows.Forms.TextBox();
            this.txtBox_decimal = new System.Windows.Forms.TextBox();
            this.txtBox_BCD = new System.Windows.Forms.TextBox();
            this.btn_claculate = new System.Windows.Forms.Button();
            this.lbl_gary = new System.Windows.Forms.Label();
            this.txtBox_gray = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Excess3
            // 
            this.lbl_Excess3.AutoSize = true;
            this.lbl_Excess3.Location = new System.Drawing.Point(62, 84);
            this.lbl_Excess3.Name = "lbl_Excess3";
            this.lbl_Excess3.Size = new System.Drawing.Size(64, 16);
            this.lbl_Excess3.TabIndex = 0;
            this.lbl_Excess3.Text = "Excess3 :";
            // 
            // lbl_2421
            // 
            this.lbl_2421.AutoSize = true;
            this.lbl_2421.Location = new System.Drawing.Point(62, 220);
            this.lbl_2421.Name = "lbl_2421";
            this.lbl_2421.Size = new System.Drawing.Size(41, 16);
            this.lbl_2421.TabIndex = 1;
            this.lbl_2421.Text = "2421 :";
            this.lbl_2421.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_Decimal
            // 
            this.lbl_Decimal.AutoSize = true;
            this.lbl_Decimal.Location = new System.Drawing.Point(62, 173);
            this.lbl_Decimal.Name = "lbl_Decimal";
            this.lbl_Decimal.Size = new System.Drawing.Size(63, 16);
            this.lbl_Decimal.TabIndex = 2;
            this.lbl_Decimal.Text = "Decimal :";
            // 
            // lbl_BCD
            // 
            this.lbl_BCD.AutoSize = true;
            this.lbl_BCD.Location = new System.Drawing.Point(62, 125);
            this.lbl_BCD.Name = "lbl_BCD";
            this.lbl_BCD.Size = new System.Drawing.Size(41, 16);
            this.lbl_BCD.TabIndex = 3;
            this.lbl_BCD.Text = "BCD :";
            this.lbl_BCD.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtBox_excess3
            // 
            this.txtBox_excess3.Location = new System.Drawing.Point(158, 84);
            this.txtBox_excess3.Name = "txtBox_excess3";
            this.txtBox_excess3.Size = new System.Drawing.Size(287, 22);
            this.txtBox_excess3.TabIndex = 4;
            // 
            // txtBox_2421
            // 
            this.txtBox_2421.Location = new System.Drawing.Point(158, 214);
            this.txtBox_2421.Name = "txtBox_2421";
            this.txtBox_2421.Size = new System.Drawing.Size(287, 22);
            this.txtBox_2421.TabIndex = 5;
            // 
            // txtBox_decimal
            // 
            this.txtBox_decimal.Location = new System.Drawing.Point(158, 173);
            this.txtBox_decimal.Name = "txtBox_decimal";
            this.txtBox_decimal.Size = new System.Drawing.Size(287, 22);
            this.txtBox_decimal.TabIndex = 6;
            // 
            // txtBox_BCD
            // 
            this.txtBox_BCD.Location = new System.Drawing.Point(158, 125);
            this.txtBox_BCD.Name = "txtBox_BCD";
            this.txtBox_BCD.Size = new System.Drawing.Size(287, 22);
            this.txtBox_BCD.TabIndex = 7;
            // 
            // btn_claculate
            // 
            this.btn_claculate.Location = new System.Drawing.Point(158, 339);
            this.btn_claculate.Name = "btn_claculate";
            this.btn_claculate.Size = new System.Drawing.Size(112, 23);
            this.btn_claculate.TabIndex = 8;
            this.btn_claculate.Text = "Calculate";
            this.btn_claculate.UseVisualStyleBackColor = true;
            this.btn_claculate.Click += new System.EventHandler(this.btn_claculate_Click);
            // 
            // lbl_gary
            // 
            this.lbl_gary.AutoSize = true;
            this.lbl_gary.Location = new System.Drawing.Point(62, 271);
            this.lbl_gary.Name = "lbl_gary";
            this.lbl_gary.Size = new System.Drawing.Size(45, 16);
            this.lbl_gary.TabIndex = 9;
            this.lbl_gary.Text = "Gray : ";
            // 
            // txtBox_gray
            // 
            this.txtBox_gray.Location = new System.Drawing.Point(158, 264);
            this.txtBox_gray.Name = "txtBox_gray";
            this.txtBox_gray.Size = new System.Drawing.Size(287, 22);
            this.txtBox_gray.TabIndex = 10;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(333, 339);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(112, 23);
            this.btn_clear.TabIndex = 11;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // CodeChanger_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 450);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.txtBox_gray);
            this.Controls.Add(this.lbl_gary);
            this.Controls.Add(this.btn_claculate);
            this.Controls.Add(this.txtBox_BCD);
            this.Controls.Add(this.txtBox_decimal);
            this.Controls.Add(this.txtBox_2421);
            this.Controls.Add(this.txtBox_excess3);
            this.Controls.Add(this.lbl_BCD);
            this.Controls.Add(this.lbl_Decimal);
            this.Controls.Add(this.lbl_2421);
            this.Controls.Add(this.lbl_Excess3);
            this.Name = "CodeChanger_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CodeChanger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Excess3;
        private System.Windows.Forms.Label lbl_2421;
        private System.Windows.Forms.Label lbl_Decimal;
        private System.Windows.Forms.Label lbl_BCD;
        private System.Windows.Forms.TextBox txtBox_excess3;
        private System.Windows.Forms.TextBox txtBox_2421;
        private System.Windows.Forms.TextBox txtBox_decimal;
        private System.Windows.Forms.TextBox txtBox_BCD;
        private System.Windows.Forms.Button btn_claculate;
        private System.Windows.Forms.Label lbl_gary;
        private System.Windows.Forms.TextBox txtBox_gray;
        private System.Windows.Forms.Button btn_clear;
    }
}