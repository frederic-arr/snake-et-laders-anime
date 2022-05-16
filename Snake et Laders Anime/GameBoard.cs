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
    public partial class GameBoard : Form
    {
        const int COLUMN_COUNT = 6;
        const int LINE_COUNT = 5;
        const int CELL_SIZE = 128;
        public GameBoard()
        {

            for (int col = 0; col < COLUMN_COUNT; col++)
            {
                for (int ln = 0; ln < LINE_COUNT; ln++)
                {
                    Label label = new Label();

                    label.Location = new Point(ln * CELL_SIZE, 512 - (col * CELL_SIZE));
                    label.Name = "label1";
                    label.TabIndex = 1;
                    label.Size = new Size(128, 128);
                    label.Text = $"({ln}, {col})";
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    Controls.Add(label);
                }
            }
            InitializeComponent();
        }
    }
}
