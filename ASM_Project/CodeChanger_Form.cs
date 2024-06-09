using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASM_Project
{
    public partial class CodeChanger_Form : Form
    {
        CodeChanger codechanger = new CodeChanger();
        BaseChanger baseChanger = new BaseChanger();
        public CodeChanger_Form()
        {
            
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_claculate_Click(object sender, EventArgs e)
        {
            string binary, decimalValue;
            if (!String.IsNullOrEmpty(txtBox_excess3.Text))
            {
                binary = codechanger.convertEx_3ToBinary(baseChanger.RemoveWhitespace(txtBox_excess3.Text));
                decimalValue = Convert.ToString(codechanger.convertBinaryToDecimal(binary));
                
                txtBox_decimal.Text = decimalValue;
                txtBox_BCD.Text = codechanger.convertDecimalToBCD(Convert.ToInt32(decimalValue));
                txtBox_2421.Text = codechanger.convertDecimalTo2421(decimalValue);
                txtBox_gray.Text = codechanger.convertBinaryToGray(binary);
            }
            else if (!String.IsNullOrEmpty(txtBox_BCD.Text))
            {
                decimalValue = Convert.ToString(codechanger.convertBCDToDecimal(baseChanger.RemoveWhitespace(txtBox_BCD.Text)));
                binary = codechanger.convertDecimalToBinary(Convert.ToInt32(decimalValue));

                txtBox_excess3.Text = codechanger.convertBinaryToEx_3(binary);
                txtBox_decimal.Text = decimalValue;
                txtBox_2421.Text = codechanger.convertDecimalTo2421(decimalValue);
                txtBox_gray.Text = codechanger.convertBinaryToGray(binary);
            }
            else if (!String.IsNullOrEmpty(txtBox_decimal.Text))
            {
                decimalValue = baseChanger.RemoveWhitespace(txtBox_decimal.Text);
                binary = codechanger.convertDecimalToBinary(Convert.ToInt32(decimalValue));

                txtBox_excess3.Text = codechanger.convertBinaryToEx_3(binary);
                txtBox_BCD.Text = codechanger.convertDecimalToBCD(Convert.ToInt32(decimalValue));
                txtBox_2421.Text = codechanger.convertDecimalTo2421(decimalValue);
                txtBox_gray.Text = codechanger.convertBinaryToGray(binary);
            }
            else if (!String.IsNullOrEmpty(txtBox_2421.Text))
            {
                decimalValue = codechanger.convert2421ToDecimal(baseChanger.RemoveWhitespace(txtBox_2421.Text));
                binary = codechanger.convertDecimalToBinary(Convert.ToInt32(decimalValue));

                txtBox_excess3.Text = codechanger.convertBinaryToEx_3(binary);
                txtBox_decimal.Text = decimalValue;
                txtBox_BCD.Text = codechanger.convertDecimalToBCD(Convert.ToInt32(decimalValue));
                txtBox_gray.Text = codechanger.convertBinaryToGray(binary);
            }
            else //Here, input is gray 
            {
                binary = codechanger.convertGaryToBinary(txtBox_gray.Text);
                decimalValue = Convert.ToString(codechanger.convertBinaryToDecimal(binary));

                txtBox_excess3.Text = codechanger.convertBinaryToEx_3(binary);
                txtBox_decimal.Text = decimalValue;
                txtBox_BCD.Text = codechanger.convertDecimalToBCD(Convert.ToInt32(decimalValue));
                txtBox_2421.Text = codechanger.convertDecimalTo2421(decimalValue);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txtBox_excess3.ResetText();
            txtBox_BCD.ResetText();
            txtBox_decimal.ResetText();
            txtBox_2421.ResetText();
            txtBox_gray.ResetText();
        }
    }
}
