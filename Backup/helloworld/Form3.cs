using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace helloworld
{
    public partial class Form3 : helloworld.Form_orig
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // �{�^�����������Ƃ��̃��O�����
            this.log(this, sender, e);

            // �I������Ƃ��́A���̃R�}���h1�s�ł悢
            this.Close();
        }
    }
}

