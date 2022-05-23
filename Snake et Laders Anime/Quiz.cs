using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_et_Laders_Anime
{
    public partial class Quiz : Form
    {
        string r = "";
        public Quiz(string[] _question)
        {
            InitializeComponent();
            label1.Text = _question[0];
            label2.Text = _question[1];

            radioButton1.Text = _question[3];
            radioButton2.Text = _question[4];
            radioButton3.Text = _question[5];
            radioButton4.Text = _question[6];

            r = _question[int.Parse(_question[2]) + 2];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void check(string _r)
        {
            //question[int.Parse(question[2])];
            if (r == _r)
            {
                MessageBox.Show("Vous avez juste");
                this.DialogResult = DialogResult.Yes;
                this.Close();
            } else
            {
                MessageBox.Show("Vous avez faux");
                this.DialogResult = DialogResult.No;
                this.Close();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            check(radioButton1.Text);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            check(radioButton2.Text);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            check(radioButton3.Text);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            check(radioButton4.Text);
        }
    }
}
