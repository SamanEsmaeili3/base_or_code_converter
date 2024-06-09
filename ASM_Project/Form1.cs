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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BaseChanger_Form baseChangerForm = new BaseChanger_Form();
            baseChangerForm.Show();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CodeChanger_Form codeChangerForm = new CodeChanger_Form(); 
            codeChangerForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
