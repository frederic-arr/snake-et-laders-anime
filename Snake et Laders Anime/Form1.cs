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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void BtnJoueur_Click(object sender, EventArgs e)
        {
            //GameBoard form2 = new GameBoard();
            //form2.ShowDialog();
            this.Hide();
            var form2 = new GameBoard();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}
