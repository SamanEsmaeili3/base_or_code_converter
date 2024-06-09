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
    public partial class BaseChanger_Form : Form
    {
        BaseChanger baseChanger = new BaseChanger();
        public BaseChanger_Form()
        {
            InitializeComponent();
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            string binary;
            int decimalValue;
            if (!String.IsNullOrEmpty(textBox_binary.Text))
            {
                binary = baseChanger.RemoveWhitespace(textBox_binary.Text);
                decimalValue = baseChanger.convertToDecimal(binary,2);

                textBox_octal.Text = baseChanger.convertDecimalToTargetBase(decimalValue, 8);
                textBox_decimal.Text = Convert.ToString(decimalValue);
                textBox_hexadecimal.Text = baseChanger.convertDecimalToTargetBase(decimalValue, 16);
            }
            else if (!String.IsNullOrEmpty(textBox_octal.Text))
            {
                decimalValue = baseChanger.convertToDecimal(textBox_octal.Text, 8);
                binary = baseChanger.convertDecimalToTargetBase(decimalValue, 2);

                textBox_binary.Text = binary;
                textBox_decimal.Text = Convert.ToString(decimalValue);
                textBox_hexadecimal.Text = baseChanger.convertDecimalToTargetBase(decimalValue, 16);
            }
            else if (!String.IsNullOrEmpty(textBox_decimal.Text))
            {
                decimalValue = Convert.ToInt32(textBox_decimal.Text);

                textBox_binary.Text = baseChanger.convertDecimalToTargetBase(decimalValue, 2);
                textBox_octal.Text = baseChanger.convertDecimalToTargetBase(decimalValue, 8);
                textBox_hexadecimal.Text = baseChanger.convertDecimalToTargetBase(decimalValue, 16);
            }
            else
            {
                decimalValue = baseChanger.convertHexToDecimal(textBox_hexadecimal.Text);

                textBox_binary.Text = baseChanger.convertDecimalToTargetBase(decimalValue, 2);
                textBox_octal.Text = baseChanger.convertDecimalToTargetBase(decimalValue, 8);
                textBox_decimal.Text = Convert.ToString(decimalValue);
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            textBox_binary.ResetText();
            textBox_octal.ResetText();
            textBox_decimal.ResetText();
            textBox_hexadecimal.ResetText();
        }
    }
}
